package com.REFA.x00157219;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.Iterator;


public class Main {

    public static void main(String[] args) {

        ArrayList<String> vocales =new ArrayList();
        Scanner escaner= new Scanner(System.in);
        int opcion=1;
        String vocal;

        do{
            System.out.println("Ingresa una letra");
            vocal=escaner.next();
            if(vocal.length()>1){
                System.out.println("Error, Ingresa solo una letra");
            }
            else {
                if(vocal.equals("A")|| vocal.equals("E")|| vocal.equals("I")|| vocal.equals("O")|| vocal.equals("U")|| vocal.equals("a")
                        ||vocal.equals("e")||vocal.equals("i")||vocal.equals("o")||vocal.equals("u")){
                    vocales.add(vocal);
                }
            }
            System.out.println("Ingresa 1 para salir o  cualquier numero para seguir");
            opcion=escaner.nextInt();
        }
        while(opcion!=1);
        System.out.println("Letras que contiene la lista : \n");
        Iterator iterat = vocales.iterator();
        while (iterat.hasNext())
            System.out.println(iterat.next());
    }
}
