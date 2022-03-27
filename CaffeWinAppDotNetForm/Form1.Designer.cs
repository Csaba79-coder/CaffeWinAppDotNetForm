namespace CaffeWinAppDotNetForm
{
    partial class Form1
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
            this.textBoxCaffee = new System.Windows.Forms.TextBox();
            this.labelHUF = new System.Windows.Forms.Label();
            this.buttonCaffee = new System.Windows.Forms.Button();
            this.buttonExtraSugar = new System.Windows.Forms.Button();
            this.buttonExtraMilk = new System.Windows.Forms.Button();
            this.buttonExtraCream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCaffee
            // 
            this.textBoxCaffee.Location = new System.Drawing.Point(270, 91);
            this.textBoxCaffee.Name = "textBoxCaffee";
            this.textBoxCaffee.Size = new System.Drawing.Size(257, 23);
            this.textBoxCaffee.TabIndex = 0;
            this.textBoxCaffee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelHUF
            // 
            this.labelHUF.AutoSize = true;
            this.labelHUF.Location = new System.Drawing.Point(549, 99);
            this.labelHUF.Name = "labelHUF";
            this.labelHUF.Size = new System.Drawing.Size(30, 15);
            this.labelHUF.TabIndex = 1;
            this.labelHUF.Text = "HUF";
            // 
            // buttonCaffee
            // 
            this.buttonCaffee.Location = new System.Drawing.Point(292, 135);
            this.buttonCaffee.Name = "buttonCaffee";
            this.buttonCaffee.Size = new System.Drawing.Size(167, 23);
            this.buttonCaffee.TabIndex = 2;
            this.buttonCaffee.Text = "Caffee 120 Ft";
            this.buttonCaffee.UseVisualStyleBackColor = true;
            this.buttonCaffee.Click += new System.EventHandler(this.buttonCaffee_Click);
            // 
            // buttonExtraSugar
            // 
            this.buttonExtraSugar.Location = new System.Drawing.Point(292, 164);
            this.buttonExtraSugar.Name = "buttonExtraSugar";
            this.buttonExtraSugar.Size = new System.Drawing.Size(167, 23);
            this.buttonExtraSugar.TabIndex = 3;
            this.buttonExtraSugar.Text = "Extra Sugar + 20 Ft";
            this.buttonExtraSugar.UseVisualStyleBackColor = true;
            this.buttonExtraSugar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExtraMilk
            // 
            this.buttonExtraMilk.Location = new System.Drawing.Point(292, 193);
            this.buttonExtraMilk.Name = "buttonExtraMilk";
            this.buttonExtraMilk.Size = new System.Drawing.Size(167, 23);
            this.buttonExtraMilk.TabIndex = 4;
            this.buttonExtraMilk.Text = "Extra Milk + 30 Ft";
            this.buttonExtraMilk.UseVisualStyleBackColor = true;
            this.buttonExtraMilk.Click += new System.EventHandler(this.buttonExtraMilk_Click);
            // 
            // buttonExtraCream
            // 
            this.buttonExtraCream.Location = new System.Drawing.Point(292, 222);
            this.buttonExtraCream.Name = "buttonExtraCream";
            this.buttonExtraCream.Size = new System.Drawing.Size(167, 23);
            this.buttonExtraCream.TabIndex = 5;
            this.buttonExtraCream.Text = "Extra Cream + 50 Ft";
            this.buttonExtraCream.UseVisualStyleBackColor = true;
            this.buttonExtraCream.Click += new System.EventHandler(this.buttonExtraCream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExtraCream);
            this.Controls.Add(this.buttonExtraMilk);
            this.Controls.Add(this.buttonExtraSugar);
            this.Controls.Add(this.buttonCaffee);
            this.Controls.Add(this.labelHUF);
            this.Controls.Add(this.textBoxCaffee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCaffee;
        private Label labelHUF;
        private Button buttonCaffee;
        private Button buttonExtraSugar;
        private Button buttonExtraMilk;
        private Button buttonExtraCream;
    }
}