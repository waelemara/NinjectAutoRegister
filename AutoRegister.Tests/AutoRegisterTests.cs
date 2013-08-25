using System.Reflection;
using AutoRegister;
using AutoRegister.Contracts;
using NUnit.Framework;
using Ninject;

namespace AutoRegister.Tests
{
    [TestFixture]
    public class AutoRegisterTests
    {
        [Test]
        public void RegisterMockService()
        {
            using (var standardKernel = new Ninject.StandardKernel())
            {
                NinjectAuto.Register(Contracts.AssemblyInfo.GetExecutingAssembly(), MockServices.AssemblyInfo.GetExecutingAssembly(), standardKernel);

                var service = standardKernel.Get<IService>();

                string writeSomething = service.WriteSomething();

                Assert.AreEqual(writeSomething, "Mock Service");
            }
        }

        [Test]
        public void RegisterRealService()
        {
            using (var standardKernel = new Ninject.StandardKernel())
            {
                NinjectAuto.Register(Contracts.AssemblyInfo.GetExecutingAssembly(), Services.AssemblyInfo.GetExecutingAssembly(), standardKernel);

                var service = standardKernel.Get<IService>();

                string writeSomething = service.WriteSomething();

                Assert.AreEqual(writeSomething, "Real Service");
            }
        }
    }
}
