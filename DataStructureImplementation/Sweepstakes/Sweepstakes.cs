using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> sweepstakes;
        Random r;
        private int _minAge = 18;
        private int _counter = 1;
        public Sweepstakes(string name)
        {
            this.Name = name;
            sweepstakes = new Dictionary<int, Contestant>();
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void RegisterContestant(Contestant contestant)
        {
            if (!sweepstakes.ContainsValue(contestant) && contestant.Age >= _minAge)
            {
                sweepstakes.Add(_counter, contestant);
                _counter++;
            }
            else
            {
                Console.WriteLine($"{contestant.Name}, you are not old enough to register for this sweepstakes. You need to be {_minAge} to register.");
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Name: {contestant.Name}\r\nAge: {contestant.Age}\r\nPhone Number: {contestant.PhoneNumber}");
        }

        public void PickWinner()
        {
            r = new Random();
            int dictIndex = r.Next(1, sweepstakes.Count);
            Console.WriteLine("Picking a winner...");
            Thread.Sleep(2000);
            Console.WriteLine("Drum roll please...");
            Thread.Sleep(2000);
            if (sweepstakes.ContainsKey(dictIndex))
            {
                Contestant value = sweepstakes[dictIndex];
                Console.WriteLine($"Congratulations {value.Name}, you are our winner!");
            }
            
        }
    }
}
