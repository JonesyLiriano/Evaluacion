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
    public partial class Ejercicio4 : Form
    {
        int counter;
        Ejercicio4Model loadJson;
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
            {
            counter = 0;
            LoadValuesFromJson();
            }
        private void LoadValuesFromJson()
            {
            loadJson = new Ejercicio4Model()
                {
                instruction = "Escribe el numero siguiente presionando los botones en el orden correcto.",
                problem = "47,935",
                options = new List<string>() { "treinta y seis", "once mil", "ochenta y dos", "treinta y cinco", "mil novecientos", "cuarenta y siente" },
                result = ""
                };
            Instruction.Text = loadJson.instruction;
            problem.Text = loadJson.problem;
            option1.Text = loadJson.options.ToArray()[0];
            option2.Text = loadJson.options.ToArray()[1];
            option3.Text = loadJson.options.ToArray()[2];
            option4.Text = loadJson.options.ToArray()[3];

            }
        private void GenerateJsonResult()
            {            
            string serializeJson = JsonConvert.SerializeObject(loadJson);
            using (var fileJson = new StreamWriter(
                "../../ResultadoEjercicio4/EjercicioEscritura.json", false))
                {
                fileJson.WriteLine(serializeJson.ToString());
                fileJson.Close();
                }
            MessageBox.Show("Opcion elegida, Json ha sido generado.");
            }

        private void option1_Click(object sender, EventArgs e)
            {
            CheckCounter(option1.Text);
            }

        private void option3_Click(object sender, EventArgs e)
            {
            CheckCounter(option3.Text);
            }

        private void option2_Click(object sender, EventArgs e)
            {
            CheckCounter(option2.Text);
            }

        private void option4_Click(object sender, EventArgs e)
            {
            CheckCounter(option4.Text);
            }

        private void option5_Click(object sender, EventArgs e)
            {
            CheckCounter(option5.Text);
            }

        private void option6_Click(object sender, EventArgs e)
            {
            CheckCounter(option6.Text);
            }
        private void CheckCounter(string result)
            {
            loadJson.result += result + " ";
            counter++;
            if (counter == 3)
                {
                
                GenerateJsonResult();
                }
            }
        }
}
