using ExamenProgramacionI.Business;
using ExamenProgramacionI.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExamenProgramacionI.Windows
{
    public partial class FormSegmentos : Form
    {
        private readonly RepositorioDeSegmentos Repositorio = new RepositorioDeSegmentos();
        private List<SegmentoRectilineo> ListaActual = new List<SegmentoRectilineo>();

        public FormSegmentos()
        {
            InitializeComponent();

            Repositorio.Leer();
        }

        private void FormSegmentos_Load(object sender, EventArgs e)
        {
            ListaActual = Repositorio.ObtenerLista();
            MostrarListaEnGridView();
        }

        private void MostrarListaEnGridView()
        {
            dataGridView.Rows.Clear();

            foreach (SegmentoRectilineo segmento in ListaActual)
            {
                var row = CrearFila(segmento);
                dataGridView.Rows.Add(row);
            }
        }

        private DataGridViewRow CrearFila(SegmentoRectilineo segmento)
        {
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView);

            row.Cells[0].Value = segmento.A.X;
            row.Cells[1].Value = segmento.A.Y;
            row.Cells[2].Value = segmento.B.X;
            row.Cells[3].Value = segmento.B.Y;
            row.Cells[4].Value = segmento.Longitud();
            row.Tag = segmento;

            return row;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var Frm = new FormAgregarEditar(Repositorio)
            {
                Text = "Agregar segmento rectilíneo"
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                Repositorio.Agregar(Frm.SegmentoAE);
                Repositorio.Guardar();
                MostrarListaEnGridView();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridView.SelectedRows[0];
            int row_index = row.Index;

            var Frm = new FormAgregarEditar(Repositorio)
            {
                Text = "Editar segmento rectilíneo",
                SegmentoAE = (SegmentoRectilineo)row.Tag
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                Repositorio.Guardar();
                MostrarListaEnGridView();

                // Seleccionamos el que acaba de editar
                dataGridView.CurrentCell = dataGridView.Rows[row_index].Cells[0];
                dataGridView.ClearSelection();
                dataGridView.Rows[row_index].Selected = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DialogResult dr = MessageBox.Show($"¿Desea borrar el segmento seleccionado?",
                "Cofirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No) return;

            DataGridViewRow row = dataGridView.SelectedRows[0];

            Repositorio.Eliminar((SegmentoRectilineo)row.Tag);
            Repositorio.Guardar();
            MostrarListaEnGridView();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaActual = Repositorio.OrdenarPorLongitud(false);
            restaurarToolStripMenuItem.Enabled = true;
            MostrarListaEnGridView();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaActual = Repositorio.ObtenerLista();
            MostrarListaEnGridView();
            restaurarToolStripMenuItem.Enabled = false;
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaActual = Repositorio.OrdenarPorLongitud(true);
            restaurarToolStripMenuItem.Enabled = true;
            MostrarListaEnGridView();
        }

        private void ascendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaActual = Repositorio.OrdenarPorCoordX1(false);
            restaurarToolStripMenuItem.Enabled = true;
            MostrarListaEnGridView();
        }

        private void descendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaActual = Repositorio.OrdenarPorCoordX1(true);
            restaurarToolStripMenuItem.Enabled = true;
            MostrarListaEnGridView();
        }
    }
}
