using DashBoardApp.TelaUsuario.MVVM.View;

namespace DashBoardApp
    {
    public partial class AppShell : Shell
        {
        public AppShell()
            {
            InitializeComponent();
            RegisterForRoute<CadastroPage>();
            }

        private void RegisterForRoute<T>()
            {
            Routing.RegisterRoute(typeof(T).Name, typeof(T));   
            }

        
        }
    }