using System;

namespace Beliefs.Budhism
{
	/// <summary>
	/// Budhism
	/// </summary>
	public class BudhismReligion : ReligionBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Beliefs.Budhism.BudhismReligion"/> class.
		/// </summary>
		public BudhismReligion() : base()
		{
			base.Name = "Budhism";
		}

		#region implemented abstract members of Beliefs.ReligionBase
		/// <summary>
		/// Pray like a true budhist
		/// </summary>
		/// <returns>
		/// The effect of the praying
		/// </returns>
		public override int Pray()
		{
			// do stuff
			return 253;
		}
		#endregion
	}
}