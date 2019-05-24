namespace TeaBagMaker
{
    partial class teaForm
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
            this.components = new System.ComponentModel.Container();
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.teaTime = new System.Windows.Forms.Label();
            this.timeResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBox
            // 
            this.cbBox.Font = new System.Drawing.Font("굴림", 15F);
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Location = new System.Drawing.Point(12, 12);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(315, 28);
            this.cbBox.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn.Location = new System.Drawing.Point(12, 46);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(315, 85);
            this.btn.TabIndex = 1;
            this.btn.Text = "담그기 !";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("궁서", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "2019.05.24 3203 김나연";
            // 
            // teaTime
            // 
            this.teaTime.AutoSize = true;
            this.teaTime.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.teaTime.Font = new System.Drawing.Font("굴림", 14F);
            this.teaTime.Location = new System.Drawing.Point(8, 146);
            this.teaTime.Name = "teaTime";
            this.teaTime.Size = new System.Drawing.Size(65, 19);
            this.teaTime.TabIndex = 3;
            this.teaTime.Text = "시간 : ";
            // 
            // timeResult
            // 
            this.timeResult.AutoSize = true;
            this.timeResult.Font = new System.Drawing.Font("굴림", 10F);
            this.timeResult.Location = new System.Drawing.Point(9, 177);
            this.timeResult.Name = "timeResult";
            this.timeResult.Size = new System.Drawing.Size(0, 14);
            this.timeResult.TabIndex = 4;
            // 
            // teaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 395);
            this.Controls.Add(this.timeResult);
            this.Controls.Add(this.teaTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cbBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "teaForm";
            this.Text = "차 만들기";
            this.Load += new System.EventHandler(this.teaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teaTime;
        private System.Windows.Forms.Label timeResult;
    }
}

