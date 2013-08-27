using System.Collections.Generic;

namespace DesignPatterns.BuilderPattern
{
    public class Product
    {
        private string _partOne;
        private string _partTwo;

        public string PartOne
        {
            get { return _partOne; }
            set { _partOne = value; }
        }

        public string PartTwo
        {
            get { return _partTwo; }
            set { _partTwo = value; }
        }
    }
}