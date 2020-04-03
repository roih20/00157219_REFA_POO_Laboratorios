package com.REFA.x00157219;

public abstract class HealthItem extends item {
    protected int reuseTime ;
    protected String level, type;

    public HealthItem(String name, int weight, String description, int reuseTime, String level, String type) {
        super(name, weight, description);
        this.reuseTime = reuseTime;
        this.level = level;
        this.type = type;
    }

    public HealthItem(int reuseTime, String level, String type) {
        this.reuseTime = reuseTime;
        this.level = level;
        this.type = type;
    }

    public void drink(){}
}
