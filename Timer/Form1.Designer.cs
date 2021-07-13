namespace Timer
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
            this.tmrAlarme = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk30Minutos = new System.Windows.Forms.CheckBox();
            this.chk60Minutos = new System.Windows.Forms.CheckBox();
            this.chk15Minutos = new System.Windows.Forms.CheckBox();
            this.ofdWave = new System.Windows.Forms.OpenFileDialog();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbWave = new System.Windows.Forms.RadioButton();
            this.rdbObjectiveCompleted = new System.Windows.Forms.RadioButton();
            this.rdbSomPadrao = new System.Windows.Forms.RadioButton();
            this.lblLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWave = new System.Windows.Forms.Label();
            this.btnWave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblHoraCandle = new System.Windows.Forms.Label();
            this.btnConverteHora = new System.Windows.Forms.Button();
            this.BarNum = new System.Windows.Forms.NumericUpDown();
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAlarme
            // 
            this.tmrAlarme.Tick += new System.EventHandler(this.tmrAlarme_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chk30Minutos);
            this.panel1.Controls.Add(this.chk60Minutos);
            this.panel1.Controls.Add(this.chk15Minutos);
            this.panel1.Location = new System.Drawing.Point(168, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 73);
            this.panel1.TabIndex = 0;
            // 
            // chk30Minutos
            // 
            this.chk30Minutos.AutoSize = true;
            this.chk30Minutos.Checked = true;
            this.chk30Minutos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk30Minutos.Location = new System.Drawing.Point(3, 26);
            this.chk30Minutos.Name = "chk30Minutos";
            this.chk30Minutos.Size = new System.Drawing.Size(77, 17);
            this.chk30Minutos.TabIndex = 2;
            this.chk30Minutos.Text = "30 minutos";
            this.chk30Minutos.UseVisualStyleBackColor = true;
            // 
            // chk60Minutos
            // 
            this.chk60Minutos.AutoSize = true;
            this.chk60Minutos.Checked = true;
            this.chk60Minutos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk60Minutos.Location = new System.Drawing.Point(3, 49);
            this.chk60Minutos.Name = "chk60Minutos";
            this.chk60Minutos.Size = new System.Drawing.Size(77, 17);
            this.chk60Minutos.TabIndex = 1;
            this.chk60Minutos.Text = "60 minutos";
            this.chk60Minutos.UseVisualStyleBackColor = true;
            // 
            // chk15Minutos
            // 
            this.chk15Minutos.AutoSize = true;
            this.chk15Minutos.Checked = true;
            this.chk15Minutos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk15Minutos.Location = new System.Drawing.Point(3, 3);
            this.chk15Minutos.Name = "chk15Minutos";
            this.chk15Minutos.Size = new System.Drawing.Size(77, 17);
            this.chk15Minutos.TabIndex = 0;
            this.chk15Minutos.Text = "15 minutos";
            this.chk15Minutos.UseVisualStyleBackColor = true;
            // 
            // ofdWave
            // 
            this.ofdWave.FileName = "openFileDialog1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Red;
            this.lblHora.Location = new System.Drawing.Point(2, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(143, 37);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "09:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdbWave);
            this.panel2.Controls.Add(this.rdbObjectiveCompleted);
            this.panel2.Controls.Add(this.rdbSomPadrao);
            this.panel2.Location = new System.Drawing.Point(310, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 73);
            this.panel2.TabIndex = 2;
            // 
            // rdbWave
            // 
            this.rdbWave.AutoSize = true;
            this.rdbWave.Location = new System.Drawing.Point(4, 50);
            this.rdbWave.Name = "rdbWave";
            this.rdbWave.Size = new System.Drawing.Size(54, 17);
            this.rdbWave.TabIndex = 2;
            this.rdbWave.Text = "Wave";
            this.rdbWave.UseVisualStyleBackColor = true;
            // 
            // rdbObjectiveCompleted
            // 
            this.rdbObjectiveCompleted.AutoSize = true;
            this.rdbObjectiveCompleted.Location = new System.Drawing.Point(4, 27);
            this.rdbObjectiveCompleted.Name = "rdbObjectiveCompleted";
            this.rdbObjectiveCompleted.Size = new System.Drawing.Size(123, 17);
            this.rdbObjectiveCompleted.TabIndex = 1;
            this.rdbObjectiveCompleted.Text = "Objective Completed";
            this.rdbObjectiveCompleted.UseVisualStyleBackColor = true;
            // 
            // rdbSomPadrao
            // 
            this.rdbSomPadrao.AutoSize = true;
            this.rdbSomPadrao.Checked = true;
            this.rdbSomPadrao.Location = new System.Drawing.Point(4, 4);
            this.rdbSomPadrao.Name = "rdbSomPadrao";
            this.rdbSomPadrao.Size = new System.Drawing.Size(82, 17);
            this.rdbSomPadrao.TabIndex = 0;
            this.rdbSomPadrao.TabStop = true;
            this.rdbSomPadrao.Text = "Som padrão";
            this.rdbSomPadrao.UseVisualStyleBackColor = true;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.Red;
            this.lblLeft.Location = new System.Drawing.Point(26, 34);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(98, 37);
            this.lblLeft.TabIndex = 3;
            this.lblLeft.Text = "05:00";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wave:";
            // 
            // lblWave
            // 
            this.lblWave.AutoSize = true;
            this.lblWave.Location = new System.Drawing.Point(66, 14);
            this.lblWave.Name = "lblWave";
            this.lblWave.Size = new System.Drawing.Size(145, 13);
            this.lblWave.TabIndex = 5;
            this.lblWave.Text = "Nenhum arquivo selecionado";
            // 
            // btnWave
            // 
            this.btnWave.Location = new System.Drawing.Point(400, 9);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(25, 23);
            this.btnWave.TabIndex = 6;
            this.btnWave.Text = "...";
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Controls.Add(this.lblLeft);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 73);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnWave);
            this.panel4.Controls.Add(this.lblWave);
            this.panel4.Location = new System.Drawing.Point(12, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 40);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblHoraCandle);
            this.panel5.Controls.Add(this.btnConverteHora);
            this.panel5.Controls.Add(this.BarNum);
            this.panel5.Location = new System.Drawing.Point(12, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 56);
            this.panel5.TabIndex = 10;
            // 
            // lblHoraCandle
            // 
            this.lblHoraCandle.AutoSize = true;
            this.lblHoraCandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCandle.ForeColor = System.Drawing.Color.Red;
            this.lblHoraCandle.Location = new System.Drawing.Point(203, 6);
            this.lblHoraCandle.Name = "lblHoraCandle";
            this.lblHoraCandle.Size = new System.Drawing.Size(98, 37);
            this.lblHoraCandle.TabIndex = 2;
            this.lblHoraCandle.Text = "00:00";
            // 
            // btnConverteHora
            // 
            this.btnConverteHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverteHora.Location = new System.Drawing.Point(131, 4);
            this.btnConverteHora.Name = "btnConverteHora";
            this.btnConverteHora.Size = new System.Drawing.Size(66, 44);
            this.btnConverteHora.TabIndex = 1;
            this.btnConverteHora.Text = ">>";
            this.btnConverteHora.UseVisualStyleBackColor = true;
            this.btnConverteHora.Click += new System.EventHandler(this.btnConverteHora_Click);
            // 
            // BarNum
            // 
            this.BarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarNum.Location = new System.Drawing.Point(4, 4);
            this.BarNum.Name = "BarNum";
            this.BarNum.Size = new System.Drawing.Size(120, 44);
            this.BarNum.TabIndex = 0;
            this.BarNum.ValueChanged += new System.EventHandler(this.BarNum_ValueChanged);
            // 
            // tmrSecond
            // 
            this.tmrSecond.Enabled = true;
            this.tmrSecond.Interval = 1000;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 204);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Beep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAlarme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk60Minutos;
        private System.Windows.Forms.CheckBox chk15Minutos;
        private System.Windows.Forms.OpenFileDialog ofdWave;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbWave;
        private System.Windows.Forms.RadioButton rdbObjectiveCompleted;
        private System.Windows.Forms.RadioButton rdbSomPadrao;
        private System.Windows.Forms.CheckBox chk30Minutos;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWave;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblHoraCandle;
        private System.Windows.Forms.Button btnConverteHora;
        private System.Windows.Forms.NumericUpDown BarNum;
        private System.Windows.Forms.Timer tmrSecond;
    }
}

