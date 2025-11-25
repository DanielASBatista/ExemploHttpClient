using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ExercicioHttpClient.Models;
using ExercicioHttpClient.Services;

namespace ExercicioHttpClient.ViewModels
{
    public class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public int userid;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
    
        public async void CarregarPostagens()
        {
            List<Postagem> Listar = new List<Postagem>();
            Listar = await new PostagensService().GetPostagens();
        }
    
    }
}