using System;
public class TrackingActivity : Tracking{
private int _subCal;
private int _option;
Cardio c1 = new Cardio(calories, subCal);
Muscule m1 = new Muscule(calories, subCal);
Warmup w1 = new Warmup(calories, subCal);
public TrackingActivity(int calories, int subcal) : base(calories){
_subCal = subcal;
}
public void SubCalories(){
  Console.WriteLine("The types of activites are:");
            Console.WriteLine("1. Push ups");
            Console.WriteLine("2. Curling");
            Console.WriteLine("3. Walking");
            Console.WriteLine("4. Running");
            Console.WriteLine("5. Standing");
            Console.WriteLine("6. Stretching");
            Console.WriteLine("Which one did you consume?");
            _option = int.Parse(Console.ReadLine());
        
        switch (_option){
    case 1:
    m1.SubPushup();
    break;
    case 2:
       m1.SubCurling();
        break;
    case 3:
        c1.SubWalking();
        break;
    case 4:
    c1.SubRunning();
    break;
    case 5:
    w1.SubStanding();
    break;
    case 6:
    w1.SubStretching();
    break;    
}
}
}
