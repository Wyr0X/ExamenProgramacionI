using ExamenProgramacionI.Business;
using ExamenProgramacionI.Model;
using System;
using System.Windows.Forms;

namespace ExamenProgramacionI.Windows
{
    public partial class FormAgregarEditar : Form
    {
        private readonly RepositorioDeSegmentos repositorio;
        public SegmentoRectilineo SegmentoAE { get; set; }

        public FormAgregarEditar(RepositorioDeSegmentos repo)
        {
            InitializeComponent();

            repositorio = repo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (SegmentoAE == null)
                {
                    SegmentoAE = new SegmentoRectilineo()
                    {
                        A = new Punto()
                        {
                            X = (int)numAX.Value,
                            Y = (int)numAY.Value
                        },
                        B = new Punto()
                        {
                            X = (int)numBX.Value,
                            Y = (int)numBY.Value
                        }
                    };

                    if (repositorio.Existe(SegmentoAE))
                    {
                        ShowError("El segmento ya existe en la lista.");
                        return;
                    }
                } else
                {
                    SegmentoAE.A.X = (int)numAX.Value;
                    SegmentoAE.A.Y = (int)numAY.Value;
                    SegmentoAE.B.X = (int)numBX.Value;
                    SegmentoAE.B.Y = (int)numBY.Value;
                }                

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidarDatos()
        {
            // Los puntos no deben ser iguales
            if (numAX.Value == numBX.Value && numAY.Value == numBY.Value)
            {
                ShowError("Las coordenadas ingresadas no pueden ser iguales.");
                return false;
            }

            return true;
        }
        private void ShowError(string error_message)
        {
            MessageBox.Show(this, error_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormAgregarEditar_Load(object sender, EventArgs e)
        {
            if (SegmentoAE != null)
            {
                numAX.Value = SegmentoAE.A.X;
                numAY.Value = SegmentoAE.A.Y;
                numBX.Value = SegmentoAE.B.X;
                numBY.Value = SegmentoAE.B.Y;
            }
        }
    }
}
