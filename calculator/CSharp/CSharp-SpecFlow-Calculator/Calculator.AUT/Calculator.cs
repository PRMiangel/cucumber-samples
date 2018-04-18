namespace Calculator.AUT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        private readonly List<int> numbers;

        public Calculator()
        {
            numbers = new List<int>();
        }

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public int Add()
        {
            return numbers.Sum();
        }

        public int Subtraction()
        {
            int result = numbers.First();

            foreach (var number in numbers.Skip(1))
            {
                result = result - number;
            }

            return result;
        }
    }
}
