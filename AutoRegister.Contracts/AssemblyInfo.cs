using System.Reflection;

namespace AutoRegister.Contracts
{
    public class AssemblyInfo
    {
        public static Assembly GetExecutingAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
