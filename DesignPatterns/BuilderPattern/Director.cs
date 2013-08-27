namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        public void Construct(Builder builder)
        {
           builder.BuildPartOne();
           builder.BuildPartTwo();
        }
    }
}
