public class Robot
{
    public string tasks;
    public Robot(string tasks)
    {
        this.tasks = tasks;
    }
    public string performtasks(string tasks) 
        {
             if(tasks=="Cleaning")
        {
            Console.WriteLine("Robot is performing tasks cleaning");
        }
             if(tasks=="Reparing")
        {
            Console.WriteLine("Robot is performing tasks reparing");
        }
             if (tasks=="Inspection")
        {
            Console.WriteLine("Robot is performing tasks inspection");
        }
        return tasks;

        }
}
