namespace FERIADO_JARVIS_.Telas
{
    partial class frmPedidoCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdutoPedido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQuantidadePedido = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.nudQuantidadePedido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProdutoPedido);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvEstoque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade";
            // 
            // txtProdutoPedido
            // 
            this.txtProdutoPedido.Location = new System.Drawing.Point(145, 207);
            this.txtProdutoPedido.Name = "txtProdutoPedido";
            this.txtProdutoPedido.Size = new System.Drawing.Size(100, 20);
            this.txtProdutoPedido.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fazer Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(21, 23);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(326, 150);
            this.dgvEstoque.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // nudQuantidadePedido
            // 
            this.nudQuantidadePedido.Location = new System.Drawing.Point(146, 245);
            this.nudQuantidadePedido.Name = "nudQuantidadePedido";
            this.nudQuantidadePedido.Size = new System.Drawing.Size(99, 20);
            this.nudQuantidadePedido.TabIndex = 13;
            this.nudQuantidadePedido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmPedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(388, 354);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPedidoCliente";
            this.Load += new System.EventHandler(this.frmPedidoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadePedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdutoPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQuantidadePedido;
    }
}