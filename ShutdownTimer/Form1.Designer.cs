namespace ShutdownTimer
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
            buttonVypnout = new Button();
            comboBoxHours = new ComboBox();
            comboBoxMinutes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            buttonRestart = new Button();
            buttonAbort = new Button();
            SuspendLayout();
            // 
            // buttonVypnout
            // 
            buttonVypnout.BackColor = Color.Brown;
            buttonVypnout.BackgroundImageLayout = ImageLayout.Center;
            buttonVypnout.FlatAppearance.BorderSize = 0;
            buttonVypnout.Image = Properties.Resources.shutdown;
            buttonVypnout.Location = new Point(79, 11);
            buttonVypnout.Name = "buttonVypnout";
            buttonVypnout.Size = new Size(35, 35);
            buttonVypnout.TabIndex = 0;
            buttonVypnout.UseVisualStyleBackColor = false;
            buttonVypnout.Click += buttonVypnout_Click;
            // 
            // comboBoxHours
            // 
            comboBoxHours.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHours.FormattingEnabled = true;
            comboBoxHours.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxHours.Location = new Point(12, 23);
            comboBoxHours.Name = "comboBoxHours";
            comboBoxHours.Size = new Size(55, 23);
            comboBoxHours.TabIndex = 4;
            // 
            // comboBoxMinutes
            // 
            comboBoxMinutes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMinutes.FormattingEnabled = true;
            comboBoxMinutes.Items.AddRange(new object[] { "0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBoxMinutes.Location = new Point(12, 68);
            comboBoxMinutes.Name = "comboBoxMinutes";
            comboBoxMinutes.Size = new Size(55, 23);
            comboBoxMinutes.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 5);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Minutes";
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.LightBlue;
            buttonRestart.BackgroundImageLayout = ImageLayout.Center;
            buttonRestart.FlatAppearance.BorderColor = Color.White;
            buttonRestart.FlatAppearance.BorderSize = 0;
            buttonRestart.Image = Properties.Resources.restart;
            buttonRestart.Location = new Point(79, 56);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(35, 35);
            buttonRestart.TabIndex = 8;
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // buttonAbort
            // 
            buttonAbort.BackColor = Color.MediumSpringGreen;
            buttonAbort.BackgroundImageLayout = ImageLayout.Center;
            buttonAbort.FlatAppearance.BorderColor = Color.White;
            buttonAbort.FlatAppearance.BorderSize = 0;
            buttonAbort.Location = new Point(12, 97);
            buttonAbort.Name = "buttonAbort";
            buttonAbort.Size = new Size(102, 26);
            buttonAbort.TabIndex = 9;
            buttonAbort.Text = "ABORT";
            buttonAbort.UseVisualStyleBackColor = false;
            buttonAbort.Click += buttonAbort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(126, 129);
            Controls.Add(buttonAbort);
            Controls.Add(buttonRestart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMinutes);
            Controls.Add(comboBoxHours);
            Controls.Add(buttonVypnout);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shutdown timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVypnout;
        private ComboBox comboBoxHours;
        private ComboBox comboBoxMinutes;
        private Label label1;
        private Label label2;
        private Button buttonRestart;
        private Button buttonAbort;
    }
}
