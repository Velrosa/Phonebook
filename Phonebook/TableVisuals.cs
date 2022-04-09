using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace Phonebook
{
    internal class TableVisuals
    {
        public static void DisplayTable(List<Contact> tableData)
        {
            Console.Clear();
            Console.WriteLine("\n Displaying all results... ");
            
            ConsoleTableBuilder.From(tableData).ExportAndWriteLine();
            
            Console.WriteLine("\n Press any key to return to menu... ");
            Console.ReadKey();
        }
    }
}
