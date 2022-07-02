namespace DesignPatterns.Singleton
{
   4 refernces 
//    to improve the performance for system for memory to create copy with first creation code line
    public class Counter
   {
    5 refernces
    public int count=0;
    3 refernces 
    // singleton pattern - lazy initialization implementaion meaning that i make initilazion in another time
    // and make create obj in another time in memry when we need
    private static Counter instance= null;
     0refernces 
     private Counter(){}
     2 refernces 
    public static Counter GetInstance(){
        // if instance = null then create a new copy else return the created copy before
        if (instance==null){instance = new Counter();}
        return instance;
    }
    3 refernces
    public void AddOne(){count++;}
    
   } 
}