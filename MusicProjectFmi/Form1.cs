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
using System.Windows.Controls;
using System.Windows.Forms;

namespace MusicProjectFmi
{
    public partial class Form1 : Form
    {
        private readonly ISongRepository _songRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IPerformerRepository _performerRepository;
        private readonly ISongsPerformersRepository _songPerformerRepository;
        private readonly IAlbumRepository _albumRepository;
        public Form1()
        {
            _songRepository = (ISongRepository)Program.ServiceProvider.GetService(typeof(ISongRepository));
            _genreRepository = (IGenreRepository)Program.ServiceProvider.GetService(typeof(IGenreRepository));
            _performerRepository = (IPerformerRepository)Program.ServiceProvider.GetService(typeof(IPerformerRepository));
            _songPerformerRepository = (ISongsPerformersRepository)Program.ServiceProvider.GetService(typeof(ISongsPerformersRepository));
            _albumRepository = (IAlbumRepository)Program.ServiceProvider.GetService(typeof(IAlbumRepository));
            
            InitializeComponent();
            OnStart();
        }
        private void OnStart()
        {
            
            SongGridView1.ColumnCount = 6;
            SongGridView1.Columns[0].Name = "Id"; 
            SongGridView1.Columns[1].Name = "Song Name"; 
            SongGridView1.Columns[2].Name = "Year"; 
            SongGridView1.Columns[3].Name = "Genre"; 
            SongGridView1.Columns[4].Name = "Album"; 
            SongGridView1.Columns[5].Name = "Performer";
            List<Song> songs = _songRepository.GetAllSongs.ToList();
            for(int i=0;i<songs.Count;i++)
            {
                int songId = songs[i].Id;
                List<Performer> performers = _songPerformerRepository.GetSongPerformers(songId).Select(sp => sp.Performer).ToList();
                string performersNames = string.Join(",", performers.Select(p => p.Name));//create string of names of the performers devided by ","

                this.SongGridView1.Rows.Add(
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


        private void SongGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void SongGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedrowindex = SongGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = SongGridView1.Rows[selectedrowindex];
            InputId.Text = selectedRow.Cells[0].Value.ToString();
            InputSongName.Text = selectedRow.Cells[1].Value.ToString();
            InputYear.Text = selectedRow.Cells[2].Value.ToString();
            InputGenreId.Text = selectedRow.Cells[3].Value.ToString();
            InputAlbum.Text = selectedRow.Cells[4].Value.ToString();
            InputPerformer.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Song newSong = new Song();
            newSong.Name = InputSongName.Text;
            newSong.Year = int.Parse(InputYear.Text);
            newSong.GenreId = _genreRepository.GetAllGenres.FirstOrDefault(g => g.Name == InputGenreId.Text).Id;
            List<string> performersNames = InputPerformer.Text.Split(',').ToList();
            for (int i = 0; i < performersNames.Count; i++)
            {
                var ExistingPerformer = _performerRepository.GetPerformerByName(performersNames[i]);
                if (ExistingPerformer == null)
                {
                    if (performersNames[i].Length != 0 && performersNames[i] != " ")
                    {
                        Performer newPerformer = new Performer();
                        newPerformer.Name = performersNames[i];
                        _performerRepository.AddPerformer(newPerformer);
                    }
                }

            }
            if(InputAlbum.Text.Length!=0 && InputAlbum.Text !=" " )
            {
                Album ExistingAlbum = _albumRepository.GetAlbumByName(InputAlbum.Text);
                
                if(ExistingAlbum == null)
                {
                    Album newAlbum = new Album();
                    newAlbum.Name = InputAlbum.Text;
                    newAlbum.PerformerId = _performerRepository.GetPerformerByName(InputPerformer.Text).Id;
                    _albumRepository.AddAlbum(newAlbum);
                    newSong.AlbumId = newAlbum.Id;

                }
                else
                {
                    newSong.AlbumId = ExistingAlbum.Id;
                }

            }
            else
            {
                newSong.AlbumId = _albumRepository.GetAlbumByName("null").Id;
            }

            _songRepository.Add(newSong);

            for (int i = 0; i < performersNames.Count; i++)
            {
                var performer = _performerRepository.GetPerformerByName(performersNames[i]);
                SongPerformer songPerformer = new SongPerformer { SongId = newSong.Id, PerformerId = performer.Id };
                _songPerformerRepository.Add(songPerformer);
                
            }

            OnStart();
            ClearForm();
        }

        private void ClearForm()
        {
            InputId.Text = "";
            InputSongName.Text = "";
            InputYear.Text = "";
            InputGenreId.Text = "";
            InputAlbum.Text = "";
            InputPerformer.Text = "";


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Song currentSong = _songRepository.GetSongById(int.Parse(InputId.Text));
            currentSong.Name = InputSongName.Text;
            currentSong.Year = int.Parse(InputYear.Text);
            List<string> performersNames = InputPerformer.Text.Split(',').ToList();
            for (int i = 0; i < performersNames.Count; i++)
            {
                var ExistingPerformer = _performerRepository.GetPerformerByName(performersNames[i]);
                if (ExistingPerformer == null)
                {
                    if (performersNames[i].Length != 0 && performersNames[i] != " ")
                    {
                        Performer newPerformer = new Performer();
                        newPerformer.Name = performersNames[i];
                        _performerRepository.AddPerformer(newPerformer);
                    }
                }

            }

            if (InputAlbum.Text.Length != 0 && InputAlbum.Text != " ")
            {
                Album ExistingAlbum = _albumRepository.GetAlbumByName(InputAlbum.Text);

                if (ExistingAlbum == null)
                {
                    Album newAlbum = new Album();
                    newAlbum.Name = InputAlbum.Text;
                    newAlbum.PerformerId = _performerRepository.GetPerformerByName(InputPerformer.Text).Id;
                    _albumRepository.AddAlbum(newAlbum);
                    currentSong.AlbumId = newAlbum.Id;

                }
                else
                {
                    currentSong.AlbumId = ExistingAlbum.Id;
                }

            }
            else
            {
                currentSong.AlbumId = _albumRepository.GetAlbumByName("null").Id;
            }
            _songRepository.Update(currentSong);
            currentSong.GenreId = _genreRepository.GetAllGenres.FirstOrDefault(g => g.Name == InputGenreId.Text).Id;
            List<SongPerformer> songPerformers = _songPerformerRepository.GetSongPerformers(currentSong.Id).ToList();
            for(int i=0;i<songPerformers.Count;i++)
            {
                _songPerformerRepository.Delete(songPerformers[i]);
            }
            
            for (int i = 0; i < performersNames.Count; i++)
            {
                var performer = _performerRepository.GetPerformerByName(performersNames[i]);

                SongPerformer songPerformer = new SongPerformer { SongId = currentSong.Id, PerformerId = performer.Id };
                _songPerformerRepository.Add(songPerformer);

            }
            ClearForm();
            OnStart();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void MyPlaylistButton_Click(object sender, EventArgs e)
        {

        }
    }
}
