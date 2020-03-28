package com.REFA.x00157219;
import javax.swing.*;
import  java.util.Scanner;
import java.util.ArrayList;
public class Main {

    public static void main(String[] args) {
        int opcion = 0;
        Scanner in = new Scanner(System.in );
        Registrodetiempo hora =new Registrodetiempo()


        do{
            

                opcion =  Integer.parseInt(JOptionPane.showInputDialog(null, "eliga una opcion: "));

            switch (opcion){

                case 1:
                    JOptionPane.showInputDialog(null, "Ingresar al parqueo ");
                    JOptionPane.showInputDialog(null, "ingrese el numero de placa" );
                    JOptionPane.showInputDialog(null, "Ingrese la Hora de entrada"  );

                    break;

                case 2: JOptionPane.showInputDialog(null, "Salir del parqueo: ");
                    JOptionPane.showInputDialog(null, "Ingrese la hora de Salida: " );
                        JOptionPane.showInputDialog(null, "Monto a pagar:" + pago = tiempo_estadia);
                        JOptionPane.showInputDialog(null, "su vuelto" + vuelto);


                    break;

                case 3:
                    JOptionPane.showInputDialog(null, "Consultar ticket: ");

                    break;

                case 4 : opcion = 0;

                    break;


            }

        }while(opcion != 0);
    }



}
