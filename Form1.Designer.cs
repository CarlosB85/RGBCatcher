namespace RGBCatcher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_auto = new System.Windows.Forms.Button();
            this.pnl_rgb_color = new System.Windows.Forms.Panel();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_alto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpt_delay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lst_puntos = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chk_preview = new System.Windows.Forms.CheckBox();
            this.chk_modo2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inpt_px_ancho = new System.Windows.Forms.NumericUpDown();
            this.inpt_px_largo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inpt_auto_largo = new System.Windows.Forms.NumericUpDown();
            this.inpt_auto_ancho = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_px_ancho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_px_largo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_auto_largo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_auto_ancho)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_auto
            // 
            this.btn_auto.Location = new System.Drawing.Point(452, 84);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(75, 23);
            this.btn_auto.TabIndex = 0;
            this.btn_auto.Text = "Automatico";
            this.btn_auto.UseVisualStyleBackColor = true;
            this.btn_auto.Click += new System.EventHandler(this.btn_probar_Click);
            // 
            // pnl_rgb_color
            // 
            this.pnl_rgb_color.Location = new System.Drawing.Point(349, 392);
            this.pnl_rgb_color.Name = "pnl_rgb_color";
            this.pnl_rgb_color.Size = new System.Drawing.Size(20, 20);
            this.pnl_rgb_color.TabIndex = 2;
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Location = new System.Drawing.Point(50, 9);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(38, 13);
            this.lbl_ancho.TabIndex = 3;
            this.lbl_ancho.Text = "Ancho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alto:";
            // 
            // lbl_alto
            // 
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Location = new System.Drawing.Point(50, 31);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(25, 13);
            this.lbl_alto.TabIndex = 6;
            this.lbl_alto.Text = "Alto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "delay";
            // 
            // inpt_delay
            // 
            this.inpt_delay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.inpt_delay.Location = new System.Drawing.Point(189, 7);
            this.inpt_delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inpt_delay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.inpt_delay.Name = "inpt_delay";
            this.inpt_delay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inpt_delay.Size = new System.Drawing.Size(60, 20);
            this.inpt_delay.TabIndex = 1;
            this.inpt_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpt_delay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(50, 53);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 13;
            this.lbl_status.Text = "Status";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(452, 113);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);            
            // 
            // lst_puntos
            // 
            this.lst_puntos.FormattingEnabled = true;
            this.lst_puntos.Location = new System.Drawing.Point(12, 84);
            this.lst_puntos.Name = "lst_puntos";
            this.lst_puntos.Size = new System.Drawing.Size(434, 329);
            this.lst_puntos.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chk_preview
            // 
            this.chk_preview.AutoSize = true;
            this.chk_preview.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_preview.Location = new System.Drawing.Point(27, 419);
            this.chk_preview.Name = "chk_preview";
            this.chk_preview.Size = new System.Drawing.Size(81, 17);
            this.chk_preview.TabIndex = 17;
            this.chk_preview.Text = "Vista previa";
            this.chk_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_preview.UseVisualStyleBackColor = true;
            // 
            // chk_modo2
            // 
            this.chk_modo2.AutoSize = true;
            this.chk_modo2.Location = new System.Drawing.Point(114, 419);
            this.chk_modo2.Name = "chk_modo2";
            this.chk_modo2.Size = new System.Drawing.Size(62, 17);
            this.chk_modo2.TabIndex = 18;
            this.chk_modo2.Text = "Modo 2";
            this.chk_modo2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "px ancho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "px largo";
            // 
            // inpt_px_ancho
            // 
            this.inpt_px_ancho.Location = new System.Drawing.Point(189, 29);
            this.inpt_px_ancho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_px_ancho.Name = "inpt_px_ancho";
            this.inpt_px_ancho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inpt_px_ancho.Size = new System.Drawing.Size(60, 20);
            this.inpt_px_ancho.TabIndex = 21;
            this.inpt_px_ancho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpt_px_ancho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inpt_px_largo
            // 
            this.inpt_px_largo.Location = new System.Drawing.Point(189, 51);
            this.inpt_px_largo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_px_largo.Name = "inpt_px_largo";
            this.inpt_px_largo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inpt_px_largo.Size = new System.Drawing.Size(60, 20);
            this.inpt_px_largo.TabIndex = 22;
            this.inpt_px_largo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpt_px_largo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "px";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "px";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "px";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "px";
            // 
            // inpt_auto_largo
            // 
            this.inpt_auto_largo.Location = new System.Drawing.Point(382, 51);
            this.inpt_auto_largo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_auto_largo.Name = "inpt_auto_largo";
            this.inpt_auto_largo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inpt_auto_largo.Size = new System.Drawing.Size(60, 20);
            this.inpt_auto_largo.TabIndex = 28;
            this.inpt_auto_largo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpt_auto_largo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inpt_auto_ancho
            // 
            this.inpt_auto_ancho.Location = new System.Drawing.Point(382, 29);
            this.inpt_auto_ancho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_auto_ancho.Name = "inpt_auto_ancho";
            this.inpt_auto_ancho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inpt_auto_ancho.Size = new System.Drawing.Size(60, 20);
            this.inpt_auto_ancho.TabIndex = 27;
            this.inpt_auto_ancho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpt_auto_ancho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "offset auto largo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "offset auto ancho";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 473);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inpt_auto_largo);
            this.Controls.Add(this.inpt_auto_ancho);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inpt_px_largo);
            this.Controls.Add(this.inpt_px_ancho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_modo2);
            this.Controls.Add(this.chk_preview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lst_puntos);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpt_delay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_alto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ancho);
            this.Controls.Add(this.pnl_rgb_color);
            this.Controls.Add(this.btn_auto);
            this.Name = "Form1";
            this.Text = "RGBCatcher";
            ((System.ComponentModel.ISupportInitialize)(this.inpt_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_px_ancho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_px_largo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_auto_largo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_auto_ancho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.Panel pnl_rgb_color;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inpt_delay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox lst_puntos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chk_preview;
        private System.Windows.Forms.CheckBox chk_modo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown inpt_px_ancho;
        private System.Windows.Forms.NumericUpDown inpt_px_largo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown inpt_auto_largo;
        private System.Windows.Forms.NumericUpDown inpt_auto_ancho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

