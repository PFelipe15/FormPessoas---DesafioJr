namespace FormPessoas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label sexoLabel;
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalCad = new System.Windows.Forms.Label();
            this.lstPessoas = new System.Windows.Forms.ListView();
            this.chbMasculino = new System.Windows.Forms.CheckBox();
            this.chbFeminino = new System.Windows.Forms.CheckBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lbTotalM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalF = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(74, 69);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(37, 13);
            idadeLabel.TabIndex = 1;
            idadeLabel.Text = "Idade:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(225, 69);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 2;
            sexoLabel.Text = "Sexo:";
            sexoLabel.Click += new System.EventHandler(this.sexoLabel_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(116, 65);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(395, 64);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastrar Pessoas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar Pessoas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de Cadastros:";
            // 
            // lbTotalCad
            // 
            this.lbTotalCad.AutoSize = true;
            this.lbTotalCad.Location = new System.Drawing.Point(170, 599);
            this.lbTotalCad.Name = "lbTotalCad";
            this.lbTotalCad.Size = new System.Drawing.Size(13, 13);
            this.lbTotalCad.TabIndex = 10;
            this.lbTotalCad.Text = "0";
            // 
            // lstPessoas
            // 
            this.lstPessoas.HideSelection = false;
            this.lstPessoas.Location = new System.Drawing.Point(12, 196);
            this.lstPessoas.Name = "lstPessoas";
            this.lstPessoas.Size = new System.Drawing.Size(530, 375);
            this.lstPessoas.TabIndex = 12;
            this.lstPessoas.UseCompatibleStateImageBehavior = false;
            // 
            // chbMasculino
            // 
            this.chbMasculino.AutoSize = true;
            this.chbMasculino.Location = new System.Drawing.Point(161, 173);
            this.chbMasculino.Name = "chbMasculino";
            this.chbMasculino.Size = new System.Drawing.Size(74, 17);
            this.chbMasculino.TabIndex = 13;
            this.chbMasculino.Text = "Masculino";
            this.chbMasculino.UseVisualStyleBackColor = true;
            this.chbMasculino.CheckedChanged += new System.EventHandler(this.chbMasculino_CheckedChanged);
            // 
            // chbFeminino
            // 
            this.chbFeminino.AutoSize = true;
            this.chbFeminino.Location = new System.Drawing.Point(252, 173);
            this.chbFeminino.Name = "chbFeminino";
            this.chbFeminino.Size = new System.Drawing.Size(68, 17);
            this.chbFeminino.TabIndex = 14;
            this.chbFeminino.Text = "Feminino";
            this.chbFeminino.UseVisualStyleBackColor = true;
            this.chbFeminino.CheckedChanged += new System.EventHandler(this.chbFeminino_CheckedChanged);
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Location = new System.Drawing.Point(344, 173);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(56, 17);
            this.chbTodos.TabIndex = 15;
            this.chbTodos.Text = "Todos";
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoCompleteCustomSource.AddRange(new string[] {
            "M"});
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(259, 65);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 16;
            this.cmbSexo.Text = "Selecione";
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbTotalM
            // 
            this.lbTotalM.AutoSize = true;
            this.lbTotalM.Location = new System.Drawing.Point(298, 599);
            this.lbTotalM.Name = "lbTotalM";
            this.lbTotalM.Size = new System.Drawing.Size(13, 13);
            this.lbTotalM.TabIndex = 18;
            this.lbTotalM.Text = "0";
            this.lbTotalM.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total de M: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbTotalF
            // 
            this.lbTotalF.AutoSize = true;
            this.lbTotalF.Location = new System.Drawing.Point(445, 599);
            this.lbTotalF.Name = "lbTotalF";
            this.lbTotalF.Size = new System.Drawing.Size(13, 13);
            this.lbTotalF.TabIndex = 20;
            this.lbTotalF.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total de F: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 167);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(341, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "DESENVOLVIDO POR PAULO FELIPE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(554, 715);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lbTotalF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotalM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.chbTodos);
            this.Controls.Add(this.chbFeminino);
            this.Controls.Add(this.chbMasculino);
            this.Controls.Add(this.lstPessoas);
            this.Controls.Add(this.lbTotalCad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(this.txtIdade);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Aplicação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalCad;
        private System.Windows.Forms.ListView lstPessoas;
        private System.Windows.Forms.CheckBox chbMasculino;
        private System.Windows.Forms.CheckBox chbFeminino;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lbTotalM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
    }
}

