﻿namespace Aliante_Interfaccia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.FusoRadio = new System.Windows.Forms.RadioButton();
            this.AlaRadio = new System.Windows.Forms.RadioButton();
            this.RuotaRadio = new System.Windows.Forms.RadioButton();
            this.CodaRadio = new System.Windows.Forms.RadioButton();
            this.CercLabel = new System.Windows.Forms.Label();
            this.GomLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.ListView();
            this.Prop1 = new System.Windows.Forms.TextBox();
            this.Prop2 = new System.Windows.Forms.TextBox();
            this.Prop5 = new System.Windows.Forms.TextBox();
            this.Prop4 = new System.Windows.Forms.TextBox();
            this.Prop3 = new System.Windows.Forms.TextBox();
            this.RimLabel = new System.Windows.Forms.Label();
            this.RimIndex = new System.Windows.Forms.TextBox();
            this.AggBut = new System.Windows.Forms.Button();
            this.RimBut = new System.Windows.Forms.Button();
            this.PrezzoBut = new System.Windows.Forms.Button();
            this.StampaBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FusoRadio
            // 
            this.FusoRadio.AutoSize = true;
            this.FusoRadio.Location = new System.Drawing.Point(27, 58);
            this.FusoRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FusoRadio.Name = "FusoRadio";
            this.FusoRadio.Size = new System.Drawing.Size(67, 17);
            this.FusoRadio.TabIndex = 0;
            this.FusoRadio.TabStop = true;
            this.FusoRadio.Text = "Fusoliera";
            this.FusoRadio.UseVisualStyleBackColor = true;
            this.FusoRadio.CheckedChanged += new System.EventHandler(this.FusoRadio_CheckedChanged);
            // 
            // AlaRadio
            // 
            this.AlaRadio.AutoSize = true;
            this.AlaRadio.Location = new System.Drawing.Point(27, 79);
            this.AlaRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlaRadio.Name = "AlaRadio";
            this.AlaRadio.Size = new System.Drawing.Size(40, 17);
            this.AlaRadio.TabIndex = 1;
            this.AlaRadio.TabStop = true;
            this.AlaRadio.Text = "Ala";
            this.AlaRadio.UseVisualStyleBackColor = true;
            this.AlaRadio.CheckedChanged += new System.EventHandler(this.AlaRadio_CheckedChanged);
            // 
            // RuotaRadio
            // 
            this.RuotaRadio.AutoSize = true;
            this.RuotaRadio.Location = new System.Drawing.Point(27, 121);
            this.RuotaRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RuotaRadio.Name = "RuotaRadio";
            this.RuotaRadio.Size = new System.Drawing.Size(54, 17);
            this.RuotaRadio.TabIndex = 3;
            this.RuotaRadio.TabStop = true;
            this.RuotaRadio.Text = "Ruota";
            this.RuotaRadio.UseVisualStyleBackColor = true;
            this.RuotaRadio.CheckedChanged += new System.EventHandler(this.RuotaRadio_CheckedChanged);
            // 
            // CodaRadio
            // 
            this.CodaRadio.AutoSize = true;
            this.CodaRadio.Location = new System.Drawing.Point(27, 100);
            this.CodaRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodaRadio.Name = "CodaRadio";
            this.CodaRadio.Size = new System.Drawing.Size(50, 17);
            this.CodaRadio.TabIndex = 2;
            this.CodaRadio.TabStop = true;
            this.CodaRadio.Text = "Coda";
            this.CodaRadio.UseVisualStyleBackColor = true;
            this.CodaRadio.CheckedChanged += new System.EventHandler(this.CodaRadio_CheckedChanged);
            // 
            // CercLabel
            // 
            this.CercLabel.AutoSize = true;
            this.CercLabel.Location = new System.Drawing.Point(245, 7);
            this.CercLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CercLabel.Name = "CercLabel";
            this.CercLabel.Size = new System.Drawing.Size(55, 13);
            this.CercLabel.TabIndex = 4;
            this.CercLabel.Text = "Cerchione";
            // 
            // GomLabel
            // 
            this.GomLabel.AutoSize = true;
            this.GomLabel.Location = new System.Drawing.Point(564, 7);
            this.GomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GomLabel.Name = "GomLabel";
            this.GomLabel.Size = new System.Drawing.Size(43, 13);
            this.GomLabel.TabIndex = 5;
            this.GomLabel.Text = "Gomma";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(189, 33);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "prop1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(294, 32);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "prop2";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(548, 32);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "prop4";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(452, 32);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "prop3";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(644, 32);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(34, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "prop5";
            // 
            // Display
            // 
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(747, 11);
            this.Display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(590, 556);
            this.Display.TabIndex = 11;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.List;
            // 
            // Prop1
            // 
            this.Prop1.Location = new System.Drawing.Point(191, 49);
            this.Prop1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prop1.Name = "Prop1";
            this.Prop1.Size = new System.Drawing.Size(76, 20);
            this.Prop1.TabIndex = 12;
            // 
            // Prop2
            // 
            this.Prop2.Location = new System.Drawing.Point(296, 49);
            this.Prop2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prop2.Name = "Prop2";
            this.Prop2.Size = new System.Drawing.Size(76, 20);
            this.Prop2.TabIndex = 13;
            // 
            // Prop5
            // 
            this.Prop5.Location = new System.Drawing.Point(646, 49);
            this.Prop5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prop5.Name = "Prop5";
            this.Prop5.Size = new System.Drawing.Size(76, 20);
            this.Prop5.TabIndex = 14;
            // 
            // Prop4
            // 
            this.Prop4.Location = new System.Drawing.Point(550, 49);
            this.Prop4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prop4.Name = "Prop4";
            this.Prop4.Size = new System.Drawing.Size(76, 20);
            this.Prop4.TabIndex = 16;
            // 
            // Prop3
            // 
            this.Prop3.Location = new System.Drawing.Point(454, 49);
            this.Prop3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prop3.Name = "Prop3";
            this.Prop3.Size = new System.Drawing.Size(76, 20);
            this.Prop3.TabIndex = 15;
            // 
            // RimLabel
            // 
            this.RimLabel.AutoSize = true;
            this.RimLabel.Location = new System.Drawing.Point(25, 169);
            this.RimLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RimLabel.Name = "RimLabel";
            this.RimLabel.Size = new System.Drawing.Size(83, 13);
            this.RimLabel.TabIndex = 17;
            this.RimLabel.Text = "Indice rimozione";
            // 
            // RimIndex
            // 
            this.RimIndex.Location = new System.Drawing.Point(27, 184);
            this.RimIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RimIndex.Name = "RimIndex";
            this.RimIndex.Size = new System.Drawing.Size(76, 20);
            this.RimIndex.TabIndex = 18;
            // 
            // AggBut
            // 
            this.AggBut.Location = new System.Drawing.Point(191, 140);
            this.AggBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AggBut.Name = "AggBut";
            this.AggBut.Size = new System.Drawing.Size(98, 72);
            this.AggBut.TabIndex = 19;
            this.AggBut.Text = "Aggiungi componente";
            this.AggBut.UseVisualStyleBackColor = true;
            this.AggBut.Click += new System.EventHandler(this.AggBut_Click);
            // 
            // RimBut
            // 
            this.RimBut.Location = new System.Drawing.Point(304, 140);
            this.RimBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RimBut.Name = "RimBut";
            this.RimBut.Size = new System.Drawing.Size(98, 72);
            this.RimBut.TabIndex = 20;
            this.RimBut.Text = "Rimuovi componente";
            this.RimBut.UseVisualStyleBackColor = true;
            this.RimBut.Click += new System.EventHandler(this.RimBut_Click);
            // 
            // PrezzoBut
            // 
            this.PrezzoBut.Location = new System.Drawing.Point(304, 216);
            this.PrezzoBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrezzoBut.Name = "PrezzoBut";
            this.PrezzoBut.Size = new System.Drawing.Size(98, 72);
            this.PrezzoBut.TabIndex = 22;
            this.PrezzoBut.Text = "Calcolo prezzo";
            this.PrezzoBut.UseVisualStyleBackColor = true;
            this.PrezzoBut.Click += new System.EventHandler(this.PrezzoBut_Click);
            // 
            // StampaBut
            // 
            this.StampaBut.Location = new System.Drawing.Point(191, 216);
            this.StampaBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StampaBut.Name = "StampaBut";
            this.StampaBut.Size = new System.Drawing.Size(98, 72);
            this.StampaBut.TabIndex = 21;
            this.StampaBut.Text = "Stampa componenti";
            this.StampaBut.UseVisualStyleBackColor = true;
            this.StampaBut.Click += new System.EventHandler(this.StampaBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1345, 576);
            this.Controls.Add(this.PrezzoBut);
            this.Controls.Add(this.StampaBut);
            this.Controls.Add(this.RimBut);
            this.Controls.Add(this.AggBut);
            this.Controls.Add(this.RimIndex);
            this.Controls.Add(this.RimLabel);
            this.Controls.Add(this.Prop4);
            this.Controls.Add(this.Prop3);
            this.Controls.Add(this.Prop5);
            this.Controls.Add(this.Prop2);
            this.Controls.Add(this.Prop1);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GomLabel);
            this.Controls.Add(this.CercLabel);
            this.Controls.Add(this.RuotaRadio);
            this.Controls.Add(this.CodaRadio);
            this.Controls.Add(this.AlaRadio);
            this.Controls.Add(this.FusoRadio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "c";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FusoRadio;
        private System.Windows.Forms.RadioButton AlaRadio;
        private System.Windows.Forms.RadioButton RuotaRadio;
        private System.Windows.Forms.RadioButton CodaRadio;
        private System.Windows.Forms.Label CercLabel;
        private System.Windows.Forms.Label GomLabel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ListView Display;
        private System.Windows.Forms.TextBox Prop1;
        private System.Windows.Forms.TextBox Prop2;
        private System.Windows.Forms.TextBox Prop5;
        private System.Windows.Forms.TextBox Prop4;
        private System.Windows.Forms.TextBox Prop3;
        private System.Windows.Forms.Label RimLabel;
        private System.Windows.Forms.TextBox RimIndex;
        private System.Windows.Forms.Button AggBut;
        private System.Windows.Forms.Button RimBut;
        private System.Windows.Forms.Button PrezzoBut;
        private System.Windows.Forms.Button StampaBut;
    }
}

