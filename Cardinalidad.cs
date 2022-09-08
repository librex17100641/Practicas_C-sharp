
using System;
using static System.Console;
public class programa_4{

static void Main(){
Boolean flag = true;
String limite ;

byte prueba = 1;
String last;
String letras;
WriteLine("Introduzca el limite");
limite= ReadLine();

    while (flag){

        if(!byte.TryParse(limite, out prueba)){
            Console.WriteLine("El numero ingresado no es valido, ingrese otro");
                limite = Console.ReadLine();
           }else{
               flag=false;

               imprimir(limite);
           }

       
}

}
static String numero_final (String num){
String num_final;

num_final=Convert.ToString(num[num.Length -1]);



return num_final;

}

static String determinar (String terminacion, String num){
String letras;

if (terminacion == "1"){
if(num=="11" || num=="111" ||num=="211"){
    letras = "th";
}else{letras = "st";}
}else if(terminacion == "2"){

if(num=="12" || num=="112" ||num=="212"){
    letras = "th";
}else{letras = "nd";}

}else if(terminacion == "3"){

if(num=="13" || num=="113" ||num=="213"){
    letras = "th";
}else{letras = "rd";}

}else {
    letras = "th";
}


return letras;
}

static async void imprimir(String num){
String last, letras, impresion;
    
 
byte impr= byte.Parse(num);

for (int i =1; i <= impr; i++ ){
    impresion= ""+i;
last= numero_final(impresion);
 letras= determinar(last,impresion);
    WriteLine("{0}-{1}",i, letras);
    

}


}



}
