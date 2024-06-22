//Crear un contador de palabras dada que tenga un string, que tenga varias palabras separadas por espacio.

using System.Text.RegularExpressions;


//variable de tipo string que servira como base para el conteo de palabras
string text = "  UN    GATO    MI     MEJOR    AMIGO";
//Variable que cuente esas palabras
int nPalabras = 0;


//Esto nos sevira para solo contar palabras e ignorar espacios en blanco
text =   Regex.Replace(text, @"\s+", " ").Trim();



//Con el metodo Split le decimos cual va a ser el caracter separador
var words = text.Split(' ');
nPalabras = words.Length;

Console.WriteLine("El total de numero de palabras que posee son:" + nPalabras);