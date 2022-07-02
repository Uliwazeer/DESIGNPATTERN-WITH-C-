namespace DesignPatterns.Builder {
    public class Director
    {
        IBuilder Builder;
        // steps to create complex object
        public void Construct(IBuilder Builder){
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadLights();
            builder.EndOperations();
        }
    }
}