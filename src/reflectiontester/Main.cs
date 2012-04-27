using System;
using Mono.Cecil;
using Mono.Collections.Generic;
using System.Text;

namespace reflectiontester
{
	public static class Extensions
	{
		public static string GetSignature(this MethodDefinition method)
		{
			StringBuilder sb = new StringBuilder();
			
			//
			// protection level
			//
			if (method.IsPrivate)
			{
				sb.Append("private ");
			}
			else if (method.IsPublic)
			{
				sb.Append("public ");
			}
			else
			{
				sb.Append("<unknown protection level> ");
			}
			
			// static
			if (method.IsStatic)
			{
				sb.Append("static ");
			}
			
			sb.Append(method.ReturnType.Name);
			sb.Append(" ");
			
			
			// name
			sb.Append(method.Name);
			
			if (!method.HasParameters)
			{
				sb.Append("()");
			}
			else
			{
				sb.Append("(");
				foreach (ParameterDefinition pdef in method.Parameters)
				{
					sb.AppendFormat("{0} {1},", pdef.ParameterType.Name, pdef.Name);
				}
				
				sb.Remove(sb.Length-1, 1);
				
				sb.Append(")");
			}
			
			
			return sb.ToString();
		}
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			//Type t = TypeHelper.GetType("Missing.Validation.Enforcers.EmailEnforcer");
			Type t = TypeHelper.GetType("Missing.Reflection.TypeHelper");
			
			MethodInfo[] methods = t.GetMethods();
			
			//MethodInfo mi = t.GetMethod("GetType");
			//ParameterInfo pi = mi.GetParameters()[0];
			
			Assembly ass = Assembly.GetExecutingAssembly();
			Module mod = ass.GetModules(false)[0];
			
			Type[] modTypes = mod.GetTypes();
			*/
			
			AssemblyDefinition ass = Mono.Cecil.AssemblyDefinition.ReadAssembly("libhowitworks-tests-input.dll");
			Collection<ModuleDefinition> modules = ass.Modules;
			
			foreach (ModuleDefinition moddef in modules)
			{
				Console.WriteLine("Module: '{0}'", moddef.FullyQualifiedName);
				
				foreach (TypeDefinition typedef in moddef.Types)
				{
					Console.WriteLine("Type: '{0}'", typedef.Name);
					
					Console.WriteLine("Methods");
					Console.WriteLine("=====================================================");
					
					foreach (MethodDefinition method in typedef.Methods)
					{
						if (method.IsGetter || method.IsSetter)
						{
							continue;
						}
						
						Console.WriteLine(method.GetSignature());
					}
					
					Console.WriteLine();
					Console.WriteLine();
					
					
					Console.WriteLine("Properties");
					Console.WriteLine("=====================================================");
					foreach (PropertyDefinition prop in typedef.Properties)
					{
						Console.WriteLine("{0} {1}", prop.PropertyType.Name, prop.Name);
					}
					
					Console.WriteLine();
					Console.WriteLine();
				}
				
				Console.WriteLine();
				Console.WriteLine();
			}
		}
	}
}