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
            this.SuspendLayout();
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoItem.Image")));
            this.btnNovoItem.Location = new System.Drawing.Point(12, 12);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(141, 192);
            this.btnNovoItem.TabIndex = 0;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // frmMenucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoItem);
            this.Name = "frmMenucs";
            this.Text = "frmMenucs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoItem;
    }
}