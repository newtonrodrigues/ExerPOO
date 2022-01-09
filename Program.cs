using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // POO
            Veiculo veiculo = new Veiculo();

            veiculo.Cor = "Vermelho";
            Console.WriteLine("Marca do veículo: " + veiculo.Marca + " " + veiculo.Cor);
            Console.WriteLine("A cor da roda é: " + veiculo.CorDaRoda);

            Console.WriteLine("---------------------------------------------------------");

            Veiculo veiculo2 = new Veiculo();
            veiculo2.Cor = "Amarelo";
            veiculo2.Marca = "Fiat";
            veiculo2.CorDaRoda = "Roxo";
            Console.WriteLine("A cor do veículo 2 é: " + veiculo2.Cor + " " + veiculo2.Marca);
            Console.WriteLine("O veículo tem roda? " + veiculo2.TemRoda);
            Console.WriteLine("A cor da roda é: " + veiculo2.CorDaRoda);

            Console.WriteLine("------------------------------------------------------------");

            Veiculo veiculo3 = new Veiculo();
            veiculo3.setCilindrada("150 cc");
            veiculo3.Acelerar();
            
            Console.WriteLine(veiculo3.getCilindrada());

            //veiculo3.Consumo();
            Console.WriteLine(veiculo3.Consumo());

            veiculo3.setConsumoPorLitro(5);
            Console.WriteLine("O veículo 3 anda " + veiculo3.getConsumoPorLitro() + " quilometros por litro.");

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Quantos quilometros pretende viajar? ");
            string valorDigitado = Console.ReadLine();
            double valor = Convert.ToDouble(valorDigitado);

            Console.WriteLine("Quantos quilometros seu carro faz por litro? ");
            string valorPorLitro = Console.ReadLine();
            double valorConvertidoPorLitro = Convert.ToDouble(valorPorLitro);

           // veiculo3.resultadoQuilometragem(valor, valorConvertidoPorLitro);

            Console.WriteLine("Você precisará de: " + veiculo3.resultadoQuilometragem(valor, valorConvertidoPorLitro) + " litros para realizar a viagem.");

        }
    }
}
