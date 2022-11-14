using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace codulculorilorRezistori
{
    public partial class culoareactrl : UserControl
    {
        public culoareactrl()
        {
            InitializeComponent();
        }

        public int codculoare;
        public int codlinie;
        public int codcoloana;
        public int codvaloare;


        public int GetCodColoana()
        {
            return this.codcoloana;
        }

       public Form1 f;

       public void setLabelColor(Color c)
       {
           label1.ForeColor = c;
       }
        public void setLabelText(string s)
        {
            label1.Text = s;
        }
        public string returnLabelValue()
        {
            return label1.Text;
        }

        private void culoareactrl_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }

        private void culoareactrl_MouseClick(object sender, MouseEventArgs e)
        {
          f.Text = this.Name;
          f.changecurrnetvalue(returnLabelValue(), this);
        }
    }
}
