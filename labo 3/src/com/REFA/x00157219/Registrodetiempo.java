package com.REFA.x00157219;

public class Registrodetiempo {

    private int Hora_entrada = 0;
    private int Hora_salida = 0 ;
    private int tiempo_estadia;

    public Registrodetiempo(int hora_entrada, int hora_salida, int Tiempo_estadia) {
       Hora_entrada = hora_entrada;
       Hora_salida = hora_salida;
       tiempo_estadia = Tiempo_estadia;
    }

    public int getHora_entrada() {
        return Hora_entrada;
    }

    public int getHora_salida() {
        return Hora_salida;
    }

    public int getTiempo_estadia() {
        return tiempo_estadia= Hora_entrada - Hora_salida;
    }



}


