namespace FERIADO_JARVIS_.Telas
{
    partial class frmFolhaPagamento
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
            this.dgvFolhaPagamento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.pagamento = new System.Windows.Forms.DateTimePicker();
            this.txtGratificação = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHRExtra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolhaPagamento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dgvFolhaPagamento);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cboFuncionario);
            this.groupBox1.Controls.Add(this.pagamento);
            this.groupBox1.Controls.Add(this.txtGratificação);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtVA);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtImpostoRenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtVT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFaltas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSalarioLiquido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalarioBruto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHRExtra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtINSS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dgvFolhaPagamento
            // 
            this.dgvFolhaPagamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFolhaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolhaPagamento.Location = new System.Drawing.Point(13, 316);
            this.dgvFolhaPagamento.Name = "dgvFolhaPagamento";
            this.dgvFolhaPagamento.Size = new System.Drawing.Size(435, 136);
            this.dgvFolhaPagamento.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 66);
            this.panel1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FERIADO_JARVIS_.Properties.Resources.voltar_icone2;
            this.pictureBox1.Location = new System.Drawing.Point(433, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(110, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 34);
            this.label13.TabIndex = 0;
            this.label13.Text = "Folha de Pagamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 24);
            this.label12.TabIndex = 69;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(141, 80);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(100, 21);
            this.cboFuncionario.TabIndex = 71;
            // 
            // pagamento
            // 
            this.pagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pagamento.Location = new System.Drawing.Point(361, 205);
            this.pagamento.Name = "pagamento";
            this.pagamento.Size = new System.Drawing.Size(97, 20);
            this.pagamento.TabIndex = 70;
            // 
            // txtGratificação
            // 
            this.txtGratificação.Location = new System.Drawing.Point(141, 156);
            this.txtGratificação.Name = "txtGratificação";
            this.txtGratificação.Size = new System.Drawing.Size(100, 20);
            this.txtGratificação.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "gratificação:";
            // 
            // txtVA
            // 
            this.txtVA.Location = new System.Drawing.Point(141, 223);
            this.txtVA.Name = "txtVA";
            this.txtVA.Size = new System.Drawing.Size(100, 20);
            this.txtVA.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 24);
            this.label10.TabIndex = 65;
            this.label10.Text = "imposto de renda:";
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Location = new System.Drawing.Point(141, 187);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(100, 20);
            this.txtImpostoRenda.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "vale alimentação:";
            // 
            // txtVT
            // 
            this.txtVT.Location = new System.Drawing.Point(141, 257);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(100, 20);
            this.txtVT.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "vale transporte:";
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(141, 290);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 20);
            this.txtFaltas.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(77, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 59;
            this.label7.Text = "faltas:";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(361, 81);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioLiquido.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(241, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "salario liquido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Funcionario:";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(361, 120);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBruto.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "salario bruto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "pagamento:";
            // 
            // txtHRExtra
            // 
            this.txtHRExtra.Location = new System.Drawing.Point(141, 116);
            this.txtHRExtra.Name = "txtHRExtra";
            this.txtHRExtra.Size = new System.Drawing.Size(100, 20);
            this.txtHRExtra.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "hora extra:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(281, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 48;
            this.button1.Text = "Inserir na folha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(358, 160);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(100, 20);
            this.txtINSS.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "inss:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(291, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 24);
            this.label14.TabIndex = 74;
            this.label14.Text = "Visualizar folha";
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::FERIADO_JARVIS_.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 485);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFolhaPagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolhaPagamento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGratificação;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHRExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker pagamento;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.DataGridView dgvFolhaPagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
    }
}