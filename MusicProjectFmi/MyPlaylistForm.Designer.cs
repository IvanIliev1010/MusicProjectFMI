
namespace MusicProjectFmi
{
    partial class MyPlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPlaylistForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongId = new System.Windows.Forms.Label();
            this.SongYear = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.SongGenre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SongAlbum = new System.Windows.Forms.Label();
            this.InputId = new System.Windows.Forms.TextBox();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.InputSongName = new System.Windows.Forms.TextBox();
            this.InputAlbum = new System.Windows.Forms.TextBox();
            this.InputPerformer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputGenreId = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DeleteErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // SongId
            // 
            this.SongId.AutoSize = true;
            this.SongId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SongId.Location = new System.Drawing.Point(41, 145);
            this.SongId.Name = "SongId";
            this.SongId.Size = new System.Drawing.Size(22, 20);
            this.SongId.TabIndex = 1;
            this.SongId.Text = "Id";
            // 
            // SongYear
            // 
            this.SongYear.AutoSize = true;
            this.SongYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SongYear.Location = new System.Drawing.Point(41, 258);
            this.SongYear.Name = "SongYear";
            this.SongYear.Size = new System.Drawing.Size(43, 20);
            this.SongYear.TabIndex = 2;
            this.SongYear.Text = "Year";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SongName.Location = new System.Drawing.Point(38, 193);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(96, 20);
            this.SongName.TabIndex = 3;
            this.SongName.Text = "Song Name";
            // 
            // SongGenre
            // 
            this.SongGenre.AutoSize = true;
            this.SongGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SongGenre.Location = new System.Drawing.Point(41, 313);
            this.SongGenre.Name = "SongGenre";
            this.SongGenre.Size = new System.Drawing.Size(55, 20);
            this.SongGenre.TabIndex = 4;
            this.SongGenre.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(41, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Perforemer";
            // 
            // SongAlbum
            // 
            this.SongAlbum.AutoSize = true;
            this.SongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SongAlbum.Location = new System.Drawing.Point(41, 368);
            this.SongAlbum.Name = "SongAlbum";
            this.SongAlbum.Size = new System.Drawing.Size(56, 20);
            this.SongAlbum.TabIndex = 6;
            this.SongAlbum.Text = "Album";
            // 
            // InputId
            // 
            this.InputId.Location = new System.Drawing.Point(158, 143);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(128, 22);
            this.InputId.TabIndex = 7;
            // 
            // InputYear
            // 
            this.InputYear.Location = new System.Drawing.Point(158, 254);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(128, 22);
            this.InputYear.TabIndex = 8;
            // 
            // InputSongName
            // 
            this.InputSongName.Location = new System.Drawing.Point(158, 191);
            this.InputSongName.Name = "InputSongName";
            this.InputSongName.Size = new System.Drawing.Size(128, 22);
            this.InputSongName.TabIndex = 9;
            // 
            // InputAlbum
            // 
            this.InputAlbum.Location = new System.Drawing.Point(158, 364);
            this.InputAlbum.Name = "InputAlbum";
            this.InputAlbum.Size = new System.Drawing.Size(128, 22);
            this.InputAlbum.TabIndex = 11;
            // 
            // InputPerformer
            // 
            this.InputPerformer.Location = new System.Drawing.Point(158, 410);
            this.InputPerformer.Name = "InputPerformer";
            this.InputPerformer.Size = new System.Drawing.Size(128, 22);
            this.InputPerformer.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 108);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // InputGenreId
            // 
            this.InputGenreId.FormattingEnabled = true;
            this.InputGenreId.Location = new System.Drawing.Point(158, 311);
            this.InputGenreId.Name = "InputGenreId";
            this.InputGenreId.Size = new System.Drawing.Size(128, 24);
            this.InputGenreId.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gold;
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(417, 400);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(136, 51);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add More Songs";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.CausesValidation = false;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(627, 400);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(146, 51);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "Remove From MyPlaylist";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.Validating += new System.ComponentModel.CancelEventHandler(this.RemoveButton_Validating);
            // 
            // DeleteErrorProvider1
            // 
            this.DeleteErrorProvider1.ContainerControl = this;
            // 
            // MyPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputGenreId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InputPerformer);
            this.Controls.Add(this.InputAlbum);
            this.Controls.Add(this.InputSongName);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.InputId);
            this.Controls.Add(this.SongAlbum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SongGenre);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.SongYear);
            this.Controls.Add(this.SongId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyPlaylistForm";
            this.Text = "MyPlaylistForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SongId;
        private System.Windows.Forms.Label SongYear;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label SongGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SongAlbum;
        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.TextBox InputSongName;
        private System.Windows.Forms.TextBox InputAlbum;
        private System.Windows.Forms.TextBox InputPerformer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox InputGenreId;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ErrorProvider DeleteErrorProvider1;
    }
}