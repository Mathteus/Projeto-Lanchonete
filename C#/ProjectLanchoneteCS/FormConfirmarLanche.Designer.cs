
namespace ProjectLanchoneteCS
{
    partial class FormConfirmarLanche
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
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonSim
            // 
            this.buttonSim.Location = new System.Drawing.Point(6, 289);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(216, 23);
            this.buttonSim.TabIndex = 1;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = true;
            this.buttonSim.Click += new System.EventHandler(this.buttonSim_Click);
            // 
            // buttonNao
            // 
            this.buttonNao.Location = new System.Drawing.Point(255, 289);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(247, 23);
            this.buttonNao.TabIndex = 2;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = true;
            this.buttonNao.Click += new System.EventHandler(this.buttonNao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seu Pedido Está Certo?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seu Combo:";
            // 
            // FormConfirmarLanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.buttonSim);
            this.Controls.Add(this.label1);
            this.Name = "FormConfirmarLanche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfirmarLanche";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfirmarLanche_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}