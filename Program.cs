using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Input Number In Box 1 : ");
            int numberBox1 = int.Parse(Console.ReadLine());
            Console.Write("Input Number In Box 2 : ");
            int numberBox2 = int.Parse(Console.ReadLine());
            Console.Write("Input Number In Box 3 : ");
            int numberBox3 = int.Parse(Console.ReadLine());
            int turnCount = 1;
            bool gameOverCheck = false;
            while (gameOverCheck == false)
            {
                Console.WriteLine("\n----------------------------------------------------------------------\n");
                Console.WriteLine("Turn : " + turnCount);
                //status a
                Console.WriteLine("Box 1 = {0}\tBox 2 = {1}\tBox 3 = {2}", numberBox1, numberBox2, numberBox3);
                
                //player a
                Console.WriteLine("\tTurn PlayerA");
                Console.Write("Choose Box : ");
                int chooseBox = int.Parse(Console.ReadLine());
                Console.Write("How many Box Remove? : ");
                int removeBox = int.Parse(Console.ReadLine());
                switch (chooseBox)
                {
                    case 1:
                        numberBox1 -= removeBox;
                        break;
                    case 2:
                        numberBox2 -= removeBox;
                        break;
                    case 3:
                        numberBox3 -= removeBox;
                        break;
                    default:
                        break;
                }
                
                //check player a
                if(numberBox1 == 0 && numberBox2 == 0 && numberBox3 == 0)
                {
                    gameOverCheck = true;
                    Console.WriteLine("**********    Game Over Player B Win    **********");
                    break;
                }
                turnCount++;
                Console.WriteLine("\n----------------------------------------------------------------------\n");

                //status b
                Console.WriteLine("Turn : " + turnCount);
                Console.WriteLine("Box 1 = {0}\tBox 2 = {1}\tBox 3 = {2}", numberBox1, numberBox2, numberBox3);

                //player b
                Console.WriteLine("\tTurn PlayerB");
                Console.Write("Choose Box : ");
                chooseBox = int.Parse(Console.ReadLine());
                Console.Write("How many Box Remove? : ");
                removeBox = int.Parse(Console.ReadLine());
                switch (chooseBox)
                {
                    case 1:
                        numberBox1 -= removeBox;
                        break;
                    case 2:
                        numberBox2 -= removeBox;
                        break;
                    case 3:
                        numberBox3 -= removeBox;
                        break;
                    default:
                        break;
                }
                
                //check player b
                if (numberBox1 == 0 && numberBox2 == 0 && numberBox3 == 0)
                {
                    gameOverCheck = true;
                    Console.WriteLine("**********     Game Over Player A Win    **********");
                    break;
                }
                turnCount++;

            }



        }
    }
}
