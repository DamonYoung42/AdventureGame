using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        string playerName;
        List<string> taskList;
        int taskNumber;

        public Player(string name)
        {
            this.playerName = name;
            this.taskList = new List<string> { "Steal a candy bar", "Hit 100 mph on a Harley", "Take the polar bear plunge", "Skinny dip at Bradford Beach", "Hang from the Miller Park roof for 10 seconds", "Talk to a stranger at the mall", "Smack a stranger on the face", "Go to the grocery store in your pajamas"};
        }


        public string getName()
        {
            return this.playerName;
        }

        public bool CompleteTask(int taskNumber)
        {
            this.taskList.RemoveAt(taskNumber);
            Random random = new Random(DateTime.Now.Millisecond);
            double randomNumber = random.NextDouble();

            if (randomNumber >= 0.5)
            {
                Console.WriteLine("Result: You did it!");
                return true;
            }
            else
            {
                Console.WriteLine("Result: You failed");
                return false;
            }

        }

        public int ChooseTask()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            this.taskNumber = random.Next(0, this.taskList.Count());
            Console.WriteLine("Task: {0}", this.taskList[this.taskNumber]);
            return this.taskNumber;
        }

        public void SetTasks()
        {
            this.taskList = new List<string> { "Steal a candy bar", "Hit 100 mph on a Harley", "Take the polar bear plunge", "Skinny dip at Bradford Beach", "Hang from the Miller Park roof for 10 seconds", "Talk to a stranger at the mall", "Smack a stranger on the face", "Go to the grocery store in your pajamas" };
        }

    }
}
