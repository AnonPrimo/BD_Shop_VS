namespace BD_Shop_VS
{
    partial class Doc_TovarForm
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
            this.dataGridViewDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTovar = new System.Windows.Forms.DataGridView();
            this.groupBoxFin = new System.Windows.Forms.GroupBox();
            this.labelDolg = new System.Windows.Forms.Label();
            this.labelOpl = new System.Windows.Forms.Label();
            this.labelSumm = new System.Windows.Forms.Label();
            this.textBoxDolg = new System.Windows.Forms.TextBox();
            this.textBoxOplata = new System.Windows.Forms.TextBox();
            this.textBoxSumm = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDataTo = new System.Windows.Forms.Label();
            this.textBoxDataTo = new System.Windows.Forms.TextBox();
            this.lableDataFrom = new System.Windows.Forms.Label();
            this.textBoxDataFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).BeginInit();
            this.groupBoxFin.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDoc
            // 
            this.dataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoc.Location = new System.Drawing.Point(13, 71);
            this.dataGridViewDoc.MultiSelect = false;
            this.dataGridViewDoc.Name = "dataGridViewDoc";
            this.dataGridViewDoc.RowHeadersWidth = 30;
            this.dataGridViewDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoc.Size = new System.Drawing.Size(357, 434);
            this.dataGridViewDoc.TabIndex = 0;
            this.dataGridViewDoc.Click += new System.EventHandler(this.dataGridViewDoc_Click);
            // 
            // dataGridViewTovar
            // 
            this.dataGridViewTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTovar.Location = new System.Drawing.Point(389, 135);
            this.dataGridViewTovar.MultiSelect = false;
            this.dataGridViewTovar.Name = "dataGridViewTovar";
            this.dataGridViewTovar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTovar.Size = new System.Drawing.Size(473, 370);
            this.dataGridViewTovar.TabIndex = 1;
            // 
            // groupBoxFin
            // 
            this.groupBoxFin.Controls.Add(this.labelDolg);
            this.groupBoxFin.Controls.Add(this.labelOpl);
            this.groupBoxFin.Controls.Add(this.labelSumm);
            this.groupBoxFin.Controls.Add(this.textBoxDolg);
            this.groupBoxFin.Controls.Add(this.textBoxOplata);
            this.groupBoxFin.Controls.Add(this.textBoxSumm);
            this.groupBoxFin.Location = new System.Drawing.Point(389, 12);
            this.groupBoxFin.Name = "groupBoxFin";
            this.groupBoxFin.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFin.TabIndex = 2;
            this.groupBoxFin.TabStop = false;
            this.groupBoxFin.Text = "Financial";
            // 
            // labelDolg
            // 
            this.labelDolg.AutoSize = true;
            this.labelDolg.Location = new System.Drawing.Point(16, 75);
            this.labelDolg.Name = "labelDolg";
            this.labelDolg.Size = new System.Drawing.Size(29, 13);
            this.labelDolg.TabIndex = 5;
            this.labelDolg.Text = "Dolg";
            // 
            // labelOpl
            // 
            this.labelOpl.AutoSize = true;
            this.labelOpl.Location = new System.Drawing.Point(16, 49);
            this.labelOpl.Name = "labelOpl";
            this.labelOpl.Size = new System.Drawing.Size(38, 13);
            this.labelOpl.TabIndex = 4;
            this.labelOpl.Text = "Oplata";
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(16, 23);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(36, 13);
            this.labelSumm.TabIndex = 3;
            this.labelSumm.Text = "Summ";
            // 
            // textBoxDolg
            // 
            this.textBoxDolg.Location = new System.Drawing.Point(81, 72);
            this.textBoxDolg.Name = "textBoxDolg";
            this.textBoxDolg.Size = new System.Drawing.Size(100, 20);
            this.textBoxDolg.TabIndex = 2;
            // 
            // textBoxOplata
            // 
            this.textBoxOplata.Location = new System.Drawing.Point(81, 46);
            this.textBoxOplata.Name = "textBoxOplata";
            this.textBoxOplata.Size = new System.Drawing.Size(100, 20);
            this.textBoxOplata.TabIndex = 1;
            // 
            // textBoxSumm
            // 
            this.textBoxSumm.Location = new System.Drawing.Point(81, 20);
            this.textBoxSumm.Name = "textBoxSumm";
            this.textBoxSumm.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumm.TabIndex = 0;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.button1);
            this.groupBoxData.Controls.Add(this.labelDataTo);
            this.groupBoxData.Controls.Add(this.textBoxDataTo);
            this.groupBoxData.Controls.Add(this.lableDataFrom);
            this.groupBoxData.Controls.Add(this.textBoxDataFrom);
            this.groupBoxData.Location = new System.Drawing.Point(13, 4);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(364, 45);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDataTo
            // 
            this.labelDataTo.AutoSize = true;
            this.labelDataTo.Location = new System.Drawing.Point(150, 14);
            this.labelDataTo.Name = "labelDataTo";
            this.labelDataTo.Size = new System.Drawing.Size(20, 13);
            this.labelDataTo.TabIndex = 7;
            this.labelDataTo.Text = "To";
            // 
            // textBoxDataTo
            // 
            this.textBoxDataTo.Location = new System.Drawing.Point(176, 14);
            this.textBoxDataTo.Name = "textBoxDataTo";
            this.textBoxDataTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataTo.TabIndex = 6;
            // 
            // lableDataFrom
            // 
            this.lableDataFrom.AutoSize = true;
            this.lableDataFrom.Location = new System.Drawing.Point(8, 15);
            this.lableDataFrom.Name = "lableDataFrom";
            this.lableDataFrom.Size = new System.Drawing.Size(30, 13);
            this.lableDataFrom.TabIndex = 5;
            this.lableDataFrom.Text = "From";
            // 
            // textBoxDataFrom
            // 
            this.textBoxDataFrom.Location = new System.Drawing.Point(44, 12);
            this.textBoxDataFrom.Name = "textBoxDataFrom";
            this.textBoxDataFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataFrom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(647, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tovar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Doc_TovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxFin);
            this.Controls.Add(this.dataGridViewTovar);
            this.Controls.Add(this.dataGridViewDoc);
            this.Name = "Doc_TovarForm";
            this.Text = "Doc_TovarForm";
            this.Load += new System.EventHandler(this.Doc_TovarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).EndInit();
            this.groupBoxFin.ResumeLayout(false);
            this.groupBoxFin.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoc;
        private System.Windows.Forms.DataGridView dataGridViewTovar;
        private System.Windows.Forms.GroupBox groupBoxFin;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label labelDolg;
        private System.Windows.Forms.Label labelOpl;
        private System.Windows.Forms.Label labelSumm;
        private System.Windows.Forms.TextBox textBoxDolg;
        private System.Windows.Forms.TextBox textBoxOplata;
        private System.Windows.Forms.TextBox textBoxSumm;
        private System.Windows.Forms.Label labelDataTo;
        private System.Windows.Forms.TextBox textBoxDataTo;
        private System.Windows.Forms.Label lableDataFrom;
        private System.Windows.Forms.TextBox textBoxDataFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}