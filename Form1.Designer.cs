namespace WindowsFormsApplication1
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
            this.CpuTitle0 = new System.Windows.Forms.Label();
            this.CpuTitle1 = new System.Windows.Forms.Label();
            this.CpuTitle2 = new System.Windows.Forms.Label();
            this.CpuTitle3 = new System.Windows.Forms.Label();
            this.cpu0 = new System.Windows.Forms.Label();
            this.cpu1 = new System.Windows.Forms.Label();
            this.cpu2 = new System.Windows.Forms.Label();
            this.cpu3 = new System.Windows.Forms.Label();
            this.Cpu_Title = new System.Windows.Forms.Label();
            this.Ram_Title = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.HDD_Titel = new System.Windows.Forms.Label();
            this.HDD_Light = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CpuTitle0
            // 
            this.CpuTitle0.AutoSize = true;
            this.CpuTitle0.Location = new System.Drawing.Point(16, 30);
            this.CpuTitle0.Name = "CpuTitle0";
            this.CpuTitle0.Size = new System.Drawing.Size(99, 13);
            this.CpuTitle0.TabIndex = 2;
            this.CpuTitle0.Text = "CPU 0 Percentage:";
            // 
            // CpuTitle1
            // 
            this.CpuTitle1.AutoSize = true;
            this.CpuTitle1.Location = new System.Drawing.Point(16, 47);
            this.CpuTitle1.Name = "CpuTitle1";
            this.CpuTitle1.Size = new System.Drawing.Size(99, 13);
            this.CpuTitle1.TabIndex = 3;
            this.CpuTitle1.Text = "CPU 1 Percentage:";
            // 
            // CpuTitle2
            // 
            this.CpuTitle2.AutoSize = true;
            this.CpuTitle2.Location = new System.Drawing.Point(16, 64);
            this.CpuTitle2.Name = "CpuTitle2";
            this.CpuTitle2.Size = new System.Drawing.Size(99, 13);
            this.CpuTitle2.TabIndex = 4;
            this.CpuTitle2.Text = "CPU 2 Percentage:";
            // 
            // CpuTitle3
            // 
            this.CpuTitle3.AutoSize = true;
            this.CpuTitle3.Location = new System.Drawing.Point(16, 81);
            this.CpuTitle3.Name = "CpuTitle3";
            this.CpuTitle3.Size = new System.Drawing.Size(99, 13);
            this.CpuTitle3.TabIndex = 5;
            this.CpuTitle3.Text = "CPU 3 Percentage:";
            // 
            // cpu0
            // 
            this.cpu0.AutoSize = true;
            this.cpu0.Location = new System.Drawing.Point(121, 30);
            this.cpu0.Name = "cpu0";
            this.cpu0.Size = new System.Drawing.Size(0, 13);
            this.cpu0.TabIndex = 6;
            // 
            // cpu1
            // 
            this.cpu1.AutoSize = true;
            this.cpu1.Location = new System.Drawing.Point(121, 47);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(0, 13);
            this.cpu1.TabIndex = 7;
            // 
            // cpu2
            // 
            this.cpu2.AutoSize = true;
            this.cpu2.Location = new System.Drawing.Point(121, 64);
            this.cpu2.Name = "cpu2";
            this.cpu2.Size = new System.Drawing.Size(0, 13);
            this.cpu2.TabIndex = 8;
            // 
            // cpu3
            // 
            this.cpu3.AutoSize = true;
            this.cpu3.Location = new System.Drawing.Point(121, 81);
            this.cpu3.Name = "cpu3";
            this.cpu3.Size = new System.Drawing.Size(0, 13);
            this.cpu3.TabIndex = 9;
            // 
            // Cpu_Title
            // 
            this.Cpu_Title.AutoSize = true;
            this.Cpu_Title.Location = new System.Drawing.Point(3, 9);
            this.Cpu_Title.Name = "Cpu_Title";
            this.Cpu_Title.Size = new System.Drawing.Size(93, 13);
            this.Cpu_Title.TabIndex = 10;
            this.Cpu_Title.Text = "CPU Percentage :";
            // 
            // Ram_Title
            // 
            this.Ram_Title.AutoSize = true;
            this.Ram_Title.Location = new System.Drawing.Point(213, 9);
            this.Ram_Title.Name = "Ram_Title";
            this.Ram_Title.Size = new System.Drawing.Size(90, 13);
            this.Ram_Title.TabIndex = 11;
            this.Ram_Title.Text = "Ram Percentage:";
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Location = new System.Drawing.Point(309, 9);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(0, 13);
            this.ram.TabIndex = 12;
            // 
            // HDD_Titel
            // 
            this.HDD_Titel.AutoSize = true;
            this.HDD_Titel.Location = new System.Drawing.Point(410, 9);
            this.HDD_Titel.Name = "HDD_Titel";
            this.HDD_Titel.Size = new System.Drawing.Size(95, 13);
            this.HDD_Titel.TabIndex = 13;
            this.HDD_Titel.Text = "Hard Drive Activity";
            // 
            // HDD_Light
            // 
            this.HDD_Light.AutoSize = true;
            this.HDD_Light.Location = new System.Drawing.Point(512, 9);
            this.HDD_Light.Name = "HDD_Light";
            this.HDD_Light.Size = new System.Drawing.Size(0, 13);
            this.HDD_Light.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 635);
            this.Controls.Add(this.HDD_Light);
            this.Controls.Add(this.HDD_Titel);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.Ram_Title);
            this.Controls.Add(this.Cpu_Title);
            this.Controls.Add(this.cpu3);
            this.Controls.Add(this.cpu2);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.cpu0);
            this.Controls.Add(this.CpuTitle3);
            this.Controls.Add(this.CpuTitle2);
            this.Controls.Add(this.CpuTitle1);
            this.Controls.Add(this.CpuTitle0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label CpuTitle0;
        private System.Windows.Forms.Label CpuTitle1;
        private System.Windows.Forms.Label CpuTitle2;
        private System.Windows.Forms.Label CpuTitle3;
        private System.Windows.Forms.Label cpu0;
        private System.Windows.Forms.Label cpu1;
        private System.Windows.Forms.Label cpu2;
        private System.Windows.Forms.Label cpu3;
        private System.Windows.Forms.Label Cpu_Title;
        private System.Windows.Forms.Label Ram_Title;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label HDD_Titel;
        private System.Windows.Forms.Label HDD_Light;





    }
}

