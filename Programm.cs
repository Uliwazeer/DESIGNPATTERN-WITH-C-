// creational patterns are singleton pattern implementation
using system;
using DesignPatterns.Singleton;
name space DesignPatterns
{
    0 refernces 
     static void Main(string[] args)
    {
        Counter counter1 = Counter.GetInstance();
        Counter counter2 = Counter.GetInstance();
        counter1.AddOne();
        counter2.AddOne();

        console.WriteLine("counter 1 :"+ counter1.count.ToString());
        console.WriteLine("counter 2 :"+ counter2.count.ToString());
        console.WriteLine();
        
        counter1.AddOne();
        console.WriteLine("counter 1 :"+ counter1.count.ToString());
        console.WriteLine("counter 2 :"+ counter2.count.ToString());
        console.ReadKey();
    }
}