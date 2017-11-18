namespace USBList
{
    partial class UBSListForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.USBListTable = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeMemoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedMemoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMemoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EjectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.USBListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // USBListTable
            // 
            this.USBListTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.USBListTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USBListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.USBListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LetterColumn,
            this.FreeMemoryColumn,
            this.UsedMemoryColumn,
            this.TotalMemoryColumn,
            this.EjectColumn});
            this.USBListTable.Location = new System.Drawing.Point(-2, -1);
            this.USBListTable.Name = "USBListTable";
            this.USBListTable.Size = new System.Drawing.Size(609, 259);
            this.USBListTable.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 95;
            // 
            // LetterColumn
            // 
            this.LetterColumn.HeaderText = "Letter";
            this.LetterColumn.Name = "LetterColumn";
            this.LetterColumn.ReadOnly = true;
            this.LetterColumn.Width = 94;
            // 
            // FreeMemoryColumn
            // 
            this.FreeMemoryColumn.HeaderText = "FreeMemory";
            this.FreeMemoryColumn.Name = "FreeMemoryColumn";
            this.FreeMemoryColumn.ReadOnly = true;
            this.FreeMemoryColumn.Width = 95;
            // 
            // UsedMemoryColumn
            // 
            this.UsedMemoryColumn.HeaderText = "UsedMemory";
            this.UsedMemoryColumn.Name = "UsedMemoryColumn";
            this.UsedMemoryColumn.ReadOnly = true;
            this.UsedMemoryColumn.Width = 95;
            // 
            // TotalMemoryColumn
            // 
            this.TotalMemoryColumn.HeaderText = "TotalMemory";
            this.TotalMemoryColumn.Name = "TotalMemoryColumn";
            this.TotalMemoryColumn.ReadOnly = true;
            this.TotalMemoryColumn.Width = 94;
            // 
            // EjectColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Eject";
            this.EjectColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.EjectColumn.HeaderText = "Eject";
            this.EjectColumn.Name = "EjectColumn";
            this.EjectColumn.ReadOnly = true;
            this.EjectColumn.Text = "Eject";
            this.EjectColumn.UseColumnTextForButtonValue = true;
            this.EjectColumn.Width = 95;
            // 
            // UBSListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 262);
            this.Controls.Add(this.USBListTable);
            this.Name = "UBSListForm";
            this.Text = "USB List";
            ((System.ComponentModel.ISupportInitialize)(this.USBListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView USBListTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeMemoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedMemoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMemoryColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EjectColumn;
    }
}

