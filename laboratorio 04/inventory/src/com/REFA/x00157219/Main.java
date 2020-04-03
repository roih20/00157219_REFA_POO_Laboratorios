package com.REFA.x00157219;

import sun.security.krb5.internal.crypto.Des;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
	// write your code here
        ArrayList<item> PersonalItems = new ArrayList<>();
        ArrayList<item> CommonItems = new ArrayList<>();

        int opcion = 0;
        do{
            opcion = Integer.parseInt(JOptionPane.showInputDialog(null, mainMenu()));
            switch (opcion){
                case 1 :
                   int item= Integer.parseInt(JOptionPane.showInputDialog(null, "Agregar Item: "));

                   switch (item){
                       case 1:


                           String nombre =JOptionPane.showInputDialog(" Nombre del Elixir: ");
                           int weight =Integer.parseInt(JOptionPane.showInputDialog("Weight: "));
                           String Descripcion= JOptionPane.showInputDialog("Descripcion: ");
                           int Reusetime =Integer.parseInt(JOptionPane.showInputDialog("reuse time: "));
                           String level = JOptionPane.showInputDialog("Level: ");
                           String Type = JOptionPane.showInputDialog("Type: ");
                           int Amount = Integer.parseInt(JOptionPane.showInputDialog("Amount: "));
                           int time =Integer.parseInt(JOptionPane.showInputDialog("Time:"));
                           PersonalItems.add(new Elixir(nombre, weight, Descripcion, Reusetime, level, Type, Amount, time));
                           PersonalItems.forEach(Elixir -> JOptionPane.showMessageDialog(null, "Datos del Elixir:  " + Elixir.toString()));
                             break;

                       case 2:
                           String name= JOptionPane.showInputDialog("Name Ammo: ");
                           weight = Integer.parseInt(JOptionPane.showInputDialog("Weight: "));
                           Descripcion = JOptionPane.showInputDialog("Descripcion: ");
                           int ReaminingUses = Integer.parseInt(JOptionPane.showInputDialog("Reamining uses: "));
                           int equipped = Integer.parseInt(JOptionPane.showInputDialog("Presione 1 para equipar: "));
                           boolean equipado;
                           if (equipped== 1){
                                equipado= true;
                           }else {
                              equipado = false;
                           }

                           PersonalItems.add(new Ammo(name, weight, Descripcion, ReaminingUses, equipado));
                           PersonalItems.forEach(Ammo -> JOptionPane.showMessageDialog(null, "El item es: " + Ammo.toString()));
                           break;


                       case 3:
                           name = JOptionPane.showInputDialog(" Potion name:");
                           weight = Integer.parseInt(JOptionPane.showInputDialog("Weight:"));
                           Descripcion = JOptionPane.showInputDialog("Descripcion: ");
                           Reusetime = Integer.parseInt(JOptionPane.showInputDialog("Reuse time: "));
                           level = JOptionPane.showInputDialog("Level: ");
                           Type = JOptionPane.showInputDialog("Type: ");
                           Amount = Integer.parseInt(JOptionPane.showInputDialog("Amount:"));
                           PersonalItems.add(new potion(name, weight, Descripcion, Reusetime, level, Type, Amount));
                           PersonalItems.forEach(potion -> JOptionPane.showMessageDialog(null, "El item es: " + potion.toString()));

                           break;

                       case 4:
                           name = JOptionPane.showInputDialog("Weapon name: ");
                           weight = Integer.parseInt(JOptionPane.showInputDialog("Weight"));
                           Descripcion = JOptionPane.showInputDialog("Descripcion: ");
                           ReaminingUses = Integer.parseInt(JOptionPane.showInputDialog("Reamining uses: "));
                           Type = JOptionPane.showInputDialog("Type:");
                           String wieldType = JOptionPane.showInputDialog("wieldType");
                          int nivel = Integer.parseInt(JOptionPane.showInputDialog("Level: "));
                          double speed = Double.parseDouble(JOptionPane.showInputDialog("Speed:"));
                          double damage = Double.parseDouble(JOptionPane.showInputDialog("Damege: "));
                          PersonalItems.add(new Weapon(name, weight, Descripcion, ReaminingUses, Type, wieldType, nivel, speed, damage));
                          PersonalItems.forEach(Weapon-> JOptionPane.showMessageDialog(null, "El item es: "+ Weapon.toString()));
                           break;

                   }


                    break;

                case 2:

                    int id = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el iD :"));
                    for(item aux:PersonalItems ){
                        if (aux.getId()== id){
                            CommonItems.add(aux);
                        }
                    }


                    CommonItems.forEach(item1-> JOptionPane.showMessageDialog(null, "se copio el item:" +item1.toString()));
                    break;


                case 3:

                    int escoger = Integer.parseInt(JOptionPane.showInputDialog("Presione 1 para buscar por ID en  la lista de PesonalItems o Presione 2 para buscar por ID en  la lista CommonItems:  "));
                    boolean search;
                    if (escoger ==1){

                        search = true;
                        id =  Integer.parseInt(JOptionPane.showInputDialog("Ingrese el Id"));
                        PersonalItems.forEach(item1 ->{
                            if(item1.getId() == id)
                                JOptionPane.showMessageDialog(null, item1.toString());

                        });

                    }else{
                        search = false;
                        id = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el id: "));
                        CommonItems.forEach(item1 -> {
                            if(item1.getId() == id)
                                JOptionPane.showMessageDialog(null, item1.toString());
                        });

                    }

                    break;

                case 4:
                    escoger = Integer.parseInt(JOptionPane.showInputDialog("Presione 1 para buscar por tipo en  la lista de PesonalItems o Presione 2 para buscar por tipo en  la lista CommonItems:  "));
                    boolean search1;

                    if(escoger == 1){
                        search1 = true;
                        String tipo = JOptionPane.showInputDialog("ingrese el tipo de item:");
                    if (tipo.equalsIgnoreCase("Elixir"))
                        PersonalItems.forEach(item1 -> {
                            if (item1 instanceof Elixir )
                                JOptionPane.showMessageDialog(null, item1.toString());
                        });
                    else if (tipo.equalsIgnoreCase("Pocion"))
                        PersonalItems.forEach(item1 -> {
                            if (item1 instanceof potion)
                                JOptionPane.showMessageDialog(null, item1.toString());
                        });
                    else if(tipo.equalsIgnoreCase("Arma"))
                        PersonalItems.forEach(item1 -> {
                            if (item1 instanceof Weapon)
                                JOptionPane.showMessageDialog(null, item1.toString());
                        });


                    }else {
                        search1 = false ;
                       String tipo = JOptionPane.showInputDialog("Ingrese el tipo de item: ");
                        if (tipo.equalsIgnoreCase("Elixir"))
                           CommonItems.forEach(item1 -> {
                                if (item1 instanceof Elixir )
                                    JOptionPane.showMessageDialog(null, item1.toString());
                            });
                        else if (tipo.equalsIgnoreCase("Pocion"))
                            CommonItems.forEach(item1 -> {
                                if (item1 instanceof potion)
                                    JOptionPane.showMessageDialog(null, item1.toString());
                            });
                        else if(tipo.equalsIgnoreCase("Arma"))
                           CommonItems.forEach(item1 -> {
                                if (item1 instanceof Weapon)
                                    JOptionPane.showMessageDialog(null, item1.toString());
                            });

                    }
                    break;

                case 5:
                    escoger = Integer.parseInt(JOptionPane.showInputDialog("Presione 1 para eliminar por Id un item de la lista de PesonalItems o Presione 2 para eliminar por Id un item de la lista CommonItems: "));
                    boolean search2;
                    if (escoger== 1){

                        search2 = true;
                        id = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el Id: "));
                        PersonalItems.removeIf(item1 -> item1.getId() == id);

                    }else{

                        search2 = false;
                        id = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el Id: "));
                        CommonItems.removeIf(item1 -> item1.getId() == id);

                    }

                    break;

                case 6:

                    escoger = Integer.parseInt(JOptionPane.showInputDialog("Presione 1 para eliminar por tipo un item de la lista de PesonalItems o Presione 2 para eliminar un item por tipo en  la lista CommonItems:  "));
                    boolean search3;
                    if (escoger == 1){
                        search3= true;
                        String tipo1 = JOptionPane.showInputDialog("Ingrese el tipo de item");
                        PersonalItems.removeIf(item1 -> tipo1.equalsIgnoreCase("Arma"));
                        PersonalItems.removeIf(item1 -> tipo1.equalsIgnoreCase("Poscion"));
                        PersonalItems.removeIf(item1 -> tipo1.equalsIgnoreCase("Elixir"));

                    }else {
                        search3 = false;String tipo1 = JOptionPane.showInputDialog("Ingrese el tipo de item");
                        CommonItems.removeIf(item1 -> tipo1.equalsIgnoreCase("Arma"));
                        CommonItems.removeIf(item1 -> tipo1.equalsIgnoreCase("Poscion"));
                        CommonItems.removeIf(item1 -> tipo1.equalsIgnoreCase("Elixir"));


                    }

                break;

                case 0:
                    JOptionPane.showMessageDialog(null, "SALIENDO DE INVENTARIO...");
                    break;
            }



        }while (opcion !=0);

    }
    static String mainMenu(){
        return("Bienvenido!!\n 1.Añadir item\n 2.Compartir item\n 3.Buscar item por ID\n 4.Buscar item por tipo\n 5.Borrar item por ID\n 6.Borrar item por tipo\n 0.SALIR\n OPCION: ");
    }

}



