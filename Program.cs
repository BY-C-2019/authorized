using System;

namespace authorized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string      username            = "Coolboy06^";
            string[]    serverPassword      = { "abc", "123", "polen"};
            string      combinedPasswords   = serverPassword[0] + " " + serverPassword[1] + " " +serverPassword[2];
            const int   NR_OF_TRIES_ALLOWED = 5;
            int         triesLeft           = NR_OF_TRIES_ALLOWED;
    
            // If some serverpasswords are equal, exit
            if (serverPassword[0] == serverPassword[1] && serverPassword[0] == serverPassword[2] && serverPassword[1] == serverPassword[2]) {
                Console.WriteLine("ERROR! - Lösenord i servern får inte vara likadana. Gör om gör rätt!");
                return;
            }
            
            Console.WriteLine("Välkommen {0}! En 3-vägs autentisering krävs för att få tillträde till denna server.", username);    
            
            do {
                Console.WriteLine("Lösenord");    

                string[] inputPass = new string[3];
                for (int i = 0; i < inputPass.Length; i++)
                {
                    Console.Write("{0} : ", i +1 );
                    inputPass[i] = Console.ReadLine();    
                }
                
                if (IsAuthorised(inputPass, combinedPasswords)) {
                    Console.WriteLine("\nDu klarade dig förbi 3-vägs autentiseringen! DU ÄR INNE I SERVERN!!!");
                    Console.WriteLine("-insertagicsserverstuffhere");
                    Console.WriteLine("---------------------------\n");
                    break;
                }
                else {
                    triesLeft--;
                    if (triesLeft > 0) {
                        Console.Clear();
                        Console.WriteLine("Fel lösenord {0}. Du har nu {1} försök kvar.", username, triesLeft);
                    }
                    else {
                        Console.WriteLine("Du har angivet fel lösenord {0} gånger. Du kommer nu få smaka bly.", NR_OF_TRIES_ALLOWED);
                        return;
                    }
                }
            } while(triesLeft != 0 );
        }

        static bool IsAuthorised(string[] userInputs, string listOfPasswords)
        { 
            for (int i = 0; i < userInputs.Length; i++)
            {
                if (listOfPasswords.Contains(userInputs[i])) {
                    // Remove the correct password from passwordlist
                    listOfPasswords = listOfPasswords.Replace(userInputs[i], "");
                }
                else {
                    return false;
                }
            }
            return true;
        }
    }
}
