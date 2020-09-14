namespace TA_PBO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnMateri = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMateri
            // 
            this.btnMateri.BackColor = System.Drawing.Color.Transparent;
            this.btnMateri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMateri.BackgroundImage")));
            this.btnMateri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMateri.FlatAppearance.BorderSize = 0;
            this.btnMateri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateri.Location = new System.Drawing.Point(74, 156);
            this.btnMateri.Name = "btnMateri";
            this.btnMateri.Size = new System.Drawing.Size(100, 100);
            this.btnMateri.TabIndex = 0;
            this.btnMateri.UseVisualStyleBackColor = false;
            this.btnMateri.Click += new System.EventHandler(this.btnMateri_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(325, 156);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 100);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Signika", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 115);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnExit3
            // 
            this.btnExit3.BackColor = System.Drawing.Color.Transparent;
            this.btnExit3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit3.BackgroundImage")));
            this.btnExit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit3.FlatAppearance.BorderSize = 0;
            this.btnExit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit3.Location = new System.Drawing.Point(467, 12);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(25, 25);
            this.btnExit3.TabIndex = 4;
            this.btnExit3.UseVisualStyleBackColor = false;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.Transparent;
            this.btnTranslate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTranslate.BackgroundImage")));
            this.btnTranslate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Location = new System.Drawing.Point(202, 156);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(95, 95);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnExit3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnMateri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMateri;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnTranslate;
    }
}