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
        int counterJsonFiles;
        Ejercicio4Model resultJson;
        Ejercicio4Model jsonFile;
        string[] jsonFiles;
        int counter;
        Ejercicio4Model loadJson;
        string finalResult;
        public Ejercicio4()
            {
            InitializeComponent();
            }

        private void Ejercicio4_Load(object sender, EventArgs e)
            {
            counter = 0;
            GetJsonFiles();
            counterJsonFiles = 0;
            }
        private void GetJsonFiles()
            {
            jsonFiles = Directory.GetFiles("../../Ejercicios4/");
            if (jsonFiles.Length > 0)
                {
                LoadValuesFromJson(jsonFiles[0]);
                }
            }
        private void LoadValuesFromJson(string json)
            {
            lbQuizCounter.Text = string.Format("Ejercicio #{0} de {1}", counterJsonFiles + 1, jsonFiles.Length);
            jsonFile = new Ejercicio4Model();
            jsonFile = JsonConvert.DeserializeObject<Ejercicio4Model>(File.ReadAllText(json));
            resultJson = new Ejercicio4Model()
                {
                instruction = jsonFile.instruction,
                problem = jsonFile.problem,
                options = jsonFile.options,
                result = "0"
                };
            Instruction.Text = resultJson.instruction;
            problem.Text = resultJson.problem;
            option1.Text = resultJson.options.ToArray()[0];
            option2.Text = resultJson.options.ToArray()[1];
            option3.Text = resultJson.options.ToArray()[2];
            option4.Text = resultJson.options.ToArray()[3];
            option5.Text = resultJson.options.ToArray()[4];
            option6.Text = resultJson.options.ToArray()[5];

            }
        private void GenerateJsonResult(string result)
            {
                {
                if (jsonFiles.Length > 1 && jsonFiles.Length > counterJsonFiles)
                    {
                    resultJson.result = result;
                    string serializeJson = JsonConvert.SerializeObject(resultJson);
                    using (var fileJson = new StreamWriter(string.Format("../../ResultadoEjercicio4/EjercicioEscritura{0}.json", counterJsonFiles), false))
                        {
                        fileJson.WriteLine(serializeJson.ToString());
                        fileJson.Close();
                        }
                    if (resultJson.result == jsonFile.result)
                        {
                        MessageBox.Show("Felicidades!, Ha elegido la respuesta correcta.");
                        }
                    else
                        {
                        MessageBox.Show(string.Format("Lo siento, No ha elegido una respuesta valida. Respuesta Correcta: {0}", jsonFile.result));
                        }
                    counter = 0;
                    counterJsonFiles++;
                    ChangeCounter();
                    }
                else
                    {
                    MessageBox.Show("No hay ejercicios para mostrar");
                    }

                }
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
            finalResult += result + " ";
            counter++;
            if (counter == 3 || !(jsonFiles.Length > counterJsonFiles))
                {                
                GenerateJsonResult(finalResult);
                }
            }
        private void ChangeCounter()
            {
            if (jsonFiles.Length > 1 && jsonFiles.Length > counterJsonFiles)
                LoadValuesFromJson(jsonFiles[counterJsonFiles]);
            }
        }
}
