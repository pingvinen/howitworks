using System;

namespace Beliefs
{
	/// <summary>
	/// Base class for religions
	/// </summary>
	public abstract class ReligionBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Beliefs.ReligionBase"/> class.
		/// </summary>
		public ReligionBase()
		{
			this.Name = String.Empty;
			this.NumberOfFollowers = 0;
		}
		
		/// <summary>
		/// Get/set the name of the religion
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Get/set the number of followers world-wide
		/// </summary>
		public int NumberOfFollowers { get; set; }
		
		/// <summary>
		/// Perform prayer
		/// </summary>
		/// <returns>
		/// The effect of the praying
		/// </returns>
		public abstract int Pray();
		
		/// <summary>
		/// Perform sacrificing
		/// </summary>
		/// <param name="what">
		/// What is being sacrificed
		/// </param>
		/// <returns>
		/// The effect of the sacrifice
		/// </returns>
		/// <remarks>
		/// Default sacrificing is to do nothing at all
		/// </remarks>
		public virtual decimal Sacrifice(string what)
		{
			// not all religions uses sacrifices, so
			// let us let each religion implement it's
			// own version of sacrifice - if relevant
			
			return 0m;
		}
	}
}