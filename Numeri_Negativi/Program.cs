using System;

namespace Numeri_Negativi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            // in questa prima riga di codice viene dichiarata una variabile e 
            // viene calcolato tramite Max value il numero massimo che un tipo int può contenere.
            Console.WriteLine(a);
            // viene stampato a video il valore della variabile a.
            Console.WriteLine(a + 1);
            // aggiungendo 1 al numero massimo si può notare che viene aggiunto 1 ma viene aggiunto anche il segno - perchè
            // si utilizza il complemento a 2.
            int b = -128;
            int c = -b;
            // si traforma b in positivo.
            Console.WriteLine(Convert.ToString(b, 2));
            // viene convertito b in binario.
            Console.WriteLine(Convert.ToString(c, 2));
            // viene convertito c in binario.
            int value = 31;
            int somma = ~value + 1;  //NOT
            //value = value +1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            // viene stampato il valore value e la somma di value e di value opposto.
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            // si converte number in binario.
            short number1 = (short)number;
            // viene convertito number da long a short.
            Console.WriteLine(number1);
            Console.ReadLine();
            //viene stampato il valore di number1 che stato trasformato in short.
        }
    }
}
