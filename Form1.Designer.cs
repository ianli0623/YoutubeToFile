
namespace YoutubeToFile
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FolderPath = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.lin_mp3 = new System.Windows.Forms.LinkLabel();
            this.lin_mp4 = new System.Windows.Forms.LinkLabel();
            this.btn_opendow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "資料夾路徑";
            // 
            // txt_FolderPath
            // 
            this.txt_FolderPath.Location = new System.Drawing.Point(29, 46);
            this.txt_FolderPath.Name = "txt_FolderPath";
            this.txt_FolderPath.Size = new System.Drawing.Size(385, 25);
            this.txt_FolderPath.TabIndex = 3;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(430, 27);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(78, 54);
            this.btn_Open.TabIndex = 5;
            this.btn_Open.Text = "選擇";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(29, 99);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(479, 25);
            this.txt_url.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "網址";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(30, 130);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(78, 54);
            this.btn_Download.TabIndex = 8;
            this.btn_Download.Text = "下載";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // lin_mp3
            // 
            this.lin_mp3.AutoSize = true;
            this.lin_mp3.Location = new System.Drawing.Point(40, 201);
            this.lin_mp3.Name = "lin_mp3";
            this.lin_mp3.Size = new System.Drawing.Size(35, 15);
            this.lin_mp3.TabIndex = 11;
            this.lin_mp3.TabStop = true;
            this.lin_mp3.Text = "MP3";
            this.lin_mp3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lin_mp3_LinkClicked);
            // 
            // lin_mp4
            // 
            this.lin_mp4.AutoSize = true;
            this.lin_mp4.Location = new System.Drawing.Point(40, 236);
            this.lin_mp4.Name = "lin_mp4";
            this.lin_mp4.Size = new System.Drawing.Size(35, 15);
            this.lin_mp4.TabIndex = 12;
            this.lin_mp4.TabStop = true;
            this.lin_mp4.Text = "MP4";
            this.lin_mp4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lin_mp4_LinkClicked);
            // 
            // btn_opendow
            // 
            this.btn_opendow.Location = new System.Drawing.Point(410, 201);
            this.btn_opendow.Name = "btn_opendow";
            this.btn_opendow.Size = new System.Drawing.Size(98, 50);
            this.btn_opendow.TabIndex = 13;
            this.btn_opendow.Text = "開啟資料夾";
            this.btn_opendow.UseVisualStyleBackColor = true;
            this.btn_opendow.Click += new System.EventHandler(this.btn_opendow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 285);
            this.Controls.Add(this.btn_opendow);
            this.Controls.Add(this.lin_mp4);
            this.Controls.Add(this.lin_mp3);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.txt_FolderPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FolderPath;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.LinkLabel lin_mp3;
        private System.Windows.Forms.LinkLabel lin_mp4;
        private System.Windows.Forms.Button btn_opendow;
    }
}

