namespace Consumo_de_APIs
{
    partial class FormAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAPI));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnGenerarGato = new System.Windows.Forms.Button();
            this.picGato = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarGato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(33, 472);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 32);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Pokémon";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(33, 425);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(307, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // picPokemon
            // 
            this.picPokemon.BackColor = System.Drawing.Color.Transparent;
            this.picPokemon.Location = new System.Drawing.Point(71, 210);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(113, 102);
            this.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPokemon.TabIndex = 2;
            this.picPokemon.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblNombre.Location = new System.Drawing.Point(68, 187);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 3;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.lblStats.Location = new System.Drawing.Point(190, 210);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 13);
            this.lblStats.TabIndex = 4;
            // 
            // btnGenerarGato
            // 
            this.btnGenerarGato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarGato.Location = new System.Drawing.Point(436, 541);
            this.btnGenerarGato.Name = "btnGenerarGato";
            this.btnGenerarGato.Size = new System.Drawing.Size(150, 28);
            this.btnGenerarGato.TabIndex = 5;
            this.btnGenerarGato.Text = "Generar Gato";
            this.btnGenerarGato.UseVisualStyleBackColor = true;
            this.btnGenerarGato.Click += new System.EventHandler(this.btnGenerarGato_Click_1);
            // 
            // picGato
            // 
            this.picGato.BackColor = System.Drawing.Color.Transparent;
            this.picGato.Location = new System.Drawing.Point(436, 13);
            this.picGato.Name = "picGato";
            this.picGato.Size = new System.Drawing.Size(350, 295);
            this.picGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGato.TabIndex = 6;
            this.picGato.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(197, 472);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 32);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarGato
            // 
            this.btnEliminarGato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarGato.Location = new System.Drawing.Point(636, 541);
            this.btnEliminarGato.Name = "btnEliminarGato";
            this.btnEliminarGato.Size = new System.Drawing.Size(150, 28);
            this.btnEliminarGato.TabIndex = 8;
            this.btnEliminarGato.Text = "Eliminar Gato";
            this.btnEliminarGato.UseVisualStyleBackColor = true;
            this.btnEliminarGato.Click += new System.EventHandler(this.btnEliminarGato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F);
            this.label1.Location = new System.Drawing.Point(31, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del pokémon:";
            // 
            // FormAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarGato);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.picGato);
            this.Controls.Add(this.btnGenerarGato);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picPokemon);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FormAPI";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnGenerarGato;
        private System.Windows.Forms.PictureBox picGato;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarGato;
        private System.Windows.Forms.Label label1;
    }
}