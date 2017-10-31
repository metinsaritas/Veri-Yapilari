using System;

namespace veriyapilariCalisma1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(6);

            s.Push('Y');
            s.Push('A');
            s.Push('L');
            s.Push('O');
            s.Push('V');
            s.Push('A');

            s.Push('U'); /*boyutu aştık (6)*/

            s.Resize(12);

            s.Push('U');

            char sonEklenen = s.Pop();
            Console.WriteLine(sonEklenen); //U

            sonEklenen = s.Pop();
            Console.WriteLine(sonEklenen); //A

            sonEklenen = s.Pop();
            Console.WriteLine(sonEklenen);//V

            s.Clear();
            
            sonEklenen = s.Pop(); /*stack boş uyarısı*/
            Console.WriteLine(sonEklenen);//0




            Console.ReadKey();
        }
    }

    class Stack {
        char[] stack;
        int tos = 0;

        public Stack(int boyut)
        {
            stack = new char[boyut];
        }

        public bool isEmpty() {
            return tos == 0;
        }

        public bool isFull() {
            return tos == stack.Length;
        }

        public void Push(char karakter) {
            if (isFull()) {
                Console.WriteLine("Stack dolu, eklenemez");
                return;
            }

            stack[tos] = karakter;
            tos++;
        }

        public char Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack boş, geri birşey döndürülemez");
                return '0';
            }

            tos--;
            return stack[tos];
        }

        public void Clear() {
            tos = 0;

            /* //VEYA

                int sonTos = tos;
                for (int i = 0; i < sonTos; i++)
                {
                    Pop();
                }
             */
        }

        public int GetNumber() {
            return tos;
        }

        public void Resize(int yeniBoyut) {
            if (yeniBoyut <= 0) {
                Console.WriteLine("Boyut 1 den küçük olamaz!");
                return;
            }

            char[] yeniStack = new char[yeniBoyut];

            for (int i = 0; i < stack.Length; i++)
            {
                yeniStack[i] = stack[i];// eski stackdaki değerleri yenisine kopyaladık
            }

            stack = yeniStack;
        }

    }
}
