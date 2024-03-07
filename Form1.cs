namespace Asignatura_Profesor_Radio_13_7_3_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            String Modalidad, Profesor, Asignatura;
            if (rb_Presencial.Checked)
            {
                Modalidad = rb_Presencial.Text;
            }

            else { Modalidad = rb_Virtual.Text; }

            Profesor = txt_Profesor.Text;
            Asignatura = txt_Asignatura.Text;

            MessageBox.Show("Modalidad:  " + Modalidad + "\n" + "Asignatura:  " + Asignatura.ToString() + "\n" +"Profesor:  " +  Profesor.ToString());
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Asignatura.Clear();
            txt_Profesor.Clear();
            rb_Presencial.Checked = false;
            rb_Virtual.Checked = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}