namespace Csharp_171180008_7_
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
            this.PreOrderButton = new System.Windows.Forms.Button();
            this.Eklebutton = new System.Windows.Forms.Button();
            this.EkleTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inlstbox = new System.Windows.Forms.ListBox();
            this.prelistbox = new System.Windows.Forms.ListBox();
            this.postlstbox = new System.Windows.Forms.ListBox();
            this.PostOrderbutton = new System.Windows.Forms.Button();
            this.inorderbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.siltextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aramabutton = new System.Windows.Forms.Button();
            this.sonuclstbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PreOrderButton
            // 
            this.PreOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PreOrderButton.Location = new System.Drawing.Point(542, 409);
            this.PreOrderButton.Name = "PreOrderButton";
            this.PreOrderButton.Size = new System.Drawing.Size(75, 23);
            this.PreOrderButton.TabIndex = 19;
            this.PreOrderButton.Text = "Pre Order";
            this.PreOrderButton.UseVisualStyleBackColor = true;
            this.PreOrderButton.Visible = false;
            this.PreOrderButton.Click += new System.EventHandler(this.PreOrderButton_Click);
            // 
            // Eklebutton
            // 
            this.Eklebutton.BackColor = System.Drawing.Color.Transparent;
            this.Eklebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eklebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Eklebutton.Location = new System.Drawing.Point(556, 59);
            this.Eklebutton.Name = "Eklebutton";
            this.Eklebutton.Size = new System.Drawing.Size(75, 23);
            this.Eklebutton.TabIndex = 18;
            this.Eklebutton.Text = "EKLE";
            this.Eklebutton.UseVisualStyleBackColor = false;
            this.Eklebutton.Click += new System.EventHandler(this.Eklebutton_Click);
            // 
            // EkleTxtbox
            // 
            this.EkleTxtbox.Location = new System.Drawing.Point(542, 33);
            this.EkleTxtbox.Name = "EkleTxtbox";
            this.EkleTxtbox.Size = new System.Drawing.Size(100, 20);
            this.EkleTxtbox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(310, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "INORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(149, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "PREORDER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "POSTORDER";
            // 
            // inlstbox
            // 
            this.inlstbox.FormattingEnabled = true;
            this.inlstbox.Location = new System.Drawing.Point(304, 33);
            this.inlstbox.Name = "inlstbox";
            this.inlstbox.Size = new System.Drawing.Size(149, 238);
            this.inlstbox.TabIndex = 13;
            // 
            // prelistbox
            // 
            this.prelistbox.FormattingEnabled = true;
            this.prelistbox.Location = new System.Drawing.Point(149, 33);
            this.prelistbox.Name = "prelistbox";
            this.prelistbox.Size = new System.Drawing.Size(149, 238);
            this.prelistbox.TabIndex = 12;
            // 
            // postlstbox
            // 
            this.postlstbox.FormattingEnabled = true;
            this.postlstbox.Location = new System.Drawing.Point(9, 33);
            this.postlstbox.Name = "postlstbox";
            this.postlstbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.postlstbox.Size = new System.Drawing.Size(134, 238);
            this.postlstbox.TabIndex = 11;
            // 
            // PostOrderbutton
            // 
            this.PostOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostOrderbutton.Location = new System.Drawing.Point(645, 409);
            this.PostOrderbutton.Name = "PostOrderbutton";
            this.PostOrderbutton.Size = new System.Drawing.Size(75, 23);
            this.PostOrderbutton.TabIndex = 20;
            this.PostOrderbutton.Text = "PostOrder";
            this.PostOrderbutton.UseVisualStyleBackColor = true;
            this.PostOrderbutton.Visible = false;
            this.PostOrderbutton.Click += new System.EventHandler(this.PostOrderbutton_Click);
            // 
            // inorderbutton
            // 
            this.inorderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inorderbutton.Location = new System.Drawing.Point(445, 409);
            this.inorderbutton.Name = "inorderbutton";
            this.inorderbutton.Size = new System.Drawing.Size(75, 23);
            this.inorderbutton.TabIndex = 21;
            this.inorderbutton.Text = "InOrder";
            this.inorderbutton.UseVisualStyleBackColor = true;
            this.inorderbutton.Visible = false;
            this.inorderbutton.Click += new System.EventHandler(this.inorderbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(603, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siltextbox
            // 
            this.siltextbox.Location = new System.Drawing.Point(542, 123);
            this.siltextbox.Name = "siltextbox";
            this.siltextbox.Size = new System.Drawing.Size(100, 20);
            this.siltextbox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // aramabutton
            // 
            this.aramabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aramabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramabutton.Location = new System.Drawing.Point(498, 167);
            this.aramabutton.Name = "aramabutton";
            this.aramabutton.Size = new System.Drawing.Size(75, 23);
            this.aramabutton.TabIndex = 25;
            this.aramabutton.Text = "ARA";
            this.aramabutton.UseVisualStyleBackColor = true;
            this.aramabutton.Click += new System.EventHandler(this.aramabutton_Click);
            // 
            // sonuclstbox
            // 
            this.sonuclstbox.FormattingEnabled = true;
            this.sonuclstbox.Location = new System.Drawing.Point(12, 303);
            this.sonuclstbox.Name = "sonuclstbox";
            this.sonuclstbox.Size = new System.Drawing.Size(248, 147);
            this.sonuclstbox.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(696, 476);
            this.Controls.Add(this.sonuclstbox);
            this.Controls.Add(this.aramabutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.siltextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inorderbutton);
            this.Controls.Add(this.PostOrderbutton);
            this.Controls.Add(this.PreOrderButton);
            this.Controls.Add(this.Eklebutton);
            this.Controls.Add(this.EkleTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inlstbox);
            this.Controls.Add(this.prelistbox);
            this.Controls.Add(this.postlstbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreOrderButton;
        private System.Windows.Forms.Button Eklebutton;
        public System.Windows.Forms.TextBox EkleTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox inlstbox;
        private System.Windows.Forms.ListBox prelistbox;
        private System.Windows.Forms.ListBox postlstbox;
        private System.Windows.Forms.Button PostOrderbutton;
        private System.Windows.Forms.Button inorderbutton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox siltextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aramabutton;
        private System.Windows.Forms.ListBox sonuclstbox;
    }
}

