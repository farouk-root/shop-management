namespace GestionShop
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Stock = new System.Windows.Forms.Button();
            this.Produit = new System.Windows.Forms.Button();
            this.Shop = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HomePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HomePanel.Controls.Add(this.button1);
            this.HomePanel.Controls.Add(this.Welcome);
            this.HomePanel.Location = new System.Drawing.Point(181, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(822, 453);
            this.HomePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(342, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Welcome.Location = new System.Drawing.Point(79, 173);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(606, 52);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome To Gestion Shop Application";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Stock);
            this.panel2.Controls.Add(this.Produit);
            this.panel2.Controls.Add(this.Shop);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 308);
            this.panel2.TabIndex = 0;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(23, 250);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(101, 40);
            this.Stock.TabIndex = 3;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // Produit
            // 
            this.Produit.Location = new System.Drawing.Point(23, 176);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(101, 40);
            this.Produit.TabIndex = 2;
            this.Produit.Text = "Produit";
            this.Produit.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            this.Shop.Location = new System.Drawing.Point(23, 98);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(101, 40);
            this.Shop.TabIndex = 1;
            this.Shop.Text = "Shop";
            this.Shop.UseVisualStyleBackColor = true;
            this.Shop.Click += new System.EventHandler(this.Shop_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(23, 25);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(101, 40);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Location = new System.Drawing.Point(23, 18);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 40);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Location = new System.Drawing.Point(18, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 70);
            this.panel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomePanel);
            this.Name = "Form1";
            this.Text = "GestionShop";
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Produit;
        private System.Windows.Forms.Button Shop;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
    }
}

