
namespace Gyak7_2
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
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(22, 25);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(46, 17);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "label1";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(22, 45);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(203, 45);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(203, 25);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(46, 17);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "label2";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(200, 129);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 5;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(200, 109);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(46, 17);
            this.lbC.TabIndex = 4;
            this.lbC.Text = "label3";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(25, 118);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(97, 33);
            this.btnSzamol.TabIndex = 6;
            this.btnSzamol.Text = "button1";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(25, 204);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 33);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "button2";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(200, 204);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(103, 33);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "button3";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 263);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEnd;
    }
}

