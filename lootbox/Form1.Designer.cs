namespace lootbox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Timer timerLosowanie;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeśli zarządzane zasoby powinny zostać usunięte; w przeciwnym razie fałsz.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.timerLosowanie = new System.Windows.Forms.Timer(this.components);

            // SuspendLayout: zaczynamy tworzenie layoutu
            this.SuspendLayout();

            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(100, 150); // Ustawienie pozycji przycisku
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(100, 30); // Ustawienie rozmiaru
            this.btnLosuj.TabIndex = 0;
            this.btnLosuj.Text = "Losuj ocenę";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click); // Przypisanie zdarzenia Click

            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWynik.Location = new System.Drawing.Point(120, 70); // Pozycja etykiety
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(50, 26); // Wstępny rozmiar etykiety
            this.lblWynik.TabIndex = 1;
            this.lblWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWynik.Text = ""; // Etykieta będzie pusta do momentu losowania

            // 
            // timerLosowanie
            // 
            this.timerLosowanie.Interval = 100; // Ustawienie interwału Timera na 100 ms
            this.timerLosowanie.Tick += new System.EventHandler(this.timerLosowanie_Tick); // Przypisanie zdarzenia Tick

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250); // Ustawienie rozmiaru formularza
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnLosuj);
            this.Name = "Form1";
            this.Text = "Lootbox Gra";
            this.ResumeLayout(false); // Zakończenie layoutu
            this.PerformLayout(); // Wywołanie automatycznego dopasowania elementów
        }

        #endregion
    }
}
