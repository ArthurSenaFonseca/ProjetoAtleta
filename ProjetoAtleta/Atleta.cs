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

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
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
    }
}
