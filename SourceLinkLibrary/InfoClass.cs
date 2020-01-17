using System;

namespace SourceLinkLibrary
{
    /// <summary>
    /// My info class
    /// </summary>
    public class InfoClass
    {
        /// <summary>
        /// A property with some info in
        /// </summary>
        public static string InfoString { get; } = "My Info String";

        /// <summary>
        /// Okay, we haven't seen this...
        /// </summary>
        public void SomeNewStuff()
        {
            Console.WriteLine("a");
            Console.WriteLine("bc");
        }
    }
}
