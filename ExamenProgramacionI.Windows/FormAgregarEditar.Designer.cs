namespace ExamenProgramacionI.Windows
{
    partial class FormAgregarEditar
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numAX = new System.Windows.Forms.NumericUpDown();
            this.numAY = new System.Windows.Forms.NumericUpDown();
            this.numBY = new System.Windows.Forms.NumericUpDown();
            this.numBX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 48);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(116, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 48);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numAX
            // 
            this.numAX.Location = new System.Drawing.Point(63, 36);
            this.numAX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numAX.Name = "numAX";
            this.numAX.Size = new System.Drawing.Size(107, 20);
            this.numAX.TabIndex = 2;
            // 
            // numAY
            // 
            this.numAY.Location = new System.Drawing.Point(63, 62);
            this.numAY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numAY.Name = "numAY";
            this.numAY.Size = new System.Drawing.Size(107, 20);
            this.numAY.TabIndex = 3;
            // 
            // numBY
            // 
            this.numBY.Location = new System.Drawing.Point(63, 145);
            this.numBY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numBY.Name = "numBY";
            this.numBY.Size = new System.Drawing.Size(107, 20);
            this.numBY.TabIndex = 5;
            // 
            // numBX
            // 
            this.numBX.Location = new System.Drawing.Point(63, 119);
            this.numBX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numBX.Name = "numBX";
            this.numBX.Size = new System.Drawing.Size(107, 20);
            this.numBX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Primer punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Segundo punto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y";
            // 
            // FormAgregarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 249);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBY);
            this.Controls.Add(this.numBX);
            this.Controls.Add(this.numAY);
            this.Controls.Add(this.numAX);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 288);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(244, 288);
            this.Name = "FormAgregarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarEditar";
            this.Load += new System.EventHandler(this.FormAgregarEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numAX;
        private System.Windows.Forms.NumericUpDown numAY;
        private System.Windows.Forms.NumericUpDown numBY;
        private System.Windows.Forms.NumericUpDown numBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}