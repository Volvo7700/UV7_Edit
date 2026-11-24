using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UV7_Edit.Preferences
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; } = new List<Node<T>>();
        public Node(T value)
        {
            Value = value;
        }
        public Node(T value, T child)
        {
            Value = value;
            Children.Add(new Node<T>(child));
        }
        public Node(T value, List<T> children)
        {
            Value = value;
            foreach (T child in children)
            {
                Children.Add(new Node<T>(child));
            }
        }

        public override string ToString()
        {
            return Value?.ToString();
        }
    }
}
