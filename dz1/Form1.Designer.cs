namespace dz1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxSeconds = new TextBox();
            textBoxMinutes = new TextBox();
            textBoxHours = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 12);
            dateTimePicker1.MinDate = new DateTime(2023, 6, 18, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(126, 65);
            button1.Name = "button1";
            button1.Size = new Size(156, 180);
            button1.TabIndex = 13;
            button1.Text = "Set up timer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 195);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Seconds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 11;
            label2.Text = "Minutes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 58);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 10;
            label1.Text = "Hours";
            // 
            // textBoxSeconds
            // 
            textBoxSeconds.Location = new Point(25, 218);
            textBoxSeconds.Name = "textBoxSeconds";
            textBoxSeconds.Size = new Size(82, 27);
            textBoxSeconds.TabIndex = 9;
            // 
            // textBoxMinutes
            // 
            textBoxMinutes.Location = new Point(25, 147);
            textBoxMinutes.Name = "textBoxMinutes";
            textBoxMinutes.Size = new Size(82, 27);
            textBoxMinutes.TabIndex = 8;
            // 
            // textBoxHours
            // 
            textBoxHours.Location = new Point(25, 81);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.Size = new Size(82, 27);
            textBoxHours.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 259);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSeconds);
            Controls.Add(textBoxMinutes);
            Controls.Add(textBoxHours);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxSeconds;
        private TextBox textBoxMinutes;
        private TextBox textBoxHours;
        private System.Windows.Forms.Timer timer1;
    }
}