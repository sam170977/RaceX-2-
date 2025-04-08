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
            {
                btnIniciarCarrera.Enabled = false;
                gbClima.Enabled = false;
            }
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
                // Valida los campos relacionados con el auto
                if (!CamposValidos())
                    return;

                // Crea un nuevo auto usando el patron Factory
                Auto nuevoAuto = AutoFactory.CrearAuto(tipoAuto, nombreAuto);

                // Verifica si el auto ya existe
                if (AutoExistente(nuevoAuto))
                    return;

                // Agrega el nuevo auto a la lista y al DataGridView
                autos.Add(nuevoAuto);
                dgvVehiculos.Rows.Add(nombreAuto, tipoAuto, "0");
                txtNombreAuto.Clear();
                cmbTipoAuto.SelectedIndex = -1;

                // Habilita el botón de iniciar carrera si hay al menos 3 autos
                if (autos.Count >= 3)
                {
                    btnIniciarCarrera.Enabled = true;
                    gbClima.Enabled = true;
                }

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
                // Verifica si se ha seleccionado un clima
                if (string.IsNullOrEmpty(climaCarrera))
                {
                    MessageBox.Show("Por favor selecciona el clima de la carrera.");
                    return;
                }

                // Verifica si hay al menos 3 autos
                if (autos.Count < 3)
                {
                    MessageBox.Show("Agrega al menos tres autos antes de iniciar la carrera.");
                    return;
                }

                // Deshabilita los controles de entrada
                txtNombreAuto.Enabled = false;
                cmbTipoAuto.Enabled = false;
                gbClima.Enabled = false;

                // Crea la carrera
                carrera = new Carrera()
                {
                    Clima = climaCarrera,
                    Autos = autos,
                };

                foreach (DataGridViewRow row in dgvVehiculos.Rows)
                {
                    row.Cells[2].Value = "0";
                }

                // Habilita el botón de siguiente turno
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
                // Verifica si la carrera ha terminado
                if (carrera.CarreraTerminada)
                {
                    MessageBox.Show($"La carrera ha terminado. Ganador: {carrera.Ganador.Nombre}");
                    return;
                }

                // Avanza el turno de la carrera
                string mensaje = carrera.SiguienteTurno();

                // Actualiza el DataGridView con las distancias recorridas
                for (int i = 0; i < autos.Count; i++)
                {
                    dgvVehiculos.Rows[i].Cells[2].Value = autos[i].DistanciaRecorrida.ToString();
                }

                // Actualiza el label de mensajes
                if (string.IsNullOrEmpty(mensaje))
                {
                    lblNovedad.Text = "Sin novedades";
                    lblNovedad.ForeColor = Color.Green;
                }
                else
                {
                    lblNovedad.Text = mensaje;
                    lblNovedad.ForeColor = Color.Red;
                }
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

        private void btnReiniciarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                // Reinicia las variables
                carrera = null;
                autos.Clear();
                nombreAuto = string.Empty;
                tipoAuto = string.Empty;
                climaCarrera = null;

                // Limpia el DataGridView
                dgvVehiculos.Rows.Clear();

                // Restablece los controles de entrada
                txtNombreAuto.Clear();
                txtNombreAuto.Enabled = true;

                cmbTipoAuto.SelectedIndex = -1;
                cmbTipoAuto.Enabled = true;

                foreach (Control control in gbClima.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        radioButton.Checked = false;
                    }
                }

                // Desabilita el grupo de clima
                gbClima.Enabled = false;

                // Restablece los botones
                btnIniciarCarrera.Enabled = false;
                btnSiguienteTurno.Enabled = false;

                // Restablece el label de novedades
                lblNovedad.Text = "";

                MessageBox.Show("El formulario ha sido reiniciado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reiniciar el formulario: {ex.Message}");
            }
        }
    }
}

