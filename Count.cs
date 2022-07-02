namespace DesignPatterns.Singleton
{
   4 refernces 
    public class Counter
   {
    5 refernces
    public int count=0;
    7 refernces 
    private static Counter instance= new Counter();
    3 refernces 
    private Counter(){}
    0 refernces 
    public static Counter GetInstance(){
        return instance;
    }
    3 refernces
    public void AddOne(){count++;}
    
   } 
}