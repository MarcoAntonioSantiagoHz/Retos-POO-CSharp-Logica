//Teniendo una cadena de caracteres contar cuantos numeros hay en esta linea de caracteres
//Lo importante es saber cuantos numeros tenemos

//Variable que alojara los caracteres
using System.Text.RegularExpressions;

string text = "anksednap4964qknw!!#?¡=)(((E#ERR_[_[¨dsa]?083212";
//Variable que pondra el detalle de buscar del cero al 9
string patron = @"[0-9]";

//Creamos el Regex para recibir el patron
var regex = new Regex(patron);


int  n = regex.Matches(text).Count;

//Mostramos la cantidad de numeros
Console.WriteLine("La cantidad de numeros son: " + n);
