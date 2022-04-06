using System;

namespace game2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int user_score = 0, computer_score = 0, computer_score2 = 0 ,index,index2;
            string computer_choice, computer_choice2 , user_choice;

            string[] options = new string[2];
            options[0] = "✋";
            options[1] = "🤚";

            while(user_score==5 || computer_score == 5 || computer_score2 == 5)
            {

                index = r.Next(0, 2);
                computer_choice = options[index];

                index2 = r.Next(0, 2);
                computer_choice2 = options[index2];

                user_choice = Console.ReadLine();
                Console.WriteLine(computer_choice);
                Console.WriteLine(computer_choice2);

                if (computer_choice == "🤚" && computer_choice2 == "✋" && user_choice == "✋")
                {
                    computer_score++;
                }
                else if (computer_choice == "✋" && computer_choice2 == "🤚" && user_choice == "✋")
                {
                    computer_score2++;
                }
                else if (computer_choice == "✋" && computer_choice2 == "✋" && user_choice == "🤚")
                {
                    user_score++;
                }


                else if (computer_choice == "✋" && computer_choice2 == "🤚" && user_choice == "🤚")
                {
                    computer_score++;
                }
                else if (computer_choice == "🤚" && computer_choice2 == "✋" && user_choice == "🤚")
                {
                    computer_score2++;
                }
                else if (computer_choice == "🤚" && computer_choice2 == "🤚" && user_choice == "✋")
                {
                    user_score++;
                }

                else if (computer_choice == "🤚" && computer_choice2 == "🤚" && user_choice == "🤚")
                {
                    computer_score++;
                    computer_score2++;
                    user_score++;
                }
                else if (computer_choice == "✋" && computer_choice2 == "✋" && user_choice == "✋")
                {
                    computer_score++;
                    computer_score2++;
                    user_score++;
                }

            }
            if (user_score > computer_score && user_score > computer_score2)
            {
                Console.WriteLine("you win");
            }
            else if (computer_score > computer_score2 && computer_score > user_score)
            {
                Console.WriteLine("computer win");
            }
            else if (computer_score2 > computer_score && computer_score2 > user_score)
            {
                Console.WriteLine("computer2 win");
            }
            else
            {
                Console.WriteLine("draw");
            }
        }
    }
}
