namespace test2.forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProperty = new System.Windows.Forms.Button();
            this.buttonPropertyTypes = new System.Windows.Forms.Button();
            this.buttonPropertyImages = new System.Windows.Forms.Button();
            this.buttonOwner = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonSale);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonOwner);
            this.panel1.Controls.Add(this.buttonPropertyImages);
            this.panel1.Controls.Add(this.buttonPropertyTypes);
            this.panel1.Controls.Add(this.buttonProperty);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 443);
            this.panel1.TabIndex = 0;
            // 
            // buttonProperty
            // 
            this.buttonProperty.FlatAppearance.BorderSize = 0;
            this.buttonProperty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProperty.ForeColor = System.Drawing.Color.Black;
            this.buttonProperty.Location = new System.Drawing.Point(0, 3);
            this.buttonProperty.Name = "buttonProperty";
            this.buttonProperty.Size = new System.Drawing.Size(211, 45);
            this.buttonProperty.TabIndex = 0;
            this.buttonProperty.Text = "PipeStock";
            this.buttonProperty.UseVisualStyleBackColor = true;
            this.buttonProperty.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPropertyTypes
            // 
            this.buttonPropertyTypes.FlatAppearance.BorderSize = 0;
            this.buttonPropertyTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPropertyTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPropertyTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPropertyTypes.ForeColor = System.Drawing.Color.Black;
            this.buttonPropertyTypes.Location = new System.Drawing.Point(0, 54);
            this.buttonPropertyTypes.Name = "buttonPropertyTypes";
            this.buttonPropertyTypes.Size = new System.Drawing.Size(211, 45);
            this.buttonPropertyTypes.TabIndex = 0;
            this.buttonPropertyTypes.Text = "Property-Types";
            this.buttonPropertyTypes.UseVisualStyleBackColor = true;
            this.buttonPropertyTypes.Click += new System.EventHandler(this.buttonPropertyTypes_Click);
            // 
            // buttonPropertyImages
            // 
            this.buttonPropertyImages.FlatAppearance.BorderSize = 0;
            this.buttonPropertyImages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPropertyImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPropertyImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPropertyImages.ForeColor = System.Drawing.Color.Black;
            this.buttonPropertyImages.Location = new System.Drawing.Point(0, 105);
            this.buttonPropertyImages.Name = "buttonPropertyImages";
            this.buttonPropertyImages.Size = new System.Drawing.Size(211, 45);
            this.buttonPropertyImages.TabIndex = 0;
            this.buttonPropertyImages.Text = "Property-Images";
            this.buttonPropertyImages.UseVisualStyleBackColor = true;
            // 
            // buttonOwner
            // 
            this.buttonOwner.FlatAppearance.BorderSize = 0;
            this.buttonOwner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOwner.ForeColor = System.Drawing.Color.Black;
            this.buttonOwner.Location = new System.Drawing.Point(0, 156);
            this.buttonOwner.Name = "buttonOwner";
            this.buttonOwner.Size = new System.Drawing.Size(211, 45);
            this.buttonOwner.TabIndex = 0;
            this.buttonOwner.Text = "Owner";
            this.buttonOwner.UseVisualStyleBackColor = true;
            // 
            // buttonClient
            // 
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClient.ForeColor = System.Drawing.Color.Black;
            this.buttonClient.Location = new System.Drawing.Point(0, 207);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(211, 45);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            // 
            // buttonSale
            // 
            this.buttonSale.FlatAppearance.BorderSize = 0;
            this.buttonSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSale.ForeColor = System.Drawing.Color.Black;
            this.buttonSale.Location = new System.Drawing.Point(0, 258);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(211, 45);
            this.buttonSale.TabIndex = 0;
            this.buttonSale.Text = "Fittings";
            this.buttonSale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProperty;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonOwner;
        private System.Windows.Forms.Button buttonPropertyImages;
        private System.Windows.Forms.Button buttonPropertyTypes;
    }
}