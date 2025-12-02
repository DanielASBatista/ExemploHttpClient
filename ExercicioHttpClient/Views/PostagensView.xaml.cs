using ExercicioHttpClient.ViewModels;

namespace ExercicioHttpClient.Views;

public partial class PostagensView : ContentPage
{
	public PostagensView()
	{
		InitializeComponent();
		this.BindingContext = new PostagensViewModel();
	}
}