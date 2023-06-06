using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoBan_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRootNode_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Node không được để trống");
                txtTitle.Text = string.Empty;
                txtTitle.Focus();
                return;
            }    

            TreeNode Node = new TreeNode();
            Node.Text = txtTitle.Text;
            foreach(TreeNode nodex in treeView1.Nodes)
            {
                if(Node.Text == nodex.Text)
                {
                    MessageBox.Show("Node đã tồn tại");
                    txtTitle.Clear();
                    txtTitle.Focus();
                    return;
                }    
            }    

            treeView1.Nodes.Add(Node);
            txtTitle.Clear();
            txtTitle.Focus();
        }

        private void btnAddChildNode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Node không được để trống");
                txtTitle.Text = string.Empty;
                txtTitle.Focus();
                return;
            }

            if(treeView1.SelectedNode == null)
            {
                MessageBox.Show("Bạn chưa chọn vị trí tạo Node con");
                return;
            }    

            TreeNode subNode = new TreeNode();
            subNode.Text = txtTitle.Text;

            foreach (TreeNode nodex in treeView1.SelectedNode.Nodes)
            {
                if (subNode.Text == nodex.Text)
                {
                    MessageBox.Show("Node đã tồn tại");
                    txtTitle.Clear();
                    txtTitle.Focus();
                    return;
                }
            }

            treeView1.SelectedNode.Nodes.Add(subNode);

            txtTitle.Clear();
            txtTitle.Focus();
        }

        private void btnRemoveAllNode_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xóa hết tất cả các node?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                treeView1.Nodes.Clear();
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && MessageBox.Show("Bạn muốn xóa node đã chọn không?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                treeView1.SelectedNode.Remove();
        }

        private void btnCountNode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng số node của treeView là: " + treeView1.GetNodeCount(true));
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();  // Hiển thị tất cả
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();    // Thu gọn tất cả
        }
    }
}
