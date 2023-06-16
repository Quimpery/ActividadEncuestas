using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestasForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistroDeEncuesta_Click(object sender, EventArgs e)
        {

            FormRegistroDeEncuesta fRegistro = new FormRegistroDeEncuesta();

            if (fRegistro.ShowDialog() == DialogResult.OK)
            {


                Encuesta nuevo = new Encuesta();

                // Console.WriteLine("Modo de transporte habitual");

                nuevo.UsaBicicleta = fRegistro.cbkUsaBicicleta.Checked; // Consulta("¿Usa bicleta?: S/N");
                nuevo.UsaAuto = false; // Consulta("¿Usa Automóvil?: S/N");
                nuevo.UsaTransportePublico = false; // Consulta("¿Usa Transporte público?: S/N");

                // Console.WriteLine("¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)\n");
                nuevo.DistanciaASuDestino = 3.0; //Convert.ToDouble(Console.ReadLine());

                bool puedeSerContactado = true; // Consulta("¿Puede ser contactado?: S/N");
                if (puedeSerContactado == true)
                {
                    //Console.Write("Email: ");
                    nuevo.Email = "lautarogomgoda@gmail.com"; //Console.ReadLine();
                                                              // Console.Write("\n");
                }


                proceso.RegistrarEncuesta(nuevo, puedeSerContactado);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormResultados fInforme = new FormResultados();

            fInforme.listBox1.Items.Add($"{"Bicicleta:",-20}  {}")

            fInforme.ShowDialog();
        }
    }
}
