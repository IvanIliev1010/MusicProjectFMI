using System;

namespace MusicProjectFmi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputSongName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputAlbum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InputPerformer = new System.Windows.Forms.TextBox();
            this.InputGenreId = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MyPlaylistButton = new System.Windows.Forms.Button();
            this.SongGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewAlbumButton = new System.Windows.Forms.Button();
            this.ViewPlaylistButton = new System.Windows.Forms.Button();
            this.SongNameErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.YearErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GenreErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PerformerErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DeleteErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddToMyPlaylistEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.PlaylistErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SongGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongNameErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformerErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddToMyPlaylistEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputId.Location = new System.Drawing.Point(131, 224);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(181, 26);
            this.InputId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(19, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Song Name";
            // 
            // InputSongName
            // 
            this.InputSongName.CausesValidation = false;
            this.InputSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputSongName.Location = new System.Drawing.Point(131, 271);
            this.InputSongName.Name = "InputSongName";
            this.InputSongName.Size = new System.Drawing.Size(181, 26);
            this.InputSongName.TabIndex = 2;
            this.InputSongName.Validating += new System.ComponentModel.CancelEventHandler(this.InputSongName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(19, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // InputYear
            // 
            this.InputYear.CausesValidation = false;
            this.InputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputYear.Location = new System.Drawing.Point(131, 332);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(181, 26);
            this.InputYear.TabIndex = 4;
            this.InputYear.Validating += new System.ComponentModel.CancelEventHandler(this.InputYear_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(19, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(19, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Album";
            // 
            // InputAlbum
            // 
            this.InputAlbum.CausesValidation = false;
            this.InputAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputAlbum.Location = new System.Drawing.Point(131, 438);
            this.InputAlbum.Name = "InputAlbum";
            this.InputAlbum.Size = new System.Drawing.Size(181, 26);
            this.InputAlbum.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(19, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Performer";
            // 
            // InputPerformer
            // 
            this.InputPerformer.CausesValidation = false;
            this.InputPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputPerformer.Location = new System.Drawing.Point(131, 491);
            this.InputPerformer.Name = "InputPerformer";
            this.InputPerformer.Size = new System.Drawing.Size(181, 26);
            this.InputPerformer.TabIndex = 10;
            this.InputPerformer.Validating += new System.ComponentModel.CancelEventHandler(this.InputPerformer_Validating);
            // 
            // InputGenreId
            // 
            this.InputGenreId.CausesValidation = false;
            this.InputGenreId.FormattingEnabled = true;
            this.InputGenreId.ItemHeight = 16;
            this.InputGenreId.Location = new System.Drawing.Point(131, 389);
            this.InputGenreId.Name = "InputGenreId";
            this.InputGenreId.Size = new System.Drawing.Size(181, 24);
            this.InputGenreId.TabIndex = 12;
            this.InputGenreId.Validating += new System.ComponentModel.CancelEventHandler(this.InputGenreId_Validating);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gold;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.Location = new System.Drawing.Point(12, 563);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 43);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Gold;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateButton.Location = new System.Drawing.Point(143, 563);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(104, 43);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(275, 563);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 43);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.Validating += new System.ComponentModel.CancelEventHandler(this.DeleteButton_Validating);
            // 
            // MyPlaylistButton
            // 
            this.MyPlaylistButton.BackColor = System.Drawing.Color.Red;
            this.MyPlaylistButton.CausesValidation = false;
            this.MyPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MyPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.MyPlaylistButton.Location = new System.Drawing.Point(802, 563);
            this.MyPlaylistButton.Name = "MyPlaylistButton";
            this.MyPlaylistButton.Size = new System.Drawing.Size(206, 43);
            this.MyPlaylistButton.TabIndex = 16;
            this.MyPlaylistButton.Text = "Add to MyPlaylist";
            this.MyPlaylistButton.UseVisualStyleBackColor = false;
            this.MyPlaylistButton.Click += new System.EventHandler(this.MyPlaylistButton_Click);
            this.MyPlaylistButton.Validating += new System.ComponentModel.CancelEventHandler(this.MyPlaylistButton_Validating);
            // 
            // SongGridView1
            // 
            this.SongGridView1.AllowUserToAddRows = false;
            this.SongGridView1.AllowUserToDeleteRows = false;
            this.SongGridView1.AllowUserToResizeColumns = false;
            this.SongGridView1.AllowUserToResizeRows = false;
            this.SongGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SongGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SongGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongGridView1.Location = new System.Drawing.Point(362, 13);
            this.SongGridView1.Name = "SongGridView1";
            this.SongGridView1.ReadOnly = true;
            this.SongGridView1.RowHeadersWidth = 51;
            this.SongGridView1.RowTemplate.Height = 24;
            this.SongGridView1.Size = new System.Drawing.Size(680, 504);
            this.SongGridView1.TabIndex = 17;
            this.SongGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SongGridView1_RowHeaderMouseClick);
            this.SongGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SongGridView1_RowHeaderMouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 172);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ViewAlbumButton
            // 
            this.ViewAlbumButton.BackColor = System.Drawing.Color.Gold;
            this.ViewAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewAlbumButton.Location = new System.Drawing.Point(454, 563);
            this.ViewAlbumButton.Name = "ViewAlbumButton";
            this.ViewAlbumButton.Size = new System.Drawing.Size(168, 43);
            this.ViewAlbumButton.TabIndex = 19;
            this.ViewAlbumButton.Text = " View Albums";
            this.ViewAlbumButton.UseVisualStyleBackColor = false;
            this.ViewAlbumButton.Click += new System.EventHandler(this.ViewAlbumButton_Click);
            // 
            // ViewPlaylistButton
            // 
            this.ViewPlaylistButton.BackColor = System.Drawing.Color.Gold;
            this.ViewPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewPlaylistButton.Location = new System.Drawing.Point(638, 563);
            this.ViewPlaylistButton.Name = "ViewPlaylistButton";
            this.ViewPlaylistButton.Size = new System.Drawing.Size(151, 43);
            this.ViewPlaylistButton.TabIndex = 20;
            this.ViewPlaylistButton.Text = "ViewPlaylist";
            this.ViewPlaylistButton.UseVisualStyleBackColor = false;
            this.ViewPlaylistButton.Click += new System.EventHandler(this.ViewPlaylistButton_Click);
            // 
            // SongNameErrorProvider1
            // 
            this.SongNameErrorProvider1.ContainerControl = this;
            // 
            // YearErrorProvider1
            // 
            this.YearErrorProvider1.ContainerControl = this;
            // 
            // GenreErrorProvider1
            // 
            this.GenreErrorProvider1.ContainerControl = this;
            // 
            // PerformerErrorProvider1
            // 
            this.PerformerErrorProvider1.ContainerControl = this;
            // 
            // DeleteErrorProvider1
            // 
            this.DeleteErrorProvider1.ContainerControl = this;
            // 
            // AddToMyPlaylistEP
            // 
            this.AddToMyPlaylistEP.ContainerControl = this;
            // 
            // PlaylistErrorProvider
            // 
            this.PlaylistErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 618);
            this.Controls.Add(this.ViewPlaylistButton);
            this.Controls.Add(this.ViewAlbumButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SongGridView1);
            this.Controls.Add(this.MyPlaylistButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputGenreId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputPerformer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputAlbum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputSongName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongNameErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformerErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddToMyPlaylistEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        

       

       

        

        #endregion

        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputSongName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputPerformer;
        private System.Windows.Forms.ComboBox InputGenreId;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MyPlaylistButton;
        private System.Windows.Forms.DataGridView SongGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ViewAlbumButton;
        private System.Windows.Forms.Button ViewPlaylistButton;
        private System.Windows.Forms.ErrorProvider SongNameErrorProvider1;
        private System.Windows.Forms.ErrorProvider YearErrorProvider1;
        private System.Windows.Forms.ErrorProvider GenreErrorProvider1;
        private System.Windows.Forms.ErrorProvider PerformerErrorProvider1;
        private System.Windows.Forms.ErrorProvider DeleteErrorProvider1;
        private System.Windows.Forms.ErrorProvider AddToMyPlaylistEP;
        private System.Windows.Forms.ErrorProvider PlaylistErrorProvider;
    }
}

