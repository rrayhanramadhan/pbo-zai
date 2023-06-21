using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Promo_Pemesanan;
using Npgsql;

namespace Promo_Pemesanan
{
    public partial class Form1 : Form
    {

        private bool guna2Button1MouseClick = false;
        private bool guna2Button2MouseClick = false;
        private bool guna2Button3MouseClick = false;

        Form2 form2 = new Form2();
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else
            {
                guna2Button1.Text = "Digunakan";
                guna2Button1.ForeColor = Color.WhiteSmoke;
                guna2Button1.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button1MouseClick = true;
                Form2 form2 = new Form2();
                form2.promodigunakan = label2.Text;
                form2.Show();
                this.Hide();
            }
            if (guna2Button2MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button2MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else
            {
                guna2Button2.Text = "Digunakan";
                guna2Button2.ForeColor = Color.WhiteSmoke;
                guna2Button2.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button2MouseClick = true;
                Form2 form2 = new Form2();
                form2.promodigunakan = label7.Text;
                form2.Show();
                this.Hide();
            }
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
            else
            {
                guna2Button3.Text = "Digunakan";
                guna2Button3.ForeColor = Color.WhiteSmoke;
                guna2Button3.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button3MouseClick = true;
                Form2 form2 = new Form2();
                form2.promodigunakan = label11.Text;
                form2.Show();
                this.Hide();
            }
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
        }

        public int label16value { get; set; }
        public void Form1_Load(object sender, EventArgs e)
        {
            label16.Text = label16value.ToString();
            label16.Visible = false;
            int syarat_tiket;
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=jecation;User Id=postgres;Password=123;");
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT nama_voucher, tanggal_berakhir, syarat_voucher FROM voucher");
            cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DateTime tanggal_sekarang = DateTime.Now;


            if (reader.Read())
            {
                label2.Text = reader["nama_voucher"].ToString();
                DateTime tanggal_berakhir = (DateTime)reader["tanggal_berakhir"];
                label3.Text = tanggal_berakhir.ToString("yyyy-mm-dd");
                syarat_tiket = reader.GetInt32(reader.GetOrdinal("syarat_voucher"));

                if (label16value < syarat_tiket || tanggal_sekarang > tanggal_berakhir)
                {
                    guna2Button1.Enabled = false;
                    guna2Button1.ForeColor = Color.WhiteSmoke;
                }

                //if (tanggal_sekarang > tanggal_berakhir)
                //{
                //    guna2Button1.Enabled = false;
                //    guna2Button1.ForeColor = Color.WhiteSmoke;
                //}
            }
            if (reader.Read())
            {
                label7.Text = reader["nama_voucher"].ToString();
                DateTime tanggal_berakhir = (DateTime)reader["tanggal_berakhir"];
                label6.Text = tanggal_berakhir.ToString("yyyy-mm-dd");
                syarat_tiket = reader.GetInt32(reader.GetOrdinal("syarat_voucher"));

                if (label16value < syarat_tiket || tanggal_sekarang > tanggal_berakhir)
                {
                    guna2Button2.Enabled = false;
                    guna2Button2.ForeColor = Color.WhiteSmoke;
                }
                //if (tanggal_sekarang > tanggal_berakhir)
                //{
                //    guna2Button2.Enabled = false;
                //    guna2Button2.ForeColor = Color.WhiteSmoke;
                //}
            }
            if (reader.Read())
            {
                label11.Text = reader["nama_voucher"].ToString();
                DateTime tanggal_berakhir = (DateTime)reader["tanggal_berakhir"];
                label10.Text = tanggal_berakhir.ToString("yyyy-mm-dd");
                syarat_tiket = reader.GetInt32(reader.GetOrdinal("syarat_voucher"));

                if (label16value < syarat_tiket || tanggal_sekarang > tanggal_berakhir)
                {
                    guna2Button3.Enabled = false;
                    guna2Button3.ForeColor = Color.WhiteSmoke;
                }
                //if (tanggal_sekarang > tanggal_berakhir)
                //{
                //    guna2Button3.Enabled = false;
                //    guna2Button3.ForeColor = Color.WhiteSmoke;
                //}
            }
            cmd.Dispose();
            con.Close();
        }

        private Size formOriginalSize;
        private Rectangle recpnl1;
        private Rectangle promo1;
        private Rectangle promo2;
        private Rectangle promo3;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpnl1 = new Rectangle(panel1.Location, panel1.Size);
            promo1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            promo2 = new Rectangle(guna2Panel2.Location, guna2Panel2.Size);
            promo3 = new Rectangle(guna2Panel3.Location, guna2Panel3.Size);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpnl1);
            resize_Control(guna2Panel1, promo1);
            resize_Control(guna2Panel2, promo2);
            resize_Control(guna2Panel3, promo3);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}