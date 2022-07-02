namespace DesignPatterns.Prototype
{
    4 refernces 
    public class RegEmplee : EmplyeePrototype
    {
        return (RegEmplee) this.MemberwiseClone();
    }
    0 refernces 
    public override EmpleePrototype DeepCopy(){
        RegEmplee emp = new RegEmplee();
        emp =(RegEmplee)this.MemberwiseClone();
        emp.EmpAddress = new Address{
            Building=EmpAddress.Building ,
            City=EmpAddress.City , 
            StreetName=EmpAddress.StreetName
        }
        emp.Name=this.Name;
        return emp;
    }
}