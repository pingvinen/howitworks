using System;
using Mono.Cecil;
using Missing.Reflection;
using System.Linq;

namespace HowItWorks.Reflection
{
	public static class CecilHelper
	{
		public static TypeDefinition GetType(string name)
		{
			Type t = TypeHelper.GetType(name);
		
			DefaultAssemblyResolver res = new DefaultAssemblyResolver();
			AssemblyDefinition adef = res.Resolve(t.Assembly.FullName);

			TypeDefinition tdef =	(
										from y in adef.Modules
										from x in y.Types.AsEnumerable()
										where x.FullName == t.FullName
										select x
									).FirstOrDefault();
			
			return tdef;
		}
	}
}