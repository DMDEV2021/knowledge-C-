using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learningCs
{
    class Programa 
    {       
        static void main(string[] args)
        { 
            string name1, name2, name3, name4, auxiliar;

            Console.Write("Digte o nome #1: ");
            name1 = Console.ReadLine();

            Console.Write("Digte o nome #2: ");
            name2 = Console.ReadLine();

            Console.Write("Digite o nome #3: ");
            name3 = Console.ReadLine();
            Console.Write("Digite o nome #4: ");
            name4 = Console.ReadLine();//entrada de dados

            //mecanismo para inverter os nomes
            auxiliar = name1;
            name1 = name4;
            name4 = auxiliar;
            auxiliar = name2;
            name2 = name3;
            name3 = auxiliar;
            Console.ReadKey();//aguarda ate que pressione uma tecla
            Console.WriteLine();//imprime na tela e quebra a linha
            Console.WriteLine("Imprimir nomes invertidos");
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
         }
              
     }
}
