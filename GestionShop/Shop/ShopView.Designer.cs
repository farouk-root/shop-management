namespace GestionShop.Shop
{
    partial class ShopView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.text_idShop = new System.Windows.Forms.TextBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_localisation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_NomShop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMESHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONSHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONESHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mLR21DBDataSet = new GestionShop.MLR21DBDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AddShopButton = new System.Windows.Forms.Button();
            this.UpdateShopButton = new System.Windows.Forms.Button();
            this.DeleteShopButton = new System.Windows.Forms.Button();
            this.ShowShops = new System.Windows.Forms.Button();
            this.sHOPTableAdapter = new GestionShop.MLR21DBDataSetTableAdapters.SHOPTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResetShopButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mLR21DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Shop";
            // 
            // text_idShop
            // 
            this.text_idShop.Location = new System.Drawing.Point(172, 18);
            this.text_idShop.Name = "text_idShop";
            this.text_idShop.Size = new System.Drawing.Size(141, 22);
            this.text_idShop.TabIndex = 1;
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(172, 144);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(141, 22);
            this.text_phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // text_localisation
            // 
            this.text_localisation.Location = new System.Drawing.Point(172, 100);
            this.text_localisation.Name = "text_localisation";
            this.text_localisation.Size = new System.Drawing.Size(141, 22);
            this.text_localisation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localisation";
            // 
            // text_NomShop
            // 
            this.text_NomShop.Location = new System.Drawing.Point(172, 60);
            this.text_NomShop.Name = "text_NomShop";
            this.text_NomShop.Size = new System.Drawing.Size(141, 22);
            this.text_NomShop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.text_localisation);
            this.panel1.Controls.Add(this.text_NomShop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.text_idShop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text_phone);
            this.panel1.Location = new System.Drawing.Point(3, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 187);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 65);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Shop Crud";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(350, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 269);
            this.panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSHOPDataGridViewTextBoxColumn,
            this.nAMESHOPDataGridViewTextBoxColumn,
            this.lOCATIONSHOPDataGridViewTextBoxColumn,
            this.pHONESHOPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sHOPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.getShopData_RowClick);
            // 
            // iDSHOPDataGridViewTextBoxColumn
            // 
            this.iDSHOPDataGridViewTextBoxColumn.DataPropertyName = "IDSHOP";
            this.iDSHOPDataGridViewTextBoxColumn.HeaderText = "IDSHOP";
            this.iDSHOPDataGridViewTextBoxColumn.Name = "iDSHOPDataGridViewTextBoxColumn";
            // 
            // nAMESHOPDataGridViewTextBoxColumn
            // 
            this.nAMESHOPDataGridViewTextBoxColumn.DataPropertyName = "NAMESHOP";
            this.nAMESHOPDataGridViewTextBoxColumn.HeaderText = "NAMESHOP";
            this.nAMESHOPDataGridViewTextBoxColumn.Name = "nAMESHOPDataGridViewTextBoxColumn";
            // 
            // lOCATIONSHOPDataGridViewTextBoxColumn
            // 
            this.lOCATIONSHOPDataGridViewTextBoxColumn.DataPropertyName = "LOCATIONSHOP";
            this.lOCATIONSHOPDataGridViewTextBoxColumn.HeaderText = "LOCATIONSHOP";
            this.lOCATIONSHOPDataGridViewTextBoxColumn.Name = "lOCATIONSHOPDataGridViewTextBoxColumn";
            // 
            // pHONESHOPDataGridViewTextBoxColumn
            // 
            this.pHONESHOPDataGridViewTextBoxColumn.DataPropertyName = "PHONESHOP";
            this.pHONESHOPDataGridViewTextBoxColumn.HeaderText = "PHONESHOP";
            this.pHONESHOPDataGridViewTextBoxColumn.Name = "pHONESHOPDataGridViewTextBoxColumn";
            // 
            // sHOPBindingSource
            // 
            this.sHOPBindingSource.DataMember = "SHOP";
            this.sHOPBindingSource.DataSource = this.mLR21DBDataSet;
            // 
            // mLR21DBDataSet
            // 
            this.mLR21DBDataSet.DataSetName = "MLR21DBDataSet";
            this.mLR21DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(656, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 22);
            this.textBox5.TabIndex = 9;
            // 
            // AddShopButton
            // 
            this.AddShopButton.Location = new System.Drawing.Point(247, 314);
            this.AddShopButton.Name = "AddShopButton";
            this.AddShopButton.Size = new System.Drawing.Size(97, 43);
            this.AddShopButton.TabIndex = 10;
            this.AddShopButton.Text = "Add";
            this.AddShopButton.UseVisualStyleBackColor = true;
            this.AddShopButton.Click += new System.EventHandler(this.AddShopButton_Click);
            // 
            // UpdateShopButton
            // 
            this.UpdateShopButton.Location = new System.Drawing.Point(135, 314);
            this.UpdateShopButton.Name = "UpdateShopButton";
            this.UpdateShopButton.Size = new System.Drawing.Size(97, 43);
            this.UpdateShopButton.TabIndex = 11;
            this.UpdateShopButton.Text = "Update";
            this.UpdateShopButton.UseVisualStyleBackColor = true;
            this.UpdateShopButton.Click += new System.EventHandler(this.UpdateShopButton_Click);
            // 
            // DeleteShopButton
            // 
            this.DeleteShopButton.Location = new System.Drawing.Point(386, 396);
            this.DeleteShopButton.Name = "DeleteShopButton";
            this.DeleteShopButton.Size = new System.Drawing.Size(97, 43);
            this.DeleteShopButton.TabIndex = 13;
            this.DeleteShopButton.Text = "Delete";
            this.DeleteShopButton.UseVisualStyleBackColor = true;
            this.DeleteShopButton.Click += new System.EventHandler(this.DeleteShopButton_Click);
            // 
            // ShowShops
            // 
            this.ShowShops.Location = new System.Drawing.Point(503, 396);
            this.ShowShops.Name = "ShowShops";
            this.ShowShops.Size = new System.Drawing.Size(97, 43);
            this.ShowShops.TabIndex = 14;
            this.ShowShops.Text = "Show";
            this.ShowShops.UseVisualStyleBackColor = true;
            this.ShowShops.Click += new System.EventHandler(this.ShowShops_Click);
            // 
            // sHOPTableAdapter
            // 
            this.sHOPTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Name",
            "Localisation"});
            this.comboBox1.Location = new System.Drawing.Point(419, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // ResetShopButton
            // 
            this.ResetShopButton.Location = new System.Drawing.Point(21, 314);
            this.ResetShopButton.Name = "ResetShopButton";
            this.ResetShopButton.Size = new System.Drawing.Size(97, 43);
            this.ResetShopButton.TabIndex = 12;
            this.ResetShopButton.Text = "Reset";
            this.ResetShopButton.UseVisualStyleBackColor = true;
            // 
            // ShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ShowShops);
            this.Controls.Add(this.DeleteShopButton);
            this.Controls.Add(this.ResetShopButton);
            this.Controls.Add(this.UpdateShopButton);
            this.Controls.Add(this.AddShopButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShopView";
            this.Size = new System.Drawing.Size(822, 453);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mLR21DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_idShop;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_localisation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_NomShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button AddShopButton;
        private System.Windows.Forms.Button UpdateShopButton;
        private System.Windows.Forms.Button DeleteShopButton;
        private System.Windows.Forms.Button ShowShops;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMESHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONSHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONESHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sHOPBindingSource;
        private MLR21DBDataSet mLR21DBDataSet;
        private MLR21DBDataSetTableAdapters.SHOPTableAdapter sHOPTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ResetShopButton;
    }
}
