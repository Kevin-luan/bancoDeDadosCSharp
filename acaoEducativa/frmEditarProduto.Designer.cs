﻿namespace acaoEducativa
{
    partial class frmEditarProduto
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
            this.lstBuscar = new System.Windows.Forms.ListView();
            this.btnBuscarTudo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBuscar
            // 
            this.lstBuscar.HideSelection = false;
            this.lstBuscar.Location = new System.Drawing.Point(25, 69);
            this.lstBuscar.Name = "lstBuscar";
            this.lstBuscar.Size = new System.Drawing.Size(707, 349);
            this.lstBuscar.TabIndex = 0;
            this.lstBuscar.UseCompatibleStateImageBehavior = false;
            this.lstBuscar.SelectedIndexChanged += new System.EventHandler(this.lstBuscar_SelectedIndexChanged);
            // 
            // btnBuscarTudo
            // 
            this.btnBuscarTudo.Location = new System.Drawing.Point(25, 12);
            this.btnBuscarTudo.Name = "btnBuscarTudo";
            this.btnBuscarTudo.Size = new System.Drawing.Size(131, 51);
            this.btnBuscarTudo.TabIndex = 1;
            this.btnBuscarTudo.Text = "Buscar todos os Items";
            this.btnBuscarTudo.UseVisualStyleBackColor = true;
            this.btnBuscarTudo.Click += new System.EventHandler(this.btnBuscarTudo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(601, 426);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 51);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnBuscarTudo);
            this.Controls.Add(this.lstBuscar);
            this.Name = "frmEditarProduto";
            this.Text = "frmEditarProduto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBuscar;
        private System.Windows.Forms.Button btnBuscarTudo;
        private System.Windows.Forms.Button btnVoltar;
    }
}