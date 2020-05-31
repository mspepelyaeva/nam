namespace Markov_normal_algorithm
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AlphabetInputTextBox = new System.Windows.Forms.TextBox();
            this.AlphabetTitle = new System.Windows.Forms.Label();
            this.AlphabetInputButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LeftPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputTitle = new System.Windows.Forms.Label();
            this.Formuls = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PartsDevelop = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.PartDevelop = new System.Windows.Forms.Label();
            this.OntputTitle = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlphabetInputTextBox
            // 
            this.AlphabetInputTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabetInputTextBox.Location = new System.Drawing.Point(14, 29);
            this.AlphabetInputTextBox.Name = "AlphabetInputTextBox";
            this.AlphabetInputTextBox.Size = new System.Drawing.Size(139, 27);
            this.AlphabetInputTextBox.TabIndex = 0;
            // 
            // AlphabetTitle
            // 
            this.AlphabetTitle.AutoSize = true;
            this.AlphabetTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphabetTitle.ForeColor = System.Drawing.Color.White;
            this.AlphabetTitle.Location = new System.Drawing.Point(10, 6);
            this.AlphabetTitle.Name = "AlphabetTitle";
            this.AlphabetTitle.Size = new System.Drawing.Size(139, 20);
            this.AlphabetTitle.TabIndex = 1;
            this.AlphabetTitle.Text = "Введите алфавит";
            // 
            // AlphabetInputButton
            // 
            this.AlphabetInputButton.Location = new System.Drawing.Point(159, 29);
            this.AlphabetInputButton.Name = "AlphabetInputButton";
            this.AlphabetInputButton.Size = new System.Drawing.Size(36, 27);
            this.AlphabetInputButton.TabIndex = 2;
            this.AlphabetInputButton.Text = "ОК";
            this.AlphabetInputButton.UseVisualStyleBackColor = true;
            this.AlphabetInputButton.Click += new System.EventHandler(this.AlphabetInputButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftPart,
            this.Action,
            this.RightPart});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 443);
            this.dataGridView1.TabIndex = 3;
            // 
            // LeftPart
            // 
            this.LeftPart.HeaderText = "Левая Часть";
            this.LeftPart.Name = "LeftPart";
            // 
            // Action
            // 
            this.Action.HeaderText = "Действие";
            this.Action.Name = "Action";
            // 
            // RightPart
            // 
            this.RightPart.HeaderText = "Правая часть";
            this.RightPart.Name = "RightPart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputTextBox);
            this.panel1.Controls.Add(this.InputTitle);
            this.panel1.Controls.Add(this.Formuls);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 555);
            this.panel1.TabIndex = 4;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(12, 516);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(340, 27);
            this.InputTextBox.TabIndex = 5;
            // 
            // InputTitle
            // 
            this.InputTitle.AutoSize = true;
            this.InputTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTitle.ForeColor = System.Drawing.Color.White;
            this.InputTitle.Location = new System.Drawing.Point(8, 493);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(128, 20);
            this.InputTitle.TabIndex = 6;
            this.InputTitle.Text = "Входная строка";
            // 
            // Formuls
            // 
            this.Formuls.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formuls.ForeColor = System.Drawing.Color.White;
            this.Formuls.Location = new System.Drawing.Point(9, 8);
            this.Formuls.Name = "Formuls";
            this.Formuls.Size = new System.Drawing.Size(347, 30);
            this.Formuls.TabIndex = 4;
            this.Formuls.Text = "Набор формул подстановки";
            this.Formuls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PartsDevelop);
            this.panel2.Controls.Add(this.OutputTextBox);
            this.panel2.Controls.Add(this.PartDevelop);
            this.panel2.Controls.Add(this.OntputTitle);
            this.panel2.Location = new System.Drawing.Point(385, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 555);
            this.panel2.TabIndex = 5;
            // 
            // PartsDevelop
            // 
            this.PartsDevelop.BackColor = System.Drawing.Color.White;
            this.PartsDevelop.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartsDevelop.Location = new System.Drawing.Point(25, 41);
            this.PartsDevelop.Name = "PartsDevelop";
            this.PartsDevelop.Size = new System.Drawing.Size(341, 443);
            this.PartsDevelop.TabIndex = 9;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(25, 516);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(340, 27);
            this.OutputTextBox.TabIndex = 7;
            // 
            // PartDevelop
            // 
            this.PartDevelop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartDevelop.ForeColor = System.Drawing.Color.White;
            this.PartDevelop.Location = new System.Drawing.Point(24, 8);
            this.PartDevelop.Name = "PartDevelop";
            this.PartDevelop.Size = new System.Drawing.Size(337, 30);
            this.PartDevelop.TabIndex = 5;
            this.PartDevelop.Text = "Этапы решения";
            this.PartDevelop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OntputTitle
            // 
            this.OntputTitle.AutoSize = true;
            this.OntputTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OntputTitle.ForeColor = System.Drawing.Color.White;
            this.OntputTitle.Location = new System.Drawing.Point(21, 493);
            this.OntputTitle.Name = "OntputTitle";
            this.OntputTitle.Size = new System.Drawing.Size(138, 20);
            this.OntputTitle.TabIndex = 8;
            this.OntputTitle.Text = "Выходная строка";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(255, 29);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(250, 27);
            this.Start.TabIndex = 6;
            this.Start.Text = "Выполнить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(572, 29);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(181, 27);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Очистить все";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(765, 617);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.AlphabetInputButton);
            this.Controls.Add(this.AlphabetInputTextBox);
            this.Controls.Add(this.AlphabetTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(781, 656);
            this.MinimumSize = new System.Drawing.Size(781, 656);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нормальный алгоритм Маркова";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AlphabetInputTextBox;
        private System.Windows.Forms.Label AlphabetTitle;
        private System.Windows.Forms.Button AlphabetInputButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightPart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Formuls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PartDevelop;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputTitle;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label OntputTitle;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label PartsDevelop;
    }
}

