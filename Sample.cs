using ExternalNamespace;

namespace MyNamespace
{
    internal delegate string Delegate();

    public enum MyEnum { Value1, Value2 }

    public struct MyStruct { }

    /// <summary>
    /// This is a XML comment
    /// </summary>
    /// <typeparam name="TGeneric"></typeparam>
    internal class MyClass<TGeneric> : IAmInterface
    {
        public bool Property { get; set; }

        public string NormalMethod(double param)
        {
            var localVariable = param.ExtensionMethod() / StaticClass.Constant;
            return $"The result {localVariable} is awesome";
        }

        public static void StaticMethod()
        {
            // This a comment...
            new MyClass<TGeneric>().NormalMethod(1234.5);
        }

        public string InterfaceMethod()
        {
            // TODO
            throw new System.NotImplementedException();
        }
    }
}

namespace ExternalNamespace
{
    public interface IAmInterface
    {
        string InterfaceMethod();
    }

    public static class StaticClass
    {
        public const int Constant = 111;

        public static double ExtensionMethod(this double param)
        {
            return param;
        }
    }
}
