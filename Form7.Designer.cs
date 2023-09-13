
namespace Agilers
{
    partial class Form7
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
            this.button2.Location = new System.Drawing.Point(753, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 165);
            this.button2.TabIndex = 34;
            this.button2.Text = "Interrupt the current sprint to address it immediately";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(314, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 165);
            this.button1.TabIndex = 33;
            this.button1.Text = "wrong";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn2Q1
            // 
            this.btn2Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2Q1.Location = new System.Drawing.Point(755, 322);
            this.btn2Q1.Name = "btn2Q1";
            this.btn2Q1.Size = new System.Drawing.Size(290, 155);
            this.btn2Q1.TabIndex = 32;
            this.btn2Q1.Text = "Prioritize fixing the bug in the following sprint";
            this.btn2Q1.UseVisualStyleBackColor = true;
            // 
            // btn1Q1
            // 
            this.btn1Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Q1.Location = new System.Drawing.Point(314, 556);
            this.btn1Q1.Name = "btn1Q1";
            this.btn1Q1.Size = new System.Drawing.Size(292, 165);
            this.btn1Q1.TabIndex = 31;
            this.btn1Q1.Text = "Assess the criticality of the bug and make an informed decision based on its impa" +
    "ct.";
            this.btn1Q1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(488, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(326, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 41);
            this.label2.TabIndex = 29;
            this.label2.Text = "During a sprint, a customer reports a critical bug.\n";
            // 
            // aim
            // 
            this.aim.AutoSize = true;
            this.aim.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aim.Location = new System.Drawing.Point(343, 61);
            this.aim.Name = "aim";
            this.aim.Size = new System.Drawing.Size(660, 74);
            this.aim.TabIndex = 28;
            this.aim.Text = "Urgent Bug Report";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 785);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2Q1);
            this.Controls.Add(this.btn1Q1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aim);
            this.Name = "Form7";
            this.Text = "Form7";
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