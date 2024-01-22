using Examen.Models;
using Examen.Service;
using System.Collections.ObjectModel;


namespace Examen;

public partial class InicioPage : ContentPage
{

    private readonly APIService _ApiService;
    public InicioPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        List<Tarea> listaTareas = await _ApiService.GetTareas();
        var tareas = new ObservableCollection<Tarea>(listaTareas);
        ListaTareas.ItemsSource = tareas;
    }

    private void Btn_Buscar(object sender, EventArgs e)
    {

    }

    private void Btn_Crear(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CrearPage());
    }
}