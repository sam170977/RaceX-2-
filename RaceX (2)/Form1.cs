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
        private Carrera carrera;
        private List<Auto> autos = new List<Auto>();
        private string nombreAuto = string.Empty;
        private string tipoAuto = string.Empty;
        private string climaCarrera;

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

            if (carrera == null)
                btnSiguienteTurno.Enabled = false;

            if (autos.Count < 3)
                btnIniciarCarrera.Enabled = false;
        }

        private void txtNombreAuto_TextChanged(object sender, EventArgs e)
        {
            nombreAuto = txtNombreAuto.Text.Trim();
        }

        private void cmbTipoAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoAuto = cmbTipoAuto.SelectedItem?.ToString();
        }

        private void rbSeleccionarClima_Changed(object sender, EventArgs e)
        {
            // Verifica cuál RadioButton activó el evento
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                climaCarrera = radioButton.Text;
            }
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CamposValidos())
                    return;

                Auto nuevoAuto = AutoFactory.CrearAuto(tipoAuto, nombreAuto);

                if (AutoExistente(nuevoAuto))
                    return;

                autos.Add(nuevoAuto);
                dgvVehiculos.Rows.Add(nombreAuto, tipoAuto, "0");
                txtNombreAuto.Clear();
                cmbTipoAuto.SelectedIndex = -1;

                if (autos.Count >= 3)
                    btnIniciarCarrera.Enabled = true;

                MessageBox.Show($"Auto '{nuevoAuto.Nombre}' agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(climaCarrera))
                {
                    MessageBox.Show("Por favor selecciona el clima de la carrera.");
                    return;
                }

                if (autos.Count < 3)
                {
                    MessageBox.Show("Agrega al menos tres autos antes de iniciar la carrera.");
                    return;
                }

                carrera = new Carrera()
                {
                    Clima = climaCarrera,
                    Autos = autos,
                };

                carrera.Reiniciar();

                foreach (DataGridViewRow row in dgvVehiculos.Rows)
                {
                    row.Cells[2].Value = "0";
                }

                if (carrera != null)
                    btnSiguienteTurno.Enabled = true;

                MessageBox.Show("¡La carrera ha comenzado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la carrera: {ex.Message}");
                return;
            }
        }

        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw new Exception("Error al avanzar el turno.", ex);
            }
        }

        private bool CamposValidos()
        {
            try
            {
                if (string.IsNullOrEmpty(nombreAuto) || string.IsNullOrEmpty(tipoAuto))
                {
                    MessageBox.Show("Por favor ingresa un nombre y selecciona un tipo de auto.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw new Exception("Error al validar campos.", ex);
            }
        }

        private bool AutoExistente(Auto nuevoAuto)
        {
            try
            {
                foreach (var auto in autos)
                {
                    if (auto.Nombre.Equals(nuevoAuto.Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Ya existe un auto con ese nombre.");
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw new Exception("Error al verificar existencia de auto.", ex);
            }
        }
    }
}

