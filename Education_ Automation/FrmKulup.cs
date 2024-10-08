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
	public partial class FrmKulup : Form
	{
		public FrmKulup()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=MELEKDMR\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
		
		public void listele()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_KULUPLER", baglanti);

			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void FrmKulup_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			listele();
		}

		private void btn_ekle_Click(object sender, EventArgs e)
		{
			try
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("INSERT INTO TBL_KULUPLER (KULUPAD) VALUES (@P1)", baglanti);
				komut.Parameters.AddWithValue("@1", textBox2.Text);
				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Kulüp listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				listele();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata mesajını gösterir
			}
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void btn_sil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Delete  From Tbl_Kulupler where KULUPID=@P1", baglanti);
			komut.Parameters.AddWithValue("@P1", textBox1.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("kulüp silme işlemi gerçekleşti.");
			listele();
		}

		private void btn_guncelle_Click(object sender, EventArgs e)
		{

			baglanti.Open();
			SqlCommand komut = new SqlCommand("Update TBL_KULUPLER set KULUPAD=@P1 WHERE KULUPID=@P2 ", baglanti);
			komut.Parameters.AddWithValue("@P1", textBox2.Text);
			komut.Parameters.AddWithValue("@P2", textBox1.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("kulüp güncelleme işlemi gerçekleşti.");
			listele();
		}
	}
}
