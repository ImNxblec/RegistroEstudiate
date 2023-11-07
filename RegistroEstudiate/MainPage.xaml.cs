namespace RegistroEstudiate
{

    public partial class MainPage : ContentPage
    {
        public Estudiante MiEstudiante { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = MiEstudiante;
        }
        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro ", MiEstudiante.Nombre + " Sus datos se ingresaron correctamente", "ok");
        }
    }
}