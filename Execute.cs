public class Execute
{
    
    public int x;
    public int y;
    public int power;
    public Execute( int x, int y, int power)
    {
       
        this.x = x;
        this.y = y;
        this.power = power;
    }
    public (int,int) getLocation(int x,int y)
    {
        Console.WriteLine($"The present location of robot is:{x},{y}");
        if(x==0&&y==0)
        {
            Console.WriteLine($"The Current location in center.The location is:{x},{y}");

        }
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The Current location in 1st quadrent.The location is:{x},{y}");
        }
        if (x < 0 && y > 0)
        {
            Console.WriteLine($"The Current location in 2nd quadrent.The location is:{x},{y}");
        }
        if (x < 0 && y < 0)
        {
            Console.WriteLine($"The Current location in 3rd quadrent.The location is:{x},{y}");
        }
        if (x > 0 && y < 0)
        {
            Console.WriteLine($"The Current location in 4th quadrent.The location is:{x},{y}");
        }
        if(x>0&&y==0)
        {
            Console.WriteLine($"The Current location in positive side lies on x-axis.The location is:{x},{y}");
        }
        if (x < 0 && y == 0)
        {
            Console.WriteLine($"The Current location in negative side lies on x-axis.The location is:{x},{y}");
        }
        if (x == 0 && y > 0)
        {
            Console.WriteLine($"The Current location in positive side lies on y-axis.The location is:{x},{y}");
        }
        if (x > 0 && y == 0)
        {
            Console.WriteLine($"The Current location in positive side lies on x-axis.The location is:{x},{y}");
        }



        return (x,y);
    }
    public void done(int x, int y)
    {
        if(x==0&&y==0)
        {
            Console.WriteLine($"The work done successfully.The current location is:{x},{y}");
        }
        else
        {
            Console.WriteLine($"The work is continueing.The current location is:{x},{y}");
        }
    }
    public (int,int,int) getpower(int x, int y, int power)
    {
        if (x == 0 && y == 0)
        {
            Console.WriteLine("The power is down!");
        }
        else
        {
            Console.WriteLine($"The power of robot is:{power} in the current location{x},{y}");
        }
        return (x,y,power);
    }
}
