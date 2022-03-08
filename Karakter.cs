using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFactoryFeladat
{
    class Karakter
    {
        public int AX { get; set; }
        public int AY { get; set; }
        public int PX { get; set; }
        public int PY { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }
        public System.ConsoleColor MyColor { get; set; }
        public char MyChar { get; set; }
        public Karakter()
        {
            Random r = new Random();
            
            AX = r.Next(2,50);
            AY = r.Next(2,25);
            DX = r.Next(-1,2);
            DY = r.Next(-1,2);
            int vel = r.Next(2);
            if (vel==0)
            {
                MyChar = '@';
            }
            else if(vel==1)
            {
                MyChar = '&';
            }
            vel = r.Next(0, 3);
            if (vel==0)
            {
                MyColor = ConsoleColor.Red;
            }
            else if (vel==1)
            {
                MyColor = ConsoleColor.Green;
            }
            else
            {
                MyColor = ConsoleColor.Blue;
            }           
        }
        public void Draw()
        {
            Console.ForegroundColor = System.ConsoleColor.Black;
           
            Console.ForegroundColor = MyColor;
            
            Console.SetCursorPosition(AX, AY);
            Console.Write(MyChar);
            Console.SetCursorPosition(PX, PY);
            Console.Write(' ');
        }
        public void Move()
        {

            while (true)
            {
               System.Threading.Thread.Sleep(400);
                Random r = new Random();
                DX = r.Next(-1, 2);
                DY = r.Next(-1, 2);
                PX = AX;
                PY = AY;
                AX = AX+ DX;
                AY = AY+ DY;
                if(AX <= 0)
                {
                    AX = 0;
                    DX = DX + -1;
                }
                if(AY <= 0)
                {
                    AY = 0;
                    DY = DY * -1;
                }
                
            }
        }
        public Karakter(int aX, int aY, int pX, int pY, int dX, int dY, ConsoleColor myColor, char myChar)
        {
            AX = aX;
            AY = aY;
            PX = pX;
            PY = pY;
            DX = dX;
            DY = dY;
            MyColor = myColor;
            MyChar = myChar;
        }
    }
}
