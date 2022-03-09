using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
	/// <summary>
    /// Класс параметра
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Текущее значение параметра
        /// </summary>
	    private double _value;

        /// <summary>
        /// Возвращает и устанавливает значение параметра
        /// </summary>
        public double Value
        {
	        get => _value;
	        set
            {
	            _value = value;
                Validator.CheckValue(value, MinValue, MaxValue);
	        }
        }

        /// <summary>
        /// Возвращает и устанавливает максимальное значение
        /// </summary>
        public double MaxValue { get; set; }

        /// <summary>
        /// Возвращает и устанавливает минимальное значение
        /// </summary>
        public double MinValue { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="value">Значение</param>
        public Parameter(double minValue, double maxValue,
	        double value)
        {
	        MinValue = minValue;
	        MaxValue = maxValue;
	        Value = value;
        }
    }
}
