using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Singleton
{
    public class Singleton
    {
        static Singleton instance;

        protected Singleton()
        {

        }
        public static Singleton Instance() => 
            instance ??= new Singleton();
    }
}
