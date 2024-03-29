using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace UI
{
    public class InventoryService
    {
        /// <summary>
        /// lists the inventory of the store
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="listToPick"></param>
        /// <returns></returns>
         public Inventory SelectAnInventory(string prompt, List<Inventory> listToPick)
        {
            selectCustomer:
            Console.WriteLine(prompt);
            for (int i = 0; i < listToPick.Count; i++)
            {
                Console.WriteLine($"[{i}] {listToPick[i]}");
            }
            string input = Console.ReadLine();
            int parsedInput;

            //pass by reference in, out, ref
            bool parseSuccess = Int32.TryParse(input, out parsedInput);

            //I'm checking to see that parse has been successful
            //and the result stays within the boundary of the index
            if(parseSuccess && parsedInput >= 0 && parsedInput < listToPick.Count)
            {
                return listToPick[parsedInput];
            }
            else {
                Console.WriteLine("invalid input");
                goto selectCustomer;
            }
        }
        /// <summary>
        /// this method will select the id of a store when passed an int parameter
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listToPick"></param>
        /// <returns></returns>
        public Inventory SelectAnInventory1(int id, List<Inventory> listToPick)
        {
            for (int i = 0; i < listToPick.Count; i++)
            {
                Console.WriteLine($"[{i}] {listToPick[i]}");
            }
                return listToPick[id];
        }
    }
}