using System.IO;
using static System.Convert;
using static System.Console;
namespace NullHandling{

class programa_5{

static void Main(string[]args){

WriteLine("Introduzca la palabra");
string  palabra = ReadLine();





palindromo(palabra);


}

static  async void palindromo( string   pal){

for (int i = 0; i <= pal.Length; i++)
{
    int j = i+2;

    if(pal[i]==pal[j]){

        string [] palin  = new string [1];
        for (int f = 0; f <= j; f++)
        WriteLine($"{palin[f]}");
        {
            
        }
        

    }else{
        WriteLine("No es un palindromo");
    }
}




}

    
}


}





