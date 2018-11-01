using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconquista
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void mtxtCPFCli_TextChanged(object sender, EventArgs e)
        {
            //colocar aqui validação do CPF
        }

        private void rbtnPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpjCli.Text = "CNPJ:";
            mtxtCpfCnpjCli.Mask = "00.000.000/0000-00";
            lblRGIECli.Text = "Insc. Est.:";            
        }

        private void rbtnPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpjCli.Text = "CPF:";
            mtxtCpfCnpjCli.Mask = "000.000.000-00";
            lblRGIECli.Text = "RG:";
        }

        private void FrmCadastroCliente_Shown(object sender, EventArgs e)
        {
            rbtnPessoaFisica.Checked = true;
            lblCpfCnpjCli.Text = "CPF:";
            mtxtCpfCnpjCli.Mask = "000.000.000-00";
            lblRGIECli.Text = "RG:";
        }

        private void mtxtTel_Leave(object sender, EventArgs e)
        {
            mtxtTel1.Mask = "";

            if (mtxtTel1.Text.Length == 11)
            {
                mtxtTel1.Mask = "";
                mtxtTel1.Mask = "(00)00000-0000";
            }
            else if (mtxtTel1.Text.Length == 10)
            {
                mtxtTel1.Mask = "";
                mtxtTel1.Mask = "(00)0000-0000";
            }
        }

        private void mtxtTel2_Leave(object sender, EventArgs e)
        {
            mtxtTel2.Mask = "";

            if (mtxtTel2.Text.Length == 11)
            {
                mtxtTel2.Mask = "";
                mtxtTel2.Mask = "(00)00000-0000";
            }
            else if (mtxtTel2.Text.Length == 10)
            {
                mtxtTel2.Mask = "";
                mtxtTel2.Mask = "(00)0000-0000";
            }
        }      

        private void btnAddBemSegurado_Click(object sender, EventArgs e)
        {
            txtBemSegurado.Enabled = true;
            mtxtPlaca.Enabled = true;
            rtxtObs.Enabled = true;
        }
    }
}
