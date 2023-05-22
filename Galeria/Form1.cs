using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; 

namespace Galeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 1; 

        private void timer1_Tick(object sender, EventArgs e)
        {
            //En la caperta Resourses encontraremos todas las imagenes que contiene este programa

            switch (contador)
            {
                case 1:
                    PBX_IMAGEN.Image = Properties.Resources.Kyrie_6;
                    contador = 2; 
                    break; 

                case 2:
                    PBX_IMAGEN.Image = Properties.Resources.Kyrie_Flytrap_II;
                    contador = 3; 
                    break; 

                case 3:
                    PBX_IMAGEN.Image = Properties.Resources.KD12_Zoom;
                    contador = 4; 
                    break; 

                case 4:
                    PBX_IMAGEN.Image = Properties.Resources.LeBron_Witness_4;
                    contador = 5; 
                    break; 

                case 5:
                    PBX_IMAGEN.Image = Properties.Resources.SB_Shane;
                    contador = 6; 
                    break; 

                case 6:
                    PBX_IMAGEN.Image = Properties.Resources.Jumpman_2020;
                    contador = 7; 
                    break; 

                case 7:
                    PBX_IMAGEN.Image = Properties.Resources.Air_Max_95;
                    contador = 8; 
                    break; 

                case 8:
                    PBX_IMAGEN.Image = Properties.Resources.SuperRep_Go;
                    contador = 9; 
                    break; 

                default:
                    PBX_IMAGEN.Image = Properties.Resources.Nike;
                    contador = 1; 
                        break; 
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            LBL_CARCATERISTICAS.Text = " "; 

            StreamReader lectura_archivo; 

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Kyrie 6":
                    LBL_CARCATERISTICAS.Items.Clear();
                    PBX_IMAGEN.Image = Properties.Resources.Kyrie_6;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\Kyrie 6.jpg"); //Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                        LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break; 

                case "Kyrie Flytrap":
                    LBL_CARCATERISTICAS.Items.Clear(); 
                    PBX_IMAGEN.Image = Properties.Resources.Kyrie_Flytrap_II;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\Kyrie Flytrap II.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                       LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break;


                case "LeBron":
                    LBL_CARCATERISTICAS.Items.Clear(); 
                    PBX_IMAGEN.Image = Properties.Resources.LeBron_Witness_4;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\LeBron Witness 4.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                        LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break; 

                case "SB Shane":
                    LBL_CARCATERISTICAS.Items.Clear(); 
                    PBX_IMAGEN.Image = Properties.Resources.SB_Shane;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\SB Shane.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                       LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break; 

                case "Jumpman":
                    LBL_CARCATERISTICAS.Items.Clear(); 
                    PBX_IMAGEN.Image = Properties.Resources.Jumpman_2020;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\Jumpman 2020.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                       LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break; 

                case "Air Max 95":
                    LBL_CARCATERISTICAS.Items.Clear(); 
                    PBX_IMAGEN.Image = Properties.Resources.Air_Max_95;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\Air Max 95.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                       LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break;

                case "SuperRep Go":
                    LBL_CARCATERISTICAS.Items.Clear(); 
                    PBX_IMAGEN.Image = Properties.Resources.SuperRep_Go;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\SuperRep Go.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                       LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break;

                case "KD12":
                    LBL_CARCATERISTICAS.Items.Clear();
                    PBX_IMAGEN.Image = Properties.Resources.KD12_Zoom;
                    lectura_archivo = new StreamReader(@"C:\Users\Mario\OneDrive\Escritorio\ICO-901\Projects\Galeria\Galeria\Resources\KD12 Zoom.jpg");//Por el momento pondremos la imagen, mas no sus caracteristicas, en un avance conectaremos el archivo de caracteristicas en este apartado, por lo tanto ahorita lo unico que va a suceder es que saldran caracteres especiales.
                    while (lectura_archivo.EndOfStream != true)
                    {
                        LBL_CARCATERISTICAS.Items.Add(lectura_archivo.ReadLine() + "\n");
                    }
                    break; 
            }

        }

        private void Combo_PRESUPUESTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Selecione modelo...";

            switch (Combo_PRESUPUESTO.SelectedIndex)
            {
                case 0:
                    LBL_KYRIE6.Visible = false;
                    LBL_K_FLYTRAP.Visible = false;
                    LBL_KD12.Visible = false;
                    LBL_LEBRON.Visible = false;
                    LBL_SHANE.Visible = false;
                    LBL_JUMPMAN.Visible = false;
                    LBL_AIR_MAX.Visible = false;
                    LBL_SUPERREP.Visible = false; 
                    break;

                case 1:

                    LBL_KYRIE6.Visible = false;
                    LBL_K_FLYTRAP.Visible = true;
                    LBL_KD12.Visible = false;
                    LBL_LEBRON.Visible = false;
                    LBL_SHANE.Visible = true;
                    LBL_JUMPMAN.Visible = false;
                    LBL_AIR_MAX.Visible = false;
                    LBL_SUPERREP.Visible = false;

                    comboBox1.Items.Add("Kyrie Flytrap");
                    comboBox1.Items.Add("SB Shane");
                    break; 

                case 2:

                    LBL_KYRIE6.Visible = false;
                    LBL_K_FLYTRAP.Visible = false;
                    LBL_KD12.Visible = false;
                    LBL_LEBRON.Visible = true;
                    LBL_SHANE.Visible = false;
                    LBL_JUMPMAN.Visible = true;
                    LBL_AIR_MAX.Visible = false;
                    LBL_SUPERREP.Visible = true;

                    comboBox1.Items.Add("LeBron");
                    comboBox1.Items.Add("Jumpman");
                    comboBox1.Items.Add("SuperRep Go");

                    break; 

                case 3:
                    LBL_KYRIE6.Visible = true;
                    LBL_K_FLYTRAP.Visible = false;
                    LBL_KD12.Visible = false;
                    LBL_LEBRON.Visible = false;
                    LBL_SHANE.Visible = false;
                    LBL_JUMPMAN.Visible = false;
                    LBL_AIR_MAX.Visible = false;
                    LBL_SUPERREP.Visible = false;

                    comboBox1.Items.Add("Kyrie 6");

                    break; 

                case 4:
                    LBL_KYRIE6.Visible = false;
                    LBL_K_FLYTRAP.Visible = false;
                    LBL_KD12.Visible = true;
                    LBL_LEBRON.Visible = false;
                    LBL_SHANE.Visible = false;
                    LBL_JUMPMAN.Visible = false;
                    LBL_AIR_MAX.Visible = true;
                    LBL_SUPERREP.Visible = false;

                    comboBox1.Items.Add("KD12");
                    comboBox1.Items.Add("Air Max 95");

                    break;

                case 5:
                    LBL_KYRIE6.Visible = false;
                    LBL_K_FLYTRAP.Visible = false;
                    LBL_KD12.Visible = false;
                    LBL_LEBRON.Visible = false;
                    LBL_SHANE.Visible = false;
                    LBL_JUMPMAN.Visible = false;
                    LBL_AIR_MAX.Visible = false;
                    LBL_SUPERREP.Visible = false;

                    break; 
            }
        }

        private void BTN_PRESUPUESTO_Click(object sender, EventArgs e)
        {
            if (BTN_PRESUPUESTO.Text == "Insertar Presupuesto")
            {
                comboBox1.Items.Clear();
                LBL_CARCATERISTICAS.Items.Clear(); 
                BTN_PRESUPUESTO.Text = "Mostrar Lista Completa";
                LBL_PRESUPUESTO.Visible = true;
                Combo_PRESUPUESTO.Visible = true;

                LBL_KYRIE6.Visible = false;
                LBL_K_FLYTRAP.Visible = false;
                LBL_KD12.Visible = false;
                LBL_LEBRON.Visible = false;
                LBL_SHANE.Visible = false;
                LBL_JUMPMAN.Visible = false;
                LBL_AIR_MAX.Visible = false;
                LBL_SUPERREP.Visible = false;
            }
            else 
            {
                comboBox1.Items.Clear();
                LBL_CARCATERISTICAS.Items.Clear();
                BTN_PRESUPUESTO.Text = "Insertar Presupuesto";
                LBL_PRESUPUESTO.Visible = false;
                Combo_PRESUPUESTO.Visible = false;

                LBL_KYRIE6.Visible = true;
                LBL_K_FLYTRAP.Visible = true;
                LBL_KD12.Visible = true;
                LBL_LEBRON.Visible = true;
                LBL_SHANE.Visible = true;
                LBL_JUMPMAN.Visible = true;
                LBL_AIR_MAX.Visible = true;
                LBL_SUPERREP.Visible = true;
                comboBox1.Items.Add("Kyrie Flytrap");
                comboBox1.Items.Add("SB Shane");
                comboBox1.Items.Add("LeBron");
                comboBox1.Items.Add("Jumpman 2020");
                comboBox1.Items.Add("SuperRep Go");
                comboBox1.Items.Add("Kyrie 6");
                comboBox1.Items.Add("KD12");
                comboBox1.Items.Add("Air Max 95");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = @"C:\Users\Hp 2018\Desktop\Caracteristicas\" + TXT_CLIENTE.Text + ".txt";

            if (File.Exists(cadena))
            {
                MessageBox.Show("YA SE HIZO COTIZACION PARA ESTE CLIENTE", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                File.Create(cadena).Dispose();
                StreamWriter Datos = new StreamWriter(cadena);
                Datos.WriteLine(DateTime.Now.ToShortDateString()); //Muestra la fecha
                Datos.WriteLine("CLIENTE: " + TXT_CLIENTE.Text);

                for (int i = 0; i < LBL_CARCATERISTICAS.Items.Count; i++)
                {
                    Datos.WriteLine(LBL_CARCATERISTICAS.Items[i].ToString() + "\n"); 
                }

                Datos.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\Hp 2018\Desktop\Caracteristicas\");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nike.com/mx/w/hombres-calzado-nik1zy7ok");
        }



    }
}
