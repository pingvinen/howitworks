using System;

namespace HowItWorks.Reflection
{
	public abstract class DocumentationBase
	{
		public DocumentationBase()
		{
			this.Summary = String.Empty;
			this.Remarks = String.Empty;
		}
		
		public string Summary { get; set; }
		public string Remarks { get; set; }
	}
}