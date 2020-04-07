using System.ComponentModel;

namespace DBMSLab
{
    partial class MainWindow
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
            this.labelParent = new System.Windows.Forms.Label();
            this.labelChild = new System.Windows.Forms.Label();
            this.childGridView = new System.Windows.Forms.DataGridView();
            this.parentGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.changesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.childGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.parentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelParent
            // 
            this.labelParent.Location = new System.Drawing.Point(12, 16);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(85, 22);
            this.labelParent.TabIndex = 3;
            this.labelParent.Text = "Customers";
            // 
            // labelChild
            // 
            this.labelChild.Location = new System.Drawing.Point(12, 272);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(85, 22);
            this.labelChild.TabIndex = 4;
            this.labelChild.Text = "Orders";
            // 
            // childGridView
            // 
            this.childGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childGridView.Location = new System.Drawing.Point(12, 297);
            this.childGridView.Name = "childGridView";
            this.childGridView.Size = new System.Drawing.Size(831, 223);
            this.childGridView.TabIndex = 0;
            // 
            // parentGridView
            // 
            this.parentGridView.AllowUserToAddRows = false;
            this.parentGridView.AllowUserToDeleteRows = false;
            this.parentGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentGridView.Location = new System.Drawing.Point(12, 42);
            this.parentGridView.Name = "parentGridView";
            this.parentGridView.ReadOnly = true;
            this.parentGridView.Size = new System.Drawing.Size(831, 192);
            this.parentGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changesLabel
            // 
            this.changesLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.changesLabel.Location = new System.Drawing.Point(874, 392);
            this.changesLabel.Name = "changesLabel";
            this.changesLabel.Size = new System.Drawing.Size(129, 22);
            this.changesLabel.TabIndex = 3;
            this.changesLabel.Text = "Changes saved";
            this.changesLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 532);
            this.Controls.Add(this.labelChild);
            this.Controls.Add(this.changesLabel);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parentGridView);
            this.Controls.Add(this.childGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize) (this.childGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.parentGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView parentGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label changesLabel;
        private System.Windows.Forms.Label labelChild;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.DataGridView childGridView;
    }
}