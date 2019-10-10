using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Ejercicio1 : Form
        {
        DataTable dtOriginal = new DataTable();
        DataTable dtOrdenado = new DataTable();
        StringBuilder datos = new StringBuilder();
        public Ejercicio1()
            {
            InitializeComponent();
            }

        private void Ejercicio1_Load(object sender, EventArgs e)
            {
            InicializarDataTable();
            CargarDGVOriginal();
            }

        private void btnEmpezar_Click(object sender, EventArgs e)
            {
            OrdenarDGV();
            GuardarFilasDGVOrdenado();
            GenerarCSV();
            MessageBox.Show("Proceso finalizado, verifique el archivo generado.","Proceso concluido.",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        private void InicializarDataTable()
            {
            dtOriginal.Columns.Add("Nombre");
            dtOriginal.Columns.Add("Cedula");
            dtOrdenado.Columns.Add("Nombre");
            dtOrdenado.Columns.Add("Cedula");
            }
        private void CargarDGVOriginal()
            {
            try {
                //Verificar ruta del archivo Ejercicio1 (3).csv
                using (TextFieldParser csvLector = new TextFieldParser("../../Mocks/Ejercicio1 (3).csv"))
                    {
                    csvLector.SetDelimiters(new string[] { "," });

                    while (!csvLector.EndOfData)
                        {
                        string[] registro = csvLector.ReadFields();
                        dtOriginal.Rows.Add(registro);

                        }
                    dgvOriginal.DataSource = dtOriginal;
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
            }

        private void OrdenarDGV()
            {
            // Primero se realiza un query al dtOriginal y se separa la cedula por guiones,
            // luego se ordena mediante las diferentes partes que se obtuvo al separar la cedula,
            // tambien se devuelve el campo nombre y cedula completo en la misma consulta.

            var query = dtOriginal.AsEnumerable().Select(e =>
            {
                var t = e.Field<string>("Cedula").Split('-');
                return new
                    {
                    parte1 = int.Parse(t[2]),
                    parte2 = int.Parse(t[1]),
                    parte3 = int.Parse(t[0]),
                    nombre = e.Field<string>("Nombre"),
                    cedula = e.Field<string>("Cedula")
                    };
            })
                 .OrderBy(x => x.parte1)
                 .ThenBy(x => x.parte2)
                 .ThenBy(x => x.parte3).Select(q => {
                     return new
                         {
                         q.nombre,
                         q.cedula
                         };
                 });

            dgvOrdenado.DataSource = query.ToList();
            }

        private void GuardarFilasDGVOrdenado()
            {
            foreach (DataGridViewRow fila in dgvOrdenado.Rows)
                {
                var campos = fila.Cells.Cast<DataGridViewCell>();
                datos.AppendLine(string.Join(",", campos.Select(campo => campo.Value).ToArray()));
                }
            }
        private void GenerarCSV()
            {
            try
                {
                // Verificar ruta donde se guardara el archivo CSV
                using (StreamWriter archivoCSV = new StreamWriter(
                    "../../ResultadoEjercicio1/ArchivoCedulasOrdenadas.csv", false))
                    {
                    archivoCSV.WriteLine(datos);
                    archivoCSV.Close();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
            }
        }
    
}
