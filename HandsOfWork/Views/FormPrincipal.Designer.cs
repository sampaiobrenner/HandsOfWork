using System.ComponentModel;

namespace HandsOfWork.Views
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnListagemClientes = new System.Windows.Forms.Button();
            this.btnListagemProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListagemClientes
            // 
            this.btnListagemClientes.Location = new System.Drawing.Point(186, 53);
            this.btnListagemClientes.Name = "btnListagemClientes";
            this.btnListagemClientes.Size = new System.Drawing.Size(206, 51);
            this.btnListagemClientes.TabIndex = 0;
            this.btnListagemClientes.Text = "Listagem de clientes";
            this.btnListagemClientes.UseVisualStyleBackColor = true;
            this.btnListagemClientes.Click += new System.EventHandler(this.btnListagemClientes_Click);
            // 
            // btnListagemProdutos
            // 
            this.btnListagemProdutos.Location = new System.Drawing.Point(413, 53);
            this.btnListagemProdutos.Name = "btnListagemProdutos";
            this.btnListagemProdutos.Size = new System.Drawing.Size(206, 51);
            this.btnListagemProdutos.TabIndex = 1;
            this.btnListagemProdutos.Text = "Listagem de produtos";
            this.btnListagemProdutos.UseVisualStyleBackColor = true;
            this.btnListagemProdutos.Click += new System.EventHandler(this.btnListagemProdutos_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 149);
            this.Controls.Add(this.btnListagemProdutos);
            this.Controls.Add(this.btnListagemClientes);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnListagemClientes;
        private System.Windows.Forms.Button btnListagemProdutos;

        #endregion
    }
}