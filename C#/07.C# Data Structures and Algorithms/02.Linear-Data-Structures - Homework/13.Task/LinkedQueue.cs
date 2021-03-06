﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Task
{
    public class LinkedQueue<T>
    {
        private LinkedList<T> elements;

        public LinkedQueue()
        {
            this.elements = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            var newItem = new ListItem<T>(value);
            this.elements.Add(newItem);
        }

        public T Dequeue()
        {
            var firstItem = this.elements.FirstElement;
            this.elements.FirstElement = firstItem.NextItem;

            return firstItem.Value;
        }

        public T Peek()
        {
            var firstItem = this.elements.FirstElement;

            return firstItem.Value;
        }
    }
}
