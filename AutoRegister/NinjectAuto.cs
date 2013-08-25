using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace AutoRegister
{
    public class NinjectAuto
    {
        public static void Register(Assembly interfacesAssembly, Assembly implementationAssembly, StandardKernel kernel)
        {
            var types = implementationAssembly.GetTypes();
            foreach (var type in types)
            {
                if (!type.IsClass) continue;

                var interfaces = type.GetInterfaces();
                foreach (var @interface in interfaces)
                {
                    var matchedInterface = interfacesAssembly.GetTypes().Where(t => t.IsInterface).FirstOrDefault(t => @interface.Name == t.Name);

                    if (matchedInterface == null) continue;

                    var bindMethod = typeof(StandardKernel).GetMethods().First(m => m.IsGenericMethod && m.Name == "Bind");
                    var genericBindMethod = bindMethod.MakeGenericMethod(matchedInterface);
                    var result = genericBindMethod.Invoke(kernel, new object[] { });
                    var toMethod = result.GetType().GetMethods().First(m => !m.IsGenericMethod && m.Name == "To");
                    toMethod.Invoke(result, new object[] { type });
                }
            }
        }
    }
}
