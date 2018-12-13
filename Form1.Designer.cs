namespace menus
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PROGRAMS", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Student_REG");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("STUDENTS", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.Kib = new System.Windows.Forms.Panel();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Kib
            // 
            this.Kib.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Kib.Location = new System.Drawing.Point(135, 9);
            this.Kib.Name = "Kib";
            this.Kib.Size = new System.Drawing.Size(827, 475);
            this.Kib.TabIndex = 1;
            // 
            // treeView3
            // 
            this.treeView3.HideSelection = false;
            this.treeView3.Location = new System.Drawing.Point(0, 9);
            this.treeView3.Name = "treeView3";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Calculator";
            treeNode10.Checked = true;
            treeNode10.Name = "Node0";
            treeNode10.Text = "PROGRAMS";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Student_REG";
            treeNode12.Name = "Node3";
            treeNode12.Text = "STUDENTS";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode12});
            this.treeView3.ShowNodeToolTips = true;
            this.treeView3.Size = new System.Drawing.Size(129, 444);
            this.treeView3.TabIndex = 2;
            this.treeView3.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView3_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 465);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.Kib);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Kib;
        private System.Windows.Forms.TreeView treeView3;
    }
}

