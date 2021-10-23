using CarFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carro = new Car();
            // Roda do carro
            carro.roda.aro.tamanho = 17;
            carro.roda.aro.tipo = "Liga Leve";
            //carro.roda.tipoRoda.tipo = "Liga Leve";
            carro.roda.pneu.aro = 17;
            carro.roda.pneu.altura = 55;
            carro.roda.pneu.largura = 255;

            // Cor 
            carro.Cor = "Vermelho Ferrari";

            // Porta
            carro.portas.machaneta.tipo = "com sensor de abertura";
            carro.portas.retrovisor.tipo = "elétrico";

            // motor
            carro.motor.cilindrada = 4100;
            carro.motor.quantidadeCilindros = 8;
            carro.motor.potencia = "395cv";
            carro.motor.torque = "53kgfn";

            carro.Velocidade = 0;

           while(carro.Velocidade < 100)
            {
                carro.Acelerar(5);
                Console.WriteLine("Velocidade Atual: " + carro.Velocidade);

            }

            Console.WriteLine(carro);

            Console.ReadLine();


        }
    }
}
