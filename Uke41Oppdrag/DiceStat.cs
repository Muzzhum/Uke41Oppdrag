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

        List<int> diceArray;
        int totalThrows = 0;

        Random rng = new Random();

        // throws 
		void diceThrower (int numOfSides, decimal numOfThrows)
		{
			for (int iii = 0; iii < numOfThrows; iii++)
			{
				diceArray[rng.Next(0, numOfSides)]++;
			}
		}


		private void ThrowBtn_Click(object sender, EventArgs e)
		{
            if (diceArray == null || diceArray.Count != (int)SidesNumUD.Value)
            {
                diceArray = Enumerable.Repeat(0, (int)SidesNumUD.Value).ToList();
                totalThrows = 0;
            }

            totalThrows += (int)SidesNumUD.Value;

            diceThrower((int)SidesNumUD.Value,ThrowsNumUD.Value);
            StatChart.Series["Antall"].Points.Clear();

            for (int iii = 0; iii < diceArray.Count; iii++)
				StatChart.Series["Antall"].Points.AddXY(iii + 1, (double)diceArray[iii] / totalThrows);
		}
    }
}
