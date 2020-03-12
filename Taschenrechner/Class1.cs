using System;

namespace Taschenrechner
{
	public class Class1
	{
		public Addition()
		{
			double ergebnis = zahl1 + zahl2;
			lblErgebnis.Text = Convert.ToString(ergebnis);
			lblOperator.Text = "+";
		}
		public Subtraktion()
        {
			double ergebnis = zahl1 - zahl2;
			lblErgebnis.Text = Convert.ToString(ergebnis);
			lblOperator.Text = "-";
		}
		public Multiplikation()
        {
			double ergebnis = zahl1 * zahl2;
			lblErgebnis.Text = Convert.ToString(ergebnis);
			lblOperator.Text = "*";
		}
		public Division()
        {
			double ergebnis = zahl1 / zahl2;
			lblErgebnis.Text = Convert.ToString(ergebnis);
			lblOperator.Text = "/";
		}
		public Mittelwert()
        {
			double ergebnis = (zahl1 + zahl2) / 2;
			lblErgebnis.Text = Convert.ToString(ergebnis);
			lblOperator.Text = "X̅";
		}
		public Potenz()
        {
			double ergebnis = Math.Pow(zahl1, zahl2);
			lblErgebnis.Text = Convert.ToString(ergebnis);
			lblOperator.Text = "^";
		}
		public Maximum()
        {
			if (zahl1 > zahl2)
			{
				lblErgebnis.Text = Convert.ToString(zahl1);
				lblOperator.Text = ">";

			}
			else
			{
				lblErgebnis.Text = Convert.ToString(zahl2);
				lblOperator.Text = ">";
			}
		}
		public static ZahlenEinlesen()
        {
			double zahl1 = Convert.ToDouble(txtOperand1.Text);
			double zahl2 = Convert.ToDouble(txtOperand2.Text);
		}
	}
}
