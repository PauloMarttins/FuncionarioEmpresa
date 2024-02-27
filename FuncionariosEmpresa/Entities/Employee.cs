using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Entities
{
    internal class Employee
    {
        //Delcara-se as propriedades (Name, Hours, ValuePerHour)
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //Construtor vazio.
        public Employee()
        { 
        }

        //Construtor com argumentos.
        //Declara-se as variaveis name, hours, valuePerHour como parametro deste construtor.
        //Cada uma das propriedades ora declarados, recebem respectivamente as variaveis compativeis com suas funcionalidades.
        //A ordem de cada variavel é extremamente importante.
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Para realizar a liberação da operação de apagamento utiliza-se o modificador "virtual"
        //Dessa forma, A Plavra em amarelo que representa a declaração desse metodo poderá ser modificada em uma classe derivada.
        //ou seja, A classe que receber esta classe como herança.
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
