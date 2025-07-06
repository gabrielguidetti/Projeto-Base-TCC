namespace SistemaVendas
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvSales = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAddSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSales
            // 
            this.DgvSales.AllowUserToAddRows = false;
            this.DgvSales.AllowUserToDeleteRows = false;
            this.DgvSales.AllowUserToResizeColumns = false;
            this.DgvSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColClientName,
            this.ColClientAge,
            this.ColAmount,
            this.ColProductName,
            this.ColDelete});
            this.DgvSales.Location = new System.Drawing.Point(10, 10);
            this.DgvSales.MultiSelect = false;
            this.DgvSales.Name = "DgvSales";
            this.DgvSales.ReadOnly = true;
            this.DgvSales.RowHeadersVisible = false;
            this.DgvSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSales.Size = new System.Drawing.Size(1240, 650);
            this.DgvSales.TabIndex = 0;
            this.DgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSales_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColClientName
            // 
            this.ColClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColClientName.DataPropertyName = "ClientName";
            this.ColClientName.HeaderText = "Nome do cliente";
            this.ColClientName.Name = "ColClientName";
            this.ColClientName.ReadOnly = true;
            // 
            // ColClientAge
            // 
            this.ColClientAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColClientAge.DataPropertyName = "ClientAge";
            this.ColClientAge.HeaderText = "Idade do cliente";
            this.ColClientAge.Name = "ColClientAge";
            this.ColClientAge.ReadOnly = true;
            // 
            // ColAmount
            // 
            this.ColAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAmount.DataPropertyName = "Amount";
            this.ColAmount.HeaderText = "Valor";
            this.ColAmount.Name = "ColAmount";
            this.ColAmount.ReadOnly = true;
            // 
            // ColProductName
            // 
            this.ColProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProductName.DataPropertyName = "ProductName";
            this.ColProductName.HeaderText = "Nome do produto";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Excluir";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Text = "Excluir";
            this.ColDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnAddSale
            // 
            this.BtnAddSale.Location = new System.Drawing.Point(13, 666);
            this.BtnAddSale.Name = "BtnAddSale";
            this.BtnAddSale.Size = new System.Drawing.Size(75, 23);
            this.BtnAddSale.TabIndex = 1;
            this.BtnAddSale.Text = "Adicionar";
            this.BtnAddSale.UseVisualStyleBackColor = true;
            this.BtnAddSale.Click += new System.EventHandler(this.BtnAddSale_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.BtnAddSale);
            this.Controls.Add(this.DgvSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.Button BtnAddSale;
    }
}

