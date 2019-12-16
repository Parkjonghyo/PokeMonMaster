namespace PokemonWinform
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserCtrl = new System.Windows.Forms.Button();
            this.btnPocketmonCtrl = new System.Windows.Forms.Button();
            this.btnPocketmonDic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUsername = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "포캣몬 마스터가 대어보자!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUserCtrl
            // 
            this.btnUserCtrl.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserCtrl.Location = new System.Drawing.Point(19, 149);
            this.btnUserCtrl.Name = "btnUserCtrl";
            this.btnUserCtrl.Size = new System.Drawing.Size(261, 286);
            this.btnUserCtrl.TabIndex = 1;
            this.btnUserCtrl.Text = "트레이너관리";
            this.btnUserCtrl.UseVisualStyleBackColor = true;
            this.btnUserCtrl.Click += new System.EventHandler(this.btnUserCtrl_Click);
            // 
            // btnPocketmonCtrl
            // 
            this.btnPocketmonCtrl.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPocketmonCtrl.Location = new System.Drawing.Point(331, 149);
            this.btnPocketmonCtrl.Name = "btnPocketmonCtrl";
            this.btnPocketmonCtrl.Size = new System.Drawing.Size(261, 286);
            this.btnPocketmonCtrl.TabIndex = 1;
            this.btnPocketmonCtrl.Text = "포캣몬관리\r\n(추후 추가)";
            this.btnPocketmonCtrl.UseVisualStyleBackColor = true;
            this.btnPocketmonCtrl.Click += new System.EventHandler(this.btnPocketmonCtrl_Click);
            // 
            // btnPocketmonDic
            // 
            this.btnPocketmonDic.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPocketmonDic.Location = new System.Drawing.Point(649, 149);
            this.btnPocketmonDic.Name = "btnPocketmonDic";
            this.btnPocketmonDic.Size = new System.Drawing.Size(261, 286);
            this.btnPocketmonDic.TabIndex = 1;
            this.btnPocketmonDic.Text = "포캣몬도감";
            this.btnPocketmonDic.UseVisualStyleBackColor = true;
            this.btnPocketmonDic.Click += new System.EventHandler(this.btnPocketmonDic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(362, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "트레이너, 당신의 이름은?";
            // 
            // cbxUsername
            // 
            this.cbxUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsername.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxUsername.FormattingEnabled = true;
            this.cbxUsername.Location = new System.Drawing.Point(399, 84);
            this.cbxUsername.Name = "cbxUsername";
            this.cbxUsername.Size = new System.Drawing.Size(121, 22);
            this.cbxUsername.TabIndex = 4;
            this.cbxUsername.SelectedIndexChanged += new System.EventHandler(this.cbxUsername_SelectedIndexChanged);
            this.cbxUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbxUsername_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 515);
            this.Controls.Add(this.cbxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPocketmonDic);
            this.Controls.Add(this.btnPocketmonCtrl);
            this.Controls.Add(this.btnUserCtrl);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserCtrl;
        private System.Windows.Forms.Button btnPocketmonCtrl;
        private System.Windows.Forms.Button btnPocketmonDic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUsername;
    }
}

