namespace WFA221125_adapter
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rbFF = new System.Windows.Forms.RadioButton();
            this.rbNO = new System.Windows.Forms.RadioButton();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(21, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(650, 385);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nev";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "nem";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "szul";
            this.Column4.Name = "Column4";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(871, 43);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(306, 36);
            this.tbNev.TabIndex = 2;
            // 
            // rbFF
            // 
            this.rbFF.AutoSize = true;
            this.rbFF.Checked = true;
            this.rbFF.Location = new System.Drawing.Point(957, 124);
            this.rbFF.Name = "rbFF";
            this.rbFF.Size = new System.Drawing.Size(53, 34);
            this.rbFF.TabIndex = 3;
            this.rbFF.TabStop = true;
            this.rbFF.Text = "FF";
            this.rbFF.UseVisualStyleBackColor = true;
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Location = new System.Drawing.Point(1016, 124);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(64, 34);
            this.rbNO.TabIndex = 3;
            this.rbNO.Text = "NO";
            this.rbNO.UseVisualStyleBackColor = true;
            // 
            // dtpSzul
            // 
            this.dtpSzul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzul.Location = new System.Drawing.Point(871, 226);
            this.dtpSzul.Name = "dtpSzul";
            this.dtpSzul.Size = new System.Drawing.Size(306, 36);
            this.dtpSzul.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpSzul);
            this.Controls.Add(this.rbNO);
            this.Controls.Add(this.rbFF);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbNev;
        private RadioButton rbFF;
        private RadioButton rbNO;
        private DateTimePicker dtpSzul;
        private Button button1;
    }
}