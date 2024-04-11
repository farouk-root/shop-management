namespace ShopManagement
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
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BasicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicPanel
            // 
            this.BasicPanel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BasicPanel.Controls.Add(this.label1);
            this.BasicPanel.Controls.Add(this.button1);
            this.BasicPanel.Location = new System.Drawing.Point(1, 1);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(1211, 667);
            this.BasicPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Gestion Shop ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(511, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 116);
            this.button1.TabIndex = 0;
            this.button1.Text = "Let\'s Get Started ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 669);
            this.Controls.Add(this.BasicPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BasicPanel.ResumeLayout(false);
            this.BasicPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BasicPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

