namespace DesignPatterns.Prototype
{
    10 refernces 
    public abstract class EmpleePrototype
    {
        2 refernces 
        public int Id{get;set;}
        6 refernces 
        public string Name{get;set;}
        13 refernces 
        public Address EmpAddress {get;set;}
        1 refernces 
        public abstract EmpleePrototype ShallowCopy();
        0 refernces 
        public abstract EmpleePrototype DeepCopy();
        public override string ToString(){
            return 
            $@"
            Id: {this.Id}
            Name: {this.Name}
            Address: {this.EmpAddress.City},{this.EmpAddress.StreetName},{this.EmpAddress.Building}";
        }

    }
}
