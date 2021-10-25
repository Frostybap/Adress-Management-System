
namespace _3.Address_Management_System
{
    partial class DisplayPersons
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
            this.textBox_Persons = new System.Windows.Forms.TextBox();
            this.listBox_Filter = new System.Windows.Forms.ListBox();
            this.label_RollNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Persons
            // 
            this.textBox_Persons.Location = new System.Drawing.Point(12, 81);
            this.textBox_Persons.Multiline = true;
            this.textBox_Persons.Name = "textBox_Persons";
            this.textBox_Persons.ReadOnly = true;
            this.textBox_Persons.Size = new System.Drawing.Size(1038, 580);
            this.textBox_Persons.TabIndex = 0;
            // 
            // listBox_Filter
            // 
            this.listBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Filter.FormattingEnabled = true;
            this.listBox_Filter.ItemHeight = 22;
            this.listBox_Filter.Items.AddRange(new object[] {
            "Type",
            "Name",
            "Creation Date"});
            this.listBox_Filter.Location = new System.Drawing.Point(174, 5);
            this.listBox_Filter.Name = "listBox_Filter";
            this.listBox_Filter.Size = new System.Drawing.Size(261, 70);
            this.listBox_Filter.TabIndex = 0;
            this.listBox_Filter.SelectedIndexChanged += new System.EventHandler(this.listBox_Filter_SelectedIndexChanged);
            // 
            // label_RollNumber
            // 
            this.label_RollNumber.AutoSize = true;
            this.label_RollNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RollNumber.Location = new System.Drawing.Point(67, 29);
            this.label_RollNumber.Name = "label_RollNumber";
            this.label_RollNumber.Size = new System.Drawing.Size(91, 24);
            this.label_RollNumber.TabIndex = 13;
            this.label_RollNumber.Text = "Filter by:";
            // 
            // DisplayPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.label_RollNumber);
            this.Controls.Add(this.listBox_Filter);
            this.Controls.Add(this.textBox_Persons);
            this.Name = "DisplayPersons";
            this.Text = "Persons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Persons;
        private System.Windows.Forms.ListBox listBox_Filter;
        private System.Windows.Forms.Label label_RollNumber;
    }
}