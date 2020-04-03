package com.REFA.x00157219;

public abstract class reusableItem  extends item{
        protected  int reaminingUses ;

    public reusableItem(String name, int weight, String description, int reaminingUses) {
        super(name, weight, description);
        this.reaminingUses = reaminingUses;
    }

    public reusableItem(int reaminingUses) {
        this.reaminingUses = reaminingUses;
    }

    public void reduceUse(){ }

    public boolean use(boolean use) {
        return true;
    }

}
