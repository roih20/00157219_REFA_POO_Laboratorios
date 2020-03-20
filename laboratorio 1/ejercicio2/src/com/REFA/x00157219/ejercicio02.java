package com.REFA.x00157219;

import java.util.Scanner;

public class ejercicio02 {
    public static void main (String[] args){
        Scanner lector = new Scanner(System.in);
        String palabra, alreves = "";
        int x;
        System.out.println("Escriba una palabra: ");
        palabra = lector.nextLine();
        for( x=palabra.length()-1; x>=0; x-- )
            alreves= String.valueOf(palabra.charAt(x));
        if(palabra.equals(alreves))
            System.out.println("la palabra es palindrome");
        else
            System.out.println("la palabra no es palindrome");

    }
}