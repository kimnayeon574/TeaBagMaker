namespace TeaBagMaker
{
    partial class Form
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
            this.teaTime = new System.Windows.Forms.Label();
            this.timeResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBox
            // 
            this.cbBox.Font = new System.Drawing.Font("굴림", 16F);
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Location = new System.Drawing.Point(12, 12);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(363, 29);
            this.cbBox.TabIndex = 0;
            this.cbBox.SelectedIndexChanged += new System.EventHandler(this.cbBox_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("굴림", 20F);
            this.btn.Location = new System.Drawing.Point(12, 57);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(363, 91);
            this.btn.TabIndex = 1;
            this.btn.Text = "담그기 !";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // teaTime
            // 
            this.teaTime.AutoSize = true;
            this.teaTime.Font = new System.Drawing.Font("굴림", 14F);
            this.teaTime.Location = new System.Drawing.Point(12, 171);
            this.teaTime.Name = "teaTime";
            this.teaTime.Size = new System.Drawing.Size(0, 19);
            this.teaTime.TabIndex = 2;
            // 
            // timeResult
            // 
            this.timeResult.AutoSize = true;
            this.timeResult.Font = new System.Drawing.Font("굴림", 14F);
            this.timeResult.Location = new System.Drawing.Point(12, 206);
            this.timeResult.Name = "timeResult";
            this.timeResult.Size = new System.Drawing.Size(15, 19);
            this.timeResult.TabIndex = 3;
            this.timeResult.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("궁서", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "2019.05.24 3203 김나연";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("굴림", 16F);
            this.result.Location = new System.Drawing.Point(12, 190);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(118, 22);
            this.result.TabIndex = 5;
            this.result.Text = "남은시간 : ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 303);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeResult);
            this.Controls.Add(this.teaTime);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cbBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "차 우리기";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label teaTime;
        private System.Windows.Forms.Label timeResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label result;
    }
}

