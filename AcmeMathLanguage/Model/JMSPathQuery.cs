using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMathLanguage.Model
{
    public class JMSPathQuery 
    {
        string string_value;

        private JMSPathQuery() { }

        public JMSPathQuery(string value)
        {
            string_value = value;
        }

        public static implicit operator JMSPathQuery(string value)
        {
            return new JMSPathQuery
            {
                string_value = value
            };
        }
    }
}
