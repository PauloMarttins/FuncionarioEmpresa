using System;
using System.Collections.Generic;
using FuncionariosEmpresa.Entities;
using System.Globalization;

namespace FuncionariosEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para poder utilizar o List é obrigatorio o (using System.Collections.Generic;) no cabeçalho.
            //E como (Employee) é de outra classe, também é obrigatório o (using FuncionariosEmpresa.Entities;) no cabeçalho.
            //Declara-se e Instancia-se a variavel ListEmployee do tipo Employee, a qual alocará todas as informações do Array.
            List<Employee> ListEmployee = new List<Employee>();

            //O Console escreve o comando para o usuário informar a quantidade de funcionarios.
            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            //Para int i igual a "posição", enquanto i for menor que (numero de funcionarios) faça o algoritimo depois retorna i++ (uma posição a mais) à cada rodada.
            for (int i = 0; i < n; i++)
            {
                //Interpolação
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Condição: Se ch (yes/no) for igual a Y faça:
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    ListEmployee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                //Se não, faça:
                else
                {
                    ListEmployee.Add(new Employee(name, hours , valuePerHour));

                }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");

                //Para cada variavel emp do tipo Employee alocado no arrayList ListEmployee faça:
                foreach (Employee emp in ListEmployee)
                {
                    Console.WriteLine(emp.Name + " - $ " +emp.Payment().ToString("C2", CultureInfo.CurrentCulture));
                }
            }
        }
    }
}


