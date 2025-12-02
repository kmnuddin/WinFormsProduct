namespace WinFormsProduct
{
    partial class Form1
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnCustomerClear = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnOrderClear = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.cmbOrderProduct = new System.Windows.Forms.ComboBox();
            this.lblOrderProduct = new System.Windows.Forms.Label();
            this.cmbOrderCustomer = new System.Windows.Forms.ComboBox();
            this.lblOrderCustomer = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCustomers);
            this.tabControlMain.Controls.Add(this.tabProducts);
            this.tabControlMain.Controls.Add(this.tabOrders);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Controls.Add(this.btnCustomerClear);
            this.tabCustomers.Controls.Add(this.btnCustomerDelete);
            this.tabCustomers.Controls.Add(this.btnCustomerUpdate);
            this.tabCustomers.Controls.Add(this.btnCustomerAdd);
            this.tabCustomers.Controls.Add(this.txtCustomerEmail);
            this.tabCustomers.Controls.Add(this.lblCustomerEmail);
            this.tabCustomers.Controls.Add(this.txtCustomerName);
            this.tabCustomers.Controls.Add(this.lblCustomerName);
            this.tabCustomers.Controls.Add(this.txtCustomerId);
            this.tabCustomers.Controls.Add(this.lblCustomerId);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(792, 424);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(8, 140);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(776, 276);
            this.dgvCustomers.TabIndex = 10;
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Location = new System.Drawing.Point(430, 100);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerClear.TabIndex = 9;
            this.btnCustomerClear.Text = "Clear";
            this.btnCustomerClear.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(349, 100);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerDelete.TabIndex = 8;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(268, 100);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerUpdate.TabIndex = 7;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(187, 100);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAdd.TabIndex = 6;
            this.btnCustomerAdd.Text = "Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(100, 70);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerEmail.TabIndex = 5;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(15, 73);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 4;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(100, 44);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 47);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(100, 18);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(80, 20);
            this.txtCustomerId.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(15, 21);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dgvProducts);
            this.tabProducts.Controls.Add(this.btnProductClear);
            this.tabProducts.Controls.Add(this.btnProductDelete);
            this.tabProducts.Controls.Add(this.btnProductUpdate);
            this.tabProducts.Controls.Add(this.btnProductAdd);
            this.tabProducts.Controls.Add(this.txtProductPrice);
            this.tabProducts.Controls.Add(this.lblProductPrice);
            this.tabProducts.Controls.Add(this.txtProductName);
            this.tabProducts.Controls.Add(this.lblProductName);
            this.tabProducts.Controls.Add(this.txtProductId);
            this.tabProducts.Controls.Add(this.lblProductId);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(792, 424);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(8, 140);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(776, 276);
            this.dgvProducts.TabIndex = 10;
            // 
            // btnProductClear
            // 
            this.btnProductClear.Location = new System.Drawing.Point(430, 100);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(75, 23);
            this.btnProductClear.TabIndex = 9;
            this.btnProductClear.Text = "Clear";
            this.btnProductClear.UseVisualStyleBackColor = true;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(349, 100);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 8;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(268, 100);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProductUpdate.TabIndex = 7;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(187, 100);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 6;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(100, 70);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 5;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(15, 73);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(34, 13);
            this.lblProductPrice.TabIndex = 4;
            this.lblProductPrice.Text = "Price:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(100, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(15, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(38, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Name:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(100, 18);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(80, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(15, 21);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(61, 13);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product ID:";
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Controls.Add(this.btnOrderClear);
            this.tabOrders.Controls.Add(this.btnOrderDelete);
            this.tabOrders.Controls.Add(this.btnOrderUpdate);
            this.tabOrders.Controls.Add(this.btnOrderAdd);
            this.tabOrders.Controls.Add(this.cmbOrderProduct);
            this.tabOrders.Controls.Add(this.lblOrderProduct);
            this.tabOrders.Controls.Add(this.cmbOrderCustomer);
            this.tabOrders.Controls.Add(this.lblOrderCustomer);
            this.tabOrders.Controls.Add(this.txtOrderQuantity);
            this.tabOrders.Controls.Add(this.lblOrderQuantity);
            this.tabOrders.Controls.Add(this.dtpOrderDate);
            this.tabOrders.Controls.Add(this.lblOrderDate);
            this.tabOrders.Controls.Add(this.txtOrderId);
            this.tabOrders.Controls.Add(this.lblOrderId);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(792, 424);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(8, 180);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(776, 236);
            this.dgvOrders.TabIndex = 14;
            // 
            // btnOrderClear
            // 
            this.btnOrderClear.Location = new System.Drawing.Point(430, 140);
            this.btnOrderClear.Name = "btnOrderClear";
            this.btnOrderClear.Size = new System.Drawing.Size(75, 23);
            this.btnOrderClear.TabIndex = 13;
            this.btnOrderClear.Text = "Clear";
            this.btnOrderClear.UseVisualStyleBackColor = true;
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(349, 140);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(75, 23);
            this.btnOrderDelete.TabIndex = 12;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.Location = new System.Drawing.Point(268, 140);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnOrderUpdate.TabIndex = 11;
            this.btnOrderUpdate.Text = "Update";
            this.btnOrderUpdate.UseVisualStyleBackColor = true;
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(187, 140);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(75, 23);
            this.btnOrderAdd.TabIndex = 10;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            // 
            // cmbOrderProduct
            // 
            this.cmbOrderProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderProduct.FormattingEnabled = true;
            this.cmbOrderProduct.Location = new System.Drawing.Point(100, 112);
            this.cmbOrderProduct.Name = "cmbOrderProduct";
            this.cmbOrderProduct.Size = new System.Drawing.Size(200, 21);
            this.cmbOrderProduct.TabIndex = 9;
            // 
            // lblOrderProduct
            // 
            this.lblOrderProduct.AutoSize = true;
            this.lblOrderProduct.Location = new System.Drawing.Point(15, 115);
            this.lblOrderProduct.Name = "lblOrderProduct";
            this.lblOrderProduct.Size = new System.Drawing.Size(47, 13);
            this.lblOrderProduct.TabIndex = 8;
            this.lblOrderProduct.Text = "Product:";
            // 
            // cmbOrderCustomer
            // 
            this.cmbOrderCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderCustomer.FormattingEnabled = true;
            this.cmbOrderCustomer.Location = new System.Drawing.Point(100, 85);
            this.cmbOrderCustomer.Name = "cmbOrderCustomer";
            this.cmbOrderCustomer.Size = new System.Drawing.Size(200, 21);
            this.cmbOrderCustomer.TabIndex = 7;
            // 
            // lblOrderCustomer
            // 
            this.lblOrderCustomer.AutoSize = true;
            this.lblOrderCustomer.Location = new System.Drawing.Point(15, 88);
            this.lblOrderCustomer.Name = "lblOrderCustomer";
            this.lblOrderCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblOrderCustomer.TabIndex = 6;
            this.lblOrderCustomer.Text = "Customer:";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(100, 59);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(80, 20);
            this.txtOrderQuantity.TabIndex = 5;
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Location = new System.Drawing.Point(15, 62);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblOrderQuantity.TabIndex = 4;
            this.lblOrderQuantity.Text = "Quantity:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(100, 33);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(100, 20);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(15, 36);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(33, 13);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Date:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(100, 7);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(80, 20);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(15, 10);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(50, 13);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Sales Management";
            this.tabControlMain.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCustomerClear;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnOrderClear;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.ComboBox cmbOrderProduct;
        private System.Windows.Forms.Label lblOrderProduct;
        private System.Windows.Forms.ComboBox cmbOrderCustomer;
        private System.Windows.Forms.Label lblOrderCustomer;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
    }
}
