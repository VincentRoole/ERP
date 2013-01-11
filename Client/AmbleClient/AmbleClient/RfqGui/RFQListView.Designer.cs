﻿namespace AmbleClient.RfqGui
{
    partial class RFQListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RFQListView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNewRfq = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscbAllOrMine = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbApply = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartNo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Mfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RfqStates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rohs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbMovePre = new System.Windows.Forms.ToolStripButton();
            this.tstbCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.tslCount = new System.Windows.Forms.ToolStripLabel();
            this.tsbMoveNext = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSet = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewRfq,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tscbAllOrMine,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripComboBox1,
            this.toolStripLabel4,
            this.toolStripTextBox1,
            this.tsbApply,
            this.tsbClear,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1082, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbNewRfq
            // 
            this.tsbNewRfq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewRfq.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewRfq.Image")));
            this.tsbNewRfq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewRfq.Name = "tsbNewRfq";
            this.tsbNewRfq.Size = new System.Drawing.Size(60, 22);
            this.tsbNewRfq.Text = "New RFQ";
            this.tsbNewRfq.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel2.Text = "List:";
            // 
            // tscbAllOrMine
            // 
            this.tscbAllOrMine.AutoCompleteCustomSource.AddRange(new string[] {
            "All RFQ I Can See",
            "My RFQ"});
            this.tscbAllOrMine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbAllOrMine.Items.AddRange(new object[] {
            "All RFQs I Can See",
            "My RFQ"});
            this.tscbAllOrMine.Name = "tscbAllOrMine";
            this.tscbAllOrMine.Size = new System.Drawing.Size(125, 25);
            this.tscbAllOrMine.SelectedIndexChanged += new System.EventHandler(this.tscbAllOrMine_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel3.Text = "Filter By:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Part No.",
            "Customer Name"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel4.Text = "Filter String:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbApply
            // 
            this.tsbApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbApply.Image = ((System.Drawing.Image)(resources.GetObject("tsbApply.Image")));
            this.tsbApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApply.Name = "tsbApply";
            this.tsbApply.Size = new System.Drawing.Size(42, 22);
            this.tsbApply.Text = "Apply";
            this.tsbApply.Click += new System.EventHandler(this.tsbApply_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(38, 22);
            this.tsbClear.Text = "Clear";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNo,
            this.Mfg,
            this.Dc,
            this.Qty,
            this.Resale,
            this.Cost,
            this.Customer,
            this.Date,
            this.SalePerson,
            this.RfqStates,
            this.Rohs,
            this.Alt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 436);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // PartNo
            // 
            this.PartNo.HeaderText = "Part #";
            this.PartNo.Name = "PartNo";
            this.PartNo.ReadOnly = true;
            // 
            // Mfg
            // 
            this.Mfg.HeaderText = "Mgf";
            this.Mfg.Name = "Mfg";
            this.Mfg.ReadOnly = true;
            // 
            // Dc
            // 
            this.Dc.HeaderText = "D/C";
            this.Dc.Name = "Dc";
            this.Dc.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Resale
            // 
            this.Resale.HeaderText = "Resale";
            this.Resale.Name = "Resale";
            this.Resale.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SalePerson
            // 
            this.SalePerson.HeaderText = "S/P";
            this.SalePerson.Name = "SalePerson";
            this.SalePerson.ReadOnly = true;
            // 
            // RfqStates
            // 
            this.RfqStates.HeaderText = "RFQ States";
            this.RfqStates.Name = "RfqStates";
            this.RfqStates.ReadOnly = true;
            // 
            // Rohs
            // 
            this.Rohs.HeaderText = "RoHS";
            this.Rohs.Name = "Rohs";
            this.Rohs.ReadOnly = true;
            // 
            // Alt
            // 
            this.Alt.HeaderText = "Alt";
            this.Alt.Name = "Alt";
            this.Alt.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMoveFirst,
            this.tsbMovePre,
            this.tstbCurrentPage,
            this.tslCount,
            this.tsbMoveNext,
            this.tsbMoveLast,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripTextBox2,
            this.tsbSet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1082, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbMoveFirst
            // 
            this.tsbMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveFirst.Image")));
            this.tsbMoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveFirst.Name = "tsbMoveFirst";
            this.tsbMoveFirst.Size = new System.Drawing.Size(30, 22);
            this.tsbMoveFirst.Text = "|<<";
            this.tsbMoveFirst.Click += new System.EventHandler(this.tsbMoveFirst_Click);
            // 
            // tsbMovePre
            // 
            this.tsbMovePre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMovePre.Image = ((System.Drawing.Image)(resources.GetObject("tsbMovePre.Image")));
            this.tsbMovePre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMovePre.Name = "tsbMovePre";
            this.tsbMovePre.Size = new System.Drawing.Size(23, 22);
            this.tsbMovePre.Text = "<";
            this.tsbMovePre.Click += new System.EventHandler(this.tsbMovePre_Click);
            // 
            // tstbCurrentPage
            // 
            this.tstbCurrentPage.Name = "tstbCurrentPage";
            this.tstbCurrentPage.ReadOnly = true;
            this.tstbCurrentPage.Size = new System.Drawing.Size(25, 25);
            this.tstbCurrentPage.Text = "0";
            // 
            // tslCount
            // 
            this.tslCount.Name = "tslCount";
            this.tslCount.Size = new System.Drawing.Size(29, 22);
            this.tslCount.Text = "/ {0}";
            this.tslCount.Click += new System.EventHandler(this.tslCount_Click);
            // 
            // tsbMoveNext
            // 
            this.tsbMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveNext.Image")));
            this.tsbMoveNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveNext.Name = "tsbMoveNext";
            this.tsbMoveNext.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveNext.Text = ">";
            this.tsbMoveNext.Click += new System.EventHandler(this.tsbMoveNext_Click);
            // 
            // tsbMoveLast
            // 
            this.tsbMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveLast.Image")));
            this.tsbMoveLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveLast.Name = "tsbMoveLast";
            this.tsbMoveLast.Size = new System.Drawing.Size(30, 22);
            this.tsbMoveLast.Text = ">>|";
            this.tsbMoveLast.Click += new System.EventHandler(this.tsbMoveLast_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Items Per Page:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(30, 25);
            this.toolStripTextBox2.Text = "30";
            // 
            // tsbSet
            // 
            this.tsbSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbSet.Image")));
            this.tsbSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSet.Name = "tsbSet";
            this.tsbSet.Size = new System.Drawing.Size(27, 22);
            this.tsbSet.Text = "Set";
            this.tsbSet.Click += new System.EventHandler(this.tsbSet_Click);
            // 
            // RFQListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 488);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "RFQListView";
            this.Text = "RFQListView";
            this.Load += new System.EventHandler(this.RFQView_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        protected System.Windows.Forms.ToolStripButton tsbNewRfq;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton tsbApply;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn RfqStates;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rohs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tscbAllOrMine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbMoveFirst;
        private System.Windows.Forms.ToolStripButton tsbMovePre;
        private System.Windows.Forms.ToolStripTextBox tstbCurrentPage;
        private System.Windows.Forms.ToolStripLabel tslCount;
        private System.Windows.Forms.ToolStripButton tsbMoveNext;
        private System.Windows.Forms.ToolStripButton tsbMoveLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton tsbSet;


    }
}