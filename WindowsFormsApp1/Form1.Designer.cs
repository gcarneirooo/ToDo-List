namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.butIncluir = new System.Windows.Forms.Button();
            this.butRemover = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.toolData = new System.Windows.Forms.ToolTip(this.components);
            this.toolTarefa = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(84, 18);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(307, 20);
            this.dateTime.TabIndex = 0;
            this.toolData.SetToolTip(this.dateTime, "Coloque a data!\r\n");
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(32, 22);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(40, 17);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data:";
            this.labelData.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(84, 58);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(307, 20);
            this.textBox.TabIndex = 2;
            this.toolTarefa.SetToolTip(this.textBox, "Coloque a tarefa desejada!");
            // 
            // labelTarefa
            // 
            this.labelTarefa.AutoSize = true;
            this.labelTarefa.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarefa.Location = new System.Drawing.Point(26, 58);
            this.labelTarefa.Name = "labelTarefa";
            this.labelTarefa.Size = new System.Drawing.Size(56, 19);
            this.labelTarefa.TabIndex = 3;
            this.labelTarefa.Text = "Tarefa:";
            // 
            // butIncluir
            // 
            this.butIncluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.butIncluir.Location = new System.Drawing.Point(410, 31);
            this.butIncluir.Name = "butIncluir";
            this.butIncluir.Size = new System.Drawing.Size(75, 43);
            this.butIncluir.TabIndex = 4;
            this.butIncluir.Text = "Incluir";
            this.butIncluir.UseVisualStyleBackColor = true;
            this.butIncluir.Click += new System.EventHandler(this.butIncluir_Click);
            // 
            // butRemover
            // 
            this.butRemover.Location = new System.Drawing.Point(410, 349);
            this.butRemover.Name = "butRemover";
            this.butRemover.Size = new System.Drawing.Size(75, 23);
            this.butRemover.TabIndex = 5;
            this.butRemover.Text = "Remover";
            this.butRemover.UseVisualStyleBackColor = true;
            this.butRemover.Click += new System.EventHandler(this.butRemover_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(30, 102);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(455, 225);
            this.listBox.TabIndex = 6;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // toolData
            // 
            this.toolData.IsBalloon = true;
            // 
            // toolTarefa
            // 
            this.toolTarefa.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 397);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.butRemover);
            this.Controls.Add(this.butIncluir);
            this.Controls.Add(this.labelTarefa);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.Button butIncluir;
        private System.Windows.Forms.Button butRemover;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ToolTip toolData;
        private System.Windows.Forms.ToolTip toolTarefa;
    }
}

