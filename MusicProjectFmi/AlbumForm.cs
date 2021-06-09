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
    public partial class AlbumForm : Form
    {
        private readonly ISongRepository _songRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IPerformerRepository _performerRepository;
        private readonly ISongsPerformersRepository _songPerformerRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly IMyPlaylistRepository _myPlaylistRepository;
        public AlbumForm()
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

            AlbumGridView1.ColumnCount = 6;
            AlbumGridView1.Columns[0].Name = "Id";
            AlbumGridView1.Columns[1].Name = "Song Name";
            AlbumGridView1.Columns[2].Name = "Year Of Release";
            AlbumGridView1.Columns[3].Name = "Genre";
            AlbumGridView1.Columns[4].Name = "Album";
            AlbumGridView1.Columns[5].Name = "Performer";
            List<Album> albums = _albumRepository.GetAllAlbums.ToList();
            for(int i=0;i<albums.Count;i++)
            {
                albumComboBox.Items.Add(albums[i].Name);
            }

         /*
            List<Song> songs = _songRepository.GetAllSongs.ToList();
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

                this.AlbumGridView1.Rows.Add(
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
           // this.Genre.Items.AddRange(genreNames);
         */
        }



        private void HomepageButton_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void AlbumGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedrowindex = AlbumGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = AlbumGridView1.Rows[selectedrowindex];
            InputId.Text = selectedRow.Cells[0].Value.ToString();
            InputSongName.Text = selectedRow.Cells[1].Value.ToString();
            InputYear.Text = selectedRow.Cells[2].Value.ToString();
            InputGenreId.Text = selectedRow.Cells[3].Value.ToString();
            InputAlbum.Text = selectedRow.Cells[4].Value.ToString();
            InputPerformer.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            OnStart();
            int albumId = _albumRepository.GetAlbumByName(albumComboBox.Text).Id;
            List<Song> songs = _songRepository.GetAllSongs.Where(s=>s.AlbumId==albumId).ToList();
            for (int i = 0; i < songs.Count; i++)
            {
                int songId = songs[i].Id;
                List<SongPerformer> songsperformers = _songPerformerRepository.GetSongPerformers(songId).ToList();
                List<Performer> performers = new List<Performer>();
                foreach (var songperfomer in songsperformers)
                {
                    performers.Add(_performerRepository.GetAllPerformers.First(per => per.Id == songperfomer.PerformerId));
                }
                string performersNames = string.Join(",", performers.Select(p => p.Name));//create string of names of the performers devided by ","

                this.AlbumGridView1.Rows.Add(
                    songs[i].Id,
                    songs[i].Name,
                    songs[i].Year,
                    songs[i].Genre.Name,
                    songs[i].Album.Name,
                    performersNames
                    );
            }         
        }
        private void ClearForm()
        {
            InputId.Text = "";
            InputSongName.Text = "";
            InputYear.Text = "";
            InputGenreId.Text = "";
            InputAlbum.Text = "";
            InputPerformer.Text = "";
            AlbumGridView1.Rows.Clear();
            albumComboBox.Items.Clear();

        }
    }
}
