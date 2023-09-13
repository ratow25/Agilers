
namespace Agilers
{
    partial class Form4
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
            this.btn2Q1 = new System.Windows.Forms.Button();
            this.btn1Q1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2Q1
            // 
            this.btn2Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2Q1.Location = new System.Drawing.Point(722, 385);
            this.btn2Q1.Name = "btn2Q1";
            this.btn2Q1.Size = new System.Drawing.Size(290, 155);
            this.btn2Q1.TabIndex = 11;
            this.btn2Q1.Text = "they can try different communication channels or schedule a face-to-face meeting " +
    "to address the stakeholder\'s concerns";
            this.btn2Q1.UseVisualStyleBackColor = true;
            // 
            // btn1Q1
            // 
            this.btn1Q1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Q1.Location = new System.Drawing.Point(244, 375);
            this.btn1Q1.Name = "btn1Q1";
            this.btn1Q1.Size = new System.Drawing.Size(292, 165);
            this.btn1Q1.TabIndex = 10;
            this.btn1Q1.Text = "Escalate the issue to their Scrum Master or Product Owner for assistance";
            this.btn1Q1.UseVisualStyleBackColor = true;
            this.btn1Q1.Click += new System.EventHandler(this.btn1Q1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(426, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "causing delays and uncertainty.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1023, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "A stakeholder is not responding to emails, calls, or requests for feedback, ";
            // 
            // aim
            // 
            this.aim.AutoSize = true;
            this.aim.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aim.Location = new System.Drawing.Point(191, 86);
            this.aim.Name = "aim";
            this.aim.Size = new System.Drawing.Size(907, 74);
            this.aim.TabIndex = 7;
            this.aim.Text = "Unresponsive Stakeholder";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(244, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 165);
            this.button1.TabIndex = 12;
            this.button1.Text = "wrong";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(720, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 165);
            this.button2.TabIndex = 13;
            this.button2.Text = "wrong";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 789);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2Q1);
            this.Controls.Add(this.btn1Q1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aim);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2Q1;
        private System.Windows.Forms.Button btn1Q1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label aim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}