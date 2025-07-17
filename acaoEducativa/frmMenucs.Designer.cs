namespace acaoEducativa
{
    partial class frmMenucs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenucs));
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstBuscar = new System.Windows.Forms.ListView();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoItem.Image")));
            this.btnNovoItem.Location = new System.Drawing.Point(12, 12);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(155, 192);
            this.btnNovoItem.TabIndex = 0;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(344, 28);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(124, 25);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar items";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(349, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 30);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(778, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstBuscar
            // 
            this.lstBuscar.HideSelection = false;
            this.lstBuscar.Location = new System.Drawing.Point(349, 92);
            this.lstBuscar.Name = "lstBuscar";
            this.lstBuscar.Size = new System.Drawing.Size(533, 267);
            this.lstBuscar.TabIndex = 7;
            this.lstBuscar.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarItem.Image")));
            this.btnEditarItem.Location = new System.Drawing.Point(180, 12);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(155, 192);
            this.btnEditarItem.TabIndex = 8;
            this.btnEditarItem.Text = "Editar Items";
            this.btnEditarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // frmMenucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 638);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.lstBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnNovoItem);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenucs";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lstBuscar;
        private System.Windows.Forms.Button btnEditarItem;
    }
}