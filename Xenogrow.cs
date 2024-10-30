 public class Xenogrow
 {
     public int speed;
     public Xenogrow(int speed)
     {
         this.speed = speed;
     }
     public void performtasks(int speed)
     {
         if (speed >= 100)
         {
             Console.WriteLine($"Performing tasks in highspeed.The speed is:{speed}");
         }
         else
         {
             Console.WriteLine($"Performing tasks in extraposition.The speed is:{speed}");
         }
     }

 }
