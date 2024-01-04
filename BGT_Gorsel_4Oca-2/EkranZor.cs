using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_Gorsel_4Oca_2
{
    public partial class EkranZor : Form
    {
        public EkranZor()
        {
            InitializeComponent();
        }

        int UretilenSayi;
        int TahminHakki=3;
        private void EkranZor_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            UretilenSayi = rnd.Next(0, 501);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahminEdilenSayi = Convert.ToInt32(textBox1.Text);
            if (TahminHakki >= 0)
            {
                if (tahminEdilenSayi == UretilenSayi)
                {
                    MessageBox.Show("DOĞRU! Oyunu Kazandınız");
                    this.Close();
                }
                else
                {
                    TahminHakki--;
                    label5.Text = TahminHakki.ToString();
                    if (tahminEdilenSayi>UretilenSayi)
                    {
                        MessageBox.Show("Daha küçük bir sayı deneyin");
                    }
                    else
                    {
                        MessageBox.Show("Daha büyük bir sayı deneyin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Oyunu Kaybettiniz. Sayı:" + UretilenSayi);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label6.Text = rnd.Next(0, 501).ToString();
        }
    }
}
