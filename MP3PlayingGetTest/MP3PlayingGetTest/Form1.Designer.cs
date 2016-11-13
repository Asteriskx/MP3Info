namespace MP3PlayingGetTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new System.Windows.Forms.Button();
            this.Track = new System.Windows.Forms.TextBox();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.TextBox();
            this.AlbumName = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(8, 121);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Track
            // 
            this.Track.Location = new System.Drawing.Point(100, 12);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(295, 19);
            this.Track.TabIndex = 1;
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(100, 90);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(295, 19);
            this.TimeText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "TrackName : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time : ";
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.ForeColor = System.Drawing.Color.White;
            this.Artist.Location = new System.Drawing.Point(39, 41);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(44, 12);
            this.Artist.TabIndex = 5;
            this.Artist.Text = "Artist : ";
            // 
            // ArtistName
            // 
            this.ArtistName.Location = new System.Drawing.Point(100, 38);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(295, 19);
            this.ArtistName.TabIndex = 6;
            // 
            // AlbumName
            // 
            this.AlbumName.Location = new System.Drawing.Point(100, 64);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(295, 19);
            this.AlbumName.TabIndex = 7;
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.ForeColor = System.Drawing.Color.White;
            this.Album.Location = new System.Drawing.Point(36, 67);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(47, 12);
            this.Album.TabIndex = 8;
            this.Album.Text = "Album : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(407, 153);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.AlbumName);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "MP3PlayingGetTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox Track;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.TextBox ArtistName;
        private System.Windows.Forms.TextBox AlbumName;
        private System.Windows.Forms.Label Album;
    }
}

