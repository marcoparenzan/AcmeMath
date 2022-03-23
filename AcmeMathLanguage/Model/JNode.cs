using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMathLanguage.Model
{
    public class JNodeKV
    {
        public string Key { get; set; }
        public JItem Value { get; set; }

        public JNodeKV(string key, JItem value) => (Key, Value) = (key, value);
    }

    public class JNode: JItem, IEnumerable<JItem>
    {
        public JNode(params JNodeKV[] items)
        {
            foreach (var item in items)
                Add(item);
        }

        private Dictionary<string, JItem> items = new Dictionary<string, JItem>();

        public JItem this[string key]
        {
            get => items[key];
            set => items[key] = value;
        }

        public bool ContainsKey(string key) => items.ContainsKey(key);

        public IEnumerator<JItem> GetEnumerator() => items.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => items.Values.GetEnumerator();

        public JNode Add(string key, JItem value)
        {
            items.Add(key, value);
            return this;
        }

        public JNode Add(JNodeKV kv)
        {
            items.Add(kv.Key, kv.Value);
            return this;
        }
    }
}
