using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RANDON_IT
{
    public partial class frmPrincipal : Form
    {
        int Valor_Nombre;
        int Valor_Opcion;
        
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void proces_Nombre_Tick(object sender, EventArgs e)
        {
           
             
            var seed = Environment.TickCount;
            var random = new Random(seed);

            Valor_Nombre = -1;

            Valor_Nombre = random.Next(0, lstNombre.Items.Count);
            lblNombre.Text = Valor_Nombre.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lstNombre.Items.Count > 0)
            {
                proces_Nombre.Interval = 10;
                proces_Nombre.Start();
            }

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proces_Nombre.Stop();

            if (lstNombre.Items.Count > 0)
            {

                string[] paises = new string[lstNombre.Items.Count];

                for (int i = 0; i < lstNombre.Items.Count; i++)
                {
                    paises[i] = lstNombre.Items[i] as String;
                }

                lblNombre.Text = paises[Valor_Nombre];
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lstOpciones.Items.Count > 0)
            {
                proces_Opcion.Interval = 10;
                proces_Opcion.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            proces_Opcion.Stop();

            if (lstOpciones.Items.Count > 0)
            {

                string[] opciones = new string[lstOpciones.Items.Count];

                for (int i = 0; i < lstOpciones.Items.Count; i++)
                {
                    opciones[i] = lstOpciones.Items[i] as String;
                }

                lblOpcion.Text = opciones[Valor_Opcion];
            }
        }

        private void proces_Opcion_Tick(object sender, EventArgs e)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            Valor_Opcion = -1;

            Valor_Opcion = random.Next(0, lstOpciones.Items.Count);
            lblOpcion.Text = Valor_Opcion.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtNombre.Text))) {

                lstNombre.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
                txtNombre.Focus();
            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstNombre.Items.Clear();
            lblNombre.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtOpcion.Text)))
            {

                lstOpciones.Items.Add(txtOpcion.Text);
                txtOpcion.Text = "";
                txtOpcion.Focus();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lstOpciones.Items.Clear();
            lblOpcion.Text = "";
        }
    }
}
