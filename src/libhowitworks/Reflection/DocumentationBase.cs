using System;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Base class for classes augmenting classes from <see cref="System.Reflection"/>
	/// with in-code documentation
	/// </summary>
	/// <typeparam name="T">
	/// The reflection type that is being wrapped
	/// </typeparam>
	public abstract class DocumentationBase<T> where T : class
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.DocumentationBase`{T}"/> class.
		/// </summary>
		public DocumentationBase()
		{
			this.Summary = String.Empty;
			this.Remarks = String.Empty;
		}
		
		/// <summary>
		/// Get/set summary
		/// </summary>
		public string Summary { get; set; }
		
		/// <summary>
		/// Get/set remarks
		/// </summary>
		public string Remarks { get; set; }
		
		/// <summary>
		/// Gets or sets the wrapped element.
		/// </summary>
		public T WrappedElement { get; protected set; }
		
		/// <summary>
		/// Populate instance with given reflection instance
		/// </summary>
		/// <param name="input">
		/// The reflection instance
		/// </param>
		public void Populate(T input)
		{
			this.WrappedElement = input;
			this.PopulateWorker();
		}
		
		/// <summary>
		/// Worker method for <see cref="Populate"/>
		/// </summary>
		/// <remarks>
		/// This can be overridden by specializations, if
		/// actions needs to be taken after invocation of populate
		/// </remarks>
		protected virtual void PopulateWorker()
		{
			// do nothing
		}
	}
}