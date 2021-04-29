using System;

namespace Homework_4._2
{
    class Program
    {
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        int Y;
        int N;
        int L;

        int Y;
        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

        int N;
        Console.Writeline("Please input Y or N.");

        int L;
        Console.Writeline("Do you want to process another srquence ? (Y/N) : ");

        Console.Readline();

    }
}
