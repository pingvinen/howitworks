using System;

namespace HowItWorks.Reflection
{
	public abstract class DocumentationBase<T> where T : class
	{
		public DocumentationBase()
		{
			this.Summary = String.Empty;
			this.Remarks = String.Empty;
		}
		
		public string Summary { get; set; }
		public string Remarks { get; set; }
		
		public T WrappedElement { get; protected set; }
		
		public void FromFrameworkType(T input)
		{
			this.WrappedElement = input;
			this.FromFrameworkTypeWorker();
		}
		
		protected virtual void FromFrameworkTypeWorker()
		{
			// do nothing
		}
	}
}