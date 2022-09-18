using System.ComponentModel;

namespace TCP_Private_Client
{
    partial class Form_NewGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.listBoxUserOnline = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxGroupMember = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(235, 31);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(498, 20);
            this.textBoxGroupName.TabIndex = 1;
            // 
            // listBoxUserOnline
            // 
            this.listBoxUserOnline.FormattingEnabled = true;
            this.listBoxUserOnline.Location = new System.Drawing.Point(38, 103);
            this.listBoxUserOnline.Name = "listBoxUserOnline";
            this.listBoxUserOnline.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxUserOnline.Size = new System.Drawing.Size(293, 264);
            this.listBoxUserOnline.TabIndex = 2;
            this.listBoxUserOnline.SelectedIndexChanged += new System.EventHandler(this.listBoxUserOnline_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(348, 175);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 50);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxGroupMember
            // 
            this.listBoxGroupMember.FormattingEnabled = true;
            this.listBoxGroupMember.Location = new System.Drawing.Point(440, 103);
            this.listBoxGroupMember.Name = "listBoxGroupMember";
            this.listBoxGroupMember.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGroupMember.Size = new System.Drawing.Size(293, 264);
            this.listBoxGroupMember.TabIndex = 5;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(348, 278);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(77, 50);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(290, 388);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(193, 50);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // Form_NewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxGroupMember);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxUserOnline);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.label1);
            this.Name = "Form_NewGroup";
            this.Text = "New Group";
            this.Load += new System.EventHandler(this.Form_NewGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonDone;

        private System.Windows.Forms.Button buttonRemove;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.ListBox listBoxGroupMember;

        private System.Windows.Forms.ListBox listBoxUserOnline;
        
        private System.Windows.Forms.TextBox textBoxGroupName;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}