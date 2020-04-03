package com.REFA.x00157219;

public abstract class item {
    protected  int id, weight ;
    protected  String name, description ;

    public item(){

        id= IdGenerator.newId();
        name =" ";
        weight = 0;
        description = " ";


    }

    public item( String name, int weight, String description) {

        id = IdGenerator.newId();
        this.name = name;
        this.weight = weight;
        this.description = description;

    }

    public int getId() {
        return id;
    }

    public int getWeight() {
        return weight;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }



    @Override
    public String toString() {
        return "item{" +
                "id=" + id +
                ", weight=" + weight +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                '}';
    }
}
