package com.REFA.x00157219;

import java.util.ArrayList;

public class potion extends HealthItem {


    private int amount;

    public potion(String name, int weight, String description, int reuseTime, String level, String type, int amount) {
        super(name, weight, description, reuseTime, level, type);
        this.amount = amount;
    }

    public potion(int reuseTime, String level, String type, int amount) {
        super(reuseTime, level, type);
        this.amount = amount;
    }

    public void drink(){ }

    public int getAmount() {
        return amount;
    }

    @Override
    public String toString() {
        return "potion{" +
                "amount=" + amount +
                ", reuseTime=" + reuseTime +
                ", level='" + level + '\'' +
                ", type='" + type + '\'' +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
