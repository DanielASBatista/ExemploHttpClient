using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using ExercicioHttpClient.Models;
using ExercicioHttpClient.Services;

namespace ExercicioHttpClient.ViewModels
{
    public partial class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public int userid;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        public ICommand CarregarPostagensCommand => new Command(async () => CarregarPostagens());
        List<Postagem> Listar = new List<Postagem>();
        public async void CarregarPostagens()
        {
            Listar = await new PostagensService().GetPostagens();
        }
    }
}