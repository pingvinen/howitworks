using System;
using System.Collections.ObjectModel;
using Missing.Reflection;
using System.Linq.Expressions;

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
		
		/// <summary>
		/// Populate a collection of documentations based on
		/// a call to a reflection method.
		/// </summary>
		/// <param name="collection">
		/// The collection to populate
		/// </param>
		/// <param name="reflectionMethod">
		/// Reflection method.
		/// </param>
		/// <typeparam name="TDocumentation">
		/// The documentation element type
		/// </typeparam>
		/// <typeparam name="TReflection">
		/// The reflection type returned from the reflection method
		/// </typeparam>
		protected void PopulateCollection<TDocumentation, TReflection>(Collection<TDocumentation> collection, Func<T, Mono.Collections.Generic.Collection<TReflection>> reflectionMethod) where TDocumentation : DocumentationBase<TReflection>, new() where TReflection : class
		{
			this.PopulateCollection<TDocumentation, TReflection>(collection, reflectionMethod, y => true);
		}
		
		
		
		/// <summary>
		/// Populate a collection of documentations based on
		/// a call to a reflection method.
		/// </summary>
		/// <param name="collection">
		/// The collection to populate
		/// </param>
		/// <param name="reflectionMethod">
		/// Reflection method.
		/// </param>
		/// <param name="doIncludeElementPredicate">
		/// A predicate that determines whether a given
		/// <typeparamref name="TReflection"/> element should
		/// be included in the collection
		/// </param>
		/// <typeparam name="TDocumentation">
		/// The documentation element type
		/// </typeparam>
		/// <typeparam name="TReflection">
		/// The reflection type returned from the reflection method
		/// </typeparam>
		protected void PopulateCollection<TDocumentation, TReflection>(Collection<TDocumentation> collection, Func<T, Mono.Collections.Generic.Collection<TReflection>> reflectionMethod, Predicate<TReflection> doIncludeElementPredicate) where TDocumentation : DocumentationBase<TReflection>, new() where TReflection : class
		{
			collection.Clear();
			
			Mono.Collections.Generic.Collection<TReflection> infos = reflectionMethod(this.WrappedElement);
			
			TDocumentation tmp;
			foreach (TReflection cur in infos)
			{
				if (doIncludeElementPredicate(cur))
				{
					tmp = new TDocumentation();
					tmp.Populate(cur);
					
					collection.Add(tmp);
				}
			}
		}
		
		protected void PopulateCollectionTwo<TDocumentation, TReflection>(
			Collection<TDocumentation> collection,
			Expression<Func<T, object>> memberExpression
		)
			where TDocumentation : DocumentationBase<TReflection>, new()
			where TReflection : class
		{
			this.PopulateCollectionTwo<TDocumentation, TReflection>(collection, memberExpression, y => true);
		}
		
		protected void PopulateCollectionTwo<TDocumentation, TReflection>(
			Collection<TDocumentation> collection,
			Expression<Func<T, object>> memberExpression,
			Predicate<TReflection> doIncludeElementPredicate
		)
			where TDocumentation : DocumentationBase<TReflection>, new()
			where TReflection : class
		{
			collection.Clear();
			
			PropertyPath path = PropertyPath.From<T>(memberExpression);
			
			Mono.Collections.Generic.Collection<TReflection> infos = (Mono.Collections.Generic.Collection<TReflection>)TypeHelper.GetPropertyData(this.WrappedElement, path).Value;
			
			TDocumentation tmp;
			foreach (TReflection cur in infos)
			{
				if (doIncludeElementPredicate(cur))
				{
					tmp = new TDocumentation();
					tmp.Populate(cur);
					
					collection.Add(tmp);
				}
			}
		}
	}
}