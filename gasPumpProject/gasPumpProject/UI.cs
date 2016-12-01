using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class UI
    {
        Store store;
        

        public void mainInterface()
        {
            int userInput;
            bool exitAction = false;
            while (exitAction != true)
            {
                Console.Out.WriteLine("Press 1 to pay with cash.\n Press 2 to pay with card.\n Input: ");
                userInput = Console.Read();

                for(int i =0; i < 4; i++)
                {
                    store.pumps[i].inUse;
                }

                if (userInput == 1)
                {
                    store.prePayPump();
                }
                
                else
                {
                    Console.Out.WriteLine("That input wasn't a recognized input. Please enter a new input.");
                }
                Console.Clear();
            }
        }
    }
}
