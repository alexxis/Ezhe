namespace Ezhe
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.tbDescr = new System.Windows.Forms.TextBox();
            this.btnMaxId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(12, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(137, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(12, 38);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(137, 20);
            this.dtpTime.TabIndex = 5;
            // 
            // tbEvent
            // 
            this.tbEvent.Location = new System.Drawing.Point(12, 64);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(100, 20);
            this.tbEvent.TabIndex = 6;
            this.tbEvent.Text = "Чаёк";
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(12, 90);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(100, 20);
            this.tbRate.TabIndex = 7;
            this.tbRate.Text = "11";
            // 
            // tbDescr
            // 
            this.tbDescr.Location = new System.Drawing.Point(12, 116);
            this.tbDescr.Name = "tbDescr";
            this.tbDescr.Size = new System.Drawing.Size(100, 20);
            this.tbDescr.TabIndex = 8;
            this.tbDescr.Text = "с плюшками";
            // 
            // btnMaxId
            // 
            this.btnMaxId.Location = new System.Drawing.Point(302, 110);
            this.btnMaxId.Name = "btnMaxId";
            this.btnMaxId.Size = new System.Drawing.Size(75, 23);
            this.btnMaxId.TabIndex = 10;
            this.btnMaxId.Text = "maxId";
            this.btnMaxId.UseVisualStyleBackColor = true;
            this.btnMaxId.Click += new System.EventHandler(this.btnMaxId_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 242);
            this.Controls.Add(this.btnMaxId);
            this.Controls.Add(this.tbDescr);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.tbEvent);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox tbEvent;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.TextBox tbDescr;
        private System.Windows.Forms.Button btnMaxId;
    }
}