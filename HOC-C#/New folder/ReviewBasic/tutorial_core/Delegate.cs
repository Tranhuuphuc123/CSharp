using System;
delegate int NumberChanger(int n);
/*tiềm hiểu về Delegrate*/
namespace ReviewBasic
{
    // method Delegrate? tiềm hiệu lại sao
    public delegate void Show();

    class Phuc
    {
        public void ShowOdd()
        {
            for (int i = 1; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }
        }

        public void ShowEven()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
