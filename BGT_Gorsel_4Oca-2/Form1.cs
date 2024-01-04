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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkranKolay ekranKolay = new EkranKolay();
            ekranKolay.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranOrta ekranOrta = new EkranOrta();  
            ekranOrta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EkranZor ekranZor = new EkranZor();
            ekranZor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
