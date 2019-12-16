namespace PokemonWinform
{
    partial class PocketmonDicForm
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
            this.rbPocketmon = new System.Windows.Forms.RadioButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbTribe = new System.Windows.Forms.RadioButton();
            this.rbSkill = new System.Windows.Forms.RadioButton();
            this.rbTrait = new System.Windows.Forms.RadioButton();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearchId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSearchType = new System.Windows.Forms.ComboBox();
            this.cbxSearchWhat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudUp = new System.Windows.Forms.NumericUpDown();
            this.nudDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSkillSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 224);
            this.dataGridView1.TabIndex = 1;
            // 
            // rbPocketmon
            // 
            this.rbPocketmon.AutoSize = true;
            this.rbPocketmon.Checked = true;
            this.rbPocketmon.Location = new System.Drawing.Point(6, 20);
            this.rbPocketmon.Name = "rbPocketmon";
            this.rbPocketmon.Size = new System.Drawing.Size(59, 16);
            this.rbPocketmon.TabIndex = 2;
            this.rbPocketmon.TabStop = true;
            this.rbPocketmon.Text = "포켓몬";
            this.rbPocketmon.UseVisualStyleBackColor = true;
            this.rbPocketmon.CheckedChanged += new System.EventHandler(this.rbPocketmon_CheckedChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbTribe);
            this.gbSearch.Controls.Add(this.rbSkill);
            this.gbSearch.Controls.Add(this.rbTrait);
            this.gbSearch.Controls.Add(this.rbType);
            this.gbSearch.Controls.Add(this.rbPocketmon);
            this.gbSearch.Location = new System.Drawing.Point(588, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(200, 196);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // rbTribe
            // 
            this.rbTribe.AutoSize = true;
            this.rbTribe.Location = new System.Drawing.Point(6, 174);
            this.rbTribe.Name = "rbTribe";
            this.rbTribe.Size = new System.Drawing.Size(59, 16);
            this.rbTribe.TabIndex = 2;
            this.rbTribe.TabStop = true;
            this.rbTribe.Text = "종족치";
            this.rbTribe.UseVisualStyleBackColor = true;
            this.rbTribe.CheckedChanged += new System.EventHandler(this.rbTribe_CheckedChanged);
            // 
            // rbSkill
            // 
            this.rbSkill.AutoSize = true;
            this.rbSkill.Location = new System.Drawing.Point(6, 135);
            this.rbSkill.Name = "rbSkill";
            this.rbSkill.Size = new System.Drawing.Size(47, 16);
            this.rbSkill.TabIndex = 2;
            this.rbSkill.TabStop = true;
            this.rbSkill.Text = "기술";
            this.rbSkill.UseVisualStyleBackColor = true;
            this.rbSkill.CheckedChanged += new System.EventHandler(this.rbSkill_CheckedChanged);
            // 
            // rbTrait
            // 
            this.rbTrait.AutoSize = true;
            this.rbTrait.Location = new System.Drawing.Point(6, 96);
            this.rbTrait.Name = "rbTrait";
            this.rbTrait.Size = new System.Drawing.Size(47, 16);
            this.rbTrait.TabIndex = 2;
            this.rbTrait.TabStop = true;
            this.rbTrait.Text = "특성";
            this.rbTrait.UseVisualStyleBackColor = true;
            this.rbTrait.CheckedChanged += new System.EventHandler(this.rbTrait_CheckedChanged);
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.Location = new System.Drawing.Point(6, 57);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(47, 16);
            this.rbType.TabIndex = 2;
            this.rbType.TabStop = true;
            this.rbType.Text = "타입";
            this.rbType.UseVisualStyleBackColor = true;
            this.rbType.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름으로 검색";
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.Location = new System.Drawing.Point(16, 34);
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Size = new System.Drawing.Size(310, 21);
            this.tbxSearchName.TabIndex = 5;
            this.tbxSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID로 검색(종족치 제외)";
            // 
            // tbxSearchId
            // 
            this.tbxSearchId.Location = new System.Drawing.Point(16, 91);
            this.tbxSearchId.Name = "tbxSearchId";
            this.tbxSearchId.Size = new System.Drawing.Size(310, 21);
            this.tbxSearchId.TabIndex = 5;
            this.tbxSearchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchId_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "타입";
            // 
            // cbxSearchType
            // 
            this.cbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchType.FormattingEnabled = true;
            this.cbxSearchType.Location = new System.Drawing.Point(18, 47);
            this.cbxSearchType.Name = "cbxSearchType";
            this.cbxSearchType.Size = new System.Drawing.Size(121, 20);
            this.cbxSearchType.TabIndex = 6;
            // 
            // cbxSearchWhat
            // 
            this.cbxSearchWhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchWhat.FormattingEnabled = true;
            this.cbxSearchWhat.Items.AddRange(new object[] {
            "power",
            "hit",
            "pp"});
            this.cbxSearchWhat.Location = new System.Drawing.Point(219, 47);
            this.cbxSearchWhat.Name = "cbxSearchWhat";
            this.cbxSearchWhat.Size = new System.Drawing.Size(76, 20);
            this.cbxSearchWhat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "가";
            // 
            // nudUp
            // 
            this.nudUp.Location = new System.Drawing.Point(342, 29);
            this.nudUp.Name = "nudUp";
            this.nudUp.Size = new System.Drawing.Size(61, 21);
            this.nudUp.TabIndex = 8;
            // 
            // nudDown
            // 
            this.nudDown.Location = new System.Drawing.Point(342, 56);
            this.nudDown.Name = "nudDown";
            this.nudDown.Size = new System.Drawing.Size(61, 21);
            this.nudDown.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "이하";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "이상";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSkillSelect);
            this.groupBox1.Controls.Add(this.nudUp);
            this.groupBox1.Controls.Add(this.nudDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxSearchType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxSearchWhat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기술 전용 검색칸";
            // 
            // btnSkillSelect
            // 
            this.btnSkillSelect.Location = new System.Drawing.Point(480, 44);
            this.btnSkillSelect.Name = "btnSkillSelect";
            this.btnSkillSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSkillSelect.TabIndex = 9;
            this.btnSkillSelect.Text = "찾기";
            this.btnSkillSelect.UseVisualStyleBackColor = true;
            this.btnSkillSelect.Click += new System.EventHandler(this.btnSkillSelect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(216, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "상세";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "이고";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(373, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(199, 23);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "포켓몬(1세대) 액셀로 출력하기";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(373, 41);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(199, 23);
            this.btnExportTxt.TabIndex = 10;
            this.btnExportTxt.Text = "포켓몬(1세대) TXT로 출력하기";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // PocketmonDicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxSearchId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PocketmonDicForm";
            this.Text = "포켓몬 도감";
            this.Load += new System.EventHandler(this.PocketmonDicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbPocketmon;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbTribe;
        private System.Windows.Forms.RadioButton rbSkill;
        private System.Windows.Forms.RadioButton rbTrait;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearchId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSearchType;
        private System.Windows.Forms.ComboBox cbxSearchWhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudUp;
        private System.Windows.Forms.NumericUpDown nudDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSkillSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportTxt;
    }
}