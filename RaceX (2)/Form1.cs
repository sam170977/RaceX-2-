using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceX__2_
{
    public partial class Form1 : Form
    {
        private Carrera carrera = new Carrera();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvVehiculos.Columns.Clear();
            dgvVehiculos.Rows.Clear();

            dgvVehiculos.Columns.Add("Nombre", "Nombre");
            dgvVehiculos.Columns.Add("Tipo", "Tipo");
            dgvVehiculos.Columns.Add("Distancia", "Distancia Recorrida (m)");
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAuto.Text.Trim();
            string tipo = cmbTipoAuto.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor ingresa un nombre y selecciona un tipo de auto.");
                return;
            }

            Auto nuevo = AutoFactory.CrearAuto(tipo, nombre);
            carrera.AgregarAuto(nuevo);

            dgvVehiculos.Rows.Add(nombre, tipo, "0");

            txtNombreAuto.Clear();
            cmbTipoAuto.SelectedIndex = -1;

            MessageBox.Show($"Auto '{nombre}' agregado correctamente.");
        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            string clima = cmbClima.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(clima))
            {
                MessageBox.Show("Selecciona el clima de la carrera.");
                return;
            }

            carrera.Clima = clima;
            carrera.Reiniciar();

            foreach (DataGridViewRow row in dgvVehiculos.Rows)
            {
                row.Cells[2].Value = "0";
            }
            MessageBox.Show("¡La carrera ha comenzado!");
        }

        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            if (carrera.CarreraTerminada)
            {
                MessageBox.Show("La carrera ya terminó.");
                return;
            }

            string resultado = carrera.SiguienteTurno();
            for (int i = 0; i < carrera.Autos.Count; i++)
            {
                dgvVehiculos.Rows[i].Cells[2].Value = carrera.Autos[i].DistanciaRecorrida.ToString();
            }

            MessageBox.Show(resultado);
            lblMensaje.Text = carrera.SiguienteTurno();

            if (carrera.CarreraTerminada && carrera.Ganador != null)
            {
                lblGanador.Text = $"Ganador: {carrera.Ganador.Nombre}";
            }

        }
    }
    }

