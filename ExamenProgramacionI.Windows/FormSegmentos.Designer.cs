namespace ExamenProgramacionI.Windows
{
    partial class FormSegmentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSegmentos));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenadaX1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AX,
            this.AY,
            this.BX,
            this.BY,
            this.Longitud});
            this.dataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(544, 410);
            this.dataGridView.TabIndex = 0;
            // 
            // AX
            // 
            this.AX.Frozen = true;
            this.AX.HeaderText = "X1";
            this.AX.Name = "AX";
            this.AX.ReadOnly = true;
            // 
            // AY
            // 
            this.AY.Frozen = true;
            this.AY.HeaderText = "Y1";
            this.AY.Name = "AY";
            this.AY.ReadOnly = true;
            // 
            // BX
            // 
            this.BX.Frozen = true;
            this.BX.HeaderText = "X2";
            this.BX.Name = "BX";
            this.BX.ReadOnly = true;
            // 
            // BY
            // 
            this.BY.Frozen = true;
            this.BY.HeaderText = "Y2";
            this.BY.Name = "BY";
            this.BY.ReadOnly = true;
            // 
            // Longitud
            // 
            this.Longitud.Frozen = true;
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.Name = "Longitud";
            this.Longitud.ReadOnly = true;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(544, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.longitudToolStripMenuItem,
            this.coordenadaX1ToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "Ordenar";
            // 
            // longitudToolStripMenuItem
            // 
            this.longitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
            this.longitudToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.longitudToolStripMenuItem.Text = "Longitud";
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // coordenadaX1ToolStripMenuItem
            // 
            this.coordenadaX1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem1,
            this.descendenteToolStripMenuItem1});
            this.coordenadaX1ToolStripMenuItem.Name = "coordenadaX1ToolStripMenuItem";
            this.coordenadaX1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coordenadaX1ToolStripMenuItem.Text = "Coordenada X1";
            // 
            // ascendenteToolStripMenuItem1
            // 
            this.ascendenteToolStripMenuItem1.Name = "ascendenteToolStripMenuItem1";
            this.ascendenteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ascendenteToolStripMenuItem1.Text = "Ascendente";
            this.ascendenteToolStripMenuItem1.Click += new System.EventHandler(this.ascendenteToolStripMenuItem1_Click);
            // 
            // descendenteToolStripMenuItem1
            // 
            this.descendenteToolStripMenuItem1.Name = "descendenteToolStripMenuItem1";
            this.descendenteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.descendenteToolStripMenuItem1.Text = "Descendente";
            this.descendenteToolStripMenuItem1.Click += new System.EventHandler(this.descendenteToolStripMenuItem1_Click);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Enabled = false;
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // FormSegmentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(560, 489);
            this.Name = "FormSegmentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Segmentos Rectilíneos";
            this.Load += new System.EventHandler(this.FormSegmentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AX;
        private System.Windows.Forms.DataGridViewTextBoxColumn AY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BX;
        private System.Windows.Forms.DataGridViewTextBoxColumn BY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordenadaX1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
    }
}