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
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxClientName = new System.Windows.Forms.TextBox();
            this.LblClientName = new System.Windows.Forms.Label();
            this.LblClientAge = new System.Windows.Forms.Label();
            this.NumClientAge = new System.Windows.Forms.NumericUpDown();
            this.LblProductName = new System.Windows.Forms.Label();
            this.TxtBoxProductName = new System.Windows.Forms.TextBox();
            this.LblAmount = new System.Windows.Forms.Label();
            this.TxtBoxAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumClientAge)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConfirmAdd
            // 
            this.BtnConfirmAdd.Location = new System.Drawing.Point(307, 197);
            this.BtnConfirmAdd.Name = "BtnConfirmAdd";
            this.BtnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmAdd.TabIndex = 0;
            this.BtnConfirmAdd.Text = "Adicionar";
            this.BtnConfirmAdd.UseVisualStyleBackColor = true;
            this.BtnConfirmAdd.Click += new System.EventHandler(this.BtnConfirmAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(388, 197);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BackColor = System.Drawing.Color.Black;
            this.TxtBoxId.ForeColor = System.Drawing.Color.White;
            this.TxtBoxId.Location = new System.Drawing.Point(13, 13);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBoxId.Size = new System.Drawing.Size(140, 20);
            this.TxtBoxId.TabIndex = 2;
            this.TxtBoxId.Text = "123";
            // 
            // TxtBoxClientName
            // 
            this.TxtBoxClientName.Location = new System.Drawing.Point(13, 76);
            this.TxtBoxClientName.Name = "TxtBoxClientName";
            this.TxtBoxClientName.Size = new System.Drawing.Size(248, 20);
            this.TxtBoxClientName.TabIndex = 3;
            // 
            // LblClientName
            // 
            this.LblClientName.AutoSize = true;
            this.LblClientName.Location = new System.Drawing.Point(13, 60);
            this.LblClientName.Name = "LblClientName";
            this.LblClientName.Size = new System.Drawing.Size(84, 13);
            this.LblClientName.TabIndex = 4;
            this.LblClientName.Text = "Nome do cliente";
            // 
            // LblClientAge
            // 
            this.LblClientAge.AutoSize = true;
            this.LblClientAge.Location = new System.Drawing.Point(340, 60);
            this.LblClientAge.Name = "LblClientAge";
            this.LblClientAge.Size = new System.Drawing.Size(83, 13);
            this.LblClientAge.TabIndex = 6;
            this.LblClientAge.Text = "Idade do cliente";
            // 
            // NumClientAge
            // 
            this.NumClientAge.Location = new System.Drawing.Point(343, 77);
            this.NumClientAge.Name = "NumClientAge";
            this.NumClientAge.Size = new System.Drawing.Size(120, 20);
            this.NumClientAge.TabIndex = 7;
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(13, 108);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(89, 13);
            this.LblProductName.TabIndex = 9;
            this.LblProductName.Text = "Nome do produto";
            // 
            // TxtBoxProductName
            // 
            this.TxtBoxProductName.Location = new System.Drawing.Point(13, 124);
            this.TxtBoxProductName.Name = "TxtBoxProductName";
            this.TxtBoxProductName.Size = new System.Drawing.Size(248, 20);
            this.TxtBoxProductName.TabIndex = 8;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(343, 108);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(89, 13);
            this.LblAmount.TabIndex = 11;
            this.LblAmount.Text = "Preço do produto";
            // 
            // TxtBoxAmount
            // 
            this.TxtBoxAmount.Location = new System.Drawing.Point(343, 124);
            this.TxtBoxAmount.Name = "TxtBoxAmount";
            this.TxtBoxAmount.Size = new System.Drawing.Size(120, 20);
            this.TxtBoxAmount.TabIndex = 10;
            // 
            // FormEditorFieldsSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(525, 256);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.TxtBoxAmount);
            this.Controls.Add(this.LblProductName);
            this.Controls.Add(this.TxtBoxProductName);
            this.Controls.Add(this.NumClientAge);
            this.Controls.Add(this.LblClientAge);
            this.Controls.Add(this.LblClientName);
            this.Controls.Add(this.TxtBoxClientName);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirmAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditorFieldsSale";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.NumClientAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBoxId;
        private System.Windows.Forms.TextBox TxtBoxClientName;
        private System.Windows.Forms.Label LblClientName;
        private System.Windows.Forms.Label LblClientAge;
        private System.Windows.Forms.NumericUpDown NumClientAge;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.TextBox TxtBoxProductName;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.TextBox TxtBoxAmount;
    }
}