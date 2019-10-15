using Evaluacion.Models;
using Newtonsoft.Json;
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
    public partial class GeneradorEjercicio : Form
        {
        Ejercicio2Model jsonEjercicio2;
        Ejercicio3Model jsonEjercicio3;
        Ejercicio4Model jsonEjercicio4;
        public GeneradorEjercicio()
            {
            InitializeComponent();
            }

        private void GeneradorEjercicio_Load(object sender, EventArgs e)
            {
            lbOpcion5.Visible = false;
            lbOpcion6.Visible = false;
            txtOption5.Visible = false;
            txtOption6.Visible = false;
            }

        private void rbEjercicio2_CheckedChanged(object sender, EventArgs e)
            {
            if (rbEjercicio2.Checked == true)
                {
                txtProblem2.Visible = true;
                } 
            else
                {
                txtProblem2.Visible = false;
                }
            }
        private void rbEjercicio3_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void rbEjercicio4_CheckedChanged(object sender, EventArgs e)
            {
            if (rbEjercicio4.Checked == true)
                {
                lbOpcion5.Visible = true;
                lbOpcion6.Visible = true;
                txtOption5.Visible = true;
                txtOption6.Visible = true;
                }
            else
                {
                lbOpcion5.Visible = false;
                lbOpcion6.Visible = false;
                txtOption5.Visible = false;
                txtOption6.Visible = false;
                }

            }

        private void btnGenerar_Click(object sender, EventArgs e)
            {
            if (ValidateTxtBoxs())
                {
                GenerateQuiz();
                }
            else
                {
                MessageBox.Show("Debe de completar todo los campos", "Favor Verificar", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                }
            }

        private void GenerateQuiz()
            {
            try
                {
                if (rbEjercicio2.Checked == true)
                    {
                    Quiz2();
                    }
                else if (rbEjercicio3.Checked == true)
                    {
                    Quiz3();
                    }
                else
                    {
                    Quiz4();
                    }
                ClearTxts();
                MessageBox.Show("Ejercicio fue generado correctamente!");
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
            
            }

        private void Quiz2()
            {
            jsonEjercicio2 = new Ejercicio2Model()
                {
                instruction = txtIntruction.Text,
                problem = new List<string>() { txtProblem1.Text, txtProblem2.Text},
                options = new List<string>() { txtOption1.Text, txtOption2.Text, txtOption3.Text, txtOption4.Text },
                result = txtResult.Text
                };            
            string serializeJson = JsonConvert.SerializeObject(jsonEjercicio2);
            GenerateJson(serializeJson, "../../Ejercicios2/", "EjercicioSuma");
            }
        private void Quiz3()
            {
            jsonEjercicio3 = new Ejercicio3Model()
                {
                instruction = txtIntruction.Text,
                problem = txtProblem1.Text,
                options = new List<string>() { txtOption1.Text, txtOption2.Text, txtOption3.Text, txtOption4.Text },
                result = txtResult.Text
                };
            string serializeJson = JsonConvert.SerializeObject(jsonEjercicio3);
            GenerateJson(serializeJson, "../../Ejercicios3/", "EjercicioPorcentaje");
            }
        private void Quiz4()
            {
            jsonEjercicio4 = new Ejercicio4Model()
                {
                instruction = txtIntruction.Text,
                problem = txtProblem1.Text,
                options = new List<string>() { txtOption1.Text, txtOption2.Text, txtOption3.Text, txtOption4.Text
                    , txtOption5.Text, txtOption6.Text},
                result = txtResult.Text
                };
            string serializeJson = JsonConvert.SerializeObject(jsonEjercicio4);
            GenerateJson(serializeJson,"../../Ejercicios4/", "EjercicioEscritura");
            }

        private void GenerateJson(string json, string path, string filename)
            {
            string serializeJson = JsonConvert.SerializeObject(json);
            serializeJson = serializeJson.Replace("\\", "");
            serializeJson = serializeJson.Remove(serializeJson.Length - 1, 1);
            serializeJson = serializeJson.Remove(0, 1);
            int counter = -1;
            bool loopControl = true;
            string filePath = "";
            do
                {
                counter++;
                if (!File.Exists(path + filename + counter + ".json"))
                    {
                    loopControl = false;
                    }
                }
            while (loopControl == true);
            filePath = path + filename + counter + ".json";
            using (var fileJson = new StreamWriter(filePath, false))
                {
                fileJson.WriteLine(serializeJson.ToString());
                fileJson.Close();
                }
            counter = -1;
            loopControl = true;
            }

        private void ClearTxts()
            {
            txtIntruction.Clear();
            txtProblem1.Clear();
            txtProblem2.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtOption5.Clear();
            txtOption6.Clear();
            txtResult.Clear();

            }

        private bool ValidateTxtBoxs()
            {
            if (rbEjercicio4.Checked == true)
                {
                if (!string.IsNullOrEmpty(txtIntruction.Text) && !string.IsNullOrEmpty(txtProblem1.Text)
                    && !string.IsNullOrEmpty(txtOption1.Text) && !string.IsNullOrEmpty(txtOption2.Text)
                    && !string.IsNullOrEmpty(txtOption3.Text) && !string.IsNullOrEmpty(txtOption4.Text)
                    && !string.IsNullOrEmpty(txtOption5.Text) && !string.IsNullOrEmpty(txtOption6.Text)
                    && !string.IsNullOrEmpty(txtResult.Text))
                    {
                    return true;
                    }
                }
            else
                {
                if (!string.IsNullOrEmpty(txtIntruction.Text) && !string.IsNullOrEmpty(txtProblem1.Text)
                   && !string.IsNullOrEmpty(txtOption1.Text) && !string.IsNullOrEmpty(txtOption2.Text)
                   && !string.IsNullOrEmpty(txtOption3.Text) && !string.IsNullOrEmpty(txtOption4.Text)
                   && !string.IsNullOrEmpty(txtResult.Text))
                    {
                    return true;
                    }                
                }
            return false;
            }
        }
    }
