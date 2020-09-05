using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_171180008_7_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        static int count = -1;
        static int incount = 1;
        static int postcount = 1;
        static int precount = 1;
       
        public class Bst
        {
            public int sayi;
            public Bst left, right;
            public Bst(int sayi, Bst left, Bst right)
            {
                this.sayi = sayi;
                this.left = left;
                this.right = right;
            }
        }
       Bst Node = new Bst(0, null, null);
        private void AddTree()
        {

            Bst yeninode = new Bst(Convert.ToInt32(EkleTxtbox.Text), null, null);
            if (Node.sayi == 0)
            {
                Node.sayi = Convert.ToInt32(EkleTxtbox.Text);

            }
            else
            {
                Bst current = Node;
                Bst parent;
                while (true)
                {
                    parent = current;
                    if (yeninode.sayi < current.sayi)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = yeninode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = yeninode;
                            break;
                        }
                    }
                }




            }
        }

        public void PreOrder(Bst Node)
        {

            prelistbox.Items.Add(Node.sayi);
            if (Node.left != null) PreOrder(Node.left);
            if (Node.right != null) PreOrder(Node.right);
        }
        private void PostOrder(Bst node)
        {

           
              if (node.left != null) PostOrder(node.left);

                if (node.right != null) PostOrder(node.right);

                postlstbox.Items.Add(node.sayi); 
            
        
        }
        private void Orderara(int key)
        {

            for (int i = 0; i < postlstbox.Items.Count; i++)
            {
                if (Convert.ToInt32(postlstbox.Items[i])==(key))
                {
                    sonuclstbox.Items.Add("postorder sıra : " + postcount);
                }
                else
                {
                    postcount++;
                }
            }
           
            for (int i = 0; i < prelistbox.Items.Count; i++)
            {
                if (Convert.ToInt32(prelistbox.Items[i]) == (key))
                {
                    sonuclstbox.Items.Add("preorder sıra : " + precount);
                }
                else
                {
                    precount++;
                }
            }
            for (int i = 0; i < inlstbox.Items.Count; i++)
            {
                if (Convert.ToInt32(inlstbox.Items[i]) == (key))
                {
                    sonuclstbox.Items.Add("inorder sıra : " + incount);
                }
                else
                {
                    incount++;
                }
            }


        }
        int minValue(Bst root)
        {
            int minv = root.sayi;
            while (root.left != null)
            {
                minv = root.left.sayi;
                root = root.left;
            }
            return minv;
        }
        Bst Deletion(Bst rootnode, int sayi)
        {
            if (rootnode == null)
            {
                return rootnode;
            }
            if (sayi < rootnode.sayi)
                rootnode.left = Deletion(rootnode.left, sayi);
            else if (sayi > rootnode.sayi)
                rootnode.right = Deletion(rootnode.right, sayi);
            else
            {
                // bir child varsa
                if (rootnode.left == null)
                    return rootnode.right;
                else if (rootnode.right == null)
                    return rootnode.left;

                // iki child 
                rootnode.sayi = minValue(rootnode.right);

              
                rootnode.right = Deletion(rootnode.right, rootnode.sayi);
            }

            return rootnode;
        }
        private void Eklebutton_Click(object sender, EventArgs e)
        {
           
            AddTree(); 
            EkleTxtbox.Clear();
            inlstbox.Items.Clear();
            inOrder(Node);
            postlstbox.Items.Clear();
            PostOrder(Node);
            prelistbox.Items.Clear();
            PreOrder(Node);
        }

        private void PreOrderButton_Click(object sender, EventArgs e)//Dolaşmalar için ayrı buton istendiğini sanmıştım. Yanlışlıkla açıldılar.
        {

           
        }

        private void PostOrderbutton_Click(object sender, EventArgs e)
        {
           

        }
        private void inOrder(Bst node)
        {
            if (node.left != null) inOrder(node.left);
            inlstbox.Items.Add(node.sayi);
            if (node.right != null) inOrder(node.right);
        }

        private void inorderbutton_Click(object sender, EventArgs e)
        {
            

        }
       
  
        public void findParent(Bst node,  int key, int parent) 
{ 
    if (node == null) 
        return; 
  
  
    if (node.sayi == key)  
    {

        if (node.sayi == Node.sayi)
        {
            sonuclstbox.Items.Add("Root node");
        }
        else
        {
            
        }
    } 
    else 
    { 
  
       
        findParent(node.left, key, node.sayi); 
        findParent(node.right, key, node.sayi); 
    } 
}
        private void FindNode(int sayi, Bst node, ListBox x)
        {count++;
            if (node.sayi == 0) x.Items.Add("boş");
            else if ((sayi < node.sayi) && (node.left != null))
            { FindNode(sayi, node.left, x);
            
            }
            else if ((sayi > node.sayi) && (node.right != null)) FindNode(sayi, node.right, x);
            else if (sayi == node.sayi)
                if (node.sayi == sayi)
                {


                    x.Items.Add(sayi + "  bulundu");
                    x.Items.Add("Depth : " + count);
                    if (node.right != null && node.left != null)
                    {
                        x.Items.Add("children : " + node.left.sayi +" "+ node.right.sayi);
                    }
                    else if (node.right == null && node.left != null)
                    {
                        x.Items.Add("child : " + node.left.sayi);
                    }
                    else if (node.right != null && node.left == null)
                    {
                        x.Items.Add("children : " + node.right.sayi);
                    }
                    else
                    {
                        x.Items.Add("Children : NULL");
                    }

                }


                else sonuclstbox.Items.Add("Sayı bulunamadı");
           

        }
        private void find(int sayi, Bst node)
        {
            if (node.sayi == 0) label4.Text = "Boş ağaç";
            else if ((sayi < node.sayi) && (node.left != null)) find(sayi, node.left);
            else if ((sayi > node.sayi) && (node.right != null)) find(sayi, node.right);
            else if (sayi == node.sayi) label4.Text = "1";
            else label4.Text = "2";
        }
        private void button1_Click(object sender, EventArgs e)//SİLME BUTONU
        {
            
            int key = Convert.ToInt32(siltextbox.Text);
            find(key, Node);
            if (Convert.ToInt32(label4.Text) == 2)
            {
                MessageBox.Show("Bu eleman ağaçta bulunmamaktadır!!!");
            }
            else
            {
                Deletion(Node, key);
                prelistbox.Items.Clear();
                PreOrder(Node);
                inlstbox.Items.Clear();
                inOrder(Node);
                postlstbox.Items.Clear();
                PostOrder(Node);
                MessageBox.Show("silindi!!!");
            }
            siltextbox.Clear();
        }

        private void aramabutton_Click(object sender, EventArgs e)
        {
            postcount = 1;
            precount = 1;
            incount = 1;
           
            sonuclstbox.Items.Clear();
            count = -1;
            int key = Convert.ToInt32(siltextbox.Text);
            
           
           FindNode(key,Node,sonuclstbox);
           findParent(Node, key,-1);
           Orderara(key);
           
            siltextbox.Clear();
        }
    }
}