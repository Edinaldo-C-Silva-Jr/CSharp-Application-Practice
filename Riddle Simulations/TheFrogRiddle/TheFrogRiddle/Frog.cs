/*
 * Date: 25/03/2023
 * Time: 18:33
 */
using System;

namespace TheFrogRiddle
{
	// A class that represents a simple frog to be used in the riddle
	// A frog has a gender, which can be male or female. It cannot be changed once the frog is instanced
	// The gender is defined in the constructor, since this will be passed from the main program
	// A frog has a chance to croak, which is also defined by a parameter passed from the main program
	// Only male frogs can croak
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
