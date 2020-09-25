using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
        int toplamsen = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            int a = rand.Next(1, 7);
            int b = rand.Next(1, 7);
            label3.Text = a.ToString();
            label4.Text = b.ToString();

            toplamsen = toplamsen + a + b;
            label16.Text = toplamsen.ToString();

            if(a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\\\Eren\\Desktop\\Zar\\1.jpg";
            }
            if(a==2)
            {
                pictureBox1.ImageLocation= "C:\\Users\\\\Eren\\Desktop\\Zar\\2.jpg";
            }
            if(a==3)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\3.jpg";
            }
            if(a==4)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\4.jpg";
            }
            if(a==5)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\5.jpg";
            }
            if(a==6)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\6.jpg";
            }

            if(b==1)
            {
                pictureBox2.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\1.jpg";
            }
            if(b==2)
            {
                pictureBox2.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\2.jpg";
            }
            if(b==3)
            {
                pictureBox2.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\3.jpg";
            }
            if(b==4)
            {
                pictureBox2.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\4.jpg";
            }
            if(b==5)
            {
                pictureBox2.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\5.jpg";
            }
            if(b==6)
            {
                pictureBox2.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\6.jpg";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            int c = rand.Next(1, 7);
            int d = rand.Next(1, 7);
            label9.Text = c.ToString();
            label10.Text = d.ToString();

            toplampc = toplampc + c + d;
            label15.Text = toplampc.ToString();

            if(c==1)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\1.jpg";
            }
            if(c==2)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\2.jpg";
            }
            if(c==3)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\3.jpg";
            }
            if(c==4)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\4.jpg";
            }
            if(c==5)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\5.jpg";
            }
            if(c==6)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Eren\\Desktop\\Zar\\6.jpg";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Eren\\Desktop\\Zar\\1.jpg";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Eren\\Desktop\\Zar\\2.jpg";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Eren\\Desktop\\Zar\\3.jpg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Eren\\Desktop\\Zar\\4.jpg";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Eren\\Desktop\\Zar\\5.jpg";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Eren\\Desktop\\Zar\\6.jpg";
            }

            if(toplamsen>=100 && toplamsen>toplampc)
            {
                label13.Text = "Tebrikler, oyunun galibi sensin!";
                label6.Text = toplamsen.ToString();
                label7.Text = toplampc.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
            }
            if(toplampc>=100 && toplampc>toplamsen)
            {
                label13.Text = "Üzgünüm,oyunu bilgisayar kazandı!";
                label6.Text = toplamsen.ToString();
                label7.Text = toplampc.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label7.Text = "0";
            label13.Text = "";

            toplamsen = Convert.ToInt32(label16.Text);
            label16.Text = toplamsen.ToString();
            toplamsen = 0;
            label16.Text = toplamsen.ToString();

            toplampc = Convert.ToInt32(label15.Text);
            label15.Text = toplampc.ToString();
            toplampc = 0;
            label15.Text = toplampc.ToString();

            button1.Enabled = true;
            button2.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        }
    }
}
