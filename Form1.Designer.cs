namespace llenadoArgumentoString
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
            this.lWord = new System.Windows.Forms.Label();
            this.tBWord = new System.Windows.Forms.TextBox();
            this.bTAdd = new System.Windows.Forms.Button();
            this.bTClear = new System.Windows.Forms.Button();
            this.tBC1 = new System.Windows.Forms.TextBox();
            this.tBC2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bTShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lWord
            // 
            this.lWord.AutoSize = true;
            this.lWord.BackColor = System.Drawing.Color.Transparent;
            this.lWord.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lWord.Location = new System.Drawing.Point(21, 24);
            this.lWord.Name = "lWord";
            this.lWord.Size = new System.Drawing.Size(64, 28);
            this.lWord.TabIndex = 0;
            this.lWord.Text = "Word";
            // 
            // tBWord
            // 
            this.tBWord.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBWord.Location = new System.Drawing.Point(115, 24);
            this.tBWord.Name = "tBWord";
            this.tBWord.Size = new System.Drawing.Size(207, 34);
            this.tBWord.TabIndex = 1;
            this.tBWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bTAdd
            // 
            this.bTAdd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bTAdd.Location = new System.Drawing.Point(91, 84);
            this.bTAdd.Name = "bTAdd";
            this.bTAdd.Size = new System.Drawing.Size(104, 31);
            this.bTAdd.TabIndex = 2;
            this.bTAdd.Text = "Add";
            this.bTAdd.UseVisualStyleBackColor = true;
            this.bTAdd.Click += new System.EventHandler(this.bTAdd_Click);
            // 
            // bTClear
            // 
            this.bTClear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bTClear.Location = new System.Drawing.Point(242, 84);
            this.bTClear.Name = "bTClear";
            this.bTClear.Size = new System.Drawing.Size(104, 31);
            this.bTClear.TabIndex = 3;
            this.bTClear.Text = "Clear";
            this.bTClear.UseVisualStyleBackColor = true;
            this.bTClear.Click += new System.EventHandler(this.bTClear_Click);
            // 
            // tBC1
            // 
            this.tBC1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBC1.Location = new System.Drawing.Point(91, 24);
            this.tBC1.Name = "tBC1";
            this.tBC1.Size = new System.Drawing.Size(18, 34);
            this.tBC1.TabIndex = 4;
            this.tBC1.Text = "\"";
            // 
            // tBC2
            // 
            this.tBC2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBC2.Location = new System.Drawing.Point(328, 24);
            this.tBC2.Name = "tBC2";
            this.tBC2.Size = new System.Drawing.Size(18, 34);
            this.tBC2.TabIndex = 5;
            this.tBC2.Text = "\",";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(370, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 372);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // bTShow
            // 
            this.bTShow.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bTShow.Location = new System.Drawing.Point(167, 130);
            this.bTShow.Name = "bTShow";
            this.bTShow.Size = new System.Drawing.Size(104, 31);
            this.bTShow.TabIndex = 7;
            this.bTShow.Text = "Show";
            this.bTShow.UseVisualStyleBackColor = true;
            this.bTShow.Click += new System.EventHandler(this.bTShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::llenadoArgumentoString.Properties.Resources.F;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 409);
            this.Controls.Add(this.bTShow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tBC2);
            this.Controls.Add(this.tBC1);
            this.Controls.Add(this.bTClear);
            this.Controls.Add(this.bTAdd);
            this.Controls.Add(this.tBWord);
            this.Controls.Add(this.lWord);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "string argument fill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lWord;
        private TextBox tBWord;
        private Button bTAdd;
        private Button bTClear;
        private TextBox tBC1;
        private TextBox tBC2;
        private RichTextBox richTextBox1;
        private Button bTShow;
    }
}