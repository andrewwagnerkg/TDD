using System;

namespace TDDLesson6
{
    class KGSConverter : Converter
    {
        private decimal _eurRate, _usdRate, _rurRate; 
        public KGSConverter(decimal eurRate, decimal usdRate, decimal rurRate)
        {
            if (eurRate <= 0 || usdRate <= 0 || rurRate <= 0)
                throw new ArgumentException("ctor");
            _eurRate = eurRate;
            _usdRate = usdRate;
            _rurRate = rurRate;
        }

        public override Currency OutputCurrency { get; set; }

        public override decimal Value
        {
            get
            {
                switch (OutputCurrency)
                {
                    case Currency.KGS: return _value;
                    case Currency.USD: return _value / _usdRate;
                    case Currency.EUR: return _value / _eurRate;
                    case Currency.RUR: return _value / _rurRate;
                    default: throw new Exception("Get Value");
                }
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Value");
                _value = value;
            }
        }
    }
}
