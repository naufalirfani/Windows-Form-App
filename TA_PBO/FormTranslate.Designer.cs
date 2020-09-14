namespace TA_PBO
{
    partial class FormTranslate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTranslate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnTranslateWord = new System.Windows.Forms.Button();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoice = new System.Windows.Forms.Button();
            this.btnVoice2 = new System.Windows.Forms.Button();
            this.btnTukar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Signika", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(147, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Translate Your Word";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(232, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(232, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // tbFrom
            // 
            this.tbFrom.BackColor = System.Drawing.Color.White;
            this.tbFrom.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrom.Location = new System.Drawing.Point(236, 144);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(178, 31);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Click += new System.EventHandler(this.tbFrom_Click);
            this.tbFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrom_KeyPress);
            // 
            // tbTo
            // 
            this.tbTo.BackColor = System.Drawing.Color.White;
            this.tbTo.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTo.Location = new System.Drawing.Point(236, 248);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(178, 31);
            this.tbTo.TabIndex = 4;
            this.tbTo.Click += new System.EventHandler(this.tbTo_Click);
            // 
            // btnTranslateWord
            // 
            this.btnTranslateWord.BackColor = System.Drawing.Color.Blue;
            this.btnTranslateWord.FlatAppearance.BorderSize = 0;
            this.btnTranslateWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslateWord.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslateWord.ForeColor = System.Drawing.Color.White;
            this.btnTranslateWord.Location = new System.Drawing.Point(273, 299);
            this.btnTranslateWord.Name = "btnTranslateWord";
            this.btnTranslateWord.Size = new System.Drawing.Size(100, 50);
            this.btnTranslateWord.TabIndex = 5;
            this.btnTranslateWord.Text = "Translate";
            this.btnTranslateWord.UseVisualStyleBackColor = false;
            this.btnTranslateWord.Click += new System.EventHandler(this.btnTranslateWord_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.BackColor = System.Drawing.Color.White;
            this.cbFrom.Font = new System.Drawing.Font("Signika", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Arabic",
            "German",
            "English",
            "French",
            "Dutch",
            "Hungarian",
            "Indonesian",
            "Italian",
            "Japanese",
            "Korean",
            "Norwegian",
            "Potuguese",
            "Romanian",
            "Spanish",
            "Russian",
            "Swedish",
            "Thai",
            "Turkish",
            "Ukrainian"});
            this.cbFrom.Location = new System.Drawing.Point(291, 108);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 27);
            this.cbFrom.TabIndex = 6;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            this.cbFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFrom_KeyPress);
            // 
            // cbTo
            // 
            this.cbTo.BackColor = System.Drawing.Color.White;
            this.cbTo.Font = new System.Drawing.Font("Signika", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Arabic",
            "German",
            "English",
            "French",
            "Dutch",
            "Hungarian",
            "Indonesian",
            "Italian",
            "Japanese",
            "Korean",
            "Norwegian",
            "Portuguese",
            "Romanian",
            "Spanish",
            "Russian",
            "Swedish",
            "Thai",
            "Turkish",
            "Ukrainian"});
            this.cbTo.Location = new System.Drawing.Point(291, 212);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 27);
            this.cbTo.TabIndex = 7;
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            this.cbTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTo_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Blue;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Blue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(147, 375);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoice
            // 
            this.btnVoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoice.BackgroundImage")));
            this.btnVoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoice.FlatAppearance.BorderSize = 0;
            this.btnVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoice.Location = new System.Drawing.Point(420, 144);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(31, 31);
            this.btnVoice.TabIndex = 12;
            this.btnVoice.UseVisualStyleBackColor = true;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // btnVoice2
            // 
            this.btnVoice2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoice2.BackgroundImage")));
            this.btnVoice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoice2.FlatAppearance.BorderSize = 0;
            this.btnVoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoice2.Location = new System.Drawing.Point(420, 248);
            this.btnVoice2.Name = "btnVoice2";
            this.btnVoice2.Size = new System.Drawing.Size(31, 31);
            this.btnVoice2.TabIndex = 13;
            this.btnVoice2.UseVisualStyleBackColor = true;
            this.btnVoice2.Click += new System.EventHandler(this.btnVoice2_Click);
            // 
            // btnTukar
            // 
            this.btnTukar.BackColor = System.Drawing.Color.White;
            this.btnTukar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTukar.BackgroundImage")));
            this.btnTukar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTukar.FlatAppearance.BorderSize = 0;
            this.btnTukar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTukar.Location = new System.Drawing.Point(314, 183);
            this.btnTukar.Name = "btnTukar";
            this.btnTukar.Size = new System.Drawing.Size(29, 23);
            this.btnTukar.TabIndex = 14;
            this.btnTukar.UseVisualStyleBackColor = false;
            this.btnTukar.Click += new System.EventHandler(this.btnTukar_Click);
            // 
            // FormTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.btnTukar);
            this.Controls.Add(this.btnVoice2);
            this.Controls.Add(this.btnVoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.btnTranslateWord);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTranslate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTranslate";
            this.Load += new System.EventHandler(this.FormTranslate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Button btnTranslateWord;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoice;
        private System.Windows.Forms.Button btnVoice2;
        private System.Windows.Forms.Button btnTukar;
    }
}