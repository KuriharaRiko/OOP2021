
namespace StopWatch {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.lbLapDisp = new System.Windows.Forms.ListBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btLap = new System.Windows.Forms.Button();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.Color.LightPink;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(29, 31);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(317, 51);
            this.lbTimerDisp.TabIndex = 1;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLapDisp
            // 
            this.lbLapDisp.BackColor = System.Drawing.Color.LightPink;
            this.lbLapDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbLapDisp.FormattingEnabled = true;
            this.lbLapDisp.ItemHeight = 24;
            this.lbLapDisp.Location = new System.Drawing.Point(352, 31);
            this.lbLapDisp.Name = "lbLapDisp";
            this.lbLapDisp.Size = new System.Drawing.Size(180, 220);
            this.lbLapDisp.TabIndex = 2;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.Location = new System.Drawing.Point(29, 93);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(141, 68);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btReset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReset.Location = new System.Drawing.Point(205, 93);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(141, 68);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btStop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStop.Location = new System.Drawing.Point(29, 177);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(141, 68);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btLap
            // 
            this.btLap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btLap.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btLap.Location = new System.Drawing.Point(205, 177);
            this.btLap.Name = "btLap";
            this.btLap.Size = new System.Drawing.Size(141, 68);
            this.btLap.TabIndex = 6;
            this.btLap.Text = "ラップ";
            this.btLap.UseVisualStyleBackColor = false;
            this.btLap.Click += new System.EventHandler(this.btLap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(551, 268);
            this.Controls.Add(this.btLap);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbLapDisp);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.ListBox lbLapDisp;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btLap;
        private System.Windows.Forms.Timer tmDisp;
    }
}

