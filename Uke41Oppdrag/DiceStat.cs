using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uke41Oppdrag
{
	public partial class DiceStat : Form
	{
		public DiceStat()
		{
			InitializeComponent();
		}

		Random rng = new Random();
		void diceThrower (int numOfSides, int[] diceArray, decimal numOfThrows)
		{
			if (diceArray.Length != numOfSides)
				return;

			for (int iii = 0; iii < numOfThrows; iii++)
			{
				diceArray[rng.Next(0, numOfSides)]++;
			}
		}

		//int[] diceArray;
		decimal sum = 0;
		private void ThrowBtn_Click(object sender, EventArgs e)
		{
			
			int[] diceArray = new int[(int)SidesNumUD.Value] { };

			diceThrower((int)SidesNumUD.Value, diceArray, ThrowsNumUD.Value);

			/*		
			for (int iii = 0; iii < diceArray.Length; iii++)
				sum += diceArray[iii];
			*/
			for (int iii = 0; iii < diceArray.Length; iii++)
			{
				StatChart.Series["Antall"].Points.AddXY(iii, iii+1);
			}
		}
	}
}
