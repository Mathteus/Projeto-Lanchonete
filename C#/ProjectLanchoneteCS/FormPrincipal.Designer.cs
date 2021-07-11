
namespace ProjectLanchoneteCS
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.button_confirmar_name = new System.Windows.Forms.Button();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button_confirmar_name
            // 
            resources.ApplyResources(this.button_confirmar_name, "button_confirmar_name");
            this.button_confirmar_name.Name = "button_confirmar_name";
            this.button_confirmar_name.UseVisualStyleBackColor = true;
            this.button_confirmar_name.Click += new System.EventHandler(this.button_confirmar_name_Click);
            // 
            // txtBox_name
            // 
            resources.ApplyResources(this.txtBox_name, "txtBox_name");
            this.txtBox_name.Name = "txtBox_name";
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.button_confirmar_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_confirmar_name;
        private System.Windows.Forms.TextBox txtBox_name;
    }
}

