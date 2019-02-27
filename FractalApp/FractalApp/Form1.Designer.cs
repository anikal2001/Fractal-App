namespace FractalApp
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
            this.mandelbrotSetPictureBox = new System.Windows.Forms.PictureBox();
            this.displayMandelbrotSetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colouringMethodComboBox = new System.Windows.Forms.ComboBox();
            this.chooseFractalComboBox = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.RealUpDown = new System.Windows.Forms.NumericUpDown();
            this.ImaginaryUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SampleJs = new System.Windows.Forms.Button();
            this.ExponentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.fxDegree = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddorSubtract = new System.Windows.Forms.NumericUpDown();
            this.coefficient = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Generate_Newton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotSetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImaginaryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExponentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddorSubtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficient)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelbrotSetPictureBox
            // 
            this.mandelbrotSetPictureBox.Location = new System.Drawing.Point(0, -1);
            this.mandelbrotSetPictureBox.Name = "mandelbrotSetPictureBox";
            this.mandelbrotSetPictureBox.Size = new System.Drawing.Size(800, 600);
            this.mandelbrotSetPictureBox.TabIndex = 0;
            this.mandelbrotSetPictureBox.TabStop = false;
            this.mandelbrotSetPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mandelbrotSetPictureBox_Paint);
            // 
            // displayMandelbrotSetButton
            // 
            this.displayMandelbrotSetButton.Location = new System.Drawing.Point(12, 611);
            this.displayMandelbrotSetButton.Name = "displayMandelbrotSetButton";
            this.displayMandelbrotSetButton.Size = new System.Drawing.Size(187, 36);
            this.displayMandelbrotSetButton.TabIndex = 1;
            this.displayMandelbrotSetButton.Text = "Display Fractal";
            this.displayMandelbrotSetButton.UseVisualStyleBackColor = true;
            this.displayMandelbrotSetButton.Click += new System.EventHandler(this.displayMandelbrotSetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colouring Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Colouring Method";
            // 
            // colouringMethodComboBox
            // 
            this.colouringMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colouringMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colouringMethodComboBox.FormattingEnabled = true;
            this.colouringMethodComboBox.Location = new System.Drawing.Point(326, 618);
            this.colouringMethodComboBox.Name = "colouringMethodComboBox";
            this.colouringMethodComboBox.Size = new System.Drawing.Size(172, 24);
            this.colouringMethodComboBox.TabIndex = 3;
            this.colouringMethodComboBox.SelectedValueChanged += new System.EventHandler(this.colouringMethodComboBox_SelectedValueChanged);
            // 
            // chooseFractalComboBox
            // 
            this.chooseFractalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseFractalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chooseFractalComboBox.FormattingEnabled = true;
            this.chooseFractalComboBox.Location = new System.Drawing.Point(628, 618);
            this.chooseFractalComboBox.Name = "chooseFractalComboBox";
            this.chooseFractalComboBox.Size = new System.Drawing.Size(172, 24);
            this.chooseFractalComboBox.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label2.Location = new System.Drawing.Point(519, 621);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 17);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Choose Fractal";
            // 
            // RealUpDown
            // 
            this.RealUpDown.DecimalPlaces = 3;
            this.RealUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RealUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.RealUpDown.Location = new System.Drawing.Point(857, 74);
            this.RealUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.RealUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147418112});
            this.RealUpDown.Name = "RealUpDown";
            this.RealUpDown.Size = new System.Drawing.Size(58, 23);
            this.RealUpDown.TabIndex = 5;
            this.RealUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // ImaginaryUpDown
            // 
            this.ImaginaryUpDown.DecimalPlaces = 3;
            this.ImaginaryUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ImaginaryUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ImaginaryUpDown.Location = new System.Drawing.Point(943, 74);
            this.ImaginaryUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.ImaginaryUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147418112});
            this.ImaginaryUpDown.Name = "ImaginaryUpDown";
            this.ImaginaryUpDown.Size = new System.Drawing.Size(54, 23);
            this.ImaginaryUpDown.TabIndex = 6;
            this.ImaginaryUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(921, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(1003, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(824, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "c =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(803, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 72);
            this.label7.TabIndex = 10;
            this.label7.Text = "Change these values to generate\r\n your own Julia Set. If no picture is\r\nmade, the" +
    " function grew without\r\nbounds. Input new values.";
            // 
            // SampleJs
            // 
            this.SampleJs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SampleJs.Location = new System.Drawing.Point(813, 139);
            this.SampleJs.Name = "SampleJs";
            this.SampleJs.Size = new System.Drawing.Size(221, 31);
            this.SampleJs.TabIndex = 11;
            this.SampleJs.Text = "Display Sample";
            this.SampleJs.UseVisualStyleBackColor = true;
            this.SampleJs.Click += new System.EventHandler(this.SampleJs_Click);
            // 
            // ExponentUpDown
            // 
            this.ExponentUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExponentUpDown.Location = new System.Drawing.Point(934, 100);
            this.ExponentUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ExponentUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ExponentUpDown.Name = "ExponentUpDown";
            this.ExponentUpDown.Size = new System.Drawing.Size(58, 23);
            this.ExponentUpDown.TabIndex = 12;
            this.ExponentUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(854, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Exponent:";
            // 
            // fxDegree
            // 
            this.fxDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fxDegree.Location = new System.Drawing.Point(905, 285);
            this.fxDegree.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fxDegree.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fxDegree.Name = "fxDegree";
            this.fxDegree.Size = new System.Drawing.Size(32, 23);
            this.fxDegree.TabIndex = 19;
            this.fxDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(803, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 90);
            this.label10.TabIndex = 18;
            this.label10.Text = "Change these values to generate\r\n your own Newton Fractal. If no\r\npicture is made" +
    ", the function\r\ngrew without bounds. Input new\r\nvalues.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(1031, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(938, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "+";
            // 
            // AddorSubtract
            // 
            this.AddorSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddorSubtract.Location = new System.Drawing.Point(957, 285);
            this.AddorSubtract.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.AddorSubtract.Name = "AddorSubtract";
            this.AddorSubtract.Size = new System.Drawing.Size(54, 23);
            this.AddorSubtract.TabIndex = 15;
            this.AddorSubtract.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // coefficient
            // 
            this.coefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coefficient.Location = new System.Drawing.Point(848, 285);
            this.coefficient.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.coefficient.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.coefficient.Name = "coefficient";
            this.coefficient.Size = new System.Drawing.Size(36, 23);
            this.coefficient.TabIndex = 14;
            this.coefficient.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(813, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "f(x)=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(883, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "z^";
            // 
            // Generate_Newton
            // 
            this.Generate_Newton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Generate_Newton.Location = new System.Drawing.Point(806, 314);
            this.Generate_Newton.Name = "Generate_Newton";
            this.Generate_Newton.Size = new System.Drawing.Size(221, 31);
            this.Generate_Newton.TabIndex = 23;
            this.Generate_Newton.Text = "Display Sample";
            this.Generate_Newton.UseVisualStyleBackColor = true;
            this.Generate_Newton.Click += new System.EventHandler(this.Generate_Newton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 653);
            this.Controls.Add(this.Generate_Newton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fxDegree);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AddorSubtract);
            this.Controls.Add(this.coefficient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExponentUpDown);
            this.Controls.Add(this.SampleJs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImaginaryUpDown);
            this.Controls.Add(this.RealUpDown);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.chooseFractalComboBox);
            this.Controls.Add(this.colouringMethodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayMandelbrotSetButton);
            this.Controls.Add(this.mandelbrotSetPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotSetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImaginaryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExponentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddorSubtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox mandelbrotSetPictureBox;
        private System.Windows.Forms.Button displayMandelbrotSetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colouringMethodComboBox;


        #endregion

        private System.Windows.Forms.ComboBox chooseFractalComboBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.NumericUpDown RealUpDown;
        private System.Windows.Forms.NumericUpDown ImaginaryUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SampleJs;
        private System.Windows.Forms.NumericUpDown ExponentUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown fxDegree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown AddorSubtract;
        private System.Windows.Forms.NumericUpDown coefficient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Generate_Newton;
    }
}

