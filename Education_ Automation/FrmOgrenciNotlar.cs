using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education__Automation
{
	public partial class FrmOgrenciNotlar : Form
	{
		public FrmOgrenciNotlar()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=MELEKDMR\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
		public string numara;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
		{

			SqlCommand komut = new SqlCommand("select DERSAD ,SINAV1 ,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBL_NOTLAR\r\nINNER JOIN TBL_DERSLER ON TBL_NOTLAR.DERSID=TBL_DERSLER.DERSID WHERE OGRID=@P1", baglanti);
			komut.Parameters.AddWithValue("@P1", numara);
			//	this.Text = numara.ToString();
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable dt=new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;

			baglanti.Open();
			SqlCommand komut2 = new SqlCommand(" SELECT OGRAD,OGRSOYAD FROM TBL_OGRENCİ WHERE OGRİD= @p2", baglanti);
			komut2.Parameters.AddWithValue("@p2", numara);
			SqlDataReader dr = komut2.ExecuteReader();
			while (dr.Read())
			{
				this.Text = dr[0].ToString() + " " + dr[1].ToString();
			}

			baglanti.Close();

		}
	}
}
