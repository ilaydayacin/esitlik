using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tek_sayı_çift_sayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=Convert.ToInt32(tbSayi.Value);

            if(sayi % 2==0)
            {
                MessageBox.Show("Sayı çifttir");
            }

            if (sayi % 2==1)
            {
                MessageBox.Show("Sayı tekdir");
            }

            if(sayi<=0)
            {
                MessageBox.Show("Sayı Nötrdür");
            }
         }

        private void tbSayi_Scroll(object sender, EventArgs e)
        {
            lblTb.Text = tbSayi.Value.ToString();
        }
    }
}
