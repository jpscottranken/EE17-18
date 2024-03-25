/*
 *      Extra 17-1 Work with a text file
 *      
 *      In this exercise, you'll add code to an Inventory Maintenance app 
 *      that reads data from and writes data to a text file.
 *      
 *      1.  Open the InventoryMaintenance project in the ExtraStarts\Ch17\ InventoryMaintenanceText 
 *          directory, and display the code for the InventoryDB class.
 *      
 *      2.  Add code to the GetItems() method that creates a StreamReader object with a 
 *          FileStream object for the InventoryItems.txt file that's included in the project. 
 *          (The Path constant contains the path to this file.) The file should be opened if 
 *          it exists or created if it doesn’t exist, and it should be opened for reading only.
 *     
 *     3.   Add code that reads each record of the text file, stores the fields, which are 
 *          separated by pipe characters, in an InventoryItem object, and adds the object 
 *          to the List<InventoryItem> object. Then, close the StreamReader object.
 *          
 *     4.   Add code to the SaveItems() method that creates a StreamWriter object with a 
 *          FileStream object for the InventoryItems.txt file. The file should be created 
 *          if it doesn't exist or overwritten if it does exist, and it should be opened 
 *          for writing only.
 *          
 *     5.  Add code that writes each InventoryItem object in the List<InventoryItem> object 
 *          to the text file, separating the fields with pipe characters. Then, close the 
 *          StreamWriter object.
 *          
 *     6.   Test the app to be sure it works correctly.
 *     
 *     7.   Update the GetItems() and SaveItems() methods to use using declarations to 
 *          automatically close the StreamReader and StreamWriter objects. Then, delete 
 *          the statements that explicitly close these objects.
 *          
 *     8. Test the app again to be sure it works correctly.
 */

namespace InventoryMaintenance
{

    public partial class frmInventoryMaint : Form
    {
        public frmInventoryMaint()
        {
            InitializeComponent();
        }

        private List<InventoryItem> items = null!;

        private void frmInventoryMaint_Load(object sender, EventArgs e)
        {
            items = InventoryDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InventoryItem item in items)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new();
            InventoryItem item = newItemForm.GetNewItem();
            if (item != null)
            {
                items.Add(item);
                InventoryDB.SaveItems(items);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;

            if (i == -1)
            {
                MessageBox.Show("Please select an item to delete.", "No item selected");
            }
            else
            {
                InventoryItem item = items[i];

                string message = $"Are you sure you want to delete {item.Description}?";
                DialogResult result =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    items.Remove(item);
                    InventoryDB.SaveItems(items);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}