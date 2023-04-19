
namespace pixel_paint
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
            this.marco = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.marco)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // marco
            // 
            this.marco.BackColor = System.Drawing.Color.White;
            this.marco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marco.Location = new System.Drawing.Point(0, 0);
            this.marco.Name = "marco";
            this.marco.Size = new System.Drawing.Size(800, 328);
            this.marco.TabIndex = 1;
            this.marco.TabStop = false;
            this.marco.Click += new System.EventHandler(this.marco_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.marco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 328);
            this.panel2.TabIndex = 6;
            // 
            // trackBar
            // 
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar.Location = new System.Drawing.Point(0, 12);
            this.trackBar.Maximum = 20;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(800, 45);
            this.trackBar.TabIndex = 3;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(12, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(146, 47);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.AllowDrop = true;
            this.txtTamaño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTamaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTamaño.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTamaño.Location = new System.Drawing.Point(270, 20);
            this.txtTamaño.Multiline = true;
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(64, 26);
            this.txtTamaño.TabIndex = 7;
            this.txtTamaño.Text = "5";
            this.txtTamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tamaño:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(378, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Coord. X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(593, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Coord. Y:";
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(270, 47);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 1);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX
            // 
            this.txtX.AllowDrop = true;
            this.txtX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtX.Location = new System.Drawing.Point(488, 22);
            this.txtX.Multiline = true;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(64, 26);
            this.txtX.TabIndex = 16;
            this.txtX.Text = "50";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(488, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 1);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY
            // 
            this.txtY.AllowDrop = true;
            this.txtY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtY.Location = new System.Drawing.Point(702, 22);
            this.txtY.Multiline = true;
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(64, 26);
            this.txtY.TabIndex = 18;
            this.txtY.Text = "50";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AllowDrop = true;
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(702, 49);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 1);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marco)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox marco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox textBox5;
    }
}

