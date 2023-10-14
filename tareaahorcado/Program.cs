using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaahorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            juego();
        }
        static void juego()
        {
            Console.WriteLine("Hola, bienvenido a Ahorcado escoge del del 0 al 9 el número de palabra con la que quieres jugar");
            int opt = int.Parse(Console.ReadLine());
            int vidas = 10;
            bool continueflag = true;
            string[] palabras = { "murciélago", "esmeralda", "deslumbrante", "elefante", "travesura", "melodía", "catarata", "aventura", "espontáneo", "laberinto" };
            char[] letras = palabras[opt].ToCharArray();
            int cont = letras.Length;
            int[] flagcont = new int[cont];
            for (int i = 0; i < cont; i++)
            {
                flagcont[i] = 0;
            }
            while (continueflag)
            {
                int victory = 0;
                Console.WriteLine($"Cuentas con {vidas} vidas");
                for (int j = 0; j < cont; j++)
                {
                    if (flagcont[j]==0)
                    {
                        Console.WriteLine(" _ ");
                    }
                    else
                    {
                        Console.WriteLine($"{letras[j]}");
                        victory++;
                    }
                }
                if (victory == cont)
                {
                    Console.WriteLine("\n\n Felicidades Ganaste!!");
                    Console.WriteLine("\nQuieres volver a jugar??");
                    Console.WriteLine("1. Si 2. No");
                    int resp = int.Parse(Console.ReadLine());
                    while (resp > 2 || resp < 1)
                    {
                        Console.WriteLine("Valor no permitido");
                        Console.WriteLine("\nQuieres volver a jugar??");
                        Console.WriteLine("1. Si 2. No");
                        resp = int.Parse(Console.ReadLine());

                    }
                    if (resp == 2)
                    {
                        continueflag = false;
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa la primera letra");
                    char letra = Convert.ToChar(Console.ReadLine());
                    bool sigo = false;
                    for (int k = 0; k < cont; k++)
                    {
                        if (letra == letras[k])
                        {
                            flagcont[k] = 1;
                            sigo = true;
                        }
                    }
                    if (sigo == false)
                    {
                        vidas--;
                    }
                    if (vidas == 0)
                    {
                        continueflag = false;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
