using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMathLanguage.Model
{
    public class JValue: JItem
    {
        string string_value;
        float int_value;
        float float_value;
        DateTimeOffset datetime_value;
        bool bool_value;

        private JValue() { }

        public JValue(string value)
        {
            string_value = value;
        }

        public JValue(int value)
        {
            int_value = value;
        }

        public JValue(float value)
        {
            float_value = value;
        }

        public JValue(DateTimeOffset value)
        {
            datetime_value = value;
        }

        public JValue(bool value)
        {
            bool_value = value;
        }

        public static implicit operator JValue(string value)
        {
            return new JValue
            {
                string_value = value
            };
        }

        public static implicit operator JValue(int value)
        {
            return new JValue
            {
                int_value = value
            };
        }

        public static implicit operator JValue(float value)
        {
            return new JValue
            {
                float_value = value
            };
        }

        public static implicit operator JValue(DateTimeOffset value)
        {
            return new JValue
            {
                datetime_value = value
            };
        }

        public static implicit operator JValue(bool value)
        {
            return new JValue
            {
                bool_value = value
            };
        }
    }
}
