namespace lab7
{
    partial class Staff_Manage
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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(86, 40);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 30);
            this.Add.TabIndex = 0;
            this.Add.Text = "添加员工信息";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(86, 107);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 30);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "删除员工信息";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(86, 182);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 30);
            this.Update.TabIndex = 2;
            this.Update.Text = "更改员工信息";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Staff_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "Staff_Manage";
            this.Text = "Staff_Manage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
    }
}