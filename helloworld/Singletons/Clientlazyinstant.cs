using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld.Singletons
{
    internal sealed class Clientlazyinstant
    {
        private Clientlazyinstant() { }
        public static Clientlazyinstant Instance { get { return Inside.instance; } }

        private static class Inside
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Inside(){ }

            internal static readonly Clientlazyinstant instance = new Clientlazyinstant();
        }
    }
}
