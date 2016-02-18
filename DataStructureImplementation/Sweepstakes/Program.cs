using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes testSweep = new Sweepstakes("Test");
            Contestant contestant1 = new Contestant("Ryan Webb", 25, "3145917157", "me@aol.com");
            Contestant contestant2 = new Contestant("Dave Gold", 29, "4148705309", "fake@gmail.com");
            Contestant contestant3 = new Contestant("Frank Jun", 33, "3214587689", "morefake@yahoo.com");
            //Contestant contestant4 = new Contestant("Jimmy John", 16, "4445558888", "fake@outlook.com");
            testSweep.RegisterContestant(contestant1);
            testSweep.RegisterContestant(contestant2);
            testSweep.RegisterContestant(contestant3);
            //testSweep.RegisterContestant(contestant4);

            testSweep.PickWinner();
            Console.ReadLine();
        }
    }
}
