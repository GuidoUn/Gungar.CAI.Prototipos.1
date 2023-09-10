namespace Gungar.CAI.Prototipos._1
{
    public partial class Ejercicio01 : Form
    {
        Ejercicio01Model model;

        public Ejercicio01()
        {
            InitializeComponent();
        }

        private void ReiniciarForm()
        {
            this.documentoText.ResetText();
            this.nombreText.ResetText();
            this.apellidoText.ResetText();
            this.nacimientoDate.Value = DateTime.Now;
        }

        private void Ejercicio01_Load(object sender, EventArgs e)
        {
            model = new Ejercicio01Model();
            this.nacimientoDate.Value = DateTime.Now;
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            model.DocumentoIngresado = this.documentoText.Text;
            model.NombreIngresado = this.nombreText.Text;
            model.ApellidoIngresado = this.apellidoText.Text;
            model.NacimientoIngresado = this.nacimientoDate.Value;

            string mensaje = model.Validar();
            this.resultadoText.Text = mensaje;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }
    }
}