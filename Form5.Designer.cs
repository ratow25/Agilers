
namespace Agilers
{
    partial class Form5
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2Q1 = new System.Windows.Forms.Button();
            this.btn1Q1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(718, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 165);
            this.button2.TabIndex = 20;
            this.button2.Text = "eject the request to maintain the project\'s original scope.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(242, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 165);
            this.button1.TabIndex = 19;
            this.button1.Text = "wrong";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn2Q1
            // 
            this.btn2Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2Q1.Location = new System.Drawing.Point(720, 385);
            this.btn2Q1.Name = "btn2Q1";
            this.btn2Q1.Size = new System.Drawing.Size(290, 155);
            this.btn2Q1.TabIndex = 18;
            this.btn2Q1.Text = "negotiate a trade-off by postponing another feature";
            this.btn2Q1.UseVisualStyleBackColor = true;
            this.btn2Q1.Click += new System.EventHandler(this.btn2Q1_Click);
            // 
            // btn1Q1
            // 
            this.btn1Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Q1.Location = new System.Drawing.Point(242, 375);
            this.btn1Q1.Name = "btn1Q1";
            this.btn1Q1.Size = new System.Drawing.Size(292, 165);
            this.btn1Q1.TabIndex = 17;
            this.btn1Q1.Text = " accommodate the new feature request";
            this.btn1Q1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(453, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "insisting on adding new features.\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(307, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(778, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "After the project has begun, a significant stakeholder is ";
            // 
            // aim
            // 
            this.aim.AutoSize = true;
            this.aim.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aim.Location = new System.Drawing.Point(453, 76);
            this.aim.Name = "aim";
            this.aim.Size = new System.Drawing.Size(418, 74);
            this.aim.TabIndex = 14;
            this.aim.Text = "Scope Creep";
            this.aim.Click += new System.EventHandler(this.aim_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 825);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2Q1);
            this.Controls.Add(this.btn1Q1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aim);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2Q1;
        private System.Windows.Forms.Button btn1Q1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label aim;
    }
}