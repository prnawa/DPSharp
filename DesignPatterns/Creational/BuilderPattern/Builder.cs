namespace DesignPatterns.BuilderPattern
{
    public abstract class Builder
    {
        public abstract void BuildPartOne();
        public abstract void BuildPartTwo();
        public abstract Product GetResult();
    }

    public class Builder1 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartOne()
        {
            _product.PartOne = "Part A";
        }

        public override void BuildPartTwo()
        {
            _product.PartTwo = "Part B";
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
    
    public class Builder2 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartOne()
        {
            _product.PartOne = "Part X";
        }

        public override void BuildPartTwo()
        {
            _product.PartTwo = "Part Y";
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

}
