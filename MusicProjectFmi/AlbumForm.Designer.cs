
namespace MusicProjectFmi
{
    partial class AlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm));
            this.InputAlbumId = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.YearOfRelease = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Performer = new System.Windows.Forms.Label();
            this.InputId = new System.Windows.Forms.TextBox();
            this.InputSongName = new System.Windows.Forms.TextBox();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.InputGenreId = new System.Windows.Forms.TextBox();
            this.InputPerformer = new System.Windows.Forms.TextBox();
            this.AlbumGridView1 = new System.Windows.Forms.DataGridView();
            this.AlbumLogo = new System.Windows.Forms.PictureBox();
            this.HomepageButton = new System.Windows.Forms.Button();
            this.InputAlbum = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // InputAlbumId
            // 
            this.InputAlbumId.AutoSize = true;
            this.InputAlbumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputAlbumId.Location = new System.Drawing.Point(79, 276);
            this.InputAlbumId.Name = "InputAlbumId";
            this.InputAlbumId.Size = new System.Drawing.Size(22, 20);
            this.InputAlbumId.TabIndex = 0;
            this.InputAlbumId.Text = "Id";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SongName.Location = new System.Drawing.Point(79, 310);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(96, 20);
            this.SongName.TabIndex = 1;
            this.SongName.Text = "Song Name";
            // 
            // YearOfRelease
            // 
            this.YearOfRelease.AutoSize = true;
            this.YearOfRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.YearOfRelease.Location = new System.Drawing.Point(79, 350);
            this.YearOfRelease.Name = "YearOfRelease";
            this.YearOfRelease.Size = new System.Drawing.Size(132, 20);
            this.YearOfRelease.TabIndex = 2;
            this.YearOfRelease.Text = "Year Of Release";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Genre.Location = new System.Drawing.Point(79, 388);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(55, 20);
            this.Genre.TabIndex = 3;
            this.Genre.Text = "Genre";
            // 
            // Performer
            // 
            this.Performer.AutoSize = true;
            this.Performer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Performer.Location = new System.Drawing.Point(79, 471);
            this.Performer.Name = "Performer";
            this.Performer.Size = new System.Drawing.Size(84, 20);
            this.Performer.TabIndex = 4;
            this.Performer.Text = "Performer";
            // 
            // InputId
            // 
            this.InputId.Location = new System.Drawing.Point(244, 274);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(127, 22);
            this.InputId.TabIndex = 8;
            // 
            // InputSongName
            // 
            this.InputSongName.Location = new System.Drawing.Point(244, 308);
            this.InputSongName.Name = "InputSongName";
            this.InputSongName.ReadOnly = true;
            this.InputSongName.Size = new System.Drawing.Size(127, 22);
            this.InputSongName.TabIndex = 9;
            // 
            // InputYear
            // 
            this.InputYear.Location = new System.Drawing.Point(244, 348);
            this.InputYear.Name = "InputYear";
            this.InputYear.ReadOnly = true;
            this.InputYear.Size = new System.Drawing.Size(127, 22);
            this.InputYear.TabIndex = 10;
            // 
            // InputGenreId
            // 
            this.InputGenreId.Location = new System.Drawing.Point(244, 386);
            this.InputGenreId.Name = "InputGenreId";
            this.InputGenreId.ReadOnly = true;
            this.InputGenreId.Size = new System.Drawing.Size(127, 22);
            this.InputGenreId.TabIndex = 11;
            // 
            // InputPerformer
            // 
            this.InputPerformer.Location = new System.Drawing.Point(244, 471);
            this.InputPerformer.Name = "InputPerformer";
            this.InputPerformer.ReadOnly = true;
            this.InputPerformer.Size = new System.Drawing.Size(127, 22);
            this.InputPerformer.TabIndex = 12;
            // 
            // AlbumGridView1
            // 
            this.AlbumGridView1.AllowUserToAddRows = false;
            this.AlbumGridView1.AllowUserToDeleteRows = false;
            this.AlbumGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlbumGridView1.Location = new System.Drawing.Point(407, 111);
            this.AlbumGridView1.Name = "AlbumGridView1";
            this.AlbumGridView1.ReadOnly = true;
            this.AlbumGridView1.RowHeadersWidth = 51;
            this.AlbumGridView1.RowTemplate.Height = 24;
            this.AlbumGridView1.Size = new System.Drawing.Size(573, 456);
            this.AlbumGridView1.TabIndex = 16;
            this.AlbumGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AlbumGridView1_RowHeaderMouseDoubleClick);
            // 
            // AlbumLogo
            // 
            this.AlbumLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlbumLogo.BackgroundImage")));
            this.AlbumLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumLogo.Location = new System.Drawing.Point(63, 26);
            this.AlbumLogo.Name = "AlbumLogo";
            this.AlbumLogo.Size = new System.Drawing.Size(308, 209);
            this.AlbumLogo.TabIndex = 17;
            this.AlbumLogo.TabStop = false;
            // 
            // HomepageButton
            // 
            this.HomepageButton.BackColor = System.Drawing.Color.Red;
            this.HomepageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HomepageButton.ForeColor = System.Drawing.Color.White;
            this.HomepageButton.Location = new System.Drawing.Point(107, 509);
            this.HomepageButton.Name = "HomepageButton";
            this.HomepageButton.Size = new System.Drawing.Size(193, 58);
            this.HomepageButton.TabIndex = 18;
            this.HomepageButton.Text = "To Homepage";
            this.HomepageButton.UseVisualStyleBackColor = false;
            this.HomepageButton.Click += new System.EventHandler(this.HomepageButton_Click);
            // 
            // InputAlbum
            // 
            this.InputAlbum.Location = new System.Drawing.Point(244, 430);
            this.InputAlbum.Name = "InputAlbum";
            this.InputAlbum.ReadOnly = true;
            this.InputAlbum.Size = new System.Drawing.Size(127, 22);
            this.InputAlbum.TabIndex = 20;
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Album.Location = new System.Drawing.Point(79, 430);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(56, 20);
            this.Album.TabIndex = 19;
            this.Album.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(432, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose album:";
            // 
            // albumComboBox
            // 
            this.albumComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.albumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(573, 47);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(250, 28);
            this.albumComboBox.TabIndex = 22;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gold;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(867, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 28);
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 597);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputAlbum);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.HomepageButton);
            this.Controls.Add(this.AlbumLogo);
            this.Controls.Add(this.AlbumGridView1);
            this.Controls.Add(this.InputPerformer);
            this.Controls.Add(this.InputGenreId);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.InputSongName);
            this.Controls.Add(this.InputId);
            this.Controls.Add(this.Performer);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.YearOfRelease);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.InputAlbumId);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.AlbumGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputAlbumId;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label YearOfRelease;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Performer;
        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.TextBox InputSongName;
        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.TextBox InputGenreId;
        private System.Windows.Forms.TextBox InputPerformer;
        private System.Windows.Forms.DataGridView AlbumGridView1;
        private System.Windows.Forms.PictureBox AlbumLogo;
        private System.Windows.Forms.Button HomepageButton;
        private System.Windows.Forms.TextBox InputAlbum;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.Button searchButton;
    }
}