namespace Phonebook
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.appLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(13, 46);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(441, 396);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // appLabel
            // 
            this.appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.Location = new System.Drawing.Point(12, 13);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(442, 23);
            this.appLabel.TabIndex = 1;
            this.appLabel.Text = "Приложение \"Телефонная книга\"";
            this.appLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // creditsLabel
            // 
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(17, 442);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(437, 107);
            this.creditsLabel.TabIndex = 2;
            this.creditsLabel.Text = "Лабораторную выполнили:\r\nВоронкина Д.К.\r\nКондратьев И.А.\r\n(ПМИ-81)\r\n";
            this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 558);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "Справка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Label creditsLabel;
    }
}