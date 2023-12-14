using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX8WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Comparador c;
            c = new Comparador();

            c.SetV1(double.Parse(txtN1.Text));
            c.SetV2(double.Parse(txtN2.Text));

            txtR.Text = c.Comparar().ToString();
        }
    }
}
