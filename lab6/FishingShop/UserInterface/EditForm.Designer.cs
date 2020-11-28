namespace UserInterface
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.backButton = new System.Windows.Forms.Button();
            this.clearDayLabel = new System.Windows.Forms.Label();
            this.SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.clearLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Allbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.backButton.Location = new System.Drawing.Point(12, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearDayLabel
            // 
            this.clearDayLabel.AutoSize = true;
            this.clearDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearDayLabel.ForeColor = System.Drawing.Color.Olive;
            this.clearDayLabel.Location = new System.Drawing.Point(288, 9);
            this.clearDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clearDayLabel.Name = "clearDayLabel";
            this.clearDayLabel.Size = new System.Drawing.Size(277, 25);
            this.clearDayLabel.TabIndex = 10;
            this.clearDayLabel.Text = "Clear information of the day";

            // 
            // SelectedDate
            // 
            this.SelectedDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.SelectedDate.Checked = false;
            this.SelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectedDate.Location = new System.Drawing.Point(293, 55);
            this.SelectedDate.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Size = new System.Drawing.Size(272, 22);
            this.SelectedDate.TabIndex = 11;
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLabel.ForeColor = System.Drawing.Color.Olive;
            this.clearLabel.Location = new System.Drawing.Point(313, 154);
            this.clearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(204, 25);
            this.clearLabel.TabIndex = 12;
            this.clearLabel.Text = "Clear all information";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnClear.Location = new System.Drawing.Point(360, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 42);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Allbtn
            // 
            this.Allbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Allbtn.ForeColor = System.Drawing.Color.OliveDrab;
            this.Allbtn.Location = new System.Drawing.Point(360, 197);
            this.Allbtn.Name = "Allbtn";
            this.Allbtn.Size = new System.Drawing.Size(113, 42);
            this.Allbtn.TabIndex = 16;
            this.Allbtn.Text = "Clear all";
            this.Allbtn.UseVisualStyleBackColor = true;
            this.Allbtn.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Allbtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.SelectedDate);
            this.Controls.Add(this.clearDayLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label clearDayLabel;
        private System.Windows.Forms.DateTimePicker SelectedDate;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Allbtn;
    }
}