namespace DesignPatterns.BuilderPattern 
{
        3 refernces 
        static void WriteColoredLine( //take text and color of line
            string text, ConsoleColor color= ConsoleColor.green
        )
        {
            Console.ForegroundColor = color ;
            Console.WriteLine(text);
        }
        0 references
        static void Main(string[] args){
            #region singleton.....
            #region prototype.....
            #region Builder.....
            System.Text.StringBuilder sb = System.Text.StringBuilder();
            sb.AppendLine("word 1,");//to print in ever
            sb.AppendLine("word 2");//to print everyone in one line
            //Append(); to print together on one line
            //sb.ToString(); //to concatenate strings with together
            WriteColoredLine(sb.ToString(),ConsoleColor.Cyan);

            /*
            we can use another way instead of append by storing in varibile x
            // but performance isn't good for memory
            ex 2 
            string x= "word 1";
            x=x+ "word 2";
            WriteColoredLine(x,ConsoleColor.Cyan);
            Console.ReadKey();
            */
            console.ReadKey();
        }
    public abstract class EmpleePrototype
    {
       
}