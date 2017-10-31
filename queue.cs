using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(6);

            q.Push('Y');
            q.Push('A');
            q.Push('L');
            q.Push('O');
            q.Push('V');
            q.Push('A');

            char ilkCikan = q.Pop();
            Console.WriteLine(ilkCikan);//Y

            ilkCikan = q.Pop();
            Console.WriteLine(ilkCikan);//A

            q.Push('U');

            q.Push('K');

            q.Push('J'); /*Dolu eklenemedi uyarısı*/

            ilkCikan = q.Pop();
            Console.WriteLine(ilkCikan);//L

            q.Push('J');



            Console.ReadKey();
        }
    }

    class Queue {
        /*FIFO: ilk giren ilk çıkar*/
        char[] queue;
        int doluluk = 0;
        int eklemeIndisi = 0;
        int cikartmaIndisi = 0;

        public Queue(int boyut)
        {
            queue = new char[boyut];
        }
        
        public bool isEmpty() {
            return doluluk == 0;
        }
        
        public bool isFull() {
            return doluluk == queue.Length;
        }
        
        public void Push(char karakter) {
            if (isFull())
            {
                Console.WriteLine("Queue dolu, eklenemez");
                return;
            }

            queue[eklemeIndisi] = karakter;
            eklemeIndisi++;
            eklemeIndisi = eklemeIndisi % queue.Length;
            doluluk++;
        }

        public char Pop() {
            if (isEmpty())
            {
                Console.WriteLine("Queue boş, geri birşey döndürülemez");
                return '0';
            }

            doluluk--;
            int indis = cikartmaIndisi;
            cikartmaIndisi++;
            return queue[indis];
        }


    }
}
