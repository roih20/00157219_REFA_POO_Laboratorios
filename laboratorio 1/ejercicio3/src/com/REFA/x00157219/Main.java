package com.REFA.x00157219;

import java.util.Scanner;
public class Main {
    int aux = 1;

    public void fiborecursivo(int numero) {
        if (aux < numero) {
            System.out.println(aux);
            aux++;
            fiborecursivo(numero);
        } else if (numero == 0) {
            return;
        } else if (aux == numero || aux > numero) {
            System.out.println(numero);
            numero--;
            fiborecursivo(numero);
        }
    }

    public static void main(String[] args) {
        System.out.println("ingresa n : \n");
        Scanner escaner = new Scanner(System.in);
        int numero = escaner.nextInt();
        Main nueva = new Main();
        System.out.println("Numeros de fibonacci :\n");
        nueva.fiborecursivo(numero);
    }
}