using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Entity
{
    public class Car 
    {
        public Car()
        {
            roda = new Roda();
            portas = new Porta();
            motor = new Motor();
        }
        // atributos
        public Roda roda;
        public string Cor;
        public Porta portas;
        public Motor motor;
        private int velocidade;

        // Propriedades
        public int Velocidade { get; set; }

        // ações ou métodos
        // public
        public void Acelerar(int aceleracao)
        {
            Velocidade += aceleracao;
        }

        public override string ToString()
        {
            return "Carro: cor: " + Cor + "\n" +
                    "Carro Motor: " + motor.potencia + "\n" +
                    "Carro Roda:" + roda.aro.tipo;

        }
    }
}

