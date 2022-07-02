using system;
using DesignPatterns.Singleton;
name space DesignPatterns
{
    0 refernces 
     static void Main(string[] args)
    {
        // first thread or first way to code walk in it
        Task task1 = Task.Factory.StartNew(() => {
            Counter counter1 = Counter.GetInstance();
            counter1.AddOne();
            console.WriteLine("counter 1 :"+ counter1.count.ToString());
        });
        // second thread or second way to code walk in it
        Task task2 = Task.Factory.StartNew(() => {
            Counter counter2 = Counter.GetInstance();
            counter2.AddOne();
            console.WriteLine("counter 2 :"+ counter2.count.ToString());
            console.WriteLine();
        });
        // previous code before create singleton pattern counter1 and counter2 everyone create 
        // a copy in memory so we should use singleton pattern to create one copy
        console.ReadKey();
    }