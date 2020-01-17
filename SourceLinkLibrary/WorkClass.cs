using System;
using System.Collections.Generic;
using System.Text;

namespace SourceLinkLibrary
{
    /// <summary>
    /// My work class
    /// </summary>
    public class WorkClass
    {
        int _count;

        /// <summary>
        /// Construct the <see cref="WorkClass"/>
        /// </summary>
        /// <param name="count"></param>
        public WorkClass(int count)
        {
            _count = count;
        }

        /// <summary>
        /// Do some work
        /// </summary>
        /// <param name="worker"></param>
        public void DoSomeWork(Action<int> worker)
        {
            for (int i = 0; i < _count; i++)
            {
                worker(i);
            }
        }
    }
}
