
namespace ProjectLanchoneteCS
{
    partial class FormRepedir
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNao = new System.Windows.Forms.Button();
            this.buttonSim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonNao
            // 
            this.buttonNao.Location = new System.Drawing.Point(124, 60);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(75, 23);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = true;
            this.buttonNao.Click += new System.EventHandler(this.buttonNao_Click);
            // 
            // buttonSim
            // 
            this.buttonSim.Location = new System.Drawing.Point(12, 60);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(75, 23);
            this.buttonSim.TabIndex = 2;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = true;
            this.buttonSim.Click += new System.EventHandler(this.buttonSim_Click);
            // 
            // FormRepedir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 91);
            this.Controls.Add(this.buttonSim);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.label1);
            this.Name = "FormRepedir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRepedir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Button buttonSim;
    }
}