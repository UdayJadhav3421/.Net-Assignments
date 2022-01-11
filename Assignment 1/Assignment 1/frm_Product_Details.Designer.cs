namespace Assignment_1
{
    partial class frm_Product_Details
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Product_Details = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Management_System_DBDataSet = new Assignment_1.Product_Management_System_DBDataSet();
            this.lbl_Product_Details = new System.Windows.Forms.Label();
            this.btn_Add_New_Product = new System.Windows.Forms.Button();
            this.tbl_Product_DetailsTableAdapter = new Assignment_1.Product_Management_System_DBDataSetTableAdapters.Tbl_Product_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Product_Details
            // 
            this.dgv_Product_Details.AllowUserToAddRows = false;
            this.dgv_Product_Details.AllowUserToDeleteRows = false;
            this.dgv_Product_Details.AutoGenerateColumns = false;
            this.dgv_Product_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Details.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.purchaePriceDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn});
            this.dgv_Product_Details.DataSource = this.tblProductDetailsBindingSource;
            this.dgv_Product_Details.Location = new System.Drawing.Point(21, 92);
            this.dgv_Product_Details.Name = "dgv_Product_Details";
            this.dgv_Product_Details.ReadOnly = true;
            this.dgv_Product_Details.Size = new System.Drawing.Size(840, 359);
            this.dgv_Product_Details.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaePriceDataGridViewTextBoxColumn
            // 
            this.purchaePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchae_Price";
            this.purchaePriceDataGridViewTextBoxColumn.HeaderText = "Purchae_Price";
            this.purchaePriceDataGridViewTextBoxColumn.Name = "purchaePriceDataGridViewTextBoxColumn";
            this.purchaePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "Sales_Price";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "Sales_Price";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblProductDetailsBindingSource
            // 
            this.tblProductDetailsBindingSource.DataMember = "Tbl_Product_Details";
            this.tblProductDetailsBindingSource.DataSource = this.product_Management_System_DBDataSet;
            // 
            // product_Management_System_DBDataSet
            // 
            this.product_Management_System_DBDataSet.DataSetName = "Product_Management_System_DBDataSet";
            this.product_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Product_Details
            // 
            this.lbl_Product_Details.AutoSize = true;
            this.lbl_Product_Details.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Product_Details.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Details.ForeColor = System.Drawing.Color.Red;
            this.lbl_Product_Details.Location = new System.Drawing.Point(268, 26);
            this.lbl_Product_Details.Name = "lbl_Product_Details";
            this.lbl_Product_Details.Size = new System.Drawing.Size(342, 50);
            this.lbl_Product_Details.TabIndex = 2;
            this.lbl_Product_Details.Text = "Product Details";
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add_New_Product.Location = new System.Drawing.Point(315, 457);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.Size = new System.Drawing.Size(259, 42);
            this.btn_Add_New_Product.TabIndex = 12;
            this.btn_Add_New_Product.Text = "Add New Product";
            this.btn_Add_New_Product.UseVisualStyleBackColor = true;
            this.btn_Add_New_Product.Click += new System.EventHandler(this.btn_Add_New_Product_Click);
            // 
            // tbl_Product_DetailsTableAdapter
            // 
            this.tbl_Product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btn_Add_New_Product);
            this.Controls.Add(this.lbl_Product_Details);
            this.Controls.Add(this.dgv_Product_Details);
            this.Name = "frm_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Product_Details";
            this.Load += new System.EventHandler(this.frm_Product_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Product_Details;
        private System.Windows.Forms.Label lbl_Product_Details;
        private System.Windows.Forms.Button btn_Add_New_Product;
        private Product_Management_System_DBDataSet product_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource tblProductDetailsBindingSource;
        private Product_Management_System_DBDataSetTableAdapters.Tbl_Product_DetailsTableAdapter tbl_Product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
    }
}