using System.Windows.Forms;

namespace HamPizza
{
    partial class SeeOrders
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
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLess20 = new System.Windows.Forms.Button();
            this.btnForJohn = new System.Windows.Forms.Button();
            this.btnWithHam = new System.Windows.Forms.Button();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrders
            // 
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridOrders.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Location = new System.Drawing.Point(22, 68);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RowHeadersWidth = 51;
            this.gridOrders.RowTemplate.Height = 29;
            this.gridOrders.Size = new System.Drawing.Size(1097, 499);
            this.gridOrders.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(564, 591);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 51);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLess20
            // 
            this.btnLess20.BackColor = System.Drawing.Color.Firebrick;
            this.btnLess20.FlatAppearance.BorderSize = 0;
            this.btnLess20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLess20.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLess20.ForeColor = System.Drawing.Color.Transparent;
            this.btnLess20.Location = new System.Drawing.Point(1140, 87);
            this.btnLess20.Name = "btnLess20";
            this.btnLess20.Size = new System.Drawing.Size(208, 69);
            this.btnLess20.TabIndex = 21;
            this.btnLess20.Text = "Orders Less than $20";
            this.btnLess20.UseVisualStyleBackColor = false;
            this.btnLess20.Click += new System.EventHandler(this.btnLess20_Click);
            // 
            // btnForJohn
            // 
            this.btnForJohn.BackColor = System.Drawing.Color.Firebrick;
            this.btnForJohn.FlatAppearance.BorderSize = 0;
            this.btnForJohn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForJohn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnForJohn.ForeColor = System.Drawing.Color.Transparent;
            this.btnForJohn.Location = new System.Drawing.Point(1140, 206);
            this.btnForJohn.Name = "btnForJohn";
            this.btnForJohn.Size = new System.Drawing.Size(208, 69);
            this.btnForJohn.TabIndex = 22;
            this.btnForJohn.Text = "Orders For John";
            this.btnForJohn.UseVisualStyleBackColor = false;
            this.btnForJohn.Click += new System.EventHandler(this.btnForJohn_Click);
            // 
            // btnWithHam
            // 
            this.btnWithHam.BackColor = System.Drawing.Color.Firebrick;
            this.btnWithHam.FlatAppearance.BorderSize = 0;
            this.btnWithHam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithHam.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnWithHam.ForeColor = System.Drawing.Color.Transparent;
            this.btnWithHam.Location = new System.Drawing.Point(1140, 327);
            this.btnWithHam.Name = "btnWithHam";
            this.btnWithHam.Size = new System.Drawing.Size(208, 69);
            this.btnWithHam.TabIndex = 23;
            this.btnWithHam.Text = "Orders with Ham Topping";
            this.btnWithHam.UseVisualStyleBackColor = false;
            this.btnWithHam.Click += new System.EventHandler(this.btnWithHam_Click);
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.BackColor = System.Drawing.Color.Firebrick;
            this.btnAllOrders.FlatAppearance.BorderSize = 0;
            this.btnAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrders.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnAllOrders.ForeColor = System.Drawing.Color.Transparent;
            this.btnAllOrders.Location = new System.Drawing.Point(1140, 447);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(208, 69);
            this.btnAllOrders.TabIndex = 24;
            this.btnAllOrders.Text = "Show all Orders";
            this.btnAllOrders.UseVisualStyleBackColor = false;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(569, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "See Orders";
            // 
            // SeeOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1360, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.btnWithHam);
            this.Controls.Add(this.btnForJohn);
            this.Controls.Add(this.btnLess20);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridOrders);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SeeOrders";
            this.Text = "See Orders";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridOrders;
        private Button btnClose;
        private Button btnLess20;
        private Button btnForJohn;
        private Button btnWithHam;
        private Button btnAllOrders;
        private Label label1;
    }
}