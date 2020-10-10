using System;

namespace Soutnic
{
    class Sputnik
    {
        private string name;
        private double speed;

        private bool isFly;
        private bool isTranslate;
        private string message;


        Sputnik(string name, double speed, string message)
        {
            this.name = name;
            this.speed = speed;
            this.message = message;
        }

        public void goToSpace()
        {
            if (isFly)
            {
                Console.WriteLine($"Sputnik {name} in space!");
            }
            else
            {
                Console.WriteLine($"Sputnik {name} is going to space!");
                isFly = true;
            }
        }

        public void GoLand()
        {
            if (isFly)
            {
                Console.WriteLine($"Sputnik {name} on land!");
            }
            else
            {
                Console.WriteLine($"Sputnik {name} is fly!");
                isFly = true;
            }
        }
        public void UpSpeed()
        {
            Console.WriteLine("Up speed: ");
            speed += 10;
            Console.WriteLine(speed);
        }

        public void DownSpeed()
        {
            Console.WriteLine("Down speed: ");
            speed -= 50;
            Console.WriteLine(speed);
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Speed: " + speed);
        }
        public void ChangeMessage()
        {
            if (isFly)
            {
                this.message = "FLY";
            }
            else
            {
                this.message = "LAND";
                isFly = true;
            }
        }
        public void StartTranslate()
        {
            if (isTranslate)
            {
                Console.WriteLine("Translate ");
            }
            else
            {
                isTranslate = true;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(message);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
        public void StopTranslate()
        {
            this.message = "Stop translate";
            Console.WriteLine(message);
        }
        class Program
        {
            static void Main(string[] args)
            {
                double speed = 80;
                Sputnik sputnik1 = new Sputnik("Apolon", speed, "The first sputnik start");
                sputnik1.goToSpace();
                sputnik1.GetInfo();

                do
                {
                    sputnik1.UpSpeed();
                    sputnik1.ChangeMessage();
                    sputnik1.GetInfo();
                    speed += 10;           //????????????????????????
                } while (speed < 100);

                sputnik1.goToSpace();

                sputnik1.StartTranslate();

                do
                {
                    sputnik1.DownSpeed();
                    sputnik1.GetInfo();
                    speed -= 50;          //?????????????????????????
                } while (speed > 0);

                sputnik1.GoLand();
                sputnik1.StopTranslate();
            }
        }
    }
}
