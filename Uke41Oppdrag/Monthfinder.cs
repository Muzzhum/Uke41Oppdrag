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
	public partial class MonthFinder : Form
	{
		public MonthFinder()
		{
			InitializeComponent();
		}

		string[] months = { "Januar", "Februar", "Mars", "April", "Mai", "Juni", "Juli",
							"August", "September", "Oktober", "November", "Desember" };

		int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		private void MonthCalcBtn_Click(object sender, EventArgs e)
		{
			int monthNum = (int) MonthNumUD.Value;
			MonthOutputLbl.Text = months[monthNum - 1] + " har " + days[monthNum - 1] + " dager";
		}
	}
}
