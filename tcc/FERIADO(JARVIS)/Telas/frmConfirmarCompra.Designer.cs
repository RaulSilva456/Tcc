namespace FERIADO_JARVIS_.Telas
{
    partial class frmConfirmarCompra
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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudQuantidadeAlteração = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdutoAlteração = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeAlteração)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvPedido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmação de compra";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(19, 19);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(308, 154);
            this.dgvPedido.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar compra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Alterar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtIDProduto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudQuantidadeAlteração);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtProdutoAlteração);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(351, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar Pedido";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nudQuantidadeAlteração
            // 
            this.nudQuantidadeAlteração.Location = new System.Drawing.Point(99, 136);
            this.nudQuantidadeAlteração.Name = "nudQuantidadeAlteração";
            this.nudQuantidadeAlteração.Size = new System.Drawing.Size(99, 20);
            this.nudQuantidadeAlteração.TabIndex = 30;
            this.nudQuantidadeAlteração.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantidade";
            // 
            // txtProdutoAlteração
            // 
            this.txtProdutoAlteração.Location = new System.Drawing.Point(98, 98);
            this.txtProdutoAlteração.Name = "txtProdutoAlteração";
            this.txtProdutoAlteração.Size = new System.Drawing.Size(100, 20);
            this.txtProdutoAlteração.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Novo Produto:";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(99, 59);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID Produto:";
            // 
            // frmConfirmarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(612, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmarCompra";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeAlteração)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantidadeAlteração;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdutoAlteração;
        private System.Windows.Forms.Label label1;
    }
}