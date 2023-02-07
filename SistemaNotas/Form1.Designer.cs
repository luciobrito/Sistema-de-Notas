namespace SistemaNotas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelMat = new System.Windows.Forms.Label();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.numericMat = new System.Windows.Forms.NumericUpDown();
            this.labelMedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(67, 37);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(403, 55);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Sistema de Notas";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitulo.Location = new System.Drawing.Point(190, 92);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(165, 25);
            this.labelSubtitulo.TabIndex = 2;
            this.labelSubtitulo.Text = "Insira suas notas:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(224, 180);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(179, 286);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(263, 286);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(189, 219);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 31);
            this.labelResultado.TabIndex = 8;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(159, 124);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(68, 16);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Português";
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMat.Location = new System.Drawing.Point(289, 124);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(77, 16);
            this.labelMat.TabIndex = 11;
            this.labelMat.Text = "Matemática";
            // 
            // numericPort
            // 
            this.numericPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPort.Location = new System.Drawing.Point(162, 143);
            this.numericPort.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(54, 26);
            this.numericPort.TabIndex = 12;
            this.numericPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPort.ValueChanged += new System.EventHandler(this.numericPort_ValueChanged);
            // 
            // numericMat
            // 
            this.numericMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMat.Location = new System.Drawing.Point(301, 143);
            this.numericMat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericMat.Name = "numericMat";
            this.numericMat.Size = new System.Drawing.Size(54, 26);
            this.numericMat.TabIndex = 13;
            this.numericMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMat.ValueChanged += new System.EventHandler(this.numericMat_ValueChanged);
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(106, 219);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(24, 31);
            this.labelMedia.TabIndex = 14;
            this.labelMedia.Text = "-";
            this.labelMedia.Click += new System.EventHandler(this.labelMedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sua Média:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Situação Final:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.numericMat);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.labelMat);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelSubtitulo);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 375);
            this.MinimumSize = new System.Drawing.Size(551, 375);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sistema de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.NumericUpDown numericMat;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

