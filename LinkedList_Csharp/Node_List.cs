using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Csharp
{
    internal class  Node<t>
    {
        public t val;
        public Node<t> next ;

        public Node(t val, Node<t> next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    internal class NodeList<t> : IEnumerable<t>
    {
        public Node<t> root;
        private int length;

        private IList<t> _node_enumer;

        public NodeList(List<t> values)
        {

            root = new Node<t>(values[0]);
            Node<t> temp = root;


            length = values.Count;
            List<t> enumer = new List<t>() { values[0] };
            for(int count =1; count < values.Count; count++)
            {
                temp.next = new Node<t>(values[count]);
                temp = temp.next;
                enumer.Add(values[count]);

            }
            _node_enumer = enumer;
        }
        public IEnumerator<t> GetEnumerator()
        {
            foreach (t val in _node_enumer)
            {
                yield return val;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



    }
}
