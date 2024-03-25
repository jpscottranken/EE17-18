using System.IO;

namespace InventoryMaintenance
{
	public static class InventoryDB
	{
		private const string Path = @"..\..\..\InventoryItems.txt";
        private const string Delimiter = "|";

        public static List<InventoryItem> GetItems()
		{
            // create the list
            List<InventoryItem> items = new();

            // Add code here to read the text file into the List<InventoryItem> object.
            //  Create the object for the input stream for a text file
            using StreamReader textIn =
                new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            //  Read the dat from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split(Delimiter);

                if (columns.Length == 3)
                {
                    InventoryItem item = new InventoryItem()
                    {
                        ItemNo = Convert.ToInt32(columns[0]),
                        Description = columns[1],
                        Price = Convert.ToDecimal(columns[2])
                    };

                    //  Add current item to the item list
                    items.Add(item);
                }
            }

            return items;
		}

		public static void SaveItems(List<InventoryItem> items)
		{
            // Add code here to write the List<InventoryItems> object to a text file.
            //  Creat the output stream for a text file that exists
            using StreamWriter textOut = new StreamWriter(
                                new FileStream(Path, FileMode.Create, FileAccess.Write));

            //  Write out each item
            foreach (InventoryItem item in items)
            {
                textOut.Write(item.ItemNo + Delimiter);
                textOut.Write(item.Description + Delimiter);
                textOut.WriteLine(item.Price);
            }
        }
    }
}