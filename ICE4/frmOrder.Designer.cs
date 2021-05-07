
namespace ICE4
{
    partial class frmOrder
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
            this.txtDonuts = new System.Windows.Forms.TextBox();
            this.txtCoffee = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDonuts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDonuts
            // 
            this.txtDonuts.Location = new System.Drawing.Point(136, 80);
            this.txtDonuts.Name = "txtDonuts";
            this.txtDonuts.Size = new System.Drawing.Size(100, 23);
            this.txtDonuts.TabIndex = 0;
            // 
            // txtCoffee
            // 
            this.txtCoffee.Location = new System.Drawing.Point(136, 122);
            this.txtCoffee.Name = "txtCoffee";
            this.txtCoffee.Size = new System.Drawing.Size(100, 23);
            this.txtCoffee.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(136, 193);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDonuts
            // 
            this.lblDonuts.AutoSize = true;
            this.lblDonuts.Location = new System.Drawing.Point(53, 80);
            this.lblDonuts.Name = "lblDonuts";
            this.lblDonuts.Size = new System.Drawing.Size(45, 15);
            this.lblDonuts.TabIndex = 4;
            this.lblDonuts.Text = "Donuts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coffee";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 42);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 7;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDonuts);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCoffee);
            this.Controls.Add(this.txtDonuts);
            this.Name = "frmOrder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonuts;
        private System.Windows.Forms.TextBox txtCoffee;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDonuts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

