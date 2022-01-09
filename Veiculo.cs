using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    class Veiculo
    {
        public string Cor;
        public string Modelo = "201";
        private string Cilindrada;
        public string Marca = "Volkswagen";
        public bool TemRoda = true;

        public void setCilindrada(string Cilindrada)
        {
            this.Cilindrada = Cilindrada;
        }

        public string getCilindrada()
        {
            return Cilindrada;
        }

        public string CorDaRoda = "Preto";

        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        //public void Veiculo( string Cor, string Cilindrada )
        //    {
        //        this.Cilindrada = "150 cc";
        //        this.Cor = "Azul";
        //  Método construtor, sempre será void e tem o mesmo nome da classe que irá instanciar. 
        //    }

      public Veiculo()
        {
            Console.WriteLine("Classe veículo sendo construída: ");
        }

        public int Consumo()
        {
            int consumo = 10;
            return consumo;
        }

        private int ConsumoPorLitro;

        public void setConsumoPorLitro(int ConsumoPorLitro)
        {
            this.ConsumoPorLitro = ConsumoPorLitro;
        }

        public int getConsumoPorLitro()
        {
            return ConsumoPorLitro;
        }

        public double resultadoQuilometragem(double valor1, double valorConvertidoPorLitro2)
        {
            double resultado = (valor1 / valorConvertidoPorLitro2);
            return resultado;
        }

    }
}
