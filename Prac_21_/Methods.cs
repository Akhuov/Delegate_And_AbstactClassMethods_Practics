
namespace Prac_21_
{
    public class Methods : Abstr
    {
        public override void Show(string name)
        {
            Console.WriteLine(name);
        }

        

        public override bool Tub(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) { return false; }
            }
            if (num<2) return false;
            else return true;
        }

        public override int Sum(int num)
        {
            int c = 0;
            for (int i = 1; i <= num; i++)
            {
                c += i;
            }
            return c;
        }





        public int Sum1(int num)
        {
            int c = 0;
            for (int i = 1; i <= num; i++)
            {
                c += i;
            }
            Console.WriteLine(c);
            return c;
        }
        public int Sum2(int num)
        {
            int c = 0;
            for (int i = 1; i <= num; i++)
            {
                c += i;
            }
            Console.WriteLine(c);
            return c*10;
        }
        public int Sum3(int num)
        {
            int c = 0;
            for (int i = 1; i <= num; i++)
            {
                c += i;
            }
            Console.WriteLine(c);
            return c*100;
        }
    }
}
