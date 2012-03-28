using System;

namespace Beliefs.Budhism
{
	/// <summary>
	/// Represents a karmic balance
	/// </summary>
	public class Karma
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Beliefs.Budhism.Karma"/> class.
		/// </summary>
		public Karma()
		{
			this.Balance = 0;
			this.NumberOfActionsPerformed = 0;
		}
		
		/// <summary>
		/// Get the current karmic balance
		/// </summary>
		public int Balance { get; private set; }
		
		/// <summary>
		/// Get the number of actions performed
		/// </summary>
		public int NumberOfActionsPerformed { get; private set; }
		
		/// <summary>
		/// The person/entity actually did something
		/// </summary>
		/// <param name="morality">
		/// The karmic "morality" of the action
		/// </param>
		/// <exception cref="NotSupportedException">
		/// Thrown if the morality is not recognized
		/// </exception>
		public void DidSomething(KarmicMorality morality)
		{
			switch (morality)
			{
				case KarmicMorality.SaintLike:
				{
					this.Balance += 5;
					break;
				}
				
				case KarmicMorality.Good:
				{
					this.Balance += 1;
					break;
				}
					
				case KarmicMorality.Neutral:
				{
					// action was neutral... does not affect balance
					break;
				}
					
				case KarmicMorality.Bad:
				{
					this.Balance -= 1;
					break;
				}
					
				case KarmicMorality.MyGodWhatHaveYouDone:
				{
					this.Balance -= 5;
					break;
				}
					
				default:
				{
					throw new NotSupportedException();
				}
			}
			
			this.NumberOfActionsPerformed++;
		}
	}
}