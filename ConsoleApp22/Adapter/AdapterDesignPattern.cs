using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Adapter
{
    public class Adaptee
    {
        public void SpeceficationRequest() =>
            Console.WriteLine("Called SpecificRequest()");
    }

    public class Adapter : Target
    {
        private Adaptee adaptee = new();
        public override void Request()
            => adaptee.SpeceficationRequest();
    }
    public class Target
    {
        public virtual void Request() =>
            Console.WriteLine("Called Target Request()");
    }
}
