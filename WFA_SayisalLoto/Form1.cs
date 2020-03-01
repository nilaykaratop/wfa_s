using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tik = 1;
        private void metroTile1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            if (tik % 2 == 0)
            {
                timer1.Stop();
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";

            }
            tik++;
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval += 30;
            sayac++;
            int[] sayilar = new int[0];
            Random rnd = new Random();
            while (sayilar.Length < 6)
            {
                int rastgele = rnd.Next(1, 50);
                if (Array.IndexOf(sayilar, rastgele) == -1)
                {
                    Array.Resize<int>(ref sayilar, sayilar.Length + 1);
                    sayilar[sayilar.Length - 1] = rastgele;
                }


            }
            Array.Sort(sayilar);
            textBox1.Text = sayilar[0].ToString();
            textBox2.Text = sayilar[1].ToString();
            textBox3.Text = sayilar[2].ToString();
            textBox4.Text = sayilar[3].ToString();
            textBox5.Text = sayilar[4].ToString();
            textBox6.Text = sayilar[5].ToString();
            if (sayac == 10)
            {
                timer1.Stop();
                timer1.Interval = 100;
                sayac = 0;
            }

        }
    }
}
