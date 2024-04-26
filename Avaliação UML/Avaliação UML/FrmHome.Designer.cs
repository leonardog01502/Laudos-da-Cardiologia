namespace Avaliação_UML
{
    partial class FrmHome
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnPapeis = new System.Windows.Forms.Button();
            this.btnSolicitarExames = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(30, 31);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(8);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(232, 76);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro dos Médicos";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnPapeis
            // 
            this.btnPapeis.BackColor = System.Drawing.Color.DimGray;
            this.btnPapeis.FlatAppearance.BorderSize = 0;
            this.btnPapeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapeis.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapeis.ForeColor = System.Drawing.Color.White;
            this.btnPapeis.Location = new System.Drawing.Point(313, 31);
            this.btnPapeis.Margin = new System.Windows.Forms.Padding(8);
            this.btnPapeis.Name = "btnPapeis";
            this.btnPapeis.Size = new System.Drawing.Size(232, 76);
            this.btnPapeis.TabIndex = 2;
            this.btnPapeis.Text = "Papeis Médicos";
            this.btnPapeis.UseVisualStyleBackColor = false;
            this.btnPapeis.Click += new System.EventHandler(this.btnPapeis_Click);
            // 
            // btnSolicitarExames
            // 
            this.btnSolicitarExames.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSolicitarExames.FlatAppearance.BorderSize = 0;
            this.btnSolicitarExames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarExames.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarExames.ForeColor = System.Drawing.Color.White;
            this.btnSolicitarExames.Location = new System.Drawing.Point(30, 155);
            this.btnSolicitarExames.Margin = new System.Windows.Forms.Padding(8);
            this.btnSolicitarExames.Name = "btnSolicitarExames";
            this.btnSolicitarExames.Size = new System.Drawing.Size(232, 76);
            this.btnSolicitarExames.TabIndex = 3;
            this.btnSolicitarExames.Text = "Solicitar Exames";
            this.btnSolicitarExames.UseVisualStyleBackColor = false;
            this.btnSolicitarExames.Click += new System.EventHandler(this.btnSolicitarExames_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(313, 155);
            this.btnSair.Margin = new System.Windows.Forms.Padding(8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(232, 76);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(618, 307);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSolicitarExames);
            this.Controls.Add(this.btnPapeis);
            this.Controls.Add(this.btnCadastro);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
//            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnPapeis;
        private System.Windows.Forms.Button btnSolicitarExames;
        private System.Windows.Forms.Button btnSair;
    }
}

