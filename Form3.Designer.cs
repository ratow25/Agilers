
namespace Agilers
{
    partial class Form3
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
            this.aim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1Q1 = new System.Windows.Forms.Button();
            this.btn2Q1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aim
            // 
            this.aim.AutoSize = true;
            this.aim.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aim.Location = new System.Drawing.Point(313, 42);
            this.aim.Name = "aim";
            this.aim.Size = new System.Drawing.Size(798, 74);
            this.aim.TabIndex = 1;
            this.aim.Text = "Changing Requirements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(892, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "A key stakeholder suddenly changes their project requirements, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(385, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "which could impact the project timeline and scope";
            // 
            // btn1Q1
            // 
            this.btn1Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Q1.Location = new System.Drawing.Point(351, 325);
            this.btn1Q1.Name = "btn1Q1";
            this.btn1Q1.Size = new System.Drawing.Size(292, 165);
            this.btn1Q1.TabIndex = 5;
            this.btn1Q1.Text = "Schedule a meeting with the stakeholder to understand the reasons behind the chan" +
    "ge";
            this.btn1Q1.UseVisualStyleBackColor = true;
            this.btn1Q1.Click += new System.EventHandler(this.btn1Q1_Click);
            // 
            // btn2Q1
            // 
            this.btn2Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2Q1.Location = new System.Drawing.Point(821, 539);
            this.btn2Q1.Name = "btn2Q1";
            this.btn2Q1.Size = new System.Drawing.Size(290, 155);
            this.btn2Q1.TabIndex = 6;
            this.btn2Q1.Text = "They can then work collaboratively to assess the impact on the project and adjust" +
    " priorities if necessary.";
            this.btn2Q1.UseVisualStyleBackColor = true;
            this.btn2Q1.Click += new System.EventHandler(this.btn2Q1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(819, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 165);
            this.button1.TabIndex = 7;
            this.button1.Text = "wrong";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(351, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 165);
            this.button2.TabIndex = 8;
            this.button2.Text = "wrong";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 777);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2Q1);
            this.Controls.Add(this.btn1Q1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aim);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label aim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1Q1;
        private System.Windows.Forms.Button btn2Q1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}