namespace AgendaEletronica
{
    partial class TelaViabilidade
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
            this.id_texto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numero_txt = new System.Windows.Forms.TextBox();
            this.bt_novoContato = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipo_txt = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_salve = new System.Windows.Forms.Button();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Visible = false;
            // 
            // id_texto
            // 
            this.id_texto.BackColor = System.Drawing.Color.White;
            this.id_texto.Location = new System.Drawing.Point(66, 81);
            this.id_texto.Name = "id_texto";
            this.id_texto.Size = new System.Drawing.Size(32, 18);
            this.id_texto.TabIndex = 1;
            this.id_texto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            this.label2.Visible = false;
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(66, 109);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(189, 20);
            this.nome_txt.TabIndex = 3;
            this.nome_txt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero";
            this.label3.Visible = false;
            // 
            // numero_txt
            // 
            this.numero_txt.Location = new System.Drawing.Point(66, 135);
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.Size = new System.Drawing.Size(126, 20);
            this.numero_txt.TabIndex = 5;
            this.numero_txt.Visible = false;
            // 
            // bt_novoContato
            // 
            this.bt_novoContato.Location = new System.Drawing.Point(12, 45);
            this.bt_novoContato.Name = "bt_novoContato";
            this.bt_novoContato.Size = new System.Drawing.Size(82, 23);
            this.bt_novoContato.TabIndex = 7;
            this.bt_novoContato.Text = "Novo contato";
            this.bt_novoContato.UseVisualStyleBackColor = true;
            this.bt_novoContato.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "e-mail";
            this.label4.Visible = false;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(66, 162);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(189, 20);
            this.email_txt.TabIndex = 9;
            this.email_txt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo";
            this.label5.Visible = false;
            // 
            // tipo_txt
            // 
            this.tipo_txt.FormattingEnabled = true;
            this.tipo_txt.Items.AddRange(new object[] {
            "Amigos",
            "Familia",
            "Negocios",
            "Trabalho",
            "Outros..."});
            this.tipo_txt.Location = new System.Drawing.Point(66, 189);
            this.tipo_txt.Name = "tipo_txt";
            this.tipo_txt.Size = new System.Drawing.Size(126, 21);
            this.tipo_txt.TabIndex = 11;
            this.tipo_txt.Text = "Amigos";
            this.tipo_txt.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Visible = false;
            // 
            // bt_salve
            // 
            this.bt_salve.Location = new System.Drawing.Point(12, 35);
            this.bt_salve.Name = "bt_salve";
            this.bt_salve.Size = new System.Drawing.Size(82, 23);
            this.bt_salve.TabIndex = 14;
            this.bt_salve.Text = "&Salve";
            this.bt_salve.UseVisualStyleBackColor = true;
            this.bt_salve.Visible = false;
            this.bt_salve.Click += new System.EventHandler(this.bt_salve_Click);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Location = new System.Drawing.Point(130, 45);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(82, 23);
            this.bt_pesquisar.TabIndex = 15;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(630, 295);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 95);
            this.listBox5.TabIndex = 20;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(469, 295);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(163, 95);
            this.listBox4.TabIndex = 19;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(321, 295);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(149, 95);
            this.listBox3.TabIndex = 18;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(150, 295);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 95);
            this.listBox2.TabIndex = 17;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(108, 295);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(43, 95);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(66, 86);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(32, 20);
            this.id_txt.TabIndex = 21;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 472);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.bt_salve);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tipo_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_novoContato);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_texto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_texto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero_txt;
        private System.Windows.Forms.Button bt_novoContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipo_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_salve;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox id_txt;
    }
}

