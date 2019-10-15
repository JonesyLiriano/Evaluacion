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
        int counterJsonFiles;
        Ejercicio3Model resultJson;
        Ejercicio3Model jsonFile;
        string[] jsonFiles;
        public Ejercicio3()
            {
            InitializeComponent();
            }

        private void Ejercicio3_Load(object sender, EventArgs e)
            {
            GetJsonFiles();
            counterJsonFiles = 0;
            }
        private void GetJsonFiles()
            {
            jsonFiles = Directory.GetFiles("../../Ejercicios3/");
            if (jsonFiles.Length > 0)
                {
                LoadValuesFromJson(jsonFiles[0]);
                }
            }
        private void LoadValuesFromJson(string json)
            {
            lbQuizCounter.Text = string.Format("Ejercicio #{0} de {1}", counterJsonFiles + 1, jsonFiles.Length);
            jsonFile = new Ejercicio3Model();
            jsonFile = JsonConvert.DeserializeObject<Ejercicio3Model>(File.ReadAllText(json));
            resultJson = new Ejercicio3Model()
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

            }
        private void GenerateJsonResult(string result)
            {
                {
                if (jsonFiles.Length > 1 && jsonFiles.Length > counterJsonFiles)
                    {
                    resultJson.result = result;
                    string serializeJson = JsonConvert.SerializeObject(resultJson);
                    using (var fileJson = new StreamWriter(string.Format("../../ResultadoEjercicio3/EjercicioPorcentaje{0}.json", counterJsonFiles), false))
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
        private void ChangeCounter()
            {
            if (jsonFiles.Length > 1 && jsonFiles.Length > counterJsonFiles)
                LoadValuesFromJson(jsonFiles[counterJsonFiles]);
            }

        }
    }
