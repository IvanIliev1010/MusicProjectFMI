using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicProjectFmi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicProjectFmi.Repositories;

namespace MusicProjectFmi
{
    static class StartUp
    {
        public static IServiceProvider ServiceProvider { get; set; }
/*
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-N9LJF86\\MSSQLSERVER01; Database= MusicDb; Trusted_Connection=True");
            });
            services.AddScoped<ISongRepository, SongRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IPerformerRepository, PerformerRepository>();
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IMyPlaylistRepository, MyPlaylistRepository>();
            services.AddScoped<ISongsPerformersRepository, SongsPerformersRepository>();
            
            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm1());
        }*/
    }
}
