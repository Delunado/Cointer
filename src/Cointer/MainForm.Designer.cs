
namespace Cointer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cents1 = new System.Windows.Forms.NumericUpDown();
            this.cents2 = new System.Windows.Forms.NumericUpDown();
            this.cents5 = new System.Windows.Forms.NumericUpDown();
            this.cents10 = new System.Windows.Forms.NumericUpDown();
            this.cents20 = new System.Windows.Forms.NumericUpDown();
            this.eur20 = new System.Windows.Forms.NumericUpDown();
            this.eur50 = new System.Windows.Forms.NumericUpDown();
            this.eur100 = new System.Windows.Forms.NumericUpDown();
            this.eur200 = new System.Windows.Forms.NumericUpDown();
            this.eur500 = new System.Windows.Forms.NumericUpDown();
            this.cents50 = new System.Windows.Forms.NumericUpDown();
            this.eur1 = new System.Windows.Forms.NumericUpDown();
            this.eur2 = new System.Windows.Forms.NumericUpDown();
            this.eur5 = new System.Windows.Forms.NumericUpDown();
            this.eur10 = new System.Windows.Forms.NumericUpDown();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cents1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur10)).BeginInit();
            this.SuspendLayout();
            // 
            // cents1
            // 
            this.cents1.Location = new System.Drawing.Point(216, 165);
            this.cents1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cents1.Name = "cents1";
            this.cents1.Size = new System.Drawing.Size(55, 20);
            this.cents1.TabIndex = 1;
            this.cents1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cents2
            // 
            this.cents2.Location = new System.Drawing.Point(289, 165);
            this.cents2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cents2.Name = "cents2";
            this.cents2.Size = new System.Drawing.Size(55, 20);
            this.cents2.TabIndex = 2;
            // 
            // cents5
            // 
            this.cents5.Location = new System.Drawing.Point(361, 165);
            this.cents5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cents5.Name = "cents5";
            this.cents5.Size = new System.Drawing.Size(55, 20);
            this.cents5.TabIndex = 3;
            // 
            // cents10
            // 
            this.cents10.Location = new System.Drawing.Point(432, 165);
            this.cents10.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cents10.Name = "cents10";
            this.cents10.Size = new System.Drawing.Size(55, 20);
            this.cents10.TabIndex = 4;
            // 
            // cents20
            // 
            this.cents20.Location = new System.Drawing.Point(502, 165);
            this.cents20.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cents20.Name = "cents20";
            this.cents20.Size = new System.Drawing.Size(55, 20);
            this.cents20.TabIndex = 5;
            // 
            // eur20
            // 
            this.eur20.Location = new System.Drawing.Point(216, 302);
            this.eur20.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur20.Name = "eur20";
            this.eur20.Size = new System.Drawing.Size(55, 20);
            this.eur20.TabIndex = 6;
            // 
            // eur50
            // 
            this.eur50.Location = new System.Drawing.Point(289, 302);
            this.eur50.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur50.Name = "eur50";
            this.eur50.Size = new System.Drawing.Size(55, 20);
            this.eur50.TabIndex = 7;
            // 
            // eur100
            // 
            this.eur100.Location = new System.Drawing.Point(361, 302);
            this.eur100.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur100.Name = "eur100";
            this.eur100.Size = new System.Drawing.Size(55, 20);
            this.eur100.TabIndex = 8;
            // 
            // eur200
            // 
            this.eur200.Location = new System.Drawing.Point(432, 302);
            this.eur200.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur200.Name = "eur200";
            this.eur200.Size = new System.Drawing.Size(55, 20);
            this.eur200.TabIndex = 9;
            // 
            // eur500
            // 
            this.eur500.Location = new System.Drawing.Point(502, 302);
            this.eur500.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur500.Name = "eur500";
            this.eur500.Size = new System.Drawing.Size(55, 20);
            this.eur500.TabIndex = 10;
            // 
            // cents50
            // 
            this.cents50.Location = new System.Drawing.Point(216, 234);
            this.cents50.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cents50.Name = "cents50";
            this.cents50.Size = new System.Drawing.Size(55, 20);
            this.cents50.TabIndex = 11;
            // 
            // eur1
            // 
            this.eur1.Location = new System.Drawing.Point(289, 234);
            this.eur1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur1.Name = "eur1";
            this.eur1.Size = new System.Drawing.Size(55, 20);
            this.eur1.TabIndex = 12;
            // 
            // eur2
            // 
            this.eur2.Location = new System.Drawing.Point(361, 234);
            this.eur2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur2.Name = "eur2";
            this.eur2.Size = new System.Drawing.Size(55, 20);
            this.eur2.TabIndex = 13;
            // 
            // eur5
            // 
            this.eur5.Location = new System.Drawing.Point(432, 234);
            this.eur5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur5.Name = "eur5";
            this.eur5.Size = new System.Drawing.Size(55, 20);
            this.eur5.TabIndex = 14;
            // 
            // eur10
            // 
            this.eur10.Location = new System.Drawing.Point(502, 234);
            this.eur10.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.eur10.Name = "eur10";
            this.eur10.Size = new System.Drawing.Size(55, 20);
            this.eur10.TabIndex = 15;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(158, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(498, 17);
            this.title.TabIndex = 16;
            this.title.Text = "Add how many coins and bills you do have and lets the computer do its magic!";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "1 cent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "2 cents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "5 cents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "10 cents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "20 cents";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "50 cents";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "1 euro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "2 euros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "5 euros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(504, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "10 euros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "20 euros";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "50 euros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "100 euros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(433, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "200 euros";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(503, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "500 euros";
            // 
            // calculateButton
            // 
            this.calculateButton.ForeColor = System.Drawing.Color.Green;
            this.calculateButton.Location = new System.Drawing.Point(289, 366);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 30);
            this.calculateButton.TabIndex = 32;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(239, 98);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(218, 13);
            this.result.TabIndex = 33;
            this.result.Text = "You have the incredible quantity of...";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cleanButton
            // 
            this.cleanButton.ForeColor = System.Drawing.Color.Red;
            this.cleanButton.Location = new System.Drawing.Point(399, 366);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(88, 30);
            this.cleanButton.TabIndex = 34;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.eur10);
            this.Controls.Add(this.eur5);
            this.Controls.Add(this.eur2);
            this.Controls.Add(this.eur1);
            this.Controls.Add(this.cents50);
            this.Controls.Add(this.eur500);
            this.Controls.Add(this.eur200);
            this.Controls.Add(this.eur100);
            this.Controls.Add(this.eur50);
            this.Controls.Add(this.eur20);
            this.Controls.Add(this.cents20);
            this.Controls.Add(this.cents10);
            this.Controls.Add(this.cents5);
            this.Controls.Add(this.cents2);
            this.Controls.Add(this.cents1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cointer";
            ((System.ComponentModel.ISupportInitialize)(this.cents1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cents50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eur10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown cents1;
        private System.Windows.Forms.NumericUpDown cents2;
        private System.Windows.Forms.NumericUpDown cents5;
        private System.Windows.Forms.NumericUpDown cents10;
        private System.Windows.Forms.NumericUpDown cents20;
        private System.Windows.Forms.NumericUpDown eur20;
        private System.Windows.Forms.NumericUpDown eur50;
        private System.Windows.Forms.NumericUpDown eur100;
        private System.Windows.Forms.NumericUpDown eur200;
        private System.Windows.Forms.NumericUpDown eur500;
        private System.Windows.Forms.NumericUpDown cents50;
        private System.Windows.Forms.NumericUpDown eur1;
        private System.Windows.Forms.NumericUpDown eur2;
        private System.Windows.Forms.NumericUpDown eur5;
        private System.Windows.Forms.NumericUpDown eur10;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button cleanButton;
    }
}

