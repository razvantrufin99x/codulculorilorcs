using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace codulculorilorRezistori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string currentval = "";
        public float A = 0.0f;
        public float B = 0.0f;
        public float C = 0.0f;
        public float D = 0.0f;
        public float valoare = 0.0f;

        public void changecurrnetvalue(string s, culoareactrl cc)
        {
            currentval = s;
            Text = cc.Name;
            Text += " : ";
            Text += cc.GetCodColoana().ToString();

            if (cc.GetCodColoana() == 1)
            {
                textBox1.Text = cc.returnLabelValue();
                if (cc.returnLabelValue() != "-")
                {
                    A = float.Parse(cc.returnLabelValue());
                }
            }
            else if (cc.GetCodColoana() == 2)
            {
                textBox2.Text = cc.returnLabelValue();
                if (cc.returnLabelValue() != "-")
                {
                    B = float.Parse(cc.returnLabelValue());
                }
            }
            else if (cc.GetCodColoana() == 3)
            {
                textBox3.Text = cc.returnLabelValue();
                if (cc.returnLabelValue() != "-")
                {
                    C = float.Parse(cc.returnLabelValue());
                }
            }
            else if (cc.GetCodColoana() == 4)
            {
                textBox4.Text = cc.returnLabelValue();
                if (cc.returnLabelValue() != "-")
                {
                    D = float.Parse(cc.returnLabelValue());
                }
            }

            try
            {
                valoare = (((A * 10) + B) * (float)(Math.Pow(10,C)) ) ;

                textBox7.Text = valoare.ToString();
                textBox6.Text = (valoare-(valoare *( D / 100))).ToString();
                textBox8.Text = (valoare+(valoare *( D / 100))).ToString();

            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            culoareactrl1.setLabelText("0"); 
            culoareactrl1.setLabelColor(Color.White);
            culoareactrl2.setLabelText("1");
            culoareactrl2.setLabelColor(Color.White);
            culoareactrl3.setLabelText("2");
            culoareactrl4.setLabelText("3");
            culoareactrl5.setLabelText("4");
            culoareactrl6.setLabelText("5");
            culoareactrl7.setLabelText("6");
            culoareactrl8.setLabelText("7");
            culoareactrl9.setLabelText("8");
            culoareactrl10.setLabelText("9");
            culoareactrl11.setLabelText("-");
            culoareactrl12.setLabelText("-");
            culoareactrl13.setLabelText("-");

            culoareactrl1.codcoloana = 1;
            culoareactrl2.codcoloana = 1;
            culoareactrl3.codcoloana = 1;
            culoareactrl4.codcoloana = 1;
            culoareactrl5.codcoloana = 1;
            culoareactrl6.codcoloana = 1;
            culoareactrl7.codcoloana = 1;
            culoareactrl8.codcoloana = 1;
            culoareactrl9.codcoloana = 1;
            culoareactrl10.codcoloana = 1;
            culoareactrl11.codcoloana = 1;
            culoareactrl12.codcoloana = 1;
            culoareactrl13.codcoloana = 1;


            culoareactrl14.setLabelText("0");
            culoareactrl14.setLabelColor(Color.White);
            culoareactrl15.setLabelText("1");
            culoareactrl15.setLabelColor(Color.White);
            culoareactrl16.setLabelText("2");
            culoareactrl17.setLabelText("3");
            culoareactrl18.setLabelText("4");
            culoareactrl19.setLabelText("5");
            culoareactrl20.setLabelText("6");
            culoareactrl21.setLabelText("7");
            culoareactrl22.setLabelText("8");
            culoareactrl23.setLabelText("9");
            culoareactrl24.setLabelText("-");
            culoareactrl25.setLabelText("-");
            culoareactrl26.setLabelText("-");

            culoareactrl14.codcoloana = 2;
            culoareactrl15.codcoloana = 2;
            culoareactrl16.codcoloana = 2;
            culoareactrl17.codcoloana = 2;
            culoareactrl18.codcoloana = 2;
            culoareactrl19.codcoloana = 2;
            culoareactrl20.codcoloana = 2;
            culoareactrl21.codcoloana = 2;
            culoareactrl22.codcoloana = 2;
            culoareactrl23.codcoloana = 2;
            culoareactrl24.codcoloana = 2;
            culoareactrl25.codcoloana = 2;
            culoareactrl26.codcoloana = 2;


            culoareactrl27.setLabelText("0");
            culoareactrl27.setLabelColor(Color.White);
            culoareactrl28.setLabelText("1");
            culoareactrl28.setLabelColor(Color.White);
            culoareactrl29.setLabelText("2");
            culoareactrl30.setLabelText("3");
            culoareactrl31.setLabelText("4");
            culoareactrl32.setLabelText("5");
            culoareactrl33.setLabelText("6");
            culoareactrl34.setLabelText("7");
            culoareactrl35.setLabelText("8");
            culoareactrl36.setLabelText("9");
            culoareactrl37.setLabelText("-1");
            culoareactrl38.setLabelText("-2");
            culoareactrl39.setLabelText("-");

            culoareactrl27.codcoloana = 3;
            culoareactrl28.codcoloana = 3;
            culoareactrl29.codcoloana = 3;
            culoareactrl30.codcoloana = 3;
            culoareactrl31.codcoloana = 3;
            culoareactrl32.codcoloana = 3;
            culoareactrl33.codcoloana = 3;
            culoareactrl34.codcoloana = 3;
            culoareactrl35.codcoloana = 3;
            culoareactrl36.codcoloana = 3;
            culoareactrl37.codcoloana = 3;
            culoareactrl38.codcoloana = 3;
            culoareactrl39.codcoloana = 3;


            culoareactrl40.setLabelText("-");
            culoareactrl40.setLabelColor(Color.White);
            culoareactrl41.setLabelText("1");
            culoareactrl41.setLabelColor(Color.White);
            culoareactrl42.setLabelText("2");
            culoareactrl43.setLabelText("-");
            culoareactrl44.setLabelText("-");
            culoareactrl45.setLabelText("-");
            culoareactrl46.setLabelText("-");
            culoareactrl47.setLabelText("-");
            culoareactrl48.setLabelText("-");
            culoareactrl49.setLabelText("-");
            culoareactrl50.setLabelText("5");
            culoareactrl51.setLabelText("10");
            culoareactrl52.setLabelText("20");

            culoareactrl40.codcoloana = 4;
            culoareactrl41.codcoloana = 4;
            culoareactrl42.codcoloana = 4;
            culoareactrl43.codcoloana = 4;
            culoareactrl44.codcoloana = 4;
            culoareactrl45.codcoloana = 4;
            culoareactrl46.codcoloana = 4;
            culoareactrl47.codcoloana = 4;
            culoareactrl48.codcoloana = 4;
            culoareactrl49.codcoloana = 4;
            culoareactrl50.codcoloana = 4;
            culoareactrl51.codcoloana = 4;
            culoareactrl52.codcoloana = 4;

        }
    }
}
