using sc = System.Console; // This means we are using the System library/assembly/namespace
// and don't have to write 'System'

namespace HelloWorld.Client
{
  /// <summary>
  /// contains the start of the program
  /// </summary>
    internal class Program
    {
      /// <summary>
      /// starts the program
      /// </summary>
      /// <param name="args"></param>
        private static void Main(string[] args)
        {
            sc.WriteLine("Hello World!");
            sc.WriteLine(args);
        }
    }
}
