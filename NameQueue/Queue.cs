using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameQueue
{
    class Queue
    {
        private readonly int maxsize = 10;
        private string[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;

        public Queue()
        {
            store = new string[maxsize];
        }

        public void Enqueue(string value)
        {
            store[tail] = value;
            if (tail == maxsize-1)
                tail = 0;
            else
                tail++;
            numItems++;
        }

        public string Dequeue()
        {
            if (store[head] == null)
                return "Queue is empty";
            string temp = store[head];
            store[head] = null;
            numItems--;
            if (head == maxsize)
                head = 0;
            else
                head++;
            return temp;
        }

        public string Peek()
        {
            if (store[head] == null)
                return "Queue is empty";
            return store[head];
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public int AmountOfElements()
        {
            if (tail > head)
                return tail - head;
            else
                return 10 + tail - head;
        }

        public string PrintValues()
        {
            string values = "";
            for (int i = 0; i < maxsize; i++)
            {
                if (i == head)
                    values += " head > ";
                else if (i == tail)
                    values += " tail > ";
                values += i + ": { " + store[i] + " } | ";
            }
            return values;

        }

        public int GetLength()
        {
            return numItems;
        }
    }

}
