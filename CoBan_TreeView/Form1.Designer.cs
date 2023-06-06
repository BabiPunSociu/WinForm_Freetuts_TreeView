namespace CoBan_TreeView
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.btnAddRootNode = new System.Windows.Forms.Button();
			this.btnAddChildNode = new System.Windows.Forms.Button();
			this.btnRemoveAllNode = new System.Windows.Forms.Button();
			this.btnRemoveNode = new System.Windows.Forms.Button();
			this.btnCountNode = new System.Windows.Forms.Button();
			this.btnCong = new System.Windows.Forms.Button();
			this.btnTru = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "TreeView";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(452, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tiêu đề Node";
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(570, 59);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(217, 22);
			this.txtTitle.TabIndex = 2;
			// 
			// btnAddRootNode
			// 
			this.btnAddRootNode.Location = new System.Drawing.Point(461, 112);
			this.btnAddRootNode.Name = "btnAddRootNode";
			this.btnAddRootNode.Size = new System.Drawing.Size(326, 38);
			this.btnAddRootNode.TabIndex = 3;
			this.btnAddRootNode.Text = "Thêm Node gốc";
			this.btnAddRootNode.UseVisualStyleBackColor = true;
			this.btnAddRootNode.Click += new System.EventHandler(this.btnAddRootNode_Click);
			// 
			// btnAddChildNode
			// 
			this.btnAddChildNode.Location = new System.Drawing.Point(461, 169);
			this.btnAddChildNode.Name = "btnAddChildNode";
			this.btnAddChildNode.Size = new System.Drawing.Size(326, 38);
			this.btnAddChildNode.TabIndex = 4;
			this.btnAddChildNode.Text = "Thêm Node con";
			this.btnAddChildNode.UseVisualStyleBackColor = true;
			this.btnAddChildNode.Click += new System.EventHandler(this.btnAddChildNode_Click);
			// 
			// btnRemoveAllNode
			// 
			this.btnRemoveAllNode.Location = new System.Drawing.Point(461, 227);
			this.btnRemoveAllNode.Name = "btnRemoveAllNode";
			this.btnRemoveAllNode.Size = new System.Drawing.Size(326, 38);
			this.btnRemoveAllNode.TabIndex = 5;
			this.btnRemoveAllNode.Text = "Xóa tất cả các Node";
			this.btnRemoveAllNode.UseVisualStyleBackColor = true;
			this.btnRemoveAllNode.Click += new System.EventHandler(this.btnRemoveAllNode_Click);
			// 
			// btnRemoveNode
			// 
			this.btnRemoveNode.Location = new System.Drawing.Point(461, 289);
			this.btnRemoveNode.Name = "btnRemoveNode";
			this.btnRemoveNode.Size = new System.Drawing.Size(326, 38);
			this.btnRemoveNode.TabIndex = 6;
			this.btnRemoveNode.Text = "Xóa Node đang chọn";
			this.btnRemoveNode.UseVisualStyleBackColor = true;
			this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
			// 
			// btnCountNode
			// 
			this.btnCountNode.Location = new System.Drawing.Point(461, 350);
			this.btnCountNode.Name = "btnCountNode";
			this.btnCountNode.Size = new System.Drawing.Size(326, 38);
			this.btnCountNode.TabIndex = 7;
			this.btnCountNode.Text = "Đếm tổng Node TreeView";
			this.btnCountNode.UseVisualStyleBackColor = true;
			this.btnCountNode.Click += new System.EventHandler(this.btnCountNode_Click);
			// 
			// btnCong
			// 
			this.btnCong.Location = new System.Drawing.Point(462, 405);
			this.btnCong.Name = "btnCong";
			this.btnCong.Size = new System.Drawing.Size(71, 40);
			this.btnCong.TabIndex = 8;
			this.btnCong.Text = "+";
			this.btnCong.UseVisualStyleBackColor = true;
			this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
			// 
			// btnTru
			// 
			this.btnTru.Location = new System.Drawing.Point(716, 405);
			this.btnTru.Name = "btnTru";
			this.btnTru.Size = new System.Drawing.Size(71, 40);
			this.btnTru.TabIndex = 9;
			this.btnTru.Text = "-";
			this.btnTru.UseVisualStyleBackColor = true;
			this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.Color.LightGreen;
			this.treeView1.ForeColor = System.Drawing.Color.Red;
			this.treeView1.Location = new System.Drawing.Point(12, 48);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(430, 396);
			this.treeView1.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.btnTru);
			this.Controls.Add(this.btnCong);
			this.Controls.Add(this.btnCountNode);
			this.Controls.Add(this.btnRemoveNode);
			this.Controls.Add(this.btnRemoveAllNode);
			this.Controls.Add(this.btnAddChildNode);
			this.Controls.Add(this.btnAddRootNode);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TreeView";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddRootNode;
        private System.Windows.Forms.Button btnAddChildNode;
        private System.Windows.Forms.Button btnRemoveAllNode;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.Button btnCountNode;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.TreeView treeView1;
    }
}

