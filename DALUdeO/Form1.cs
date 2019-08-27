using DALUdeO.DataClass;
using DALUdeO.Reader;
using Modelos.Persona;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALUdeO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PersonaModel personaModel = new PersonaModel();
            //personaModel.IdPersona = 1;
            personaModel.Apellido = "Shark";
            personaModel.Nombre = "Quintuss";
            personaModel.Direccion = "Zona 1";
            //personaModel.FecNac = DateTime.Now;
            PersonaReader reader = new PersonaReader(QuerysRepo.TipoQuery.AddRow, personaModel);
            Collection<PersonaModel> people = reader.Execute();

            foreach (PersonaModel p in people)
                MessageBox.Show(string.Format("{0}, {1}: {2}", p.Nombre, p.Apellido, p.Direccion));

        }
    }
}
