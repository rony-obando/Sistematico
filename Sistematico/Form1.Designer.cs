
namespace Sistematico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbNombres = new System.Windows.Forms.Label();
            this.TxBNombres = new System.Windows.Forms.TextBox();
            this.LBNotas = new System.Windows.Forms.Label();
            this.TxBNotas = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Nnotas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxBCarnet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxBApellidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbNombres
            // 
            this.LbNombres.AutoSize = true;
            this.LbNombres.Location = new System.Drawing.Point(53, 108);
            this.LbNombres.Name = "LbNombres";
            this.LbNombres.Size = new System.Drawing.Size(49, 13);
            this.LbNombres.TabIndex = 0;
            this.LbNombres.Text = "Nombres";
            // 
            // TxBNombres
            // 
            this.TxBNombres.Location = new System.Drawing.Point(170, 101);
            this.TxBNombres.Name = "TxBNombres";
            this.TxBNombres.Size = new System.Drawing.Size(100, 20);
            this.TxBNombres.TabIndex = 1;
            // 
            // LBNotas
            // 
            this.LBNotas.AutoSize = true;
            this.LBNotas.Location = new System.Drawing.Point(56, 225);
            this.LBNotas.Name = "LBNotas";
            this.LBNotas.Size = new System.Drawing.Size(35, 13);
            this.LBNotas.TabIndex = 2;
            this.LBNotas.Text = "Notas";
            // 
            // TxBNotas
            // 
            this.TxBNotas.Location = new System.Drawing.Point(170, 218);
            this.TxBNotas.Name = "TxBNotas";
            this.TxBNotas.Size = new System.Drawing.Size(100, 20);
            this.TxBNotas.TabIndex = 3;
            this.TxBNotas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxBNotas_KeyDown);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(524, 258);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 4;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Nnotas
            // 
            this.Nnotas.AutoSize = true;
            this.Nnotas.Location = new System.Drawing.Point(685, 49);
            this.Nnotas.Name = "Nnotas";
            this.Nnotas.Size = new System.Drawing.Size(0, 13);
            this.Nnotas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carnet";
            // 
            // TxBCarnet
            // 
            this.TxBCarnet.Location = new System.Drawing.Point(170, 48);
            this.TxBCarnet.Name = "TxBCarnet";
            this.TxBCarnet.Size = new System.Drawing.Size(100, 20);
            this.TxBCarnet.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellidos";
            // 
            // TxBApellidos
            // 
            this.TxBApellidos.Location = new System.Drawing.Point(170, 163);
            this.TxBApellidos.Name = "TxBApellidos";
            this.TxBApellidos.Size = new System.Drawing.Size(100, 20);
            this.TxBApellidos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxBApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxBCarnet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nnotas);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.TxBNotas);
            this.Controls.Add(this.LBNotas);
            this.Controls.Add(this.TxBNombres);
            this.Controls.Add(this.LbNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNombres;
        private System.Windows.Forms.TextBox TxBNombres;
        private System.Windows.Forms.Label LBNotas;
        private System.Windows.Forms.TextBox TxBNotas;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Label Nnotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBCarnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxBApellidos;
    }
}

