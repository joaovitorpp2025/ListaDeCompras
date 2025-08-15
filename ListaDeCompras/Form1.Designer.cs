namespace ListaDeCompras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pibLogo = new PictureBox();
            lblTitulo = new Label();
            lblNomeProduto = new Label();
            txtProduto = new TextBox();
            btnAdicionar = new Button();
            lblCompras = new ListBox();
            btnExluir = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pibLogo).BeginInit();
            SuspendLayout();
            // 
            // pibLogo
            // 
            pibLogo.Image = Properties.Resources.logo;
            pibLogo.Location = new Point(24, 12);
            pibLogo.Name = "pibLogo";
            pibLogo.Size = new Size(193, 173);
            pibLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pibLogo.TabIndex = 0;
            pibLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Futura Bk BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(324, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(392, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Lista de Compras";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(63, 228);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(116, 16);
            lblNomeProduto.TabIndex = 2;
            lblNomeProduto.Text = " Nome Do Produto:";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(12, 247);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(265, 23);
            txtProduto.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 307);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(265, 44);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // lblCompras
            // 
            lblCompras.FormattingEnabled = true;
            lblCompras.Location = new Point(304, 83);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(476, 276);
            lblCompras.TabIndex = 5;
            // 
            // btnExluir
            // 
            btnExluir.Location = new Point(285, 377);
            btnExluir.Name = "btnExluir";
            btnExluir.Size = new Size(227, 29);
            btnExluir.TabIndex = 6;
            btnExluir.Text = "Excluir";
            btnExluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(532, 377);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(257, 29);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar Lista";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 449);
            Controls.Add(btnLimpar);
            Controls.Add(btnExluir);
            Controls.Add(lblCompras);
            Controls.Add(btnAdicionar);
            Controls.Add(txtProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblTitulo);
            Controls.Add(pibLogo);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Compras:";
            ((System.ComponentModel.ISupportInitialize)pibLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pibLogo;
        private Label lblTitulo;
        private Label lblNomeProduto;
        private TextBox txtProduto;
        private Button btnAdicionar;
        private ListBox lblCompras;
        private Button btnExluir;
        private Button btnLimpar;
    }
}
