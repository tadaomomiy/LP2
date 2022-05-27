
namespace PAtividade8
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
            this.lblNumN = new System.Windows.Forms.Label();
            this.txtNumN = new System.Windows.Forms.TextBox();
            this.txtNumH = new System.Windows.Forms.TextBox();
            this.lblNumH = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumN
            // 
            this.lblNumN.AutoSize = true;
            this.lblNumN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumN.Location = new System.Drawing.Point(93, 61);
            this.lblNumN.Name = "lblNumN";
            this.lblNumN.Size = new System.Drawing.Size(80, 20);
            this.lblNumN.TabIndex = 0;
            this.lblNumN.Text = "Número N";
            // 
            // txtNumN
            // 
            this.txtNumN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumN.Location = new System.Drawing.Point(180, 58);
            this.txtNumN.Name = "txtNumN";
            this.txtNumN.Size = new System.Drawing.Size(112, 26);
            this.txtNumN.TabIndex = 1;
            // 
            // txtNumH
            // 
            this.txtNumH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumH.Location = new System.Drawing.Point(180, 254);
            this.txtNumH.Name = "txtNumH";
            this.txtNumH.ReadOnly = true;
            this.txtNumH.Size = new System.Drawing.Size(112, 26);
            this.txtNumH.TabIndex = 2;
            // 
            // lblNumH
            // 
            this.lblNumH.AutoSize = true;
            this.lblNumH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumH.Location = new System.Drawing.Point(76, 257);
            this.lblNumH.Name = "lblNumH";
            this.lblNumH.Size = new System.Drawing.Size(98, 20);
            this.lblNumH.TabIndex = 2;
            this.lblNumH.Text = "Resultado H";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(164, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(147, 78);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 367);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumH);
            this.Controls.Add(this.lblNumH);
            this.Controls.Add(this.txtNumN);
            this.Controls.Add(this.lblNumN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumN;
        private System.Windows.Forms.TextBox txtNumN;
        private System.Windows.Forms.TextBox txtNumH;
        private System.Windows.Forms.Label lblNumH;
        private System.Windows.Forms.Button btnCalcular;
    }
}