using System;

namespace CircularDependency.Services
{
    public class AService : IAService
    {
        public AService(IBService bService)
        {
            
        }

        public void SayHelloFromA()
        {
            Console.WriteLine("Hi, Soheil! I'm from A");
        }
    }
}
