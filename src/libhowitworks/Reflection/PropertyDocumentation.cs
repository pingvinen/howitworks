using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	public class PropertyDocumentation : DocumentationBase
	{
		public PropertyDocumentation() : base()
		{
		}
		
		public PropertyInfo PropertyInfo { get; set; }
	}
}