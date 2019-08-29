namespace taller1
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
            this.lblbienvenidos = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.btnpresioname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbienvenidos
            // 
            this.lblbienvenidos.AutoSize = true;
            this.lblbienvenidos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenidos.Location = new System.Drawing.Point(265, 50);
            this.lblbienvenidos.Name = "lblbienvenidos";
            this.lblbienvenidos.Size = new System.Drawing.Size(185, 36);
            this.lblbienvenidos.TabIndex = 0;
            this.lblbienvenidos.Text = "Bienvenidos";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(73, 143);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(244, 31);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Ingrese su Nombre";
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(323, 143);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(273, 35);
            this.txtnombres.TabIndex = 2;
            this.txtnombres.TextChanged += new System.EventHandler(this.txtnombres_TextChanged);
            // 
            // btnpresioname
            // 
            this.btnpresioname.Location = new System.Drawing.Point(618, 143);
            this.btnpresioname.Name = "btnpresioname";
            this.btnpresioname.Size = new System.Drawing.Size(84, 38);
            this.btnpresioname.TabIndex = 3;
            this.btnpresioname.Text = "presioname";
            this.btnpresioname.UseVisualStyleBackColor = true;
            this.btnpresioname.Click += new System.EventHandler(this.btnpresioname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpresioname);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblbienvenidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenidos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Button btnpresioname;
    }
}

