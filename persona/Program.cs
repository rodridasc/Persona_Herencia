using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona
{
    public class Persona //clase padre
    {
        //En esta parte se esta realizando el constructor, con diferentes tipos de datos



        private string Nombre;
        private string Apellidos;
        private string Fecha;
        private string Edad;


        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string apellido
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public string edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public Persona(string Pnombre, string Papellidos, string Pfecha, string Edades)
        {
            nombre = Pnombre;
            apellido = Papellidos;
            fecha = Pfecha;
            edad = Edades;

        }

    }

    class Alumno : Persona //clase hija alumno
    {

        private string Matricula;
        private string Carrera;

        public String matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public String carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public Alumno(string Pnombre, string Papellidos, string Pfecha, string Edades, string Pmatricula, string Pcarrera)
            : base(Pnombre, Papellidos, Pfecha, Edades)
        {
            matricula = Pmatricula;
            carrera = Pcarrera;

        }



        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        private string Matricula;
        private string Carrera;
        private string Salario;

        public String matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public String carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public String salario
        {
            get { return Salario; }
            set { Salario = value; }
        }
        public Empleado(string Pnombre, string Papellidos, string Pfecha, string Edades, string Pmatricula, string Pcarrera, string Psalario)
            : base(Pnombre, Papellidos, Pfecha, Edades)
        {
            matricula = Pmatricula;
            carrera = Pcarrera;
            salario = Psalario;

        }
    }

    class Docente : Persona //clase Hija
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        private string Matricula;
        private string Carrera;
        private string Salario;

        public String matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public String carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public String salario
        {
            get { return Salario; }
            set { Salario = value; }
        }
        public Docente(string Pnombre, string Papellidos, string Pfecha, string Edades, string Pmatricula, string Pcarrera, string Psalario)
            : base(Pnombre, Papellidos, Pfecha, Edades)
        {
            matricula = Pmatricula;
            carrera = Pcarrera;
            salario = Psalario;

        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Alumno alumno = new Alumno("Daniel", "Perez", "20/04/03", "20", "Id22051", "Ing Software");


        }


    }
}
