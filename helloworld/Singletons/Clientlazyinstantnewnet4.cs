using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld.Singletons
{
    internal sealed class Clientlazyinstantnewnet4
    {
        private static readonly Lazy<Clientlazyinstantnewnet4>
            lazy = new Lazy<Clientlazyinstantnewnet4>
                (() => new Clientlazyinstantnewnet4());

        public static Clientlazyinstantnewnet4 Instance { get { return lazy.Value; } }

        private Clientlazyinstantnewnet4()
        {
        }
    }
}
