using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advinarNumero
{
    public class adivinadorfor
    {
        public static void Main(string[]args)
        {
            var generadormagico = new Random();
            int numeromagico = generadormagico.Next(0, 16);

            Console.WriteLine("Bienvenidos a la prueba mortal de la adivinanza de números" +
                ",\nla prueba consiste en adivinar un número que nuestros superordenadores han " +
                "determinado al azar\nmediante complejos logaritmos.\n \n Dicho número se haya comprendido entre" +
                " el 0 y el 16, dispone de 3 intentos para averiguarlo.\n Recuerde, aquí se esta jugando con algo" +
                " más valioso que su vida; su dignidad.\n Así pues comencemos.");
            Console.WriteLine("Introduzca un número entre 0 y 16");
            int numero = Int32.Parse(Console.ReadLine());
            int intentos = 3;
            while ((numero != numeromagico) && (intentos <= 4))
            {
                if (numero < numeromagico)
                {
                    Console.WriteLine("Casi, casi, tu número está por debajo del número mágico ='D\n vuélvelo a intentar subiendo la apuesta");
                    numero = Int32.Parse(Console.ReadLine());
                }
                else if (numero > numeromagico)
                {
                    Console.WriteLine("Vaya, vaya, te has pasado de list@ y de número.\n Inténtalo de nuevo y se más certero.");
                    numero = Int32.Parse(Console.ReadLine());
                }
                if (numero == numeromagico)
                {
                    Console.WriteLine("¡¡¡FELICIDADES!!! Has conseguido averiguar el número!\nTu nombre quedará grabado para siempre" +
                        "\n en los anales de la historia.");
                    Environment.Exit(0);
                }
                intentos++;
            }
            Console.WriteLine($"Upsss. El número a adivinar era {numeromagico}.\n No te sientas triste, pues errare humanum est");
        }
    }
}
