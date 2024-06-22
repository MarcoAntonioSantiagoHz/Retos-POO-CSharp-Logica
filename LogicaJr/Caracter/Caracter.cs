


using System;

namespace Caracter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caracter cadena = new Caracter();
            cadena.ContarCaracter();
        }

        //BUSCAR CUANTAS VECES SE REPITE UN CARACTER 
        public class Caracter
        {
            // Creamos nuestras variables
            string text = "ABCDEGHIJKLMNÑOPQRS4516AASFEKMEEUUWDMAÑFE";
            char characterr = 'A';

            public void ContarCaracter()
            {
                int n = 0;
                //Esta forma es imperativa
                //foreach (var charc in text)
                //{
                //    if (charc == characterr)
                //    {
                //        n++;
                //    }
                //}

                //Otra forma de hacerlo es por medio declarativa(le decimos que hacer)
                n = text.Where(c => characterr == c).Count();

                Console.WriteLine($"El carácter '{characterr}' se repite {n} veces.");
            }
        }
    }
}
