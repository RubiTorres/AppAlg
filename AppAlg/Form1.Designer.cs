namespace AppAlg
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
      this.txtTamaño = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCrear = new System.Windows.Forms.Button();
      this.LbArregloC = new System.Windows.Forms.Label();
      this.LbArregloO = new System.Windows.Forms.Label();
      this.LbComparaciones = new System.Windows.Forms.Label();
      this.LbIntercambios = new System.Windows.Forms.Label();
      this.tbComparaciones = new System.Windows.Forms.TextBox();
      this.tbArregloO = new System.Windows.Forms.TextBox();
      this.tbArregloC = new System.Windows.Forms.TextBox();
      this.tbIntercambios = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtTamaño
      // 
      this.txtTamaño.Location = new System.Drawing.Point(79, 12);
      this.txtTamaño.Name = "txtTamaño";
      this.txtTamaño.Size = new System.Drawing.Size(210, 20);
      this.txtTamaño.TabIndex = 29;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 24;
      this.label1.Text = "Tamaño";
      // 
      // btnCrear
      // 
      this.btnCrear.Location = new System.Drawing.Point(304, 9);
      this.btnCrear.Name = "btnCrear";
      this.btnCrear.Size = new System.Drawing.Size(75, 23);
      this.btnCrear.TabIndex = 23;
      this.btnCrear.Text = "Crear arreglo";
      this.btnCrear.UseVisualStyleBackColor = true;
      this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
      // 
      // LbArregloC
      // 
      this.LbArregloC.AutoSize = true;
      this.LbArregloC.Location = new System.Drawing.Point(27, 50);
      this.LbArregloC.Name = "LbArregloC";
      this.LbArregloC.Size = new System.Drawing.Size(76, 13);
      this.LbArregloC.TabIndex = 20;
      this.LbArregloC.Text = "Arreglo creado";
      // 
      // LbArregloO
      // 
      this.LbArregloO.AutoSize = true;
      this.LbArregloO.Location = new System.Drawing.Point(27, 76);
      this.LbArregloO.Name = "LbArregloO";
      this.LbArregloO.Size = new System.Drawing.Size(88, 13);
      this.LbArregloO.TabIndex = 32;
      this.LbArregloO.Text = "Arreglo ordenado";
      // 
      // LbComparaciones
      // 
      this.LbComparaciones.AutoSize = true;
      this.LbComparaciones.Location = new System.Drawing.Point(27, 104);
      this.LbComparaciones.Name = "LbComparaciones";
      this.LbComparaciones.Size = new System.Drawing.Size(80, 13);
      this.LbComparaciones.TabIndex = 34;
      this.LbComparaciones.Text = "Comparaciones";
      // 
      // LbIntercambios
      // 
      this.LbIntercambios.AutoSize = true;
      this.LbIntercambios.Location = new System.Drawing.Point(27, 130);
      this.LbIntercambios.Name = "LbIntercambios";
      this.LbIntercambios.Size = new System.Drawing.Size(67, 13);
      this.LbIntercambios.TabIndex = 35;
      this.LbIntercambios.Text = "Intercambios";
      // 
      // tbComparaciones
      // 
      this.tbComparaciones.Location = new System.Drawing.Point(120, 95);
      this.tbComparaciones.Name = "tbComparaciones";
      this.tbComparaciones.Size = new System.Drawing.Size(62, 20);
      this.tbComparaciones.TabIndex = 36;
      // 
      // tbArregloO
      // 
      this.tbArregloO.Location = new System.Drawing.Point(120, 69);
      this.tbArregloO.Name = "tbArregloO";
      this.tbArregloO.Size = new System.Drawing.Size(383, 20);
      this.tbArregloO.TabIndex = 37;
      // 
      // tbArregloC
      // 
      this.tbArregloC.Location = new System.Drawing.Point(120, 43);
      this.tbArregloC.Name = "tbArregloC";
      this.tbArregloC.Size = new System.Drawing.Size(383, 20);
      this.tbArregloC.TabIndex = 38;
      // 
      // tbIntercambios
      // 
      this.tbIntercambios.Location = new System.Drawing.Point(120, 121);
      this.tbIntercambios.Name = "tbIntercambios";
      this.tbIntercambios.Size = new System.Drawing.Size(62, 20);
      this.tbIntercambios.TabIndex = 40;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tbIntercambios);
      this.Controls.Add(this.tbArregloC);
      this.Controls.Add(this.tbArregloO);
      this.Controls.Add(this.tbComparaciones);
      this.Controls.Add(this.LbIntercambios);
      this.Controls.Add(this.LbComparaciones);
      this.Controls.Add(this.LbArregloO);
      this.Controls.Add(this.LbArregloC);
      this.Controls.Add(this.txtTamaño);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCrear);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label LbArregloC;
        private System.Windows.Forms.Label LbArregloO;
        private System.Windows.Forms.Label LbComparaciones;
        private System.Windows.Forms.Label LbIntercambios;
        private System.Windows.Forms.TextBox tbComparaciones;
        private System.Windows.Forms.TextBox tbArregloO;
        private System.Windows.Forms.TextBox tbArregloC;
        private System.Windows.Forms.TextBox tbIntercambios;
    }
}

