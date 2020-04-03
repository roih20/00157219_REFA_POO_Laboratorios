package com.REFA.x00157219;

public class Ammo  extends reusableItem{

    private boolean equipped;

    public Ammo(String name, int weight, String description, int reaminingUses, boolean equipped) {
        super(name, weight, description, reaminingUses);
        this.equipped = equipped;
    }

    public Ammo(int reaminingUses, boolean equipped) {
        super(reaminingUses);
        this.equipped = equipped;
    }

    public void equip(){}

    public boolean isEquipped() {
        return equipped;
    }

    @Override
    public String toString() {
        return "Ammo{" +
                "equipped=" + equipped +
                ", reaminingUses=" + reaminingUses +
                ", id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
