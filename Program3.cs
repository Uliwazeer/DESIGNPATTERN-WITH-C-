// creational patterns are singleton pattern implementation
using system;
using DesignPatterns.Prototype;
name space DesignPatterns
{
  
    0 refernces 
     static void Main(string[] args)
    {
          #region singleton...
          #region prototype...
          EmpleePrototype tempEmp1 = new TempEmployee();
          tempEmp1.Name = "temp employee 1";
          tempEmp1.Id = 1;
          tempEmp1.EmpAddress = new Address{City="city 1", Building="B1", StreetName="street name"};

          EmployeePrototype tempEmp2 =tempEmp1.ShallowCopy();

        
        
        console.WriteLine("=======Temp Emp 1 Original Values=========");
        console.WriteLine(tempEmp1.ToString());
        console.WriteLine("=======Temp Emp 2 Original Values=========");
        console.WriteLine(tempEmp2.ToString());
        
        
        tempEmp2.EmpAddress.City="new city";
        console.ForegroundColor = consoleColor.Cyan;
        console.WriteLine("=======Temp Emp 1 changes=========");
        console.WriteLine(tempEmp1.ToString());
        console.WriteLine("=======Temp Emp 2 changes=========");
        console.WriteLine(tempEmp2.ToString());

        #endregion
        console.ReadKey();
        
        
        console.ReadKey();
    }
}