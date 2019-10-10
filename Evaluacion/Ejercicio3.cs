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
    public partial class Ejercicio3 : Form
    {
        Ejercicio3Model loadJson;
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
            {
            LoadValuesFromJson();
            }
        private void LoadValuesFromJson()
            {
            loadJson = new Ejercicio3Model()
                {
                instruction = "Completa correctamente la oracion arrastrando al espacio en blanco la cantidad que corresponda.",
                problem = "Aumentar en un 35% la cantidad de 4,720, resulta en:",
                options = new List<string>() { "6,372", "6.370", "130", "135" },
                result = "0"
                };
            Instruction.Text = loadJson.instruction;
            problem.Text = loadJson.problem;            
            option1.Text = loadJson.options.ToArray()[0];
            option2.Text = loadJson.options.ToArray()[1];
            option3.Text = loadJson.options.ToArray()[2];
            option4.Text = loadJson.options.ToArray()[3];

            }
        private void GenerateJsonResult(string result)
            {
            loadJson.result = result;
            string serializeJson = JsonConvert.SerializeObject(loadJson);
            using (var fileJson = new StreamWriter(
                "../../ResultadoEjercicio3/EjercicioPorcentaje.json", false))
                {
                fileJson.WriteLine(serializeJson.ToString());
                fileJson.Close();
                }
            MessageBox.Show("Opcion elegida, Json ha sido generado.");
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
        }


}
