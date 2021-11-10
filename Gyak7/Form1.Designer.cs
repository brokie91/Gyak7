
namespace Gyak7
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
            this.components = new System.ComponentModel.Container();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMultip = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(41, 45);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(100, 22);
            this.txtOp1.TabIndex = 0;
            this.txtOp1.TextChanged += new System.EventHandler(this.txtOp1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(326, 45);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(100, 22);
            this.txtOp2.TabIndex = 2;
            this.txtOp2.TextChanged += new System.EventHandler(this.txtOp2_TextChanged);
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Location = new System.Drawing.Point(38, 25);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(46, 17);
            this.lblOp1.TabIndex = 3;
            this.lblOp1.Text = "label1";
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Location = new System.Drawing.Point(323, 25);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(46, 17);
            this.lblOp2.TabIndex = 4;
            this.lblOp2.Text = "label2";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(192, 77);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 30);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "button1";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(192, 113);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 30);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "button2";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMultip
            // 
            this.btnMultip.Location = new System.Drawing.Point(192, 149);
            this.btnMultip.Name = "btnMultip";
            this.btnMultip.Size = new System.Drawing.Size(75, 30);
            this.btnMultip.TabIndex = 7;
            this.btnMultip.Text = "button3";
            this.btnMultip.UseVisualStyleBackColor = true;
            this.btnMultip.Click += new System.EventHandler(this.btnMultip_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(192, 185);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 30);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "button4";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(192, 221);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 30);
            this.btnMod.TabIndex = 9;
            this.btnMod.Text = "button5";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(182, 275);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(100, 22);
            this.txtAns.TabIndex = 10;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(86, 275);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(46, 17);
            this.lblAns.TabIndex = 11;
            this.lblAns.Text = "label3";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(41, 375);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "button6";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(351, 375);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 30);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "button7";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMultip);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblOp2);
            this.Controls.Add(this.lblOp1);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMultip;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblOp2;
    }
}

