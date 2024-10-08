using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education__Automation
{
	public partial class FrmOgretmen : Form
	{
		public FrmOgretmen()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			FrmKulup fr = new FrmKulup();
			fr.Show();
		}
	}
}
