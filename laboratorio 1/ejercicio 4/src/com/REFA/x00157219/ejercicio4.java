package com.REFA.x00157219;
import java.util.Scanner;
public class ejercicio4 {
    public static void main ( String[] args){
        Scanner entrada= new Scanner(System.in);
        System.out.println("ingrese una frase:");
        String cadena = entrada.nextLine();
        System.out.println("caracter que desea reemplezar: ");
        String c1= entrada.nextLine();
        System.out.println("caracter por el cual lo desea remmplazar");
        String c2 = entrada.nextLine();
        cadena= cadena.replace(c1, c2);
        System.out.println("nueva frase: "+ cadena);

    }
}
