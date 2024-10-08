namespace Education__Automation
{
	partial class FrmKulup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnListele = new System.Windows.Forms.Button();
			this.btn_guncelle = new System.Windows.Forms.Button();
			this.btn_ekle = new System.Windows.Forms.Button();
			this.btn_sil = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-2, -5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(686, 208);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(168, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kulüp Ad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(174, 223);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kulüp ID:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.Location = new System.Drawing.Point(273, 220);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(221, 30);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox2.Location = new System.Drawing.Point(273, 256);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(221, 30);
			this.textBox2.TabIndex = 4;
			// 
			// btnListele
			// 
			this.btnListele.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnListele.Location = new System.Drawing.Point(75, 305);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(212, 56);
			this.btnListele.TabIndex = 5;
			this.btnListele.Text = "Listele";
			this.btnListele.UseVisualStyleBackColor = false;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// btn_guncelle
			// 
			this.btn_guncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_guncelle.Location = new System.Drawing.Point(349, 305);
			this.btn_guncelle.Name = "btn_guncelle";
			this.btn_guncelle.Size = new System.Drawing.Size(212, 55);
			this.btn_guncelle.TabIndex = 6;
			this.btn_guncelle.Text = "Güncelle";
			this.btn_guncelle.UseVisualStyleBackColor = false;
			this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
			// 
			// btn_ekle
			// 
			this.btn_ekle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_ekle.Location = new System.Drawing.Point(75, 367);
			this.btn_ekle.Name = "btn_ekle";
			this.btn_ekle.Size = new System.Drawing.Size(212, 56);
			this.btn_ekle.TabIndex = 7;
			this.btn_ekle.Text = "Ekle";
			this.btn_ekle.UseVisualStyleBackColor = false;
			this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
			// 
			// btn_sil
			// 
			this.btn_sil.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_sil.Location = new System.Drawing.Point(349, 367);
			this.btn_sil.Name = "btn_sil";
			this.btn_sil.Size = new System.Drawing.Size(212, 56);
			this.btn_sil.TabIndex = 8;
			this.btn_sil.Text = "Sİl";
			this.btn_sil.UseVisualStyleBackColor = false;
			this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
			// 
			// FrmKulup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 450);
			this.Controls.Add(this.btn_sil);
			this.Controls.Add(this.btn_ekle);
			this.Controls.Add(this.btn_guncelle);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FrmKulup";
			this.Text = "Kulüp İşlemleri";
			this.Load += new System.EventHandler(this.FrmKulup_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Button btn_guncelle;
		private System.Windows.Forms.Button btn_ekle;
		private System.Windows.Forms.Button btn_sil;
	}
}