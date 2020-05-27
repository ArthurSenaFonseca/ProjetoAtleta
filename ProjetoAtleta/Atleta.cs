using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;

        public string Nome {
            set
            {
                if(value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }

            }
            get { return this.nome; }
        }
        public double Altura
        {
            set
            {
                if (value >= 1)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima é de 1.00m");
                }

            }
            get { return this.altura; }
        }
        public double Peso
        {
            set
            {
                if (value >= 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso mínumo é de 1Kg");
                }

            }
            get { return this.peso; }
        }
        public int Idade
        {
            set
            {
                if (value >= 1)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade mínima é de 1 ano");
                }

            }
            get { return this.idade; }
        }
        public string ImprimirDados()
        {
            return "Dados dos Atletas: \n\n Nome: " + this.nome + "\n Altura: " + this.altura.ToString("0.00") + "m" + "\n Peso: " + this.peso + "\n Idade: " + this.idade;
        }
        /*public double CalcularIMC()
        {
            Double total;
            total = (obj.Peso / (obj.Altura * obj.Altura));
            string resultado = Convert.ToString(total);
            txt_imc.Text = resultado.ToString(CultureInfo.InvariantCulture);
        }
        {
            if (nome != string.Empty)
            {
                this.Nome = nome;
            }
            else
            {
                throw new Exception("O nome deve ser obrigatoriamente preenchido.");
            }
            
        }
        public string getNome()
        {
            return Nome;
        }
        
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getAltura()
        {
            return altura;
        }
        public void getPeso(double peso)
        {
            this.peso = peso;
        }
        public double getPeso()
        {
            return peso;
        }
        public void getIdade(int idade)
        {
            this.idade = idade;
        }
        public double getIdade()
        {
            return idade;
        }
        */
    }
}
