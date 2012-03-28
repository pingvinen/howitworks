using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="System.Reflection.MethodInfo"/>
	/// </summary>
	public class MethodDocumentation : DocumentationBase<MethodInfo>
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
			
			ParameterInfo[] infos = base.WrappedElement.GetParameters();
			
			ParameterDocumentation tmp;
			foreach (ParameterInfo cur in infos)
			{
				tmp = new ParameterDocumentation();
				tmp.Populate(cur);
				
				this.Parameters.Add(tmp);
			}
		}
	}
}