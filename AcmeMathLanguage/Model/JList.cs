using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMathLanguage.Model
{
    public class JList: JItem, IEnumerable<JItem>
    {
        public JList()
        {
        }

        public JList(params JItem[] items)
        {
            foreach (var item in items)
                Add(item);
        }

        private List<JItem> items;

        public JItem this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        public IEnumerator<JItem> GetEnumerator() => items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();

        public JList Add(JItem value)
        {
            items.Add(value);
            return this;
        }

        public JItem[] ToArray() => items.ToArray();
    }
}
