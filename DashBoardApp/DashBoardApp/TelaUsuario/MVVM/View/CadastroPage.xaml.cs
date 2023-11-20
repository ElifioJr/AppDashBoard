using DashBoardApp.TelaUsuario.MVVM.ViewModel;

namespace DashBoardApp.TelaUsuario.MVVM.View;

public partial class CadastroPage : ContentPage
{
	public CadastroPage(CadastroPageViewModel cadastroPageViewModel)
	{

		InitializeComponent();
		BindingContext = cadastroPageViewModel;
	}
}