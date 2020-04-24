using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWindowsChas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operacija;
        decimal prvbroj, vtorbroj, rezultat;
        bool tocka = false;
        private void btnNum_Click(object sender, EventArgs e)
        {
            if(rezultat == 0)
            {
                Button btn = sender as Button;
                if (btn.Name.Contains("btnNum"))
                {
                    txtInput.Text += btn.Text;
                }
            }
            else if(rezultat != 0)
            {
                rezultat = 0;
                txtInput.Text = "";
                Button btn = sender as Button;
                if (btn.Name.Contains("btnNum"))
                {
                    txtInput.Text += btn.Text;
                }
            }
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (tocka == false && txtInput.Text != "")
            {
                txtInput.Text += btnDecimal.Text;
                tocka = true;
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            operacija = "sobiranje";
            txtInput.Text = "";
            tocka = false;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            operacija = "odzemanje";
            txtInput.Text = "";
            tocka = false;
        }
        private void btnMultiple_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            operacija = "mnozenje";
            txtInput.Text = "";
            tocka = false;
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            operacija = "delenje";
            txtInput.Text = "";
            tocka = false;
        }
        private void btnQuadratic_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            rezultat = Operation_Units.SquareRoot(prvbroj);
            txtInput.Text = Convert.ToString(rezultat);
            tocka = false;
        }
        private void btn1DividedX_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            rezultat = Operation_Units.Reciprocal(prvbroj);
            txtInput.Text = Convert.ToString(rezultat);
            tocka = false;
        }
        private void btnbtnOnQuadrate_Click(object sender, EventArgs e)
        {
            prvbroj = Convert.ToDecimal(txtInput.Text);
            rezultat = Operation_Units.Square(prvbroj);
            txtInput.Text = Convert.ToString(rezultat);
            tocka = false;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            vtorbroj = Convert.ToDecimal(txtInput.Text);
            if(operacija == "")
            {
                txtInput.Text = txtInput.Text;
                prvbroj = 0;
                vtorbroj = 0;
                tocka = false;
            }
            else
            {
                if(operacija == "sobiranje")
                {
                    rezultat = Operation_Units.Add(prvbroj, vtorbroj);
                    txtInput.Text = Convert.ToString(rezultat);
                    tocka = false;
                }
                if (operacija == "odzemanje")
                {
                    rezultat = Operation_Units.Substract(prvbroj, vtorbroj);
                    txtInput.Text = Convert.ToString(rezultat);
                    tocka = false;
                }
                if (operacija == "mnozenje")
                {
                    rezultat = Operation_Units.Multiply(prvbroj, vtorbroj);
                    txtInput.Text = Convert.ToString(rezultat);
                    tocka = false;
                }
                if (operacija == "delenje")
                {
                    rezultat = Operation_Units.Divide(prvbroj, vtorbroj);
                    txtInput.Text = Convert.ToString(rezultat);
                    tocka = false;
                }
            }
        }
        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
