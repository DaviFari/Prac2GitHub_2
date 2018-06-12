namespace WindowsFormsAppGitHub
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Maroon;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.Location = new System.Drawing.Point(544, 119);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(152, 38);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Click";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(544, 234);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(152, 45);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Click";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ChangFormBackColor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
    }
}

