namespace NetflixOnTheTop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.painel = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(784, 561);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://netflix.com", System.UriKind.Absolute);
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.painel.Controls.Add(this.button6);
            this.painel.Controls.Add(this.button5);
            this.painel.Controls.Add(this.button4);
            this.painel.Controls.Add(this.button3);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.button2);
            this.painel.Controls.Add(this.button1);
            this.painel.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel.Location = new System.Drawing.Point(0, 0);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(784, 81);
            this.painel.TabIndex = 1;
            this.painel.TabStop = false;
            this.painel.Text = "Controles do Aplicativo";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(272, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Desativar Bordas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(577, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Desligar painel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aperte F1 para este painel aparecer";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(177, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ativar Bordas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ativar/Desativar sempre no topo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(380, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "Desativar barra de rolagem";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(475, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "Ativar barra de rolagem";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Netflix On Top";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox painel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

