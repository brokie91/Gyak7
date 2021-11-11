
namespace Gyak7_3
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
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtSzamtani = new System.Windows.Forms.TextBox();
            this.txtMertani = new System.Windows.Forms.TextBox();
            this.txtHarmonikus = new System.Windows.Forms.TextBox();
            this.lbSzamtani = new System.Windows.Forms.Label();
            this.lbMertani = new System.Windows.Forms.Label();
            this.lbHarmonikus = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnVege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(19, 25);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(46, 17);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "label1";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(211, 25);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(46, 17);
            this.lbY.TabIndex = 1;
            this.lbY.Text = "label2";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(22, 45);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 2;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(214, 45);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 3;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // txtSzamtani
            // 
            this.txtSzamtani.Location = new System.Drawing.Point(118, 111);
            this.txtSzamtani.Name = "txtSzamtani";
            this.txtSzamtani.Size = new System.Drawing.Size(100, 22);
            this.txtSzamtani.TabIndex = 4;
            // 
            // txtMertani
            // 
            this.txtMertani.Location = new System.Drawing.Point(118, 139);
            this.txtMertani.Name = "txtMertani";
            this.txtMertani.Size = new System.Drawing.Size(100, 22);
            this.txtMertani.TabIndex = 5;
            // 
            // txtHarmonikus
            // 
            this.txtHarmonikus.Location = new System.Drawing.Point(118, 167);
            this.txtHarmonikus.Name = "txtHarmonikus";
            this.txtHarmonikus.Size = new System.Drawing.Size(100, 22);
            this.txtHarmonikus.TabIndex = 6;
            // 
            // lbSzamtani
            // 
            this.lbSzamtani.AutoSize = true;
            this.lbSzamtani.Location = new System.Drawing.Point(19, 111);
            this.lbSzamtani.Name = "lbSzamtani";
            this.lbSzamtani.Size = new System.Drawing.Size(46, 17);
            this.lbSzamtani.TabIndex = 7;
            this.lbSzamtani.Text = "label2";
            // 
            // lbMertani
            // 
            this.lbMertani.AutoSize = true;
            this.lbMertani.Location = new System.Drawing.Point(19, 139);
            this.lbMertani.Name = "lbMertani";
            this.lbMertani.Size = new System.Drawing.Size(46, 17);
            this.lbMertani.TabIndex = 8;
            this.lbMertani.Text = "label2";
            // 
            // lbHarmonikus
            // 
            this.lbHarmonikus.AutoSize = true;
            this.lbHarmonikus.Location = new System.Drawing.Point(19, 167);
            this.lbHarmonikus.Name = "lbHarmonikus";
            this.lbHarmonikus.Size = new System.Drawing.Size(46, 17);
            this.lbHarmonikus.TabIndex = 9;
            this.lbHarmonikus.Text = "label2";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(49, 216);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 35);
            this.btnSzamol.TabIndex = 10;
            this.btnSzamol.Text = "button1";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(130, 216);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 35);
            this.btnTorles.TabIndex = 11;
            this.btnTorles.Text = "button2";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnVege
            // 
            this.btnVege.Location = new System.Drawing.Point(211, 216);
            this.btnVege.Name = "btnVege";
            this.btnVege.Size = new System.Drawing.Size(75, 35);
            this.btnVege.TabIndex = 12;
            this.btnVege.Text = "button3";
            this.btnVege.UseVisualStyleBackColor = true;
            this.btnVege.Click += new System.EventHandler(this.btnVege_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 287);
            this.Controls.Add(this.btnVege);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.lbHarmonikus);
            this.Controls.Add(this.lbMertani);
            this.Controls.Add(this.lbSzamtani);
            this.Controls.Add(this.txtHarmonikus);
            this.Controls.Add(this.txtMertani);
            this.Controls.Add(this.txtSzamtani);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtSzamtani;
        private System.Windows.Forms.TextBox txtMertani;
        private System.Windows.Forms.TextBox txtHarmonikus;
        private System.Windows.Forms.Label lbSzamtani;
        private System.Windows.Forms.Label lbMertani;
        private System.Windows.Forms.Label lbHarmonikus;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnVege;
    }
}

