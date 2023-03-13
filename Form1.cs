using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi1
{
    public partial class Form1 : Form
    {

        char _islem;        //her yerde geçerli olduğu anlaşılsın diye çizgi koydum
        bool _ekrantemizmi;
        int _ilksayi;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi= false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = " ";
            ekranlabel1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizmi) ekranlabel1.Text = "";
            _ekrantemizmi = false;
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _ekrantemizmi = false;
            if (_ekrantemizmi) ekranlabel1.Text = "";
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "0";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);//text str olduğu için int yaptık
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //eşittir butonu
            int ikincisayi = Convert.ToInt32(ekranlabel1.Text);
            int sonuc =0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi; break;
                case '-':
                    sonuc = _ilksayi - ikincisayi; break;
                case '*':
                    sonuc = _ilksayi * ikincisayi; break;
                case '/':
                    sonuc = _ilksayi / ikincisayi; break;
               

            }
            ekranlabel1.Text = Convert.ToString(sonuc);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekrantemizmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ekranlabel1.Text = "0";
        }
    }
}
