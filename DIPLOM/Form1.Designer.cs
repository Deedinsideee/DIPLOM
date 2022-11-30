namespace DIPLOM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_downloadmany = new System.Windows.Forms.Button();
            this.button_download_one = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_downloadmany
            // 
            this.button_downloadmany.Location = new System.Drawing.Point(694, 12);
            this.button_downloadmany.Name = "button_downloadmany";
            this.button_downloadmany.Size = new System.Drawing.Size(187, 97);
            this.button_downloadmany.TabIndex = 0;
            this.button_downloadmany.Text = "загрузить много файлов";
            this.button_downloadmany.UseVisualStyleBackColor = true;
            // 
            // button_download_one
            // 
            this.button_download_one.Location = new System.Drawing.Point(199, 12);
            this.button_download_one.Name = "button_download_one";
            this.button_download_one.Size = new System.Drawing.Size(187, 97);
            this.button_download_one.TabIndex = 1;
            this.button_download_one.Text = "загрузить один файл";
            this.button_download_one.UseVisualStyleBackColor = true;
            this.button_download_one.Click += new System.EventHandler(this.button_download_one_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 315);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_download_one);
            this.Controls.Add(this.button_downloadmany);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_downloadmany;
        private System.Windows.Forms.Button button_download_one;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

