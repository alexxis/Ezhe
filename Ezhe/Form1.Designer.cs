namespace Ezhe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.btnRefreshEvents = new System.Windows.Forms.Button();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.tpPressure = new System.Windows.Forms.TabPage();
            this.dgvPressure = new System.Windows.Forms.DataGridView();
            this.btnAddNewPressure = new System.Windows.Forms.Button();
            this.btnRefreshPressure = new System.Windows.Forms.Button();
            this.tpDrugs = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNewDrug = new System.Windows.Forms.Button();
            this.btnRefreshNewDrug = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.tpPressure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPressure)).BeginInit();
            this.tpDrugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEvents);
            this.tabControl1.Controls.Add(this.tpPressure);
            this.tabControl1.Controls.Add(this.tpDrugs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.btnRefreshEvents);
            this.tpEvents.Controls.Add(this.btnAddNewEvent);
            this.tpEvents.Controls.Add(this.dgvEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvents.Size = new System.Drawing.Size(762, 381);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // btnRefreshEvents
            // 
            this.btnRefreshEvents.Location = new System.Drawing.Point(681, 352);
            this.btnRefreshEvents.Name = "btnRefreshEvents";
            this.btnRefreshEvents.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshEvents.TabIndex = 2;
            this.btnRefreshEvents.Text = "Refresh";
            this.btnRefreshEvents.UseVisualStyleBackColor = true;
            this.btnRefreshEvents.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Location = new System.Drawing.Point(6, 253);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewEvent.TabIndex = 1;
            this.btnAddNewEvent.Text = "Add new...";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(6, 6);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(750, 241);
            this.dgvEvents.TabIndex = 0;
            // 
            // tpPressure
            // 
            this.tpPressure.Controls.Add(this.btnRefreshPressure);
            this.tpPressure.Controls.Add(this.btnAddNewPressure);
            this.tpPressure.Controls.Add(this.dgvPressure);
            this.tpPressure.Location = new System.Drawing.Point(4, 22);
            this.tpPressure.Name = "tpPressure";
            this.tpPressure.Padding = new System.Windows.Forms.Padding(3);
            this.tpPressure.Size = new System.Drawing.Size(762, 381);
            this.tpPressure.TabIndex = 1;
            this.tpPressure.Text = "Pressure";
            this.tpPressure.UseVisualStyleBackColor = true;
            // 
            // dgvPressure
            // 
            this.dgvPressure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPressure.Location = new System.Drawing.Point(6, 6);
            this.dgvPressure.Name = "dgvPressure";
            this.dgvPressure.Size = new System.Drawing.Size(750, 241);
            this.dgvPressure.TabIndex = 1;
            // 
            // btnAddNewPressure
            // 
            this.btnAddNewPressure.Location = new System.Drawing.Point(6, 253);
            this.btnAddNewPressure.Name = "btnAddNewPressure";
            this.btnAddNewPressure.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewPressure.TabIndex = 2;
            this.btnAddNewPressure.Text = "Add new...";
            this.btnAddNewPressure.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPressure
            // 
            this.btnRefreshPressure.Location = new System.Drawing.Point(681, 352);
            this.btnRefreshPressure.Name = "btnRefreshPressure";
            this.btnRefreshPressure.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPressure.TabIndex = 3;
            this.btnRefreshPressure.Text = "Refresh";
            this.btnRefreshPressure.UseVisualStyleBackColor = true;
            // 
            // tpDrugs
            // 
            this.tpDrugs.Controls.Add(this.btnRefreshNewDrug);
            this.tpDrugs.Controls.Add(this.btnAddNewDrug);
            this.tpDrugs.Controls.Add(this.dataGridView1);
            this.tpDrugs.Location = new System.Drawing.Point(4, 22);
            this.tpDrugs.Name = "tpDrugs";
            this.tpDrugs.Size = new System.Drawing.Size(762, 381);
            this.tpDrugs.TabIndex = 2;
            this.tpDrugs.Text = "Drugs";
            this.tpDrugs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 241);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAddNewDrug
            // 
            this.btnAddNewDrug.Location = new System.Drawing.Point(6, 253);
            this.btnAddNewDrug.Name = "btnAddNewDrug";
            this.btnAddNewDrug.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewDrug.TabIndex = 3;
            this.btnAddNewDrug.Text = "Add new...";
            this.btnAddNewDrug.UseVisualStyleBackColor = true;
            // 
            // btnRefreshNewDrug
            // 
            this.btnRefreshNewDrug.Location = new System.Drawing.Point(681, 352);
            this.btnRefreshNewDrug.Name = "btnRefreshNewDrug";
            this.btnRefreshNewDrug.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshNewDrug.TabIndex = 4;
            this.btnRefreshNewDrug.Text = "Refresh";
            this.btnRefreshNewDrug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 431);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezhe";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.tpPressure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPressure)).EndInit();
            this.tpDrugs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.Button btnRefreshEvents;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TabPage tpPressure;
        private System.Windows.Forms.DataGridView dgvPressure;
        private System.Windows.Forms.Button btnRefreshPressure;
        private System.Windows.Forms.Button btnAddNewPressure;
        private System.Windows.Forms.TabPage tpDrugs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefreshNewDrug;
        private System.Windows.Forms.Button btnAddNewDrug;
    }
}

