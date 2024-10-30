class program
{
    public static void Main(string[] args)
    {
        Xenogrow x1 = new Xenogrow(150);
        Xenogrow x2 = new Xenogrow(35);
       x1.performtasks(150);
        x2.performtasks(35);
        Execute ex1 = new Execute( 3, 2, 50);
        Execute ex2=new Execute(0,0,0);
        Execute ex3 = new Execute(-4,8,10);
        Execute ex4 = new Execute(-10,-5,80);
        Execute ex5= new Execute(8,-3,40);
        Execute ex6= new Execute(4,0,0);
        Execute ex7 = new Execute(-7, 0, 0);
        Execute ex8 = new Execute(0, 40, 0);
        Execute ex9 = new Execute(0, -30, 0);

        Console.WriteLine(ex1.getLocation(3,2));
        Console.WriteLine(ex2.getLocation(0, 0));
        Console.WriteLine(ex3.getLocation(-4, 8));
        Console.WriteLine(ex4.getLocation(-10, -5));
        Console.WriteLine(ex5.getLocation(8, -3));
        Console.WriteLine(ex6.getLocation(4, 0));
        Console.WriteLine(ex7.getLocation(-7, 0));
        Console.WriteLine(ex8.getLocation(0, 40));
        Console.WriteLine(ex9.getLocation(0, -30));
        ex1.done(3,2);
        ex2.done(0, 0);
        ex3.done(-4, 8);
        ex4 .done(-10, -5);
        ex5.done(8, -3);
        ex6.done(4, 0);
        ex7.done(-7, 0);
        ex8.done(0, 40);
        ex9.done(0, -30);
        Console.WriteLine(ex1.getpower(3,2,50));
        Console.WriteLine(ex2.getpower(0,0,0));
        Console.WriteLine(ex3.getpower(-4, -8, 10));
        Console.WriteLine(ex4.getpower(-10, -5, 80));
        Console.WriteLine(ex5.getpower(8, -3, 40));
        Console.WriteLine(ex6.getpower(4, 0, 0));
        Console.WriteLine(ex7.getpower(-7, 0, 0));
        Console.WriteLine(ex8.getpower(0, 40, 0));
        Console.WriteLine(ex9.getpower(0, -30, 0));
        Robot r1 = new Robot("Cleaning");
        Robot r2 = new Robot("Repairing");
        Robot r3 = new Robot("Inspection");
        Console.WriteLine(r1.performtasks("Cleaning"));
        Console.WriteLine(r2.performtasks("Repairing"));
        Console.WriteLine(r3.performtasks("Inspection"));

    }
