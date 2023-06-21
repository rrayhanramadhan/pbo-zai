using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Promo_Pemesanan;

namespace Promo_Pemesanan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = promodigunakan;
        }
        public string promodigunakan { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int textBoxValue))
            {
                Form1 form1 = new Form1();
                form1.label16value = textBoxValue; // Mengatur nilai properti LabelValue di Form 2
                form1.ShowDialog(); // Menampilkan Form2 sebagai dialog
                this.Hide(); // Menyembunyikan Form1
            }
        }
    }
}
