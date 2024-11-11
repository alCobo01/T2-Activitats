# T2- Activitats
## Exercici 1
```c#
//PRE: El valor que rebri serà un enter
public static bool IsNatural(int numUser)
{
    return numUser > 0; 
}
//CON: Retornarà un booleà depenent si és narutal o no.
```

## Exercici 2
```c#
//PRE:

//CON:
```

## Exercici 3
```c#
//PRE: El valor que rebri serà un enter
public static bool IsNegative(int numUser)
{
    return numUser < 0;
}
//CON: Retornarà un booleà depenent si és negatiu o no.
```

## Exercici 4 - Ampliat amb sobrecàrrega
```c#
//PRE: El valor que rebri serà un enter
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static bool IsInRange(int numUser, int minRangeUser, int maxRangeUser)
        {
            return numUser > minRangeUser && numUser < maxRangeUser;
        }

        public static bool IsInRange(int numUser)
        {
             return numUser > 0 && numUser < 100;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string SegonMissatge = "Introdueix el mínim del rang: ";
            const string TercerMissatge = "Introdueix el màxim del rang: ";
            const string MissatgeIsInRange = "El valor està dins del rang.";
            const string MissatgeNotInRange = "El valor no està dins del rang.";
            const string MissatgeError = "Format incorrecte";

            int numUser, minRangeUser, maxRangeUser;
  
            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.Write(SegonMissatge);
                minRangeUser = Convert.ToInt32(Console.ReadLine()); 
                Console.Write(TercerMissatge);
                maxRangeUser = Convert.ToInt32(Console.ReadLine());
                if (IsInRange(numUser, minRangeUser, maxRangeUser)) {
                    Console.WriteLine(MissatgeIsInRange);
                } else
                {
                    Console.WriteLine(MissatgeNotInRange);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: Retornarà un booleà depenent si és positiu i menor que 100, o no.
```


## Exercici 5
```c#
//PRE: El usuari introduirà un enter 
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static bool IsNatural(int numUser)
        {
            if (numUser < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string MissatgeNatural = "El valor introduït és natural.";
            const string MissatgeNoNatural = "El valor introduït no és natural. Torna a introduïr un altre nombre: ";
            const string MissatgeIntents = "Has superat el nombre d'intents.";
            const string MissatgeError = "Format incorrecte";

            int numUser, attempts = 0;
            bool isValid = false;


            Console.Write(PrimerMissatge);
            try
            {
                while (attempts < 3 && !isValid)
                {
                    numUser = Convert.ToInt32(Console.ReadLine());
                    if (IsNatural(numUser))
                    {
                        Console.WriteLine(MissatgeNatural);
                        isValid = true;
                    }
                    else if (attempts < 2)
                    {
                        Console.Write(MissatgeNoNatural);
                    }
                    attempts++;
                }
                if (attempts == 3)
                {
                    Console.WriteLine(MissatgeIntents);
                }
            }
            catch (Exception) { 
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: El programa retornarà si és natural o no, amb tres intents per fer-ho.
``` 

## Exercici 6
```c#
//PRE: El usuari introduirà un nombre enter.
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static int AbsolutNumber(int numUser)
        {
            return Math.Abs(numUser);
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string MissatgeError = "Format incorrecte";

            int numUser;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El valor absolut de {numUser} és {AbsolutNumber(numUser)}");
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: El programa retornarà el valor absolut del número introduït.
```

## Exercici 7
```c#
//PRE: El mètode rebrà una string
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static string ChangeToLowerOrUpperCase(string userInput)
        {
            if (userInput == userInput.ToLower())
            {
                return userInput.ToUpper();
            }
            else if (userInput == userInput.ToUpper())
            {
                return userInput.ToLower();
            }
            return userInput;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix una frase";
            const string MissatgeError = "Format incorrecte";

            string userInput;

            Console.Write(PrimerMissatge);
            try
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"El teu text transformat és: {ChangeToLowerOrUpperCase(userInput)}");

            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: Retornarà la versió en majúscules o minuscules depenen de l'input.
```

## Exercici 8
```c#
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static (int, int) ExchangeNumbers(int numOneUser, int numTwoUser)
        {
            int rem = 0;
            rem = numOneUser;
            numOneUser = numTwoUser;
            numTwoUser = rem;
            return (numOneUser, numTwoUser);
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix el primer valor: ";
            const string SegonMissatge = "Introdueix el segon valor: ";
            const string MissatgeFinal = "Els teus valors intercanviats són: ";
            const string MissatgeError = "Format incorrecte";

            int numOneUser, numTwoUser;

            Console.Write(PrimerMissatge);
            try
            {
                numOneUser = Convert.ToInt32(Console.ReadLine());
                Console.Write(SegonMissatge);
                numTwoUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{MissatgeFinal}{ExchangeNumbers(numOneUser, numTwoUser)}");
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
```

## Exercici 9
```c#
//PRE:
//CON:
```

## Exercici 10
```c#
//PRE:
//CON:
```

## Exercici 11
```c#
//PRE:
//CON:
```

## Exercici 12
```c#
//PRE:
//CON:
```

## Exercici 13
```c#
//PRE:
//CON:
```

## Exercici 14
```c#
//PRE:
//CON:
```

## Exercici 15
```c#
//PRE:
//CON:
```

## Exercici 16
```c#
//PRE:
//CON:
```

## Exercici 17
```c#
//PRE:
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static int[] StoreNumbersInUndefinedArray()
        {
            const string PrimerMissatge = "Quants valors vols introduïr? ";
            const string MissatgeError = "Format incorrecte";
            int numUser;

            Console.Write(PrimerMissatge);
            try
            {
                do
                {
                    numUser = Convert.ToInt32(Console.ReadLine());
                } while (numUser < 0);
                int[] userNumbers = new int[numUser];
                for (int i = 0; i < userNumbers.Length; i++)
                {
                    userNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                return userNumbers;
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }

        public static void PrintArray(int array)
        {
            foreach (int i in StoreNumbersInUndefinedArray()) 
            { 
                Console.WriteLine(i); 
            }

        }

        public static void Main()
        {
            const string MissatgeError = "Format incorrecte";

            StoreNumbersInUndefinedArray();

        }
    }
}
//CON:
```




