﻿namespace calculator_project
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cleanTextArea);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(381, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 104);
            this.button3.TabIndex = 3;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(253, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 104);
            this.button4.TabIndex = 2;
            this.button4.Text = "+/-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.changeSign);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(380, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 104);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(380, 518);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 104);
            this.button5.TabIndex = 5;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(380, 628);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 104);
            this.button6.TabIndex = 6;
            this.button6.Text = "=";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Result);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(380, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 104);
            this.button7.TabIndex = 7;
            this.button7.Text = "x";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(0, 628);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(251, 104);
            this.button8.TabIndex = 8;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(253, 628);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 104);
            this.button9.TabIndex = 9;
            this.button9.Text = ".";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.addSeparator_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(251, 298);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 104);
            this.button10.TabIndex = 12;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(251, 518);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(126, 104);
            this.button11.TabIndex = 11;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(251, 408);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(126, 104);
            this.button12.TabIndex = 10;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(125, 298);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(126, 104);
            this.button13.TabIndex = 15;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(125, 518);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 104);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Silver;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(125, 408);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 104);
            this.button15.TabIndex = 13;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Silver;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(0, 298);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(126, 104);
            this.button16.TabIndex = 18;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Silver;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(0, 518);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(126, 104);
            this.button17.TabIndex = 17;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Silver;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(0, 408);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(126, 104);
            this.button18.TabIndex = 16;
            this.button18.Text = "4";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(1, 55);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(481, 59);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_GotFocus);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 735);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(534, 791);
            this.MinimumSize = new System.Drawing.Size(534, 791);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

