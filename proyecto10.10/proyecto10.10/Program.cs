using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lado1, lado2, lado3, posicion;
                int escaleno = 0;
                int isoceles = 0;
                int equilatero = 0;
                Console.Write("Introduzca la cantidad de triangulos que vamos a analizar: ");
                int cantidad = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < cantidad; i++)
                {
                    posicion = i + 1;
                    Console.Write("Dame el primer lado del triangulo #"+posicion+": ");
                    lado1 = int.Parse(Console.ReadLine());

                    Console.Write("Dame el segundo lado del triangulo #" + posicion + ": ");
                    lado2 = int.Parse(Console.ReadLine());

                    Console.Write("Dame el tercer lado del triangulo #" + posicion + ": ");
                    lado3 = int.Parse(Console.ReadLine());

                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        Console.WriteLine("El triangulo #"+posicion+" es equilatero.");
                        equilatero = equilatero + 1;
                    }
                    else if(lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
                    {
                        Console.WriteLine("El triangulo #" + posicion + " es escaleno.");
                        escaleno = escaleno + 1;
                    }
                    else
                    {
                        Console.WriteLine("El triangulo #" + posicion + " es isoceles.");
                        isoceles = isoceles + 1;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Hay "+escaleno+" triangulos escalenos.");
                Console.WriteLine("Hay "+isoceles+" triangulos isoceles.");
                Console.WriteLine("Hay "+equilatero+" triangulos equilateros.");
                Console.WriteLine();

                if (escaleno < equilatero && escaleno < isoceles)
                {
                    Console.WriteLine("La menor cantidad de triangulos que hay son los escalenos.");
                }
                else if(isoceles < equilatero && isoceles < escaleno)
                {
                    Console.WriteLine("La menor cantidad de triangulos que hay son los isoceles.");
                }
                else if(equilatero < escaleno && equilatero < isoceles)
                {
                    Console.WriteLine("La menor cantidad de triangulos que hay son los equilateros.");
                }
                else
                {
                    Console.WriteLine("Mas de un tipo de triangulos tienen la menor e igual cantidad.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");
            }
            Console.ReadKey();
        }
    }
}
