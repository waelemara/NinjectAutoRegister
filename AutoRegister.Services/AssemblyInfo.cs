using System.Reflection;

namespace AutoRegister.Services
{
    public class AssemblyInfo
    {
        public static Assembly GetExecutingAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
