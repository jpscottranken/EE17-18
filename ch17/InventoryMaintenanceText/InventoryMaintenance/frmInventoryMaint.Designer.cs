namespace InventoryMaintenance
{
    partial class frmInventoryMaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstItems = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 31;
            lstItems.Location = new Point(28, 22);
            lstItems.Margin = new Padding(2);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(476, 438);
            lstItems.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(579, 36);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 76);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnDelete.Location = new Point(579, 206);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 76);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(579, 370);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 76);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInventoryMaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            CancelButton = btnExit;
            ClientSize = new Size(792, 509);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Margin = new Padding(2);
            Name = "frmInventoryMaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Maintenance";
            Load += frmInventoryMaint_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstItems;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
    }
}