namespace PROJECT
{
    partial class User2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.video1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lst1);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 325);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb1.Location = new System.Drawing.Point(0, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(143, 22);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Here words only";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(307, 32);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(126, 20);
            this.txt1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(439, 32);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "search";
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // video1
            // 
            this.video1.Enabled = true;
            this.video1.Location = new System.Drawing.Point(149, 107);
            this.video1.Name = "video1";
            this.video1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video1.OcxState")));
            this.video1.Size = new System.Drawing.Size(234, 186);
            this.video1.TabIndex = 3;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(386, 107);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(234, 186);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // lst1
            // 
            this.lst1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lst1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst1.ForeColor = System.Drawing.SystemColors.Info;
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 19;
            this.lst1.Location = new System.Drawing.Point(0, 22);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(143, 303);
            this.lst1.TabIndex = 2;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // User2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.video1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.panel1);
            this.Name = "User2";
            this.Size = new System.Drawing.Size(632, 325);
            this.Load += new System.EventHandler(this.User2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.ListBox lst1;
        private AxWMPLib.AxWindowsMediaPlayer video1;
    }
}
