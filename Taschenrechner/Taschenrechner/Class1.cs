using System;

namespace Taschenrechner
{
	public class Class1
	{
		public static double Addition(double zahl1, double zahl2)
		{
			return zahl1 + zahl2;						
		}
		public static double Subtraktion(double zahl1, double zahl2)
        {
			return  zahl1 - zahl2;
		
		}
		public static double Multiplikation(double zahl1, double zahl2)
        {
			return  zahl1 * zahl2;
			
		}
		public static double Division(double zahl1, double zahl2)
        {
			return zahl1 / zahl2;
			
		}
		public static double Mittelwert(double zahl1, double zahl2)
        {
				return (zahl1 + zahl2) / 2;
		}
		public static double Potenz(double zahl1, double zahl2)
        {
			return Math.Pow(zahl1, zahl2);
			
		}
		public static double Maximum(double zahl1, double zahl2)
        {
			if (zahl1 > zahl2)
			{
				return zahl1;

			}
			else
			{
				return zahl2;
			}
		}
	}
}
