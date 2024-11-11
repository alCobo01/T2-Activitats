using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static bool IsNegative(int numUser)
        {
            return numUser < 0;
        }
        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string SegonMissatge = "No és negatiu";
            const string TercerMissatge = "És negatiu";
            const string MissatgeError = "Format incorrecte";

            int numUser;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                if (IsNegative(numUser)) { 
                    Console.WriteLine(SegonMissatge);

                } else
                {
                    Console.WriteLine(TercerMissatge);
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}