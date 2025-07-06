namespace SistemaVendas.Forms
{
    partial class FormEditorFieldsSale
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
            this.BtnConfirmAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConfirmAdd
            // 
            this.BtnConfirmAdd.Location = new System.Drawing.Point(804, 510);
            this.BtnConfirmAdd.Name = "BtnConfirmAdd";
            this.BtnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmAdd.TabIndex = 0;
            this.BtnConfirmAdd.Text = "Adicionar";
            this.BtnConfirmAdd.UseVisualStyleBackColor = true;
            this.BtnConfirmAdd.Click += new System.EventHandler(this.BtnConfirmAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(885, 510);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormEditorFieldsSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirmAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditorFieldsSale";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Venda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmAdd;
        private System.Windows.Forms.Button BtnCancel;
    }
}