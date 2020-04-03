package com.REFA.x00157219;

public class Weapon extends reusableItem {

    private String type, wieldType;
    private int level;
    private double speed, damage;

    public Weapon(String name, int weight, String description, int reaminingUses, String type, String wieldType, int level, double speed, double damage) {
        super(name, weight, description, reaminingUses);
        this.type = type;
        this.wieldType = wieldType;
        this.level = level;
        this.speed = speed;
        this.damage = damage;
    }

    public Weapon(int reaminingUses, String type, String wieldType, int level, double speed, double damage) {
        super(reaminingUses);
        this.type = type;
        this.wieldType = wieldType;
        this.level = level;
        this.speed = speed;
        this.damage = damage;
    }

    public String getType() {
        return type;
    }

    public String getWieldType() {
        return wieldType;
    }

    public int getLevel() {
        return level;
    }

    public double getSpeed() {
        return speed;
    }

    public double getDamage() {
        return damage;
    }

    @Override
    public String toString() {
        return "Weapon{" +
                "type='" + type + '\'' +
                ", wieldType='" + wieldType + '\'' +
                ", level=" + level +
                ", speed=" + speed +
                ", damage=" + damage +
                ", reaminingUses=" + reaminingUses +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }

    public void upgrade(){}


}
