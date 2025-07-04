namespace acaoEducativa
{
    partial class frmCadartroDeProduto
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
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.txtMarcaProduto = new System.Windows.Forms.TextBox();
            this.lblManrcaProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeProduto = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 59);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(252, 26);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoNome.Location = new System.Drawing.Point(12, 29);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(53, 20);
            this.lblProdutoNome.TabIndex = 1;
            this.lblProdutoNome.Text = "Nome";
            // 
            // txtMarcaProduto
            // 
            this.txtMarcaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaProduto.Location = new System.Drawing.Point(12, 156);
            this.txtMarcaProduto.Name = "txtMarcaProduto";
            this.txtMarcaProduto.Size = new System.Drawing.Size(252, 26);
            this.txtMarcaProduto.TabIndex = 2;
            // 
            // lblManrcaProduto
            // 
            this.lblManrcaProduto.AutoSize = true;
            this.lblManrcaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManrcaProduto.Location = new System.Drawing.Point(12, 126);
            this.lblManrcaProduto.Name = "lblManrcaProduto";
            this.lblManrcaProduto.Size = new System.Drawing.Size(125, 20);
            this.lblManrcaProduto.TabIndex = 3;
            this.lblManrcaProduto.Text = "Marca / Modelo";
            // 
            // lblQuantidadeProduto
            // 
            this.lblQuantidadeProduto.AutoSize = true;
            this.lblQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProduto.Location = new System.Drawing.Point(12, 199);
            this.lblQuantidadeProduto.Name = "lblQuantidadeProduto";
            this.lblQuantidadeProduto.Size = new System.Drawing.Size(94, 20);
            this.lblQuantidadeProduto.TabIndex = 6;
            this.lblQuantidadeProduto.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(12, 229);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 26);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.Text = "0";
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Location = new System.Drawing.Point(43, 311);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(180, 54);
            this.btnCadastraProduto.TabIndex = 7;
            this.btnCadastraProduto.Text = "Cadastra";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(353, 215);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(94, 20);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "Quantidade";
            // 
            // frmCadartroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCadastraProduto);
            this.Controls.Add(this.lblQuantidadeProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblManrcaProduto);
            this.Controls.Add(this.txtMarcaProduto);
            this.Controls.Add(this.lblProdutoNome);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "frmCadartroDeProduto";
            this.Text = "frmCadartroDeProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.TextBox txtMarcaProduto;
        private System.Windows.Forms.Label lblManrcaProduto;
        private System.Windows.Forms.Label lblQuantidadeProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.Label lblRes;
    }
}