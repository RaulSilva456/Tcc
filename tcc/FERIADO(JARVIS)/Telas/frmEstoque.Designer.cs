namespace FERIADO_JARVIS_.Telas
{
    partial class frmEstoque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.dtpValidadeProduto = new System.Windows.Forms.DateTimePicker();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEstoque);
            this.groupBox1.Controls.Add(this.dtpValidadeProduto);
            this.groupBox1.Controls.Add(this.txtPreço);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(114, 184);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(119, 41);
            this.btnEstoque.TabIndex = 21;
            this.btnEstoque.Text = "Inserir produto para o estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // dtpValidadeProduto
            // 
            this.dtpValidadeProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidadeProduto.Location = new System.Drawing.Point(152, 132);
            this.dtpValidadeProduto.Name = "dtpValidadeProduto";
            this.dtpValidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.dtpValidadeProduto.TabIndex = 20;
            // 
            // txtPreço
            // 
            this.txtPreço.Location = new System.Drawing.Point(152, 99);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(100, 20);
            this.txtPreço.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "data validade:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(152, 64);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "nome do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(361, 315);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.DateTimePicker dtpValidadeProduto;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}