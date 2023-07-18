using System;
public class TrackingFood : Tracking {
private int _addCal;
private int _option;
Healthy h1 = new Healthy(calories, addCal);
Junk j1 = new Junk(calories, addCal);
public TrackingFood(int calories, int addCal): base(calories){
_addCal = addCal;
}


    public void AddCalories(){
Console.WriteLine("The types of foods are:");
            Console.WriteLine("1. Fruit");
            Console.WriteLine("2. Vegtable");
            Console.WriteLine("3. Meat");
            Console.WriteLine("4. Candy");
            Console.WriteLine("5. Carby food");
            Console.WriteLine("Which one did you consume?");
            _option = int.Parse(Console.ReadLine());
        
        switch (_option){
    case 1:
    h1.AddFruit();
    _addCal = h1.ReturnHealth();
    break;
    case 2:
       h1.AddVeg();
       _addCal = h1.ReturnHealth();
        break;
    case 3:
        h1.AddMeat();
        _addCal = h1.ReturnHealth();
        break;
    case 4:
    j1.AddSugar();
    _addCal = j1.ReturnJunk();
    break;
    case 5:
    j1.AddCarbs();
    _addCal = j1.ReturnJunk();
    break;
            }
}
}