namespace WindowsFormsApp1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.lineButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.startXlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startYlabel = new System.Windows.Forms.Label();
            this.endXlabel = new System.Windows.Forms.Label();
            this.endYlabel = new System.Windows.Forms.Label();
            this.startXtext = new System.Windows.Forms.TextBox();
            this.startYtext = new System.Windows.Forms.TextBox();
            this.endXtext = new System.Windows.Forms.TextBox();
            this.endYtext = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.positionY = new System.Windows.Forms.Label();
            this.positionX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1319, 897);
            this.canvas.TabIndex = 0;
            this.canvas.Click += new System.EventHandler(this.panel1_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasMouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasMouseUp);
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lineButton.Location = new System.Drawing.Point(1337, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 1;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.shapeButtonClicked);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(1337, 41);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 2;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.shapeButtonClicked);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(1337, 70);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(75, 23);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.shapeButtonClicked);
            // 
            // startXlabel
            // 
            this.startXlabel.AutoSize = true;
            this.startXlabel.Location = new System.Drawing.Point(1337, 103);
            this.startXlabel.Name = "startXlabel";
            this.startXlabel.Size = new System.Drawing.Size(37, 13);
            this.startXlabel.TabIndex = 4;
            this.startXlabel.Text = "start X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // startYlabel
            // 
            this.startYlabel.AutoSize = true;
            this.startYlabel.Location = new System.Drawing.Point(1337, 142);
            this.startYlabel.Name = "startYlabel";
            this.startYlabel.Size = new System.Drawing.Size(37, 13);
            this.startYlabel.TabIndex = 6;
            this.startYlabel.Text = "start Y";
            // 
            // endXlabel
            // 
            this.endXlabel.AutoSize = true;
            this.endXlabel.Location = new System.Drawing.Point(1337, 181);
            this.endXlabel.Name = "endXlabel";
            this.endXlabel.Size = new System.Drawing.Size(35, 13);
            this.endXlabel.TabIndex = 7;
            this.endXlabel.Text = "end X";
            // 
            // endYlabel
            // 
            this.endYlabel.AutoSize = true;
            this.endYlabel.Location = new System.Drawing.Point(1337, 220);
            this.endYlabel.Name = "endYlabel";
            this.endYlabel.Size = new System.Drawing.Size(35, 13);
            this.endYlabel.TabIndex = 8;
            this.endYlabel.Text = "end Y";
            // 
            // startXtext
            // 
            this.startXtext.Location = new System.Drawing.Point(1337, 119);
            this.startXtext.Name = "startXtext";
            this.startXtext.Size = new System.Drawing.Size(75, 20);
            this.startXtext.TabIndex = 9;
            // 
            // startYtext
            // 
            this.startYtext.Location = new System.Drawing.Point(1337, 158);
            this.startYtext.Name = "startYtext";
            this.startYtext.Size = new System.Drawing.Size(75, 20);
            this.startYtext.TabIndex = 10;
            // 
            // endXtext
            // 
            this.endXtext.Location = new System.Drawing.Point(1337, 197);
            this.endXtext.Name = "endXtext";
            this.endXtext.Size = new System.Drawing.Size(75, 20);
            this.endXtext.TabIndex = 11;
            // 
            // endYtext
            // 
            this.endYtext.Location = new System.Drawing.Point(1337, 236);
            this.endYtext.Name = "endYtext";
            this.endYtext.Size = new System.Drawing.Size(75, 20);
            this.endYtext.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1337, 293);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addShape);
            // 
            // positionY
            // 
            this.positionY.AutoSize = true;
            this.positionY.Location = new System.Drawing.Point(1337, 896);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(26, 13);
            this.positionY.TabIndex = 18;
            this.positionY.Text = "Y: 0";
            // 
            // positionX
            // 
            this.positionX.AutoSize = true;
            this.positionX.Location = new System.Drawing.Point(1337, 883);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(26, 13);
            this.positionX.TabIndex = 19;
            this.positionX.Text = "X: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 921);
            this.Controls.Add(this.positionX);
            this.Controls.Add(this.positionY);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endYtext);
            this.Controls.Add(this.endXtext);
            this.Controls.Add(this.startYtext);
            this.Controls.Add(this.startXtext);
            this.Controls.Add(this.endYlabel);
            this.Controls.Add(this.endXlabel);
            this.Controls.Add(this.startYlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startXlabel);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.canvas);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WindowsFormsApp1.Properties.Settings.Default, "OK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::WindowsFormsApp1.Properties.Settings.Default.OK;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Label startXlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startYlabel;
        private System.Windows.Forms.Label endXlabel;
        private System.Windows.Forms.Label endYlabel;
        private System.Windows.Forms.TextBox startXtext;
        private System.Windows.Forms.TextBox startYtext;
        private System.Windows.Forms.TextBox endXtext;
        private System.Windows.Forms.TextBox endYtext;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label positionY;
        private System.Windows.Forms.Label positionX;
    }
}

