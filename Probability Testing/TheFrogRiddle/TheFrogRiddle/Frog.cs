/*
 * Date: 25/03/2023
 * Time: 18:33
 */
using System;

namespace TheFrogRiddle
{
	/// <summary>
	/// Description of Frog.
	/// </summary>
	public class Frog
	{
		private bool male;
		private bool croaked;
		
		public Frog(bool isMale)
		{
			this.male = isMale;
		}
		
		public void croak(bool didItCroak)
		{
			if (this.male)
			{
				this.croaked = didItCroak;
			}
		}
		
		public bool getGender()
		{
			return this.male;
		}
		
		public bool getCroaked()
		{
			return this.croaked;
		}
	}
}
