using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MOVIMIENTO_DE_UNA_FRASE
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM;
            byte K;
            Console.Write("SU NOMBRE ES: "); NOM = Console.ReadLine();
            for (K = 1; K <= 70; K++)
            {
                Console.SetCursorPosition(K, 12);
                Console.Write(" " + NOM);
                //REALIZAMOS UNA PAUSA;
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}