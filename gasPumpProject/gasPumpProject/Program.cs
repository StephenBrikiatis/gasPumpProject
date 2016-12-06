using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    //enumerators, because magic numbers are bad
    enum function { success = 0, failure = -1 };
    //pumpState tracks transaction type, both for setting pumpState and for recording transactions
    enum pumpState { card = 0, cash = 1, diagnostics = 2 };

    enum fuelType { regular = 0, premium = 1, super = 2 };

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.openStore();
            UI ui = new UI(store);
            ui.start();
        }
    }
}
