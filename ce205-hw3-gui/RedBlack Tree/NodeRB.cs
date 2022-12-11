using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_gui.RedBlack_Tree
{
    public class NodeRB
    {
        public string value;
        public NodeRB left, right;
        public string idLingkaran;
        public NodeRB parent;
        public int x, y;
        public Color color;
        public Boolean sentinel;
        public Boolean isRight;
        public int height;
        public Boolean passed = false;

        public NodeRB(string value, string idLingkaran)
        {
            this.value = value;
            this.left = null;
            this.right = null;
            this.parent = null;
            this.idLingkaran = idLingkaran;
            color = Color.Red;
            this.sentinel = false;
            this.height = 1;
        }
        public NodeRB(string value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
            this.parent = null;
            color = Color.Red;
            this.sentinel = false;
            this.height = 1;
        }
        public NodeRB()
        {
            this.left = null;
            this.right = null;
            this.parent = null;
            color = Color.Red;
            this.sentinel = true;
            this.height = 1;
        }
    }
}
