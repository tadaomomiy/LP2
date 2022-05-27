
namespace PAtividade9
{
    partial class frmExercicio2
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.txtFaturamento = new System.Windows.Forms.TextBox();
            this.lstbxProduto = new System.Windows.Forms.ListBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lstbxQtde = new System.Windows.Forms.ListBox();
            this.lstbxPreco = new System.Windows.Forms.ListBox();
            this.lstbxTotal = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(113, 237);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 50);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Faturamento";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturamento.Location = new System.Drawing.Point(31, 306);
            this.lblFaturamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(109, 20);
            this.lblFaturamento.TabIndex = 1;
            this.lblFaturamento.Text = "Faturamento: ";
            // 
            // txtFaturamento
            // 
            this.txtFaturamento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaturamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFaturamento.Location = new System.Drawing.Point(130, 303);
            this.txtFaturamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFaturamento.Name = "txtFaturamento";
            this.txtFaturamento.ReadOnly = true;
            this.txtFaturamento.Size = new System.Drawing.Size(127, 28);
            this.txtFaturamento.TabIndex = 2;
            // 
            // lstbxProduto
            // 
            this.lstbxProduto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstbxProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxProduto.Enabled = false;
            this.lstbxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxProduto.ForeColor = System.Drawing.Color.Black;
            this.lstbxProduto.FormattingEnabled = true;
            this.lstbxProduto.ItemHeight = 17;
            this.lstbxProduto.Location = new System.Drawing.Point(23, 39);
            this.lstbxProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbxProduto.Name = "lstbxProduto";
            this.lstbxProduto.Size = new System.Drawing.Size(74, 170);
            this.lstbxProduto.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(24, 17);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(69, 18);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto  ";
            // 
            // lstbxQtde
            // 
            this.lstbxQtde.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstbxQtde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxQtde.Enabled = false;
            this.lstbxQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxQtde.FormattingEnabled = true;
            this.lstbxQtde.ItemHeight = 17;
            this.lstbxQtde.Location = new System.Drawing.Point(94, 39);
            this.lstbxQtde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbxQtde.Name = "lstbxQtde";
            this.lstbxQtde.Size = new System.Drawing.Size(79, 170);
            this.lstbxQtde.TabIndex = 3;
            // 
            // lstbxPreco
            // 
            this.lstbxPreco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstbxPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxPreco.Enabled = false;
            this.lstbxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxPreco.FormatString = "C2";
            this.lstbxPreco.FormattingEnabled = true;
            this.lstbxPreco.ItemHeight = 17;
            this.lstbxPreco.Location = new System.Drawing.Point(172, 39);
            this.lstbxPreco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbxPreco.Name = "lstbxPreco";
            this.lstbxPreco.Size = new System.Drawing.Size(79, 170);
            this.lstbxPreco.TabIndex = 8;
            // 
            // lstbxTotal
            // 
            this.lstbxTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstbxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxTotal.Enabled = false;
            this.lstbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTotal.FormatString = "C2";
            this.lstbxTotal.FormattingEnabled = true;
            this.lstbxTotal.ItemHeight = 17;
            this.lstbxTotal.Location = new System.Drawing.Point(250, 39);
            this.lstbxTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbxTotal.Name = "lstbxTotal";
            this.lstbxTotal.Size = new System.Drawing.Size(79, 170);
            this.lstbxTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(251, 17);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 18);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total         ";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(174, 17);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(80, 18);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço        ";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(91, 17);
            this.lblQtde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(83, 18);
            this.lblQtde.TabIndex = 5;
            this.lblQtde.Text = "Quantidade";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 375);
            this.Controls.Add(this.lstbxTotal);
            this.Controls.Add(this.lstbxPreco);
            this.Controls.Add(this.lstbxQtde);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lstbxProduto);
            this.Controls.Add(this.txtFaturamento);
            this.Controls.Add(this.lblFaturamento);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.TextBox txtFaturamento;
        private System.Windows.Forms.ListBox lstbxProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListBox lstbxQtde;
        private System.Windows.Forms.ListBox lstbxPreco;
        private System.Windows.Forms.ListBox lstbxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQtde;
    }
}