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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void MonthfinderBtn_Click(object sender, EventArgs e)
		{
			MonthFinder monthfinder = new MonthFinder();
			monthfinder.Show();	
		}

		private void DoubleDiceBtn_Click(object sender, EventArgs e)
		{
			DoubleDice doubleDice = new DoubleDice();
			doubleDice.Show();
		}

		private void DiceStatBtn_Click(object sender, EventArgs e)
		{
			DiceStat diceStat = new DiceStat();
			diceStat.Show();
		}
	}
}
