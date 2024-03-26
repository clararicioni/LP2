using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskdbx1.Text = "";
            mskdbx2.Text = "";
            mskdbx1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            double.TryParse(mskdbx1.Text, out peso);//converte texto em double
            double.TryParse(mskdbx2.Text, out altura);
            imc = peso/Math.Pow(altura, 2);
            imc = Math.Round(imc,1);//arredonda o IMC
            if (imc < 18.5)
                MessageBox.Show("Imc: "+ imc +" - Menor que 18,5 - Magreza - Obesidade grau 0.");
            else if (imc<=24.9)
                MessageBox.Show("Imc: " + imc + " - Entre 18,5 e 24,9 - Normal - Obesidade grau 0.");
            else if(imc<=29.9)
                MessageBox.Show("Imc: " + imc + " - Entre 25,0 e 29,9 - Sobrepeso - Obesidade grau 1.");
            else if(imc<=39.9)
                MessageBox.Show("Imc: " + imc + " - Entre 30,0 e 39,9 - Obesidade - Obesidade grau 2.");
            else
                MessageBox.Show("Imc: " + imc + " - Maior ou igual a 40,0 - Obesidade grave - Obesidade grau 3.");
        }

        private void mskdbx1_Validated(object sender, EventArgs e)
        {
            if (mskdbx1.Text == "000,00") { 
            MessageBox.Show("Valores nao podem ser igual a 0");
            mskdbx1.Text = "";
            mskdbx1.Focus();
        }
        }

        private void mskdbx2_Validated(object sender, EventArgs e)
        {
            if (mskdbx2.Text == "0,00") {
            MessageBox.Show("Valores nao podem ser iguais a 0");
            mskdbx2.Text = "";
            mskdbx2.Focus();
        }
        }
    }
}
