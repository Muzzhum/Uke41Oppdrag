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
	public partial class DoubleDice : Form
	{
		public DoubleDice()
		{
			InitializeComponent();
		}

		Random rng = new Random();

		System.Drawing.Bitmap[] picArray = { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3,
											 Properties.Resources._4, Properties.Resources._5, Properties.Resources._6};
		int numOfRounds = 0;
		int numOfWins = 0;

		private void ThrowBtn_Click(object sender, EventArgs e)
		{
			WinMsgLbl.Hide();
			int d1 = rng.Next(0, 6);
			int d2 = rng.Next(0, 6);

			Die1.Image = picArray[d1];
			Die2.Image = picArray[d2];

			if (d1 == d2)
			{
				numOfWins++;
				WinsLbl.Text = numOfWins.ToString();
				WinMsgLbl.Show();
			}
			numOfRounds++;
			RoundsLbl.Text = numOfRounds.ToString();
		}
	}
}
