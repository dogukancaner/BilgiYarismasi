using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogrusayisi = 0, yanlisayisi = 0;

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttonb.Text;
            if (label4.Text==label5.Text)
            {
                dogrusayisi++;
                labeldogru.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisayisi++;
                labelyanlis.Text = yanlisayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttonc.Text;
            if (label4.Text == label5.Text)
            {
                dogrusayisi++;
                labeldogru.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisayisi++;
                labelyanlis.Text = yanlisayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttond.Text;
            if (label4.Text == label5.Text)
            {
                dogrusayisi++;
                labeldogru.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisayisi++;
                labelyanlis.Text = yanlisayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttona.Text;
            if (label4.Text==label5.Text)
            {
                dogrusayisi++;
                labeldogru.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisayisi++;
                labelyanlis.Text = yanlisayisi.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void buttonsonraki_Click(object sender, EventArgs e)
        {
            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttonsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            labelsoruno.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                buttona.Text = "1921";
                buttonb.Text = "1922";
                buttonc.Text = "1923";
                buttond.Text = "1924";
                label4.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde bulunmaz?";
                buttona.Text = "İzmir";
                buttonb.Text = "Manisa";
                buttonc.Text = "Aydın";
                buttond.Text = "Bursa";
                label4.Text = "Bursa";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Çay en çok hangi şehrimizde üretilir?";
                buttona.Text = "Artvin";
                buttonb.Text = "Rize";
                buttonc.Text = "Giresun";
                buttond.Text = "Trabzon";
                label4.Text = "Rize";
                buttonsonraki.Text = "Sonuçlar";
            }
            if (soruno==4)
            {
                buttona.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttonsonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogrusayisi + "\n" + " Yanlış: " + yanlisayisi);
            }
        }
    }
}
