namespace BunifuPictureBoxDemo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bunifuPictureBox5 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bunifuPictureBox4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.webClient1 = new System.Net.WebClient();
            this.saveImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbDb = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox5)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 75);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BunifuPictureBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bunifu Demo App";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bunifuPictureBox5);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(215, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 146);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Custom";
            // 
            // bunifuPictureBox5
            // 
            this.bunifuPictureBox5.AllowFocused = false;
            this.bunifuPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox5.BorderRadius = 58;
            this.bunifuPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox5.Image")));
            this.bunifuPictureBox5.IsCircle = false;
            this.bunifuPictureBox5.Location = new System.Drawing.Point(19, 12);
            this.bunifuPictureBox5.Name = "bunifuPictureBox5";
            this.bunifuPictureBox5.Size = new System.Drawing.Size(169, 116);
            this.bunifuPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox5.TabIndex = 6;
            this.bunifuPictureBox5.TabStop = false;
            this.bunifuPictureBox5.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bunifuPictureBox4);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(36, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 146);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Circle";
            // 
            // bunifuPictureBox4
            // 
            this.bunifuPictureBox4.AllowFocused = false;
            this.bunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox4.BorderRadius = 50;
            this.bunifuPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox4.Image")));
            this.bunifuPictureBox4.IsCircle = true;
            this.bunifuPictureBox4.Location = new System.Drawing.Point(15, 29);
            this.bunifuPictureBox4.Name = "bunifuPictureBox4";
            this.bunifuPictureBox4.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox4.TabIndex = 6;
            this.bunifuPictureBox4.TabStop = false;
            this.bunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuPictureBox3);
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(328, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 130);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Square";
            // 
            // bunifuPictureBox3
            // 
            this.bunifuPictureBox3.AllowFocused = false;
            this.bunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox3.BorderRadius = 0;
            this.bunifuPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox3.Image")));
            this.bunifuPictureBox3.IsCircle = false;
            this.bunifuPictureBox3.Location = new System.Drawing.Point(15, 21);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 6;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuPictureBox2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(181, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 130);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Edges";
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 20;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = false;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(15, 21);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 6;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuPictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(35, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From URL";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(14, 19);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 5;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.WaitOnLoad = true;
            // 
            // webClient1
            // 
            this.webClient1.BaseAddress = "https://upload.wikimedia.org/wikipedia/commons/c/cd/Bill_Clinton_(square).jpg";
            this.webClient1.CachePolicy = null;
            this.webClient1.Credentials = null;
            this.webClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("webClient1.Encoding")));
            this.webClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webClient1.Headers")));
            this.webClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webClient1.QueryString")));
            this.webClient1.UseDefaultCredentials = false;
            this.webClient1.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.webClient1_DownloadFileCompleted);
            this.webClient1.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.webClient1_DownloadProgressChanged);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            this.saveImageDialog.RestoreDirectory = true;
            this.saveImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveImageDialog_FileOk);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGetImage);
            this.groupBox6.Controls.Add(this.btnSave);
            this.groupBox6.Controls.Add(this.pbDb);
            this.groupBox6.ForeColor = System.Drawing.Color.Navy;
            this.groupBox6.Location = new System.Drawing.Point(35, 490);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(408, 130);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "From Database [Save & Get]";
            // 
            // btnGetImage
            // 
            this.btnGetImage.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnGetImage.FlatAppearance.BorderSize = 0;
            this.btnGetImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGetImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetImage.ForeColor = System.Drawing.Color.LightGray;
            this.btnGetImage.Location = new System.Drawing.Point(296, 57);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(89, 34);
            this.btnGetImage.TabIndex = 4;
            this.btnGetImage.Text = "GetImage";
            this.btnGetImage.UseVisualStyleBackColor = false;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.LightGray;
            this.btnSave.Location = new System.Drawing.Point(161, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SaveImage";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbDb
            // 
            this.pbDb.AllowFocused = false;
            this.pbDb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDb.BorderRadius = 50;
            this.pbDb.Image = ((System.Drawing.Image)(resources.GetObject("pbDb.Image")));
            this.pbDb.IsCircle = true;
            this.pbDb.Location = new System.Drawing.Point(14, 19);
            this.pbDb.Name = "pbDb";
            this.pbDb.Size = new System.Drawing.Size(100, 100);
            this.pbDb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDb.TabIndex = 6;
            this.pbDb.TabStop = false;
            this.pbDb.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 654);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.Text = "BunifuPictureBox Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Net.WebClient webClient1;
        private System.Windows.Forms.OpenFileDialog saveImageDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.UI.WinForms.BunifuPictureBox pbDb;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.Button btnSave;
    }
}

