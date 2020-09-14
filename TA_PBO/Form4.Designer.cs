namespace TA_PBO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlPenanda = new System.Windows.Forms.Panel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnPrisma = new System.Windows.Forms.Button();
            this.btnBola = new System.Windows.Forms.Button();
            this.btnBalok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPrism1 = new TA_PBO.ucPrism();
            this.ucBall1 = new TA_PBO.ucBall();
            this.ucBalok1 = new TA_PBO.ucBalok();
            this.calculator1 = new TA_PBO.Calculator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Blue;
            this.splitContainer1.Panel1.Controls.Add(this.pnlPenanda);
            this.splitContainer1.Panel1.Controls.Add(this.btnBackToMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalculator);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrisma);
            this.splitContainer1.Panel1.Controls.Add(this.btnBola);
            this.splitContainer1.Panel1.Controls.Add(this.btnBalok);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calculator1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.ucPrism1);
            this.splitContainer1.Panel2.Controls.Add(this.ucBall1);
            this.splitContainer1.Panel2.Controls.Add(this.ucBalok1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(504, 375);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlPenanda
            // 
            this.pnlPenanda.BackColor = System.Drawing.Color.Red;
            this.pnlPenanda.Location = new System.Drawing.Point(0, 103);
            this.pnlPenanda.Name = "pnlPenanda";
            this.pnlPenanda.Size = new System.Drawing.Size(11, 40);
            this.pnlPenanda.TabIndex = 10;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToMenu.BackgroundImage")));
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.FlatAppearance.BorderSize = 0;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Signika", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(5, 326);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(40, 40);
            this.btnBackToMenu.TabIndex = 9;
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCalculator.Location = new System.Drawing.Point(13, 241);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(150, 40);
            this.btnCalculator.TabIndex = 8;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnPrisma
            // 
            this.btnPrisma.FlatAppearance.BorderSize = 0;
            this.btnPrisma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrisma.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrisma.ForeColor = System.Drawing.Color.White;
            this.btnPrisma.Location = new System.Drawing.Point(13, 195);
            this.btnPrisma.Name = "btnPrisma";
            this.btnPrisma.Size = new System.Drawing.Size(150, 40);
            this.btnPrisma.TabIndex = 6;
            this.btnPrisma.Text = "Prism";
            this.btnPrisma.UseVisualStyleBackColor = true;
            this.btnPrisma.Click += new System.EventHandler(this.btnPrisma_Click);
            // 
            // btnBola
            // 
            this.btnBola.BackColor = System.Drawing.Color.Blue;
            this.btnBola.FlatAppearance.BorderSize = 0;
            this.btnBola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBola.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBola.ForeColor = System.Drawing.Color.White;
            this.btnBola.Location = new System.Drawing.Point(13, 103);
            this.btnBola.Name = "btnBola";
            this.btnBola.Size = new System.Drawing.Size(150, 40);
            this.btnBola.TabIndex = 5;
            this.btnBola.Text = "Sphere";
            this.btnBola.UseVisualStyleBackColor = false;
            this.btnBola.Click += new System.EventHandler(this.btnBola_Click);
            // 
            // btnBalok
            // 
            this.btnBalok.BackColor = System.Drawing.Color.Blue;
            this.btnBalok.FlatAppearance.BorderSize = 0;
            this.btnBalok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalok.Font = new System.Drawing.Font("Signika", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalok.ForeColor = System.Drawing.Color.White;
            this.btnBalok.Location = new System.Drawing.Point(13, 149);
            this.btnBalok.Name = "btnBalok";
            this.btnBalok.Size = new System.Drawing.Size(150, 40);
            this.btnBalok.TabIndex = 4;
            this.btnBalok.Text = "Cube";
            this.btnBalok.UseVisualStyleBackColor = false;
            this.btnBalok.Click += new System.EventHandler(this.btnBalok_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Signika", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Signika", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "and";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Signika", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geometri 3D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ucPrism1
            // 
            this.ucPrism1.BackColor = System.Drawing.Color.Blue;
            this.ucPrism1.Location = new System.Drawing.Point(29, 25);
            this.ucPrism1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPrism1.Name = "ucPrism1";
            this.ucPrism1.Size = new System.Drawing.Size(276, 324);
            this.ucPrism1.TabIndex = 5;
            // 
            // ucBall1
            // 
            this.ucBall1.BackColor = System.Drawing.Color.Blue;
            this.ucBall1.Location = new System.Drawing.Point(29, 25);
            this.ucBall1.Margin = new System.Windows.Forms.Padding(4);
            this.ucBall1.Name = "ucBall1";
            this.ucBall1.Size = new System.Drawing.Size(276, 324);
            this.ucBall1.TabIndex = 4;
            // 
            // ucBalok1
            // 
            this.ucBalok1.BackColor = System.Drawing.Color.Blue;
            this.ucBalok1.Location = new System.Drawing.Point(29, 25);
            this.ucBalok1.Margin = new System.Windows.Forms.Padding(4);
            this.ucBalok1.Name = "ucBalok1";
            this.ucBalok1.Size = new System.Drawing.Size(276, 324);
            this.ucBalok1.TabIndex = 3;
            // 
            // calculator1
            // 
            this.calculator1.BackColor = System.Drawing.Color.Blue;
            this.calculator1.Location = new System.Drawing.Point(29, 26);
            this.calculator1.Margin = new System.Windows.Forms.Padding(4);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(276, 324);
            this.calculator1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnPrisma;
        private System.Windows.Forms.Button btnBola;
        private System.Windows.Forms.Button btnBalok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPenanda;
        private Calculator calculator1;
        private ucBalok ucBalok1;
        private ucBall ucBall1;
        private ucPrism ucPrism1;
    }
}