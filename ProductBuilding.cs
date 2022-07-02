namespace DesignPatterns.Builder 
{
    9 references 
    public class Product
    {
        3 references 
        private System.Collections.Generic.LinkedList<string> parts;
        2 references 
        public Product(){ parts = new System.Collections.Generic.LinkedList<string>();
        8 references 
        public void Add(string part) {
            // Add Parts
            parts.AddLast(part);
        }
        2 references 
        public string show(){
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            result.AppendLine("Products Components Are :");
            foreach (string part in parts)
                result.AppendLine(part);
            return result.ToString();
            
                
            }
        }

    }
}