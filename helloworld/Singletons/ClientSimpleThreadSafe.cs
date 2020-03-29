using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace helloworld.Singletons
{
    public sealed class ClientSimpleThreadSafe
    {
        public static ClientSimpleThreadSafe instance;
        private static readonly object padlock = new object();

        private ClientSimpleThreadSafe() { }

        public static ClientSimpleThreadSafe Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ClientSimpleThreadSafe();
                    }
                    return instance;
                }
            }
        }
    }
}
