using System;

using NUnit.Framework;

using SourceLinkLibrary;

namespace SourceLinkLibraryTests
{
    public class Tests
    {
        [Test]
        public void TheOnlyTest()
        {
            var worker = new WorkClass(10);
            var msg = $"{InfoClass.InfoString} called with {{0}}";
            worker.DoSomeWork(i => Console.WriteLine(msg, i));
        }
    }
}