

//Distancia de hamming:
//Tenemos 2 cadenas se ira comparando caracter por caracter y vamos viendo cuantos caracteres son distintos


//Creamos las variables cadenas
string text1 = "felinosA";
string text2 = "caninosB";

//Varible de tipo distancia
int distance = 0;


//Sentencia de condicion, si las cadenas no miden igual, marcaran error
if (text1.Length != text2.Length)
{
    throw new Exception("Longitudes distintas");
}

//Hacemos un recorrido sobre la variable
for (int i = 0; i < text1.Length; i++)
{
    //Hacemos la comparativa el text1 en su i,  en la posicion de text2 en su i, si son diferentes hace la sumatoria en la distancia
    if (text1[i] != text2[i])
    {

        distance++;
    }
}

Console.WriteLine("LA DISTANCIA ES DE:" + distance);


