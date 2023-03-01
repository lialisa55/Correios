
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ENDi = new System.Windows.Forms.Label();
            this.NUMi = new System.Windows.Forms.Label();
            this.COMi = new System.Windows.Forms.Label();
            this.BRRi = new System.Windows.Forms.Label();
            this.CDDi = new System.Windows.Forms.Label();
            this.ESTi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CEPi
            // 
            this.CEPi.Location = new System.Drawing.Point(63, 33);
            this.CEPi.Name = "CEPi";
            this.CEPi.Size = new System.Drawing.Size(100, 20);
            this.CEPi.TabIndex = 0;
            this.CEPi.Leave += new System.EventHandler(this.CEPi_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(63, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(301, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(184, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o CEP";
            // 
            // ENDi
            // 
            this.ENDi.AutoSize = true;
            this.ENDi.Location = new System.Drawing.Point(60, 61);
            this.ENDi.Name = "ENDi";
            this.ENDi.Size = new System.Drawing.Size(53, 13);
            this.ENDi.TabIndex = 8;
            this.ENDi.Text = "Endereço";
            // 
            // NUMi
            // 
            this.NUMi.AutoSize = true;
            this.NUMi.Location = new System.Drawing.Point(181, 61);
            this.NUMi.Name = "NUMi";
            this.NUMi.Size = new System.Drawing.Size(44, 13);
            this.NUMi.TabIndex = 9;
            this.NUMi.Text = "Número";
            // 
            // COMi
            // 
            this.COMi.AutoSize = true;
            this.COMi.Location = new System.Drawing.Point(298, 61);
            this.COMi.Name = "COMi";
            this.COMi.Size = new System.Drawing.Size(71, 13);
            this.COMi.TabIndex = 10;
            this.COMi.Text = "Complemento";
            // 
            // BRRi
            // 
            this.BRRi.AutoSize = true;
            this.BRRi.Location = new System.Drawing.Point(60, 108);
            this.BRRi.Name = "BRRi";
            this.BRRi.Size = new System.Drawing.Size(34, 13);
            this.BRRi.TabIndex = 11;
            this.BRRi.Text = "Bairro";
            // 
            // CDDi
            // 
            this.CDDi.AutoSize = true;
            this.CDDi.Location = new System.Drawing.Point(60, 152);
            this.CDDi.Name = "CDDi";
            this.CDDi.Size = new System.Drawing.Size(40, 13);
            this.CDDi.TabIndex = 12;
            this.CDDi.Text = "Cidade";
            // 
            // ESTi
            // 
            this.ESTi.AutoSize = true;
            this.ESTi.Location = new System.Drawing.Point(60, 194);
            this.ESTi.Name = "ESTi";
            this.ESTi.Size = new System.Drawing.Size(40, 13);
            this.ESTi.TabIndex = 13;
            this.ESTi.Text = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 265);
            this.Controls.Add(this.ESTi);
            this.Controls.Add(this.CDDi);
            this.Controls.Add(this.BRRi);
            this.Controls.Add(this.COMi);
            this.Controls.Add(this.NUMi);
            this.Controls.Add(this.ENDi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CEPi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CEPi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ENDi;
        private System.Windows.Forms.Label NUMi;
        private System.Windows.Forms.Label COMi;
        private System.Windows.Forms.Label BRRi;
        private System.Windows.Forms.Label CDDi;
        private System.Windows.Forms.Label ESTi;
    }
}

