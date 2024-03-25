/*
 *      In this exercise, you'll use LINQ to update the Inventory Maintenance app 
 *      so it displays the inventory items in alphabetical order by description, 
 *      and so it can filter the inventory items by price.
 *      
 *      Review the starting code:
 *      
 *      1.  Open the InventoryMaintenance project in the ExtraStarts\Ch18 directory.
 *      
 *      2.  Display the code for the Inventory Maintenance form and review the code that 
 *          loads the items in the combo box and the code that executes when the selected 
 *          item in the combo box is changed.
 *      
 *      3.  Run the app and view the items in the combo box. Notice that nothing happens 
 *          when you change the selected item. Exit the app.
 *      
 *          Add code that sorts and filters the inventory items:
 *      
 *      4.  Find the FillItemListBox() method in the Inventory Maintenance form. 
 *          It starts by storing the selected value of the combo box in a variable named 
 *          filter and declaring a local collection of InventoryItem objects named filteredItems.
 *          
 *      Note:   This local collection is of the IEnumerable<InventoryItem> type. 
 *              That's because LINQ queries return IEnumerable<T> collections (see figure 18-2).
 *              
 *      5.  Code an if/else statement that uses LINQ to query the class-level collection named 
 *          items based on the value of the filter variable. The LINQ queries should also order 
 *          the inventory items by Description. Assign the result of each LINQ query to the 
 *          filteredItems collection.
 *      
 *      Note:   You can use method-based queries or query expressions here.
 *      
 *      6.  Update the foreach statement so it loops through the local filteredItems 
 *          collection rather than the class-level items collection.
 *      
 *      7.  Test the app to be sure it displays the items in alphabetical order and filters the 
 *          items by price when the selected item in the combo box changes.
 *      
 *      8. Add the following new item to the inventory:
 *      
 *          ItemNo: 4372639 Description: Creeping Phlox Price: 24.99
 *      
 *      Notice that the new item is sorted so it appears alphabetically in the display. 
 *      Use the combo box to show items whose price is between $10 and $50, and see that 
 *      the new item is displayed. When you're done, exit the app.
 *      
 *      9.  Open the InventoryItems.txt file and see that the items aren't in alphabetical order, 
 *          and that the item you just added is the last item in the file.
 *      
 *      Add code that uses LINQ to find the inventory item to delete.
 *      
 *      10. Run the app, select the item you added in step 9, and click Delete. 
 *          Note that the confirmation message identifies the wrong item for deletion. 
 *          Click Cancel and exit the app.
 *      
 *      11. Display the btnDelete_Click() event handler in the Inventory Maintenance form 
 *          and comment out the line of code that uses the selected index value of the 
 *          ListView control to get the selected InventoryItem object from the items collection.
 *      
 *      12. Add code that uses that selected index value to retrieve the display text of the 
 *          selected item from the Items collection of the ListView control.
 *      
 *      13. Use a LINQ query to get the selected InventoryItem object from the items collection. 
 *          The LINQ query should select the item whose GetDisplayText() method returns a value 
 *          equal to the display text value you just retrieved.
 *      
 *      Note:   To do this, you need to use the First() or FirstOrDefault() method. 
 *              Because of that, you should code this as a method-based query.
 *      
 *      14. Run the app and try to delete the item you added in step 9. This time, the confirm 
 *          message should present the correct inventory item. Click OK to delete the item and 
 *          then exit the app.
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
            LoadComboBox();
            FillItemListBox();
        }

        private void LoadComboBox()
        {
            cboFilterBy.DataSource = new string[] {
                "All", "Under $10", "$10 to $50", "Over $50"
            };
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();

            string filter = cboFilterBy.SelectedValue?.ToString() ?? "";
            IEnumerable<InventoryItem> filteredItems = null!;

            //  Add items to the filteredItems collection based on FilterBy value
            //  These are using query expressions
            if (filter == "All")
            {
                filteredItems =
                        from item in items
                        orderby item.Description
                        select item;
            }
            else if (filter == "Under $10")
            {
                filteredItems =
                        from item in items
                        where item.Price < 10
                        orderby item.Description
                        select item;
            }
            else if (filter == "$10 to $50")
            {
                filteredItems =
                        from item in items
                        where item.Price >= 10 && item.Price <= 50
                        orderby item.Description
                        select item;
            }
            else if (filter == "Over $50")
            {
                filteredItems =
                        from item in items
                        where item.Price > 50
                        orderby item.Description
                        select item;
            }

            // change code to loop the filteredItems collection
            foreach (InventoryItem item in filteredItems)
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
                //InventoryItem item = items[i];

                //string message = $"Are you sure you want to delete {item.Description}?";
                string displayText = lstItems.Items[i].ToString()!;

                InventoryItem item = items
                            .Where(item => item.GetDisplayText() == displayText)
                            .FirstOrDefault()!;

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

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemListBox();
        }
    }
}