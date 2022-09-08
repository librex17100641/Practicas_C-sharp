
using System;

public class programa_3{

    public static void Main(){

        String numero, menu;

        Boolean flag= true;

        double prueba = 1.0;

        

       Console.WriteLine("Introduzca la cantidad");

       numero = Console.ReadLine();
       while (flag)
       {
           if(!double.TryParse(numero,out prueba)){
                Console.WriteLine("El numero ingresado no es valido, ingrese otro");
                numero = Console.ReadLine();
           }else{
               flag=false;
           }
       }

       double numero_1;

       numero_1 = double.Parse(numero);

        var dateAndTime = new DateTime (2021,01,31);

        var fecha_1 = dateAndTime.Date.ToString("dd-MM-yyyy");

        String []fecha = fecha_1.Split("-");

        int []dia=new int[3];

        for(int i=0; i < 3; i++){
            try
            {
                dia[i]=int.Parse(fecha[i]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("no se pudo convertir");
                
            } 
            
        }
            
       Console.WriteLine("Elija una opcion:");
        Console.WriteLine("1- 6 mensualidades");
        Console.WriteLine("2- 1 año");
        Console.WriteLine("3- 3 años");

        menu= Console.ReadLine();

        flag = true;


        while (flag){
            if(menu=="1"){

            numero_1 = numero_1 * 1.1;
            flag = false;
        }else
            if(menu=="2"){

            numero_1 = numero_1 * 1.2;
            flag = false;
        }else
            if(menu=="3"){

            numero_1 = numero_1 * 1.3;
            flag = false;
        }else{
            Console.WriteLine("Elija una opcion valida");
            menu= Console.ReadLine();

        }
        
        }
        
            int dia_pago = dia [0];
            int mes_pago = dia[1]+1;

            
            string mes = "nada";
            if((mes_pago == 1 || mes_pago==3 || mes_pago==5 ||mes_pago==7 
            || mes_pago== 8 || mes_pago==10 || mes_pago==12) ){

               
                dia_pago = 31;

            }else if((  mes_pago==4 || mes_pago==6 ||mes_pago==9 
            || mes_pago== 11 ) ){

                
               dia_pago=30;

            }
            else if (mes_pago==2){
                dia_pago=28;
            }
            if (mes_pago == 1){
                mes = "Enero";
            }
            if (mes_pago == 2){
                mes = "Febrero";
            }
            if (mes_pago == 3){
                mes = "Marzo";
            }
            if (mes_pago == 4){
                mes = "Abril";
            }
            if (mes_pago == 5){
                mes = "Mayo";
            }

            if (mes_pago == 6){
                mes = "Junio";
            }

            if (mes_pago == 7){
                mes = "Julio";
            }

            if (mes_pago == 8){
                mes = "Agosto";
            }
            if (mes_pago == 9){
                mes = "Septiembre";
            }
            if (mes_pago == 10){
                mes = "Octubre";
            }
            if (mes_pago == 11){
                mes = "Noviembre";
            }
            if (mes_pago == 12){
                mes = "Diciembre";
            }




            Console.WriteLine("El siguiente pago se debe realizar el: {0}/{1}",dia_pago,mes);
            Console.WriteLine("la cantidad a pagar es: {0}",numero_1);


    }

    }