namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.cbxOperador = new System.Windows.Forms.ComboBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.bttnOperar = new System.Windows.Forms.Button();
            this.bttnLimpiar = new System.Windows.Forms.Button();
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.bttnConvertirBinario = new System.Windows.Forms.Button();
            this.bttnConvertirDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(13, 19);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(111, 20);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.Text = "0";
            // 
            // cbxOperador
            // 
            this.cbxOperador.FormattingEnabled = true;
            this.cbxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbxOperador.Location = new System.Drawing.Point(146, 18);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(104, 21);
            this.cbxOperador.TabIndex = 1;
            this.cbxOperador.Text = "+";
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(269, 21);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(110, 20);
            this.txtnumero2.TabIndex = 2;
            this.txtnumero2.Text = "0";
            // 
            // bttnOperar
            // 
            this.bttnOperar.Location = new System.Drawing.Point(12, 82);
            this.bttnOperar.Name = "bttnOperar";
            this.bttnOperar.Size = new System.Drawing.Size(112, 28);
            this.bttnOperar.TabIndex = 3;
            this.bttnOperar.Text = "Operar";
            this.bttnOperar.UseVisualStyleBackColor = true;
            // 
            // bttnLimpiar
            // 
            this.bttnLimpiar.Location = new System.Drawing.Point(146, 82);
            this.bttnLimpiar.Name = "bttnLimpiar";
            this.bttnLimpiar.Size = new System.Drawing.Size(104, 28);
            this.bttnLimpiar.TabIndex = 4;
            this.bttnLimpiar.Text = "Limpiar";
            this.bttnLimpiar.UseVisualStyleBackColor = true;
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Location = new System.Drawing.Point(269, 82);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(109, 28);
            this.bttnCerrar.TabIndex = 5;
            this.bttnCerrar.Text = "Cerrar";
            this.bttnCerrar.UseVisualStyleBackColor = true;
            // 
            // bttnConvertirBinario
            // 
            this.bttnConvertirBinario.Location = new System.Drawing.Point(13, 131);
            this.bttnConvertirBinario.Name = "bttnConvertirBinario";
            this.bttnConvertirBinario.Size = new System.Drawing.Size(136, 33);
            this.bttnConvertirBinario.TabIndex = 6;
            this.bttnConvertirBinario.Text = "Convertir a Binario";
            this.bttnConvertirBinario.UseVisualStyleBackColor = true;
            // 
            // bttnConvertirDecimal
            // 
            this.bttnConvertirDecimal.Location = new System.Drawing.Point(247, 131);
            this.bttnConvertirDecimal.Name = "bttnConvertirDecimal";
            this.bttnConvertirDecimal.Size = new System.Drawing.Size(132, 30);
            this.bttnConvertirDecimal.TabIndex = 7;
            this.bttnConvertirDecimal.Text = "Convertir a Decimal";
            this.bttnConvertirDecimal.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 198);
            this.Controls.Add(this.bttnConvertirDecimal);
            this.Controls.Add(this.bttnConvertirBinario);
            this.Controls.Add(this.bttnCerrar);
            this.Controls.Add(this.bttnLimpiar);
            this.Controls.Add(this.bttnOperar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.cbxOperador);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "FormCalculadora";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox txtNumero1;
    private System.Windows.Forms.ComboBox cbxOperador;
    private System.Windows.Forms.TextBox txtnumero2;
    private System.Windows.Forms.Button bttnOperar;
    private System.Windows.Forms.Button bttnLimpiar;
    private System.Windows.Forms.Button bttnCerrar;
    private System.Windows.Forms.Button bttnConvertirBinario;
    private System.Windows.Forms.Button bttnConvertirDecimal;
  }
}
