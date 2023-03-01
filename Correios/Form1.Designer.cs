
namespace Correios
{
    partial class Form1
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
            this.CEPi = new System.Windows.Forms.TextBox();
            this.RUAi = new System.Windows.Forms.TextBox();
            this.ESTi = new System.Windows.Forms.TextBox();
            this.CIDi = new System.Windows.Forms.TextBox();
            this.BAIi = new System.Windows.Forms.TextBox();
            this.COMi = new System.Windows.Forms.TextBox();
            this.NUMi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ENDi = new System.Windows.Forms.Label();
            this.um = new System.Windows.Forms.Label();
            this.sad = new System.Windows.Forms.Label();
            this.BRRi = new System.Windows.Forms.Label();
            this.CDDi = new System.Windows.Forms.Label();
            this.ESTsdai = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CEPi
            // 
            this.CEPi.Location = new System.Drawing.Point(41, 35);
            this.CEPi.Name = "CEPi";
            this.CEPi.Size = new System.Drawing.Size(100, 20);
            this.CEPi.TabIndex = 0;
            this.CEPi.TextChanged += new System.EventHandler(this.CEPi_TextChanged_1);
            this.CEPi.Leave += new System.EventHandler(this.CEPi_Leave);
            // 
            // RUAi
            // 
            this.RUAi.Location = new System.Drawing.Point(41, 79);
            this.RUAi.Name = "RUAi";
            this.RUAi.Size = new System.Drawing.Size(100, 20);
            this.RUAi.TabIndex = 1;
            // 
            // ESTi
            // 
            this.ESTi.Location = new System.Drawing.Point(279, 126);
            this.ESTi.Name = "ESTi";
            this.ESTi.Size = new System.Drawing.Size(100, 20);
            this.ESTi.TabIndex = 2;
            // 
            // CIDi
            // 
            this.CIDi.Location = new System.Drawing.Point(162, 126);
            this.CIDi.Name = "CIDi";
            this.CIDi.Size = new System.Drawing.Size(100, 20);
            this.CIDi.TabIndex = 3;
            // 
            // BAIi
            // 
            this.BAIi.Location = new System.Drawing.Point(41, 126);
            this.BAIi.Name = "BAIi";
            this.BAIi.Size = new System.Drawing.Size(100, 20);
            this.BAIi.TabIndex = 4;
            // 
            // COMi
            // 
            this.COMi.Location = new System.Drawing.Point(279, 79);
            this.COMi.Name = "COMi";
            this.COMi.Size = new System.Drawing.Size(100, 20);
            this.COMi.TabIndex = 5;
            // 
            // NUMi
            // 
            this.NUMi.Location = new System.Drawing.Point(162, 79);
            this.NUMi.Name = "NUMi";
            this.NUMi.Size = new System.Drawing.Size(100, 20);
            this.NUMi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o CEP";
            // 
            // ENDi
            // 
            this.ENDi.AutoSize = true;
            this.ENDi.Location = new System.Drawing.Point(38, 63);
            this.ENDi.Name = "ENDi";
            this.ENDi.Size = new System.Drawing.Size(53, 13);
            this.ENDi.TabIndex = 8;
            this.ENDi.Text = "Endereço";
            // 
            // um
            // 
            this.um.AutoSize = true;
            this.um.Location = new System.Drawing.Point(159, 63);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(44, 13);
            this.um.TabIndex = 9;
            this.um.Text = "Número";
            // 
            // sad
            // 
            this.sad.AutoSize = true;
            this.sad.Location = new System.Drawing.Point(276, 63);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(71, 13);
            this.sad.TabIndex = 10;
            this.sad.Text = "Complemento";
            // 
            // BRRi
            // 
            this.BRRi.AutoSize = true;
            this.BRRi.Location = new System.Drawing.Point(38, 110);
            this.BRRi.Name = "BRRi";
            this.BRRi.Size = new System.Drawing.Size(34, 13);
            this.BRRi.TabIndex = 11;
            this.BRRi.Text = "Bairro";
            // 
            // CDDi
            // 
            this.CDDi.AutoSize = true;
            this.CDDi.Location = new System.Drawing.Point(159, 110);
            this.CDDi.Name = "CDDi";
            this.CDDi.Size = new System.Drawing.Size(40, 13);
            this.CDDi.TabIndex = 12;
            this.CDDi.Text = "Cidade";
            // 
            // ESTsdai
            // 
            this.ESTsdai.AutoSize = true;
            this.ESTsdai.Location = new System.Drawing.Point(276, 110);
            this.ESTsdai.Name = "ESTsdai";
            this.ESTsdai.Size = new System.Drawing.Size(40, 13);
            this.ESTsdai.TabIndex = 13;
            this.ESTsdai.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consulta automática";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ESTsdai);
            this.Controls.Add(this.CDDi);
            this.Controls.Add(this.BRRi);
            this.Controls.Add(this.sad);
            this.Controls.Add(this.um);
            this.Controls.Add(this.ENDi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUMi);
            this.Controls.Add(this.COMi);
            this.Controls.Add(this.BAIi);
            this.Controls.Add(this.CIDi);
            this.Controls.Add(this.ESTi);
            this.Controls.Add(this.RUAi);
            this.Controls.Add(this.CEPi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CEPi;
        private System.Windows.Forms.TextBox RUAi;
        private System.Windows.Forms.TextBox ESTi;
        private System.Windows.Forms.TextBox CIDi;
        private System.Windows.Forms.TextBox BAIi;
        private System.Windows.Forms.TextBox COMi;
        private System.Windows.Forms.TextBox NUMi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ENDi;
        private System.Windows.Forms.Label um;
        private System.Windows.Forms.Label sad;
        private System.Windows.Forms.Label BRRi;
        private System.Windows.Forms.Label CDDi;
        private System.Windows.Forms.Label ESTsdai;
        private System.Windows.Forms.Button button1;
    }
}

