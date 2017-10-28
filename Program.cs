using System;
using System.Collections.Generic;
using System.Text;

namespace linkedListCiftTarafli
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList List = new LinkedList();

            Node N1 = new Node("Kişi1",70,80);
            Node N2 = new Node("Kişi2", 74, 20);
            Node N3 = new Node("Kişi3", 40, 70);
            Node N4 = new Node("Kişi4", 30, 10);
            Node N5 = new Node("Kişi5", 60, 100);
            List.AddBack(N1);
            List.AddBack(N2);
            List.AddBack(N3);
            List.AddBack(N4);
            List.InsertAt(List.getCount(), N5);

            List.RemoveFront();
            List.RemoveFront();
            List.RemoveBack();

            List.RemoveAt(0);
        }
    }

    class Node {
        public Node Next;
        public Node Before;

        int Vize;
        int Final;
        string Isim;

        public Node(string Isim, int Vize, int Final)
        {
            this.Isim = Isim;
            this.Vize = Vize;
            this.Final = Final;
        }
    }

    class LinkedList {
        Node Head;
        Node Tail;
        int Count;

        public void AddFront(Node N)
        {
            InsertAt(0, N);
        }

        public void AddBack(Node N) {
            InsertAt(Count, N);
        }

        public void RemoveFront ()
        {
            RemoveAt(0);
        }

        public void RemoveBack() {
            RemoveAt(Count-1);
        }
        public int getCount() {
            return Count;
        }

        public bool isEmpty() {
            return Count == 0;
        }

        public Node getNodeAt(int index) {

            Node tempCurrent = Head;
            for (int i = 1; i <= index; i++)
            {
                tempCurrent = tempCurrent.Next;
            }
            return tempCurrent;

        }

        public void InsertAt(int index, Node N)
        {
            if (index < 0 || index > Count)
            {
                Console.Write("Hatalı index");
                return;
            }

            if (isEmpty())
            {
                Head = Tail = N;
            }
            else
            {

                Node current = getNodeAt(index);

                N.Next = current;
                if (index == 0) /*İlk elemana ekleniyorsa, current.Before = null, Head ile işlem yap*/
                {
                    Head.Before = N;
                    Head = N;
                }
                else if (index == Count) /*Son elemana ekleniyorsa, current = null, Tail ile işlem yap*/
                {
                    N.Before = Tail;
                    Tail.Next = N;
                    Tail = N;
                }
                else
                {
                    current.Before.Next = N;
                    N.Before = current.Before;
                    current.Before = N;
                }


            }

            Count++;
        }

        public void RemoveAt(int index) {
            if (index < 0 || index >= Count)
            {
                Console.Write("Hatalı index");
                return;
            }

            if (isEmpty()) {
                Console.Write("Liste zaten boş");
                return;
            }

            if (index == 0) {/* current = Head*/
                Head = Head.Next;
                Head.Before = null;
            } else if (index == Count -1) { /* current = Tail*/
                Tail = Tail.Before;
                Tail.Next = null;
            } else {
                Node current = getNodeAt(index);
                current.Before.Next = current.Next;
                current.Next.Before = current.Before;                
            }


            Count--;
        }
    }

}
