
namespace PAtividade9
{
    partial class frmExercicio6
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lstbxNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(138, 53);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(159, 76);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lstbxNomes
            // 
            this.lstbxNomes.BackColor = System.Drawing.Color.LightBlue;
            this.lstbxNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxNomes.FormattingEnabled = true;
            this.lstbxNomes.HorizontalScrollbar = true;
            this.lstbxNomes.ItemHeight = 22;
            this.lstbxNomes.Location = new System.Drawing.Point(21, 162);
            this.lstbxNomes.MultiColumn = true;
            this.lstbxNomes.Name = "lstbxNomes";
            this.lstbxNomes.Size = new System.Drawing.Size(416, 48);
            this.lstbxNomes.TabIndex = 1;
            // 
            // frmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 255);
            this.Controls.Add(this.lstbxNomes);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmExercicio6";
            this.Text = "frmExercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox lstbxNomes;
    }
}