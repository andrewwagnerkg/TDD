namespace TDDLesson6
{
    abstract class Converter
    {
        protected decimal _value;
        public abstract Currency OutputCurrency { get; set; }

        public abstract decimal Value { get; set; }
    }
}
