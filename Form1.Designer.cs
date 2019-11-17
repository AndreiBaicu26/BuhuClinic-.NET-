namespace Cabinet_Medical_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Patients = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.Medics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to \r\nBuhu Clinic\r\n";
            // 
            // Patients
            // 
            this.Patients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.Patients.FlatAppearance.BorderSize = 0;
            this.Patients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(107)))));
            this.Patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients.ForeColor = System.Drawing.Color.White;
            this.Patients.Location = new System.Drawing.Point(137, 191);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(160, 53);
            this.Patients.TabIndex = 1;
            this.Patients.Text = "Patients";
            this.Patients.UseVisualStyleBackColor = false;
            this.Patients.Click += new System.EventHandler(this.Patients_Click);
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.Statistics.FlatAppearance.BorderSize = 0;
            this.Statistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(107)))));
            this.Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.ForeColor = System.Drawing.Color.White;
            this.Statistics.Location = new System.Drawing.Point(137, 292);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(160, 53);
            this.Statistics.TabIndex = 2;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = false;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Medics
            // 
            this.Medics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.Medics.FlatAppearance.BorderSize = 0;
            this.Medics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(107)))));
            this.Medics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medics.ForeColor = System.Drawing.Color.White;
            this.Medics.Location = new System.Drawing.Point(137, 391);
            this.Medics.Name = "Medics";
            this.Medics.Size = new System.Drawing.Size(160, 53);
            this.Medics.TabIndex = 3;
            this.Medics.Text = "Medics";
            this.Medics.UseVisualStyleBackColor = false;
            this.Medics.Click += new System.EventHandler(this.Medics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 601);
            this.Controls.Add(this.Medics);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.Patients);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Patients;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button Medics;
    }
}

