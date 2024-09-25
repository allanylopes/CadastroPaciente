using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPaciente
{
    class Paciente
    {
        private int codigo;
        private string nomePaciente;
        private char sexo;
        private string rg;
        private string cpf;
        private string dataNasc;
        private string endereco;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string telefone;
        private string celular;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string NomePaciente
        {
            get
            {
                return nomePaciente;
            }

            set
            {
                nomePaciente = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string mostrarDadosPaciente()
        {
            return " Codigo: " + codigo + "\n Nome: " + nomePaciente + "\n Sexo: " + sexo + "\n RG: " + rg + "\n CPF: " + cpf + "\n Data Nascimento: " + dataNasc + "\n Endereço: " + endereco + "\n Número: " + numero + "\n Complemento: " + complemento + "\n Bairro: " + bairro + "\n Cidade: " + cidade + "\n Estado: " + estado + "\n Telefone: " + telefone + "\n Celular: " + celular ;
        }
    }
}
