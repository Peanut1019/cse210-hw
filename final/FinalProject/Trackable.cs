using System;
public abstract class Trackable : Tracking {

public Trackable(int calories): base(calories){
}


    public abstract double computeCalories();
}
