using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        Player playerOne;
        int numberOfTasks;
        bool finishedTasks;


        public Game()
        {
            this.playerOne = new Player(this.EnterPlayerName());
            this.numberOfTasks = 3;
            this.finishedTasks = false;
        }
        

        public void RunGame()
        {

            Console.WriteLine("If you accept the challenge, you will attempt to complete 3 random tasks. If you complete these tasks, you win!");
            Console.WriteLine("Are you ready to start? (Y/N):");

            if (Console.ReadLine() == "n")
            {
                EndGame();
            }

            else
            {
                PlayGame();
                EndGame();
            }

        }
    

        public string EnterPlayerName()
        {
            Console.WriteLine("Enter your player name:");
            return Console.ReadLine();
        }

        public void EndGame()
        {
            if (this.finishedTasks)
            {
                WinMessage();
            }
            else
            {
                LoseMessage();
            }

            if (RetryGame())
            {
                this.playerOne.SetTasks();
                RunGame();
            }
            else
            {
                Console.WriteLine("See you next time, {0}!", this.playerOne.getName());
            }

        }

        public void LoseMessage()
        {
            Console.WriteLine("Sorry, you did not complete 3 tasks.");
        }

        public void WinMessage()
        {
            Console.WriteLine("Awesome, you won the game!");
        }

        public void PlayGame()
        {
             Console.WriteLine("Welcome, {0}!", this.playerOne.getName());

            for (int i = 0; i < this.numberOfTasks; i++)
            {
                this.finishedTasks = this.playerOne.CompleteTask(this.playerOne.ChooseTask());
                if (this.finishedTasks == false)
                {
                    break;
                }
            }
        }

        public bool RetryGame()
        {
            Console.WriteLine("Would you like to play again? Y/N:");
            if (Console.ReadLine() == "y")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
