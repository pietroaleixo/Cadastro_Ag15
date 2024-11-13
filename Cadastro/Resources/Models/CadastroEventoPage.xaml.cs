using System.Windows.Input;

namespace Cadastro.Resources.Models;

public partial class CadastroEventoPage : ContentPage
{
    public Evento Evento { get; set; }
    public ICommand CadastrarEventoCommand { get; }

    public CadastroEventoPage()
    {
        InitializeComponent();
        Evento = new Evento();
        CadastrarEventoCommand = new Command(CadastrarEvento);
        BindingContext = this;
    }

    private void DataInicio(object sender, DateChangedEventArgs e)
    {


    }  
        private void DataTermino(object sender, DateChangedEventArgs e)
    {


    }

    private async void CadastrarEvento()
    {
        await Navigation.PushAsync(new ResumoEventoPage(Evento));
    }
}