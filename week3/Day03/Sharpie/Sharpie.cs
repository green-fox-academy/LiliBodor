using System;
namespace Sharpie
{
    public class Sharpie
    {
		public string color;
		public float width;
		public float inkamount;

		public Sharpie(string color, float width)
		{
			this.color = color;
			this.width = width;
			inkamount = 100f;
		}
        public void Use()
		{
			this.inkamount--;
		}
	}
}
