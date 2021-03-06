﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projev3
{
   public class Kuyruk : IKuyruk
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public Kuyruk(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            Queue[++rear] = o;
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue bož.");

            object temp = Queue[front];
            Queue[front] = null;
            front++;
            count--;

            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void ekle(object o)
        {
            throw new NotImplementedException();
        }

        public object kaldır()
        {
            throw new NotImplementedException();
        }

        public object goruntule()
        {
            throw new NotImplementedException();
        }
    }
}
