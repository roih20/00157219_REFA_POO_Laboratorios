package com.REFA.x00157219;

public class Moneda {

    private double pago;
    private double vuelto ;
    private double moneda ;

    public Moneda(double pago, double vuelto , double moneda) {
        this.pago = pago;
        this.vuelto =  vuelto;
    }

    public double getPago() {
        return pago;
    }

    public double getVuelto() {
        return vuelto = moneda - pago ;
    }

}


