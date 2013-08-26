NinjectAutoRegister
===================

Auto Register Classes and interfaces for Ninject IoC not by name but by inheritance 

So usually when you use Ninject you have to register or bind you classes and interfaces like this

IKernel kernel = new StandardKernel();
kernel.Bind<IWeapon>().To<Sword>();

and this is good but tedious , what if you have big library and you don't want to bother your self with 
remembering extra step when you add a new service

and also what if you are introducing Ninject into a project.

so why i think this library is good one thing , it just auto register (Bind)

also it does not depend on a naming convention , it looks for the inheritance and do the binding 

Ex:

using (var standardKernel = new Ninject.StandardKernel()) {
  
  NinjectAuto.Register(Contracts.AssemblyInfo.GetExecutingAssembly(), MockServices.AssemblyInfo.GetExecutingAssembly(), standardKernel);

  var service = standardKernel.Get<IService>();

  string writeSomething = service.WriteSomething();

  Assert.AreEqual(writeSomething, "Mock Service");
  
}

that it , just give where i should find the contracts , where are the implementation and let it do the rest
