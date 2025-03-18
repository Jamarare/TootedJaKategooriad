namespace TootedJaKategooriad
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            buttonSave = new Button();
            DataGridViewCategories = new DataGridView();
            categoryIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            DataGridViewProducts = new DataGridView();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(630, 331);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Salvesta";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // DataGridViewCategories
            // 
            DataGridViewCategories.AutoGenerateColumns = false;
            DataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { categoryIDDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn });
            DataGridViewCategories.DataSource = categoryBindingSource;
            DataGridViewCategories.Location = new Point(83, 65);
            DataGridViewCategories.Name = "DataGridViewCategories";
            DataGridViewCategories.Size = new Size(244, 150);
            DataGridViewCategories.TabIndex = 1;
            DataGridViewCategories.SelectionChanged += DataGridViewCategories_SelectionChanged;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // DataGridViewProducts
            // 
            DataGridViewProducts.AutoGenerateColumns = false;
            DataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, categoryIDDataGridViewTextBoxColumn1, categoryDataGridViewTextBoxColumn });
            DataGridViewProducts.DataSource = productBindingSource;
            DataGridViewProducts.Location = new Point(446, 65);
            DataGridViewProducts.Name = "DataGridViewProducts";
            DataGridViewProducts.Size = new Size(259, 150);
            DataGridViewProducts.TabIndex = 2;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn1
            // 
            categoryIDDataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            categoryIDDataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            categoryIDDataGridViewTextBoxColumn1.Name = "categoryIDDataGridViewTextBoxColumn1";
            categoryIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridViewProducts);
            Controls.Add(DataGridViewCategories);
            Controls.Add(buttonSave);
            Name = "MainForm";
            Text = "Tooted ja kategooriad";
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private DataGridView DataGridViewCategories;
        private DataGridView DataGridViewProducts;
        private DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
    }
}
