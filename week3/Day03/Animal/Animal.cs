using System;
namespace Animal
{
    public class Animal
    {
		public int hunger;
		public int thirst;

		public Animal(int hunger, int thirst)
		{
			this.hunger = hunger;
			this.thirst = thirst;
		}
		public void Eating()
		{
			this.hunger ++;
		}
		public void Drinking()
		{
			this.thirst--;
		}
		public void Playing()
		{
			this.hunger++;
			this.thirst--;
		}
	}
}
