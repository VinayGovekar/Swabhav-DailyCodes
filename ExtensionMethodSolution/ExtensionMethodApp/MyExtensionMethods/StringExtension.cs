
namespace ExtensionMethodApp.MyExtensionMethods
{
    public static class StringExtension
    {
        public static string Foo(this string input)
        {
            return input + " : Foo";
        }
    }
}
