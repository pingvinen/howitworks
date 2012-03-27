using System;
using System.Reflection;
using Missing.Reflection;

namespace reflectiontester
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Type t = TypeHelper.GetType("Missing.Validation.Enforcers.EmailEnforcer");
			Type t = TypeHelper.GetType("Missing.Reflection.TypeHelper");
			
			MethodInfo[] methods = t.GetMethods();
			
			//MethodInfo mi = t.GetMethod("GetType");
			//ParameterInfo pi = mi.GetParameters()[0];
			
			Assembly ass = Assembly.GetExecutingAssembly();
			Module mod = ass.GetModules(false)[0];
			
			Type[] modTypes = mod.GetTypes();
			
			
			Console.WriteLine("Bye bye");
		}
	}
}