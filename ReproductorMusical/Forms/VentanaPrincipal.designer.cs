namespace ReproductorMusical.Forms
{
    public partial class VentanaPrincipal : System.Windows.Forms.Form
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.artistaTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generoTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.duracionTxt = new System.Windows.Forms.Label();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.busquedaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.errorTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colaTxt = new System.Windows.Forms.Label();
            this.reproduccionTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.duraciontotalTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tituloTxt
            // 
            this.tituloTxt.AutoSize = true;
            this.tituloTxt.ForeColor = System.Drawing.Color.Black;
            this.tituloTxt.Location = new System.Drawing.Point(81, 58);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(11, 13);
            this.tituloTxt.TabIndex = 1;
            this.tituloTxt.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artista:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // artistaTxt
            // 
            this.artistaTxt.AutoSize = true;
            this.artistaTxt.ForeColor = System.Drawing.Color.Black;
            this.artistaTxt.Location = new System.Drawing.Point(81, 75);
            this.artistaTxt.Name = "artistaTxt";
            this.artistaTxt.Size = new System.Drawing.Size(35, 13);
            this.artistaTxt.TabIndex = 3;
            this.artistaTxt.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genero: ";
            // 
            // generoTxt
            // 
            this.generoTxt.AutoSize = true;
            this.generoTxt.ForeColor = System.Drawing.Color.Black;
            this.generoTxt.Location = new System.Drawing.Point(81, 92);
            this.generoTxt.Name = "generoTxt";
            this.generoTxt.Size = new System.Drawing.Size(35, 13);
            this.generoTxt.TabIndex = 5;
            this.generoTxt.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duración:";
            // 
            // duracionTxt
            // 
            this.duracionTxt.AutoSize = true;
            this.duracionTxt.ForeColor = System.Drawing.Color.Black;
            this.duracionTxt.Location = new System.Drawing.Point(96, 109);
            this.duracionTxt.Name = "duracionTxt";
            this.duracionTxt.Size = new System.Drawing.Size(35, 13);
            this.duracionTxt.TabIndex = 7;
            this.duracionTxt.Text = "label5";
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.ForeColor = System.Drawing.Color.Black;
            this.siguienteBtn.Location = new System.Drawing.Point(431, 331);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(70, 51);
            this.siguienteBtn.TabIndex = 8;
            this.siguienteBtn.Text = "►►|";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // busquedaTextBox
            // 
            this.busquedaTextBox.Location = new System.Drawing.Point(573, 58);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(170, 20);
            this.busquedaTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(524, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Buscar:";
            // 
            // buscarBtn
            // 
            this.buscarBtn.ForeColor = System.Drawing.Color.Black;
            this.buscarBtn.Location = new System.Drawing.Point(586, 119);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(148, 23);
            this.buscarBtn.TabIndex = 11;
            this.buscarBtn.Text = "Realizar busqueda";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // errorTxt
            // 
            this.errorTxt.AutoSize = true;
            this.errorTxt.ForeColor = System.Drawing.Color.Black;
            this.errorTxt.Location = new System.Drawing.Point(586, 92);
            this.errorTxt.Name = "errorTxt";
            this.errorTxt.Size = new System.Drawing.Size(35, 13);
            this.errorTxt.TabIndex = 12;
            this.errorTxt.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cola:";
            // 
            // colaTxt
            // 
            this.colaTxt.AutoSize = true;
            this.colaTxt.ForeColor = System.Drawing.Color.Black;
            this.colaTxt.Location = new System.Drawing.Point(36, 193);
            this.colaTxt.Name = "colaTxt";
            this.colaTxt.Size = new System.Drawing.Size(35, 13);
            this.colaTxt.TabIndex = 14;
            this.colaTxt.Text = "label7";
            this.colaTxt.Click += new System.EventHandler(this.Label7_Click);
            // 
            // reproduccionTxt
            // 
            this.reproduccionTxt.AutoSize = true;
            this.reproduccionTxt.ForeColor = System.Drawing.Color.Black;
            this.reproduccionTxt.Location = new System.Drawing.Point(347, 305);
            this.reproduccionTxt.Name = "reproduccionTxt";
            this.reproduccionTxt.Size = new System.Drawing.Size(35, 13);
            this.reproduccionTxt.TabIndex = 15;
            this.reproduccionTxt.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "En Reproducción:";
            // 
            // playBtn
            // 
            this.playBtn.ForeColor = System.Drawing.Color.Black;
            this.playBtn.Location = new System.Drawing.Point(331, 331);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 51);
            this.playBtn.TabIndex = 17;
            this.playBtn.Text = "►";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // duraciontotalTxt
            // 
            this.duraciontotalTxt.AutoSize = true;
            this.duraciontotalTxt.ForeColor = System.Drawing.Color.Black;
            this.duraciontotalTxt.Location = new System.Drawing.Point(36, 163);
            this.duraciontotalTxt.Name = "duraciontotalTxt";
            this.duraciontotalTxt.Size = new System.Drawing.Size(116, 13);
            this.duraciontotalTxt.TabIndex = 18;
            this.duraciontotalTxt.Text = "Duracion de la playlist: ";
            this.duraciontotalTxt.Click += new System.EventHandler(this.DuraciontotalTxt_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duraciontotalTxt);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reproduccionTxt);
            this.Controls.Add(this.colaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorTxt);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.busquedaTextBox);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.duracionTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label artistaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label generoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label duracionTxt;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.TextBox busquedaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label errorTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label colaTxt;
        private System.Windows.Forms.Label reproduccionTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label duraciontotalTxt;
    }
}