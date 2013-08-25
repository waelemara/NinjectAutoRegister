using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRegister.Contracts;

namespace AutoRegister.MockServices
{
    public class ServiceMock :  IService
    {
        public string WriteSomething()
        {
            return "Mock Service";
        }
    }
}
