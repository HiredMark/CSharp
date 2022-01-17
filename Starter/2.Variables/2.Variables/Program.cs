using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Gareth";
            int characterAge = 42;
            bool isTrainer = true;
            char surnameInitial = 'D';
            double percentage = 99.99D;

            Console.WriteLine("There was a man named " + characterName + " " + surnameInitial + ". It is " + isTrainer + " that he was a trainer" + " he was mean " + percentage + "%  of the time.");
            Console.ReadLine();
        }
    }
}