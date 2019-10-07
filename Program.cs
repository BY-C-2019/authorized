using System;

namespace authorized
{
    class Program
    {
        // huvud bool
        static bool authorized = false;

        // håller koll på om ett lösenord har matats in korrekt
        static bool password1Correct = false;
        static bool password2Correct = false;
        static bool password3Correct = false;

        static void Main(string[] args)
        {
            Console.Clear();

            // kalla på metoden, ta emot true/false
            authorized = isAuthorized();

            if (authorized)
            {
                Console.WriteLine("Kom in.");
            }
            else
            {
                Console.WriteLine("Du kommer inte in.");
            }
        }

        static bool isAuthorized()
        {
            string userInput;
            int triesToAutorize = 5;

            // så länge det finns försök kvar och inte alla tre lösen stämmer
            while (triesToAutorize > 0 && !authorized)
            {
                // om alla tre stämmer
                if (password1Correct && password2Correct && password3Correct)
                {
                    authorized = true;
                }
                else
                {
                    Console.Write("Ange lösenord: ");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        // password 1
                        case "piggy":
                            Console.WriteLine("Korrekt.");
                            password1Correct = true;
                            break;

                        // password 2
                        case "snuff":
                            Console.WriteLine("Korrekt.");
                            password2Correct = true;
                            break;

                        // password 3
                        case "bark":
                            Console.WriteLine("Korrekt.");
                            password3Correct = true;
                            break;

                        // felaktig inmatning
                        default:
                            triesToAutorize--;
                            Console.WriteLine("Fel. Du har {0} försök kvar.", triesToAutorize);
                            break;
                    }
                }
            }
            return authorized;
        }
    }
}