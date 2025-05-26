namespace DotNetTraining
{
    partial class ProductList
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
            dgvData = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colProductPrice = new DataGridViewTextBoxColumn();
            colProductQuantity = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtProductname = new TextBox();
            label2 = new Label();
            txtProductprice = new TextBox();
            label3 = new Label();
            txtProductquantity = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colProductName, colProductPrice, colProductQuantity });
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 357);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1009, 303);
            dgvData.TabIndex = 0;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 125;
            // 
            // colProductPrice
            // 
            colProductPrice.DataPropertyName = "Price";
            colProductPrice.HeaderText = "Product Price";
            colProductPrice.MinimumWidth = 6;
            colProductPrice.Name = "colProductPrice";
            colProductPrice.ReadOnly = true;
            colProductPrice.Width = 125;
            // 
            // colProductQuantity
            // 
            colProductQuantity.DataPropertyName = "Quantity";
            colProductQuantity.HeaderText = "Product Quantity";
            colProductQuantity.MinimumWidth = 6;
            colProductQuantity.Name = "colProductQuantity";
            colProductQuantity.ReadOnly = true;
            colProductQuantity.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // txtProductname
            // 
            txtProductname.Location = new Point(20, 40);
            txtProductname.Name = "txtProductname";
            txtProductname.Size = new Size(341, 27);
            txtProductname.TabIndex = 2;
            txtProductname.KeyDown += txtProductname_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Product Price";
            // 
            // txtProductprice
            // 
            txtProductprice.Location = new Point(20, 106);
            txtProductprice.Name = "txtProductprice";
            txtProductprice.Size = new Size(341, 27);
            txtProductprice.TabIndex = 4;
            txtProductprice.KeyDown += txtProductprice_KeyDown;
            txtProductprice.KeyPress += txtProductprice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 147);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 5;
            label3.Text = "Product Quantity";
            // 
            // txtProductquantity
            // 
            txtProductquantity.Location = new Point(20, 170);
            txtProductquantity.Name = "txtProductquantity";
            txtProductquantity.Size = new Size(341, 27);
            txtProductquantity.TabIndex = 6;
            txtProductquantity.TextChanged += txtProductquantity_TextChanged;
            txtProductquantity.KeyDown += txtProductquantity_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(20, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 43);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(169, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(871, 6);
            button1.Name = "button1";
            button1.Size = new Size(126, 42);
            button1.TabIndex = 9;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 660);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtProductquantity);
            Controls.Add(label3);
            Controls.Add(txtProductprice);
            Controls.Add(label2);
            Controls.Add(txtProductname);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Name = "ProductList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductList";
            Load += ProductList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label label1;
        private TextBox txtProductname;
        private Label label2;
        private TextBox txtProductprice;
        private Label label3;
        private TextBox txtProductquantity;
        private Button btnCancel;
        private Button btnSave;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colProductPrice;
        private DataGridViewTextBoxColumn colProductQuantity;
        private Button button1;
    }
}