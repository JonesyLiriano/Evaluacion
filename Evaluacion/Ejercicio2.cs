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
using Evaluacion.Models;
using Newtonsoft.Json;

namespace Evaluacion
{
    public partial class Ejercicio2 : Form
    {
        Ejercicio2Model loadJson;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
            {
            LoadValuesFromJson();            
            }

        private void LoadValuesFromJson()
            {
            loadJson = new Ejercicio2Model()
                {
                instruction = "Selecciona el resultado de la siguiente suma.",
                problem = new List<string>() { "13,064", "66,318"},
                options = new List<string>() { "79,382", "53,459", "12,193", "96,408" },
                result = "0"
                };
            Instruction.Text = loadJson.instruction;
            number1.Text = loadJson.problem.ToArray()[0];
            number2.Text = loadJson.problem.ToArray()[1];
            option1.Text = loadJson.options.ToArray()[0];
            option2.Text = loadJson.options.ToArray()[1];
            option3.Text = loadJson.options.ToArray()[2];
            option4.Text = loadJson.options.ToArray()[3];
            
            }

        private void option1_Click(object sender, EventArgs e)
            {
            GenerateJsonResult(option1.Text);
            }

        private void option2_Click(object sender, EventArgs e)
            {
            GenerateJsonResult(option2.Text);
            }

        private void option3_Click(object sender, EventArgs e)
            {
            GenerateJsonResult(option3.Text);
            }

        private void option4_Click(object sender, EventArgs e)
            {
            GenerateJsonResult(option4.Text);
            }

        private void GenerateJsonResult(string result)
            {
            loadJson.result = result;
            string serializeJson = JsonConvert.SerializeObject(loadJson);
            using (var fileJson = new StreamWriter("../../ResultadoEjercicio2/EjercicioSuma.json", false))
                {
                fileJson.WriteLine(serializeJson.ToString());
                fileJson.Close();
                }
            MessageBox.Show("Opcion elegida, Json ha sido generado.");
            }
        }
}
