using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir =Convert.ToInt16(textBox1.Text);
            bilet =Convert.ToInt16(textBox4.Text);
            su = Convert.ToInt16(textBox2.Text);
            cay = Convert.ToInt16(textBox3.Text);

            toplam = misir * 40 + cay * 15 + su * 10 + bilet * 100;
            label9.Text = toplam.ToString() + "TL";
            //label11.Text=toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            label11.Text = kasatutar.ToString() + "TL";
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
