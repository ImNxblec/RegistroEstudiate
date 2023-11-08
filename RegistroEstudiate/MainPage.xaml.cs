namespace RegistroEstudiate
{

    public partial class MainPage : ContentPage
    {
        private string titulo = "Registro";
        public Estudiante MiEstudiante { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = MiEstudiante;
        }

        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var messaje = $"{MiEstudiante.Nombre} sus datos se ingresaron correctamente";
                DisplayAlert(titulo, messaje, "ok");
            }     
        }

        private bool IsValid()
        {
            if (String.IsNullOrEmpty(MiEstudiante.Nombre)) 
            {
                DisplayAlert(titulo, "ERROR CAMPO DEL NOMBRE VACIOS", "ok");
                return false;
            }
            if (String.IsNullOrEmpty(MiEstudiante.Apellido))
            {
                DisplayAlert(titulo, "ERROR CAMPO DEL APELLIDO VACIOS", "ok");
                return false;
            }
            if (String.IsNullOrEmpty(MiEstudiante.Materia))
            {
                DisplayAlert(titulo, "ERROR CAMPO DEL MATERIA VACIOS", "ok");
                return false;
            }
            return true;
        }
    }
}