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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_helper_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.customer_id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidelity_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.changesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 22);
            label1.TabIndex = 3;
            label1.Text = "Customers";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 272);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 22);
            label2.TabIndex = 4;
            label2.Text = "Orders";
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.order_id, this.customer_id, this.date, this.employee_helper_id, this.progress});
            this.ordersGridView.Location = new System.Drawing.Point(12, 297);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.Size = new System.Drawing.Size(831, 223);
            this.ordersGridView.TabIndex = 0;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.Frozen = true;
            this.order_id.HeaderText = "Order ID";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.Frozen = true;
            this.customer_id.HeaderText = "Customer ID";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // employee_helper_id
            // 
            this.employee_helper_id.DataPropertyName = "employee_helper_id";
            this.employee_helper_id.HeaderText = "Employee Helper ID";
            this.employee_helper_id.Name = "employee_helper_id";
            this.employee_helper_id.Width = 200;
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.HeaderText = "Progress";
            this.progress.Items.AddRange(new object[] {"delivered", "not delivered", "in progress"});
            this.progress.Name = "progress";
            this.progress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // customersGridView
            // 
            this.customersGridView.AllowUserToAddRows = false;
            this.customersGridView.AllowUserToDeleteRows = false;
            this.customersGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.customer_id2, this.name, this.fidelity_points, this.email});
            this.customersGridView.Location = new System.Drawing.Point(12, 42);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.ReadOnly = true;
            this.customersGridView.Size = new System.Drawing.Size(831, 192);
            this.customersGridView.TabIndex = 1;
            // 
            // customer_id2
            // 
            this.customer_id2.DataPropertyName = "customer_id";
            this.customer_id2.HeaderText = "Customer ID";
            this.customer_id2.Name = "customer_id2";
            this.customer_id2.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // fidelity_points
            // 
            this.fidelity_points.DataPropertyName = "fidelity_points";
            this.fidelity_points.HeaderText = "Fidelity Points";
            this.fidelity_points.Name = "fidelity_points";
            this.fidelity_points.ReadOnly = true;
            this.fidelity_points.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
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
            this.Controls.Add(label2);
            this.Controls.Add(this.changesLabel);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customersGridView);
            this.Controls.Add(this.ordersGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize) (this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.customersGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn employee_helper_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidelity_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id2;
        private System.Windows.Forms.DataGridViewComboBoxColumn progress;
        private System.Windows.Forms.Label changesLabel;
    }
}