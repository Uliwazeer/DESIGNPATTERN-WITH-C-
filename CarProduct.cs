namespace DesignPatterns.Builder 
{
1 references
public class car : IBuilder 
{
    2 references 
    private string brandName;
    6 references 
    private Product Product;
    1 references 
    public Car(string brand){
        Product = new Product();
        this.brandName = brand; 

    }
    1 references 
    public void StartUpOperations(){
        product.Add($"car model name :{this.brandName}");
    }
    1 references 
    public void BuildBody() {product.Add("Body Of Car Was Added");}
    1 references
    public void InsertWheels() {product.Add("Wheels Of Car Was Added");}
    1 references 
    public void AddHeadLights(){
        product.Add("HeadLights Are Added");
    }
    1 references 
     public void EndOperations(){//end operations}
     2 references
     public void GetVehicle(){return product;}
}
}