using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10.View.CPF
{
    public partial class CPF : Form
    {
        public CPF()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validaCpf();
        }
        private void validaCpf(){
            if (string.IsNullOrWhiteSpace(tbxCpf.Text))
            {
                MessageBox.Show("CPF é obrigatório","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tbxCpf.Focus();
                tbxCpf.SelectAll();
                return;

            }
            string cpfInformado = tbxCpf.Text.Replace(".", "").Replace("-","");
            lblResultado.Text = cpfInformado;

            if(cpfInformado.Length != 11)
            {
                lblResultado.Text = "Informe seu CPF com 11 Digitos.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformado.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;
        }

    }
}
