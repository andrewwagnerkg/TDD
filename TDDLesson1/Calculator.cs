namespace TDDLesson1
{
    class Calculator
    {
        public int Add(int x, int y) => x + y;

        public int Minus(int x, int y) => x - y;

        public int Muliply(int x, int y) => x * y + 4; //LogicalError

        public int Divide(int x, int y) => x / y; //may be error 

    }
}
