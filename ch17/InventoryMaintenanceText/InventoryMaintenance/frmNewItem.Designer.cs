namespace InventoryMaintenance
{
    partial class frmNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtItemNo = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label1.Location = new Point(172, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtItemNo
            // 
            txtItemNo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtItemNo.Location = new Point(392, 95);
            txtItemNo.Margin = new Padding(2);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(193, 38);
            txtItemNo.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDescription.Location = new Point(392, 181);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(193, 38);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label2.Location = new Point(172, 181);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 37);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPrice.Location = new Point(392, 268);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 38);
            txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label3.Location = new Point(172, 268);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 37);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSave.Location = new Point(120, 387);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 76);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCancel.Location = new Point(440, 387);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 76);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            CancelButton = btnCancel;
            ClientSize = new Size(792, 509);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItemNo;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}