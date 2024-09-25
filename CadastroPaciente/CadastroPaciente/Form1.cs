using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPaciente
{
    public partial class Form1 : Form
    {
        Paciente pac = new Paciente();
        public Form1()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string dados;
            dados = pac.mostrarDadosPaciente();

            Font fonte25 = new Font("Comic Sans", 25, FontStyle.Bold);
            SolidBrush corFonteTitulo = new SolidBrush(Color.BurlyWood);

            Font fonte16 = new Font("Tahoma", 16);
            SolidBrush corFonteTexto = new SolidBrush(Color.LightGreen);

            e.Graphics.DrawString("FOLHA EMPREGADO", fonte25, corFonteTitulo, new Point(60, 50));
            e.Graphics.DrawString(dados, fonte16, corFonteTexto, new Point(100, 170));
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigoPaciente.Text);
            string nome = txtNomePaciente.Text;
            char sexo = char.Parse(cmbSexoPaciente.Text);
            string rg = mskRg.Text;
            string cpf = mskCpf.Text;
            string dataNasc = mskData.Text;
            string endereco = txtEndereco.Text;
            int numero = int.Parse(txtNumero.Text);
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string estado = cmbEstado.Text;
            string telefone = msktelefone.Text;
            string celular = mskCelular.Text;

            pac.Codigo = codigo;
            pac.NomePaciente = nome;
            pac.Sexo = sexo;
            pac.Rg = rg;
            pac.Cpf = cpf;
            pac.DataNasc = dataNasc;
            pac.Endereco = endereco;
            pac.Numero = numero;
            pac.Complemento = complemento;
            pac.Bairro = bairro;
            pac.Cidade = cidade;
            pac.Estado = estado;
            pac.Telefone = telefone;
            pac.Celular = celular;

            MessageBox.Show("Cadastro Realizado Com Sucesso!!!");

        }
    }
}
