using System.Reflection;

namespace AutoRegister.MockServices
{
    public class AssemblyInfo
    {
        public static Assembly GetExecutingAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
