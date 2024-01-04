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
    public partial class EkranKolay : Form
    {
        public EkranKolay()
        {
            InitializeComponent();
        }

        int tahminHakki = 3;
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (tahminHakki>=0)
            {
                tahminHakki--;
                label5.Text = tahminHakki.ToString();

                if (tahmin==sayi)
                {
                    MessageBox.Show("DOĞRU");
                    this.Close();
                }
                else
                {
                    if (tahmin>sayi)
                    {
                        MessageBox.Show("YANLIŞ! Daha küçük sayı dene");
                    }
                    else
                    {
                        MessageBox.Show("YANLIŞ! Daha büyük sayı dene");
                    }
                }

            }
            else
            {
                MessageBox.Show("Maalesef Kaybettiniz. Sayı:"+sayi.ToString(),"GAME OVER");
                this.Close();
            }
        }

        private void EkranKolay_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 11);
        }
    }
}
