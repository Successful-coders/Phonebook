namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.callersListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.separatorLine = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addCallerButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.aboutToolButton = new System.Windows.Forms.ToolStripButton();
            this.applyChangesButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchImage = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // callersListView
            // 
            this.callersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.phoneColumn});
            this.callersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callersListView.FullRowSelect = true;
            this.callersListView.HideSelection = false;
            this.callersListView.Location = new System.Drawing.Point(13, 84);
            this.callersListView.MultiSelect = false;
            this.callersListView.Name = "callersListView";
            this.callersListView.Size = new System.Drawing.Size(775, 172);
            this.callersListView.TabIndex = 0;
            this.callersListView.UseCompatibleStateImageBehavior = false;
            this.callersListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "ФИО";
            this.nameColumn.Width = 440;
            // 
            // phoneColumn
            // 
            this.phoneColumn.Text = "Телефон";
            this.phoneColumn.Width = 327;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Yellow;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(146, 262);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(395, 262);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 29);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(528, 262);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 29);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(661, 263);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(127, 29);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // separatorLine
            // 
            this.separatorLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separatorLine.Location = new System.Drawing.Point(-9, 317);
            this.separatorLine.Name = "separatorLine";
            this.separatorLine.Size = new System.Drawing.Size(823, 1);
            this.separatorLine.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(7, 322);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 26);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "ФИО:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(60, 322);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(324, 26);
            this.nameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(489, 323);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(179, 26);
            this.phoneTextBox.TabIndex = 7;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(399, 323);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(84, 26);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Телефон:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCallerButton
            // 
            this.addCallerButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addCallerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCallerButton.Location = new System.Drawing.Point(692, 321);
            this.addCallerButton.Name = "addCallerButton";
            this.addCallerButton.Size = new System.Drawing.Size(96, 30);
            this.addCallerButton.TabIndex = 8;
            this.addCallerButton.Text = "Добавить";
            this.addCallerButton.UseVisualStyleBackColor = false;
            this.addCallerButton.Click += new System.EventHandler(this.addCallerButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.PaleGreen;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(13, 263);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(127, 29);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // aboutToolButton
            // 
            this.aboutToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolButton.Image")));
            this.aboutToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolButton.Name = "aboutToolButton";
            this.aboutToolButton.Size = new System.Drawing.Size(57, 22);
            this.aboutToolButton.Text = "Справка";
            this.aboutToolButton.Click += new System.EventHandler(this.aboutToolButton_Click);
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.BackColor = System.Drawing.Color.PaleGreen;
            this.applyChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyChangesButton.Location = new System.Drawing.Point(692, 320);
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.Size = new System.Drawing.Size(96, 30);
            this.applyChangesButton.TabIndex = 8;
            this.applyChangesButton.Text = "Изменить";
            this.applyChangesButton.UseVisualStyleBackColor = false;
            this.applyChangesButton.Visible = false;
            this.applyChangesButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(46, 52);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(742, 26);
            this.searchTextBox.TabIndex = 11;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchImage
            // 
            this.searchImage.Image = global::Phonebook.Properties.Resources.searchIcon;
            this.searchImage.Location = new System.Drawing.Point(12, 52);
            this.searchImage.Name = "searchImage";
            this.searchImage.Size = new System.Drawing.Size(28, 26);
            this.searchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchImage.TabIndex = 12;
            this.searchImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchImage);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.applyChangesButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.addCallerButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.separatorLine);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.callersListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Телефонная книга";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView callersListView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label separatorLine;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button addCallerButton;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader phoneColumn;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton aboutToolButton;
        private System.Windows.Forms.Button applyChangesButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox searchImage;
    }
}

