
namespace PAtividade8
{
    partial class frmExercicio4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.lblProducao = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(50, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 29);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(488, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(52, 103);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(56, 20);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(30, 68);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(77, 20);
            this.lblMatricula.TabIndex = 4;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(115, 65);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(159, 26);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.Validated += new System.EventHandler(this.txtMatricula_Validated);
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(115, 173);
            this.txtProducao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(109, 26);
            this.txtProducao.TabIndex = 4;
            this.txtProducao.Validated += new System.EventHandler(this.txtProducao_Validated);
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Location = new System.Drawing.Point(26, 177);
            this.lblProducao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(81, 20);
            this.lblProducao.TabIndex = 6;
            this.lblProducao.Text = "Produção:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(115, 137);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(159, 26);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.Validated += new System.EventHandler(this.txtSalario_Validated);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(45, 140);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(62, 20);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Salário:";
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(115, 209);
            this.txtGratificacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(141, 26);
            this.txtGratificacao.TabIndex = 6;
            this.txtGratificacao.Validated += new System.EventHandler(this.txtGratificacao_Validated);
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Location = new System.Drawing.Point(8, 212);
            this.lblGratificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(99, 20);
            this.lblGratificacao.TabIndex = 10;
            this.lblGratificacao.Text = "Gratificação:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(13, 291);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(206, 65);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.BackColor = System.Drawing.SystemColors.Info;
            this.txtSalBruto.Location = new System.Drawing.Point(404, 330);
            this.txtSalBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.ReadOnly = true;
            this.txtSalBruto.Size = new System.Drawing.Size(186, 26);
            this.txtSalBruto.TabIndex = 14;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(291, 333);
            this.lblSalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(105, 20);
            this.lblSalBruto.TabIndex = 13;
            this.lblSalBruto.Text = "Salário Bruto:";
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Analista de TI",
            "Head  Web Analytics.",
            "Head de TI.",
            "Tech Leader.",
            "Engenheiro de software"});
            this.cbxCargo.Location = new System.Drawing.Point(115, 100);
            this.cbxCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(290, 28);
            this.cbxCargo.TabIndex = 2;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 389);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.ComboBox cbxCargo;
    }
}