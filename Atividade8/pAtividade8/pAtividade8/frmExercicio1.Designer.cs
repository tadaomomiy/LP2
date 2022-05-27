
namespace PAtividade8
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnContSpace = new System.Windows.Forms.Button();
            this.btnContR = new System.Windows.Forms.Button();
            this.btnContOcorrencias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(79, 27);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(367, 105);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnContSpace
            // 
            this.btnContSpace.Location = new System.Drawing.Point(31, 155);
            this.btnContSpace.Name = "btnContSpace";
            this.btnContSpace.Size = new System.Drawing.Size(142, 84);
            this.btnContSpace.TabIndex = 1;
            this.btnContSpace.Text = "Conta Espaços";
            this.btnContSpace.UseVisualStyleBackColor = true;
            this.btnContSpace.Click += new System.EventHandler(this.btnContSpace_Click);
            // 
            // btnContR
            // 
            this.btnContR.Location = new System.Drawing.Point(192, 155);
            this.btnContR.Name = "btnContR";
            this.btnContR.Size = new System.Drawing.Size(142, 84);
            this.btnContR.TabIndex = 2;
            this.btnContR.Text = "Conta Letra R";
            this.btnContR.UseVisualStyleBackColor = true;
            this.btnContR.Click += new System.EventHandler(this.btnContR_Click);
            // 
            // btnContOcorrencias
            // 
            this.btnContOcorrencias.Location = new System.Drawing.Point(352, 155);
            this.btnContOcorrencias.Name = "btnContOcorrencias";
            this.btnContOcorrencias.Size = new System.Drawing.Size(142, 84);
            this.btnContOcorrencias.TabIndex = 3;
            this.btnContOcorrencias.Text = "Conta Ocorrências";
            this.btnContOcorrencias.UseVisualStyleBackColor = true;
            this.btnContOcorrencias.Click += new System.EventHandler(this.btnContOcorrencias_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 288);
            this.Controls.Add(this.btnContOcorrencias);
            this.Controls.Add(this.btnContR);
            this.Controls.Add(this.btnContSpace);
            this.Controls.Add(this.rchtxtFrase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnContSpace;
        private System.Windows.Forms.Button btnContR;
        private System.Windows.Forms.Button btnContOcorrencias;
    }
}