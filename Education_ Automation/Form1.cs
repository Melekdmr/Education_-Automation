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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			FrmOgrenciNotlar frm = new FrmOgrenciNotlar();
			frm.numara = textBox1.Text;
			frm.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			FrmOgretmen frm = new FrmOgretmen();

			frm.Show();
			this.Hide();

		}
	}
}
