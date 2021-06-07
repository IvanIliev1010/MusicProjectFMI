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
            ((System.ComponentModel.ISupportInitialize)(this.SongGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputId.Location = new System.Drawing.Point(124, 67);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(181, 26);
            this.InputId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Song Name";
            // 
            // InputSongName
            // 
            this.InputSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputSongName.Location = new System.Drawing.Point(124, 114);
            this.InputSongName.Name = "InputSongName";
            this.InputSongName.Size = new System.Drawing.Size(181, 26);
            this.InputSongName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // InputYear
            // 
            this.InputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputYear.Location = new System.Drawing.Point(124, 175);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(181, 26);
            this.InputYear.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Album";
            // 
            // InputAlbum
            // 
            this.InputAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputAlbum.Location = new System.Drawing.Point(124, 281);
            this.InputAlbum.Name = "InputAlbum";
            this.InputAlbum.Size = new System.Drawing.Size(181, 26);
            this.InputAlbum.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Performer";
            // 
            // InputPerformer
            // 
            this.InputPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputPerformer.Location = new System.Drawing.Point(124, 334);
            this.InputPerformer.Name = "InputPerformer";
            this.InputPerformer.Size = new System.Drawing.Size(181, 26);
            this.InputPerformer.TabIndex = 10;
            // 
            // InputGenreId
            // 
            this.InputGenreId.FormattingEnabled = true;
            this.InputGenreId.ItemHeight = 16;
            this.InputGenreId.Location = new System.Drawing.Point(124, 232);
            this.InputGenreId.Name = "InputGenreId";
            this.InputGenreId.Size = new System.Drawing.Size(181, 24);
            this.InputGenreId.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.Location = new System.Drawing.Point(16, 447);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 43);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateButton.Location = new System.Drawing.Point(170, 447);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(104, 43);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(333, 447);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 43);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MyPlaylistButton
            // 
            this.MyPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MyPlaylistButton.Location = new System.Drawing.Point(781, 447);
            this.MyPlaylistButton.Name = "MyPlaylistButton";
            this.MyPlaylistButton.Size = new System.Drawing.Size(206, 43);
            this.MyPlaylistButton.TabIndex = 16;
            this.MyPlaylistButton.Text = "Add to MyPlaylist";
            this.MyPlaylistButton.UseVisualStyleBackColor = true;
            this.MyPlaylistButton.Click += new System.EventHandler(this.MyPlaylistButton_Click);
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
            this.SongGridView1.Location = new System.Drawing.Point(333, 67);
            this.SongGridView1.Name = "SongGridView1";
            this.SongGridView1.ReadOnly = true;
            this.SongGridView1.RowHeadersWidth = 51;
            this.SongGridView1.RowTemplate.Height = 24;
            this.SongGridView1.Size = new System.Drawing.Size(654, 349);
            this.SongGridView1.TabIndex = 17;
            this.SongGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SongGridView1_RowHeaderMouseClick);
            this.SongGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SongGridView1_RowHeaderMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 518);
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
    }
}

