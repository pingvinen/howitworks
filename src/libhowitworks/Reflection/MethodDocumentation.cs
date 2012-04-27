using System;
using Mono.Cecil;
using Mono.Collections.Generic;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="Mono.Cecil.MethodDefinition"/>
	/// </summary>
	public class MethodDocumentation : DocumentationBase<MethodDefinition>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.MethodDocumentation"/> class.
		/// </summary>
		public MethodDocumentation() : base()
		{
			this.Parameters = new ParameterDocumentationCollection();
		}
		
		/// <summary>
		/// Get/set full set of parameters
		/// </summary>
		public ParameterDocumentationCollection Parameters { get; set; }
		
		/// <summary>
		/// Worker method for <see cref="Populate"/>
		/// </summary>
		protected override void PopulateWorker()
		{
			this.Parameters.Clear();
			
			Collection<ParameterDefinition> infos = base.WrappedElement.Parameters;
			
			ParameterDocumentation tmp;
			foreach (ParameterDefinition cur in infos)
			{
				tmp = new ParameterDocumentation();
				tmp.Populate(cur);
				
				this.Parameters.Add(tmp);
			}
		}
	}
}