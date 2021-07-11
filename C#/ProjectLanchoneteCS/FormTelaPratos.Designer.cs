
namespace ProjectLanchoneteCS
{
    partial class FormTelaPratos
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.buttonLanche = new System.Windows.Forms.Button();
            this.buttonPizza = new System.Windows.Forms.Button();
            this.buttonSalgados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "label1";
            // 
            // buttonLanche
            // 
            this.buttonLanche.Location = new System.Drawing.Point(12, 36);
            this.buttonLanche.Name = "buttonLanche";
            this.buttonLanche.Size = new System.Drawing.Size(208, 23);
            this.buttonLanche.TabIndex = 1;
            this.buttonLanche.Text = "Lanche";
            this.buttonLanche.UseVisualStyleBackColor = true;
            this.buttonLanche.Click += new System.EventHandler(this.buttonLanche_Click);
            // 
            // buttonPizza
            // 
            this.buttonPizza.Location = new System.Drawing.Point(12, 78);
            this.buttonPizza.Name = "buttonPizza";
            this.buttonPizza.Size = new System.Drawing.Size(208, 23);
            this.buttonPizza.TabIndex = 2;
            this.buttonPizza.Text = "Pizza";
            this.buttonPizza.UseVisualStyleBackColor = true;
            this.buttonPizza.Click += new System.EventHandler(this.buttonPizza_Click);
            // 
            // buttonSalgados
            // 
            this.buttonSalgados.Location = new System.Drawing.Point(12, 116);
            this.buttonSalgados.Name = "buttonSalgados";
            this.buttonSalgados.Size = new System.Drawing.Size(208, 23);
            this.buttonSalgados.TabIndex = 3;
            this.buttonSalgados.Text = "Salgados";
            this.buttonSalgados.UseVisualStyleBackColor = true;
            this.buttonSalgados.Click += new System.EventHandler(this.buttonSalgados_Click);
            // 
            // FormTelaPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 162);
            this.Controls.Add(this.buttonSalgados);
            this.Controls.Add(this.buttonPizza);
            this.Controls.Add(this.buttonLanche);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "FormTelaPratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTelaPratos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTelaPratos_FormClosed);
            this.Load += new System.EventHandler(this.FormTelaPratos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button buttonLanche;
        private System.Windows.Forms.Button buttonPizza;
        private System.Windows.Forms.Button buttonSalgados;
    }
}