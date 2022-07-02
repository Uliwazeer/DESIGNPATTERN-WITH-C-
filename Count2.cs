namespace DesignPatterns.Singleton
  
{
   4 refernces 
//    to improve the performance for system for memory to create copy with first creation code line
    public class Counter
   {
    3 refernces
    public int count=0;
    3 refernces
    private static Counter instance=null;
    0 refernces
    private static object lockObj = new object();
    1 refernces
    private Counter(){}
    2 refernces 
    // make lock on counter2 to hold on counter1 then counter2 until create two copy in memory
    public static Counter GetInstance(){
        lock(lockObj){
        if (instance=null){instance = new Counter();}
        return instance;
        }
    }
    2 refernces 
    public void AddOne(){count++;}
    }
  }
//   there are anthor way instead of lock called double check
// double check to check twise
namespace DesignPatterns.Singleton
  
{
   4 refernces 
//    to improve the performance for system for memory to create copy with first creation code line
    public class Counter
   {
    3 refernces
    public int count=0;
    3 refernces
    private static Counter instance=null;
    0 refernces
    private static object lockObj = new object();
    1 refernces
    private Counter(){}
    2 refernces 
    // make lock on counter2 to hold on counter1 then counter2 until create two copy in memory
    public static Counter GetInstance(){
        // anther way called double check it is a safe way than lock
        if(instance == null){
        lock(lockObj){
        if (instance=null){instance = new Counter();}
        }
        }
          return instance;
    }
    2 refernces 
    public void AddOne(){count++;}
    }
  }
