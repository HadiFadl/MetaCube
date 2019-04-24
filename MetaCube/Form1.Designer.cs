namespace MetaCube
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Data Source");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Data Source View");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Partition");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Aggregation Design");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Measure Group", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cube", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Mining Structure");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Role");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Server", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerNametextbox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(227, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ServerNametextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 45);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Retrieve objects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // ServerNametextbox
            // 
            this.ServerNametextbox.Location = new System.Drawing.Point(61, 13);
            this.ServerNametextbox.Name = "ServerNametextbox";
            this.ServerNametextbox.Size = new System.Drawing.Size(351, 20);
            this.ServerNametextbox.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 45);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Data Source";
            treeNode1.Tag = "2";
            treeNode1.Text = "Data Source";
            treeNode2.Name = "Data Source View";
            treeNode2.Tag = "2";
            treeNode2.Text = "Data Source View";
            treeNode3.Name = "Dimension";
            treeNode3.Tag = "2";
            treeNode3.Text = "Dimension";
            treeNode4.Name = "Partition";
            treeNode4.Tag = "4";
            treeNode4.Text = "Partition";
            treeNode5.Name = "Aggregation Design";
            treeNode5.Tag = "4";
            treeNode5.Text = "Aggregation Design";
            treeNode6.Name = "Measure Group";
            treeNode6.Tag = "3";
            treeNode6.Text = "Measure Group";
            treeNode7.Name = "Cube";
            treeNode7.Tag = "2";
            treeNode7.Text = "Cube";
            treeNode8.Name = "Mining Structure";
            treeNode8.Tag = "2";
            treeNode8.Text = "Mining Structure";
            treeNode9.Name = "Role";
            treeNode9.Tag = "2";
            treeNode9.Text = "Role";
            treeNode10.Name = "Database";
            treeNode10.Tag = "1";
            treeNode10.Text = "Database";
            treeNode11.Name = "Server";
            treeNode11.Tag = "0";
            treeNode11.Text = "Server";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(227, 445);
            this.treeView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerNametextbox;
        private System.Windows.Forms.TreeView treeView1;
    }
}

