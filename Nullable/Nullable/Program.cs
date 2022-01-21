using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // É a mesma coisa que usar " Nullable<double> x = null; ".
            double? x = null;
            double? y = 10.0;

            //GetValueOrDefault() mostrara o valor contido na variavel, caso nao tenha, mostrará o valor padrão do tipo da variavel.
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //HasValue mostrará verdadeiro se tiver algum valor na variavel e Falso se nao tiver.
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) Console.WriteLine(x.Value);        
            else Console.WriteLine("X is null");

            if (y.HasValue) Console.WriteLine(y.Value);
            else Console.WriteLine("Y is null");
            
            //Uso do operador coalescência  "??"
            double? x1 = null;
            double? y1 = 10.0;

            //Se o valor de x1 for NULL, a irá receber 5. A mesma situação se aplica para b.
            double a = x1 ?? 5;
            double b = y1 ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
