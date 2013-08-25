using AutoRegister.Contracts;

namespace AutoRegister.Services
{
    public class Service : IService
    {
        public string WriteSomething()
        {
            return "Real Service";
        }
    }
}
