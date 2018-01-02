using System;
using System.Collections.Generic;

namespace SetSpace
{
    /// <summary>
    /// Класс множества
    /// </summary>
    public class SetClass
    {
        /// <summary>
        /// Список для хранения множества
        /// </summary>
        private List<int> values = new List<int>();

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetClass()
        { }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="values">множество</param>
        public SetClass(List<int> values)
        {
            if (values.Count == 0)
                throw new Exception("Empty set");

            this.values = values;
        }

        /// <summary>
        /// Заполнение множества
        /// </summary>
        /// <param name="SetStringArray"></param>
        public void Fill(string[] SetStringArray)
        {
            foreach (var substring in SetStringArray)
            {
                int number;

                if (Int32.TryParse(substring, out number))
                    values.Add(number);
            }
        }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj">объект, с которым сравнивать</param>
        /// <returns>0 если равны, 1 если 
        /// кол-во элементов первого больше
        /// чем у второго и второй является 
        /// подмножеством первого, -1 если 
        /// кол-во элементов первого меньше
        /// чем кол-во элементов второго или 
        /// второй не является подмножеством 
        /// первого</returns>
        private int Compare(SetClass obj)
        {
            int length = 0;

            if (values.Count == obj.values.Count)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (!(values.Contains(obj.values[i])))
                        return -1;
                }
                return 0;
            }
            else if (values.Count > obj.values.Count)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (obj.values.Contains(values[i]))
                        length++;
                }
                if (length == obj.values.Count)
                    return 1;
            }
            return -1;
        }

        /// <summary>
        /// Оператор явного преобразовани в double
        /// </summary>
        /// <param name="obj">объект</param>
        public static explicit operator double(SetClass obj)
        {
            double sum = 0;

            for (int i = 0; i < obj.values.Count; i++)
                sum += obj.values[i];

            return sum;
        }

        /// <summary>
        /// Оператор неявного преобразования в строку
        /// </summary>
        /// <param name="obj">объект</param>
        public static implicit operator string(SetClass obj)
        {
            if (obj.values.Count == 0)
                return "Empty Set";

            string str = "{";

            str += $"{obj.values[0]}";
            for (int i = 1; i < obj.values.Count; i++)
                str += "," + $"{obj.values[i]}";
            str += "}";

            return str;
        }

        /// <summary>
        /// Перегруженый оператор +
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>объект с объеденёнными множествами</returns>
        public static SetClass operator +(SetClass first, SetClass second)
        {
            SetClass obj = new SetClass();
            int i;

            for (i = 0; i < first.values.Count; i++)
                obj.values.Add(first.values[i]);
            for (int j = 0; j < second.values.Count; j++, i++)
            {
                if (!obj.values.Contains(second.values[j]))
                    obj.values.Add(second.values[j]);
            }

            return obj;
        }

        /// <summary>
        /// Перегруженый оператор -
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>объект с разницей множеств</returns>
        public static SetClass operator -(SetClass first, SetClass second)
        {
            SetClass obj = new SetClass();

            for (int i = 0; i < first.values.Count; i++)
            {
                if (!(second.values.Contains(first.values[i])))
                    obj.values.Add(first.values[i]);
            }

            return obj;
        }

        /// <summary>
        /// Перегруженый оператор *
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns></returns>
        public static SetClass operator *(SetClass first, SetClass second)
        {
            SetClass obj = new SetClass();

            for (int i = 0; i < first.values.Count; i++)
            {
                if (second.values.Contains(first.values[i]))
                    obj.values.Add(first.values[i]);
            }

            return obj;
        }

        /// <summary>
        /// Перегруженый оператор ==
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>Равны ли множества</returns>
        public static bool operator ==(SetClass first, SetClass second)
        {
            return first.Compare(second) == 0;
        }

        /// <summary>
        /// Перегруженый оператор !=
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>Не равны ли множества</returns>
        public static bool operator !=(SetClass first, SetClass second)
        {
            return first.Compare(second) != 0;
        }

        /// <summary>
        /// Перегруженый оператор >
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>Больше ли одно множество другого</returns>
        public static bool operator >(SetClass first, SetClass second)
        {
            return first.Compare(second) > 0;
        }

        /// <summary>
        /// Перегруженый оператор <
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>Меньше ли одно множество другого</returns>
        public static bool operator <(SetClass first, SetClass second)
        {
            return first.Compare(second) < 0;
        }

        /// <summary>
        /// Перегруженый оператор >=
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>Больше или равно ли одно множество другому</returns>
        public static bool operator >=(SetClass first, SetClass second)
        {
            return first.Compare(second) >= 0;
        }

        /// <summary>
        /// Перегруженый оператор <=
        /// </summary>
        /// <param name="first">первый объект</param>
        /// <param name="second">второй объект</param>
        /// <returns>Меньше или равно ли одно множество другому</returns>
        public static bool operator <=(SetClass first, SetClass second)
        {
            return first.Compare(second) <= 0;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
