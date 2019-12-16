namespace PokemonWinform
{
    partial class UserCtrlForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUinsert = new System.Windows.Forms.Button();
            this.btnUdelete = new System.Windows.Forms.Button();
            this.btnUselect = new System.Windows.Forms.Button();
            this.tbxUSname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUIname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUsex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSelectedTrainer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUusex = new System.Windows.Forms.ComboBox();
            this.btnUupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(220, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // btnUinsert
            // 
            this.btnUinsert.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUinsert.Location = new System.Drawing.Point(44, 171);
            this.btnUinsert.Name = "btnUinsert";
            this.btnUinsert.Size = new System.Drawing.Size(126, 32);
            this.btnUinsert.TabIndex = 3;
            this.btnUinsert.Text = "추가";
            this.btnUinsert.UseVisualStyleBackColor = true;
            this.btnUinsert.Click += new System.EventHandler(this.btnUinsert_Click);
            // 
            // btnUdelete
            // 
            this.btnUdelete.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUdelete.Location = new System.Drawing.Point(44, 297);
            this.btnUdelete.Name = "btnUdelete";
            this.btnUdelete.Size = new System.Drawing.Size(126, 32);
            this.btnUdelete.TabIndex = 3;
            this.btnUdelete.Text = "삭제";
            this.btnUdelete.UseVisualStyleBackColor = true;
            this.btnUdelete.Click += new System.EventHandler(this.btnUdelete_Click);
            // 
            // btnUselect
            // 
            this.btnUselect.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUselect.Location = new System.Drawing.Point(39, 52);
            this.btnUselect.Name = "btnUselect";
            this.btnUselect.Size = new System.Drawing.Size(126, 32);
            this.btnUselect.TabIndex = 3;
            this.btnUselect.Text = "찾기";
            this.btnUselect.UseVisualStyleBackColor = true;
            this.btnUselect.Click += new System.EventHandler(this.btnUselect_Click);
            // 
            // tbxUSname
            // 
            this.tbxUSname.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxUSname.Location = new System.Drawing.Point(44, 21);
            this.tbxUSname.Name = "tbxUSname";
            this.tbxUSname.Size = new System.Drawing.Size(107, 25);
            this.tbxUSname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // tbxUIname
            // 
            this.tbxUIname.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxUIname.Location = new System.Drawing.Point(44, 109);
            this.tbxUIname.Name = "tbxUIname";
            this.tbxUIname.Size = new System.Drawing.Size(107, 25);
            this.tbxUIname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별";
            // 
            // cbxUsex
            // 
            this.cbxUsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsex.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxUsex.FormattingEnabled = true;
            this.cbxUsex.Items.AddRange(new object[] {
            "남",
            "여"});
            this.cbxUsex.Location = new System.Drawing.Point(44, 140);
            this.cbxUsex.Name = "cbxUsex";
            this.cbxUsex.Size = new System.Drawing.Size(121, 25);
            this.cbxUsex.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "선택된 트레이너(삭제,수정)";
            // 
            // lbSelectedTrainer
            // 
            this.lbSelectedTrainer.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSelectedTrainer.Location = new System.Drawing.Point(11, 264);
            this.lbSelectedTrainer.Name = "lbSelectedTrainer";
            this.lbSelectedTrainer.Size = new System.Drawing.Size(189, 24);
            this.lbSelectedTrainer.TabIndex = 6;
            this.lbSelectedTrainer.Text = "label4";
            this.lbSelectedTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "성별";
            // 
            // cbxUusex
            // 
            this.cbxUusex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUusex.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxUusex.FormattingEnabled = true;
            this.cbxUusex.Items.AddRange(new object[] {
            "남",
            "여"});
            this.cbxUusex.Location = new System.Drawing.Point(44, 362);
            this.cbxUusex.Name = "cbxUusex";
            this.cbxUusex.Size = new System.Drawing.Size(121, 25);
            this.cbxUusex.TabIndex = 5;
            // 
            // btnUupdate
            // 
            this.btnUupdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUupdate.Location = new System.Drawing.Point(44, 393);
            this.btnUupdate.Name = "btnUupdate";
            this.btnUupdate.Size = new System.Drawing.Size(126, 32);
            this.btnUupdate.TabIndex = 3;
            this.btnUupdate.Text = "수정";
            this.btnUupdate.UseVisualStyleBackColor = true;
            this.btnUupdate.Click += new System.EventHandler(this.btnUupdate_Click);
            // 
            // UserCtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.lbSelectedTrainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxUusex);
            this.Controls.Add(this.cbxUsex);
            this.Controls.Add(this.tbxUIname);
            this.Controls.Add(this.tbxUSname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUselect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUdelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUupdate);
            this.Controls.Add(this.btnUinsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserCtrlForm";
            this.Text = "트레이너 관리";
            this.Load += new System.EventHandler(this.UserCtrlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUinsert;
        private System.Windows.Forms.Button btnUdelete;
        private System.Windows.Forms.Button btnUselect;
        private System.Windows.Forms.TextBox tbxUSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUIname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUsex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSelectedTrainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUusex;
        private System.Windows.Forms.Button btnUupdate;
    }
}