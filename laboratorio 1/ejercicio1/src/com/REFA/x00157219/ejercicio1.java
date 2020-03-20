package com.REFA.x00157219;
import java.util.Scanner;
public class ejercicio1 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int num = 0;
        int primernum= 0;
        int segundonum = 1;
        int tercernum = 0;
        System.out.println("ingrese un numero");
        num = in.nextInt();
        for (int i=0 ; i<num ; i++){
            System.out.println(primernum  + "");
            tercernum = primernum + segundonum ;
            primernum = segundonum ;
            segundonum = tercernum ;


        }
    }
}