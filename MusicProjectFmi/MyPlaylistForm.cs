using MusicProjectFmi.Data.Models;
using MusicProjectFmi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProjectFmi
{
    public partial class MyPlaylistForm : Form
    {
        private readonly ISongRepository _songRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IPerformerRepository _performerRepository;
        private readonly ISongsPerformersRepository _songPerformerRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly IMyPlaylistRepository _myPlaylistRepository;
        public MyPlaylistForm()
        {
            _songRepository = (ISongRepository)Program.ServiceProvider.GetService(typeof(ISongRepository));
            _genreRepository = (IGenreRepository)Program.ServiceProvider.GetService(typeof(IGenreRepository));
            _performerRepository = (IPerformerRepository)Program.ServiceProvider.GetService(typeof(IPerformerRepository));
            _songPerformerRepository = (ISongsPerformersRepository)Program.ServiceProvider.GetService(typeof(ISongsPerformersRepository));
            _albumRepository = (IAlbumRepository)Program.ServiceProvider.GetService(typeof(IAlbumRepository));
            _myPlaylistRepository = (IMyPlaylistRepository)Program.ServiceProvider.GetService(typeof(IMyPlaylistRepository));

            InitializeComponent();
            OnStart();
        }
        private void OnStart()
        {

           dataGridView1.ColumnCount = 6;
           dataGridView1.Columns[0].Name = "Id";
           dataGridView1.Columns[1].Name = "Song Name";
           dataGridView1.Columns[2].Name = "Year";
           dataGridView1.Columns[3].Name = "Genre";
           dataGridView1.Columns[4].Name = "Album";
           dataGridView1.Columns[5].Name = "Performer";
            List<int> songsId = _myPlaylistRepository.GetAllSongIds.ToList();
            List<Song> songs = new List<Song>(); //generate only songs from myPlaylist
            for(int i=0;i<songsId.Count;i++)
            {
                songs.Add(_songRepository.GetSongById(songsId[i])); // acess by Id, then shows it on MyPlaylist
            }
            for (int i = 0; i < songs.Count; i++)
            {
                int songId = songs[i].Id;
                // List<Performer> performers = _songPerformerRepository.GetSongPerformers(songId).Select(sp => sp.Performer).ToList();
                List<SongPerformer> songsperformers = _songPerformerRepository.GetSongPerformers(songId).ToList();
                List<Performer> performers = new List<Performer>();
                foreach (var songperfomer in songsperformers)
                {
                    performers.Add(_performerRepository.GetAllPerformers.First(per => per.Id == songperfomer.PerformerId));
                }
                string performersNames = string.Join(",", performers.Select(p => p.Name));//create string of names of the performers devided by ","

                this.dataGridView1.Rows.Add(
                    songs[i].Id,
                    songs[i].Name,
                    songs[i].Year,
                    songs[i].Genre.Name,
                    songs[i].Album.Name,
                    performersNames
                    );
            }
            var genreNames = _genreRepository.GetAllGenres
                .Select(g => g.Name).ToArray();
            this.InputGenreId.Items.AddRange(genreNames);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            InputId.Text = selectedRow.Cells[0].Value.ToString();
            InputSongName.Text = selectedRow.Cells[1].Value.ToString();
            InputYear.Text = selectedRow.Cells[2].Value.ToString();
            InputGenreId.Text = selectedRow.Cells[3].Value.ToString();
            InputAlbum.Text = selectedRow.Cells[4].Value.ToString();
            InputPerformer.Text = selectedRow.Cells[5].Value.ToString();
        }
        private void ClearForm()
        {
            InputId.Text = "";
            InputSongName.Text = "";
            InputYear.Text = "";
            InputGenreId.Text = "";
            InputAlbum.Text = "";
            InputPerformer.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
           
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveButton_Validating(sender, new CancelEventArgs());
            }
            catch (ArgumentException)
            {
                return;

            }
            DialogResult dialogResult = MessageBox.Show("Remove from MyPlaylist?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var currentId = int.Parse(InputId.Text);
                var song = _myPlaylistRepository.GetAllMyPlaylists.First(s => s.SongId == currentId);
                _myPlaylistRepository.Delete(song);
                ClearForm();
                OnStart();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void RemoveButton_Validating(object sender, CancelEventArgs e)
        {
            if(InputId.Text.Length==0 && InputId.Text=="")
            {
                DeleteErrorProvider1.SetError(this.RemoveButton, "Song was not choosen!");
                throw new ArgumentException();
            }
            else
            {
                DeleteErrorProvider1.Clear();
            }
        }
    }
}
