using System;

namespace CircularDependency.Services
{
    public class BService : IBService
    {
        public BService(IAService aService)
        {

        }

        public void SayHelloFromB()
        {
            Console.WriteLine("Hi, Soheil! I'm from B");
        }
    }
}
