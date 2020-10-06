namespace CalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.clear2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.allClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Gray;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.Location = new System.Drawing.Point(30, 138);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(45, 45);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            this.plus.MouseHover += new System.EventHandler(this.plus_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.textBox1_clicked);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_Hover);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(30, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 36);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Clicked);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leaved);
            this.textBox2.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Gray;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.Location = new System.Drawing.Point(81, 138);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(45, 45);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.button2_Click);
            this.minus.MouseHover += new System.EventHandler(this.minus_MouseHover);
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.Color.Gray;
            this.times.Cursor = System.Windows.Forms.Cursors.Hand;
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.times.Location = new System.Drawing.Point(132, 138);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(45, 45);
            this.times.TabIndex = 4;
            this.times.Text = "X";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.button3_Click);
            this.times.MouseHover += new System.EventHandler(this.times_MouseHover);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Gray;
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divide.Location = new System.Drawing.Point(183, 138);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(45, 45);
            this.divide.TabIndex = 5;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.button4_Click);
            this.divide.MouseHover += new System.EventHandler(this.divide_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clear
            // 
            this.clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear.BackColor = System.Drawing.Color.Gray;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear.Location = new System.Drawing.Point(234, 20);
            this.clear.Name = "clear";
            this.clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clear.Size = new System.Drawing.Size(45, 45);
            this.clear.TabIndex = 8;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear1_Click);
            this.clear.MouseHover += new System.EventHandler(this.clear1_MouseHover);
            // 
            // clear2
            // 
            this.clear2.BackColor = System.Drawing.Color.Gray;
            this.clear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear2.Location = new System.Drawing.Point(234, 77);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(45, 45);
            this.clear2.TabIndex = 9;
            this.clear2.Text = "C";
            this.clear2.UseVisualStyleBackColor = false;
            this.clear2.Click += new System.EventHandler(this.clear2_Click);
            this.clear2.MouseHover += new System.EventHandler(this.clear2_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // allClear
            // 
            this.allClear.BackColor = System.Drawing.Color.Gray;
            this.allClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allClear.Location = new System.Drawing.Point(234, 138);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(45, 45);
            this.allClear.TabIndex = 11;
            this.allClear.Text = "AC";
            this.allClear.UseVisualStyleBackColor = false;
            this.allClear.Click += new System.EventHandler(this.allClear_Click);
            this.allClear.MouseHover += new System.EventHandler(this.allClear_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Answer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.Cursor = System.Windows.Forms.Cursors.No;
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.HideSelection = false;
            this.result.Location = new System.Drawing.Point(32, 219);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(250, 64);
            this.result.TabIndex = 7;
            this.result.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.result.MouseHover += new System.EventHandler(this.result_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(30, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 68);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.allClear);
            this.Controls.Add(this.clear2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plus);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clear2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button allClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox result;
    }
}

