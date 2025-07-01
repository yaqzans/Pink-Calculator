namespace Calculator
{
    partial class History
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
            this.components = new System.ComponentModel.Container();
            this.btnback = new System.Windows.Forms.Button();
            this.calculatorDataSet = new Calculator.CalculatorDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new Calculator.CalculatorDataSetTableAdapters.HistoryTableAdapter();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.btnload = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(277, 258);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 33);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // calculatorDataSet
            // 
            this.calculatorDataSet.DataSetName = "CalculatorDataSet";
            this.calculatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.calculatorDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // dgmain
            // 
            this.dgmain.AllowUserToAddRows = false;
            this.dgmain.AllowUserToDeleteRows = false;
            this.dgmain.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.GridColor = System.Drawing.Color.DeepPink;
            this.dgmain.Location = new System.Drawing.Point(12, 12);
            this.dgmain.Name = "dgmain";
            this.dgmain.ReadOnly = true;
            this.dgmain.RowHeadersWidth = 62;
            this.dgmain.RowTemplate.Height = 28;
            this.dgmain.Size = new System.Drawing.Size(340, 231);
            this.dgmain.TabIndex = 1;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(12, 258);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 33);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(142, 258);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 33);
            this.btnclr.TabIndex = 3;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(364, 303);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.dgmain);
            this.Controls.Add(this.btnback);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calculatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private CalculatorDataSet calculatorDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private CalculatorDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnclr;
    }
}