
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.button5_3_3 = new System.Windows.Forms.Button();
            this.TextBoxWordCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxCount = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.tbStringBuilder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.outputStrData = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(16, 50);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(680, 28);
            this.inputStrText.TabIndex = 1;
            // 
            // button5_3_1
            // 
            this.button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_1.Location = new System.Drawing.Point(33, 106);
            this.button5_3_1.Name = "button5_3_1";
            this.button5_3_1.Size = new System.Drawing.Size(154, 44);
            this.button5_3_1.TabIndex = 2;
            this.button5_3_1.Text = "空白をカウント";
            this.button5_3_1.UseVisualStyleBackColor = true;
            this.button5_3_1.Click += new System.EventHandler(this.button5_3_1_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(225, 116);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(154, 28);
            this.TextBoxSpaceCount.TabIndex = 1;
            // 
            // button5_3_2
            // 
            this.button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_2.Location = new System.Drawing.Point(33, 175);
            this.button5_3_2.Name = "button5_3_2";
            this.button5_3_2.Size = new System.Drawing.Size(154, 44);
            this.button5_3_2.TabIndex = 2;
            this.button5_3_2.Text = "big → small";
            this.button5_3_2.UseVisualStyleBackColor = true;
            this.button5_3_2.Click += new System.EventHandler(this.button5_3_2_Click);
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(225, 185);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(471, 28);
            this.TextBoxWordChange.TabIndex = 1;
            // 
            // button5_3_3
            // 
            this.button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_3.Location = new System.Drawing.Point(33, 244);
            this.button5_3_3.Name = "button5_3_3";
            this.button5_3_3.Size = new System.Drawing.Size(154, 44);
            this.button5_3_3.TabIndex = 3;
            this.button5_3_3.Text = "単語をカウント";
            this.button5_3_3.UseVisualStyleBackColor = true;
            this.button5_3_3.Click += new System.EventHandler(this.button5_3_3_Click);
            // 
            // TextBoxWordCount
            // 
            this.TextBoxWordCount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordCount.Location = new System.Drawing.Point(225, 254);
            this.TextBoxWordCount.Name = "TextBoxWordCount";
            this.TextBoxWordCount.Size = new System.Drawing.Size(154, 28);
            this.TextBoxWordCount.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(33, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "4文字以下の単語";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxCount.Location = new System.Drawing.Point(225, 317);
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(471, 28);
            this.TextBoxCount.TabIndex = 5;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_5.Location = new System.Drawing.Point(33, 381);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(154, 44);
            this.Button5_3_5.TabIndex = 6;
            this.Button5_3_5.Text = "StringBuilder";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // tbStringBuilder
            // 
            this.tbStringBuilder.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbStringBuilder.Location = new System.Drawing.Point(225, 386);
            this.tbStringBuilder.Name = "tbStringBuilder";
            this.tbStringBuilder.Size = new System.Drawing.Size(471, 28);
            this.tbStringBuilder.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "問題5.4";
            // 
            // inputStrData
            // 
            this.inputStrData.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrData.Location = new System.Drawing.Point(225, 537);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(538, 28);
            this.inputStrData.TabIndex = 5;
            // 
            // outputStrData
            // 
            this.outputStrData.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputStrData.Location = new System.Drawing.Point(225, 571);
            this.outputStrData.Multiline = true;
            this.outputStrData.Name = "outputStrData";
            this.outputStrData.Size = new System.Drawing.Size(538, 114);
            this.outputStrData.TabIndex = 5;
            // 
            // Button5_4
            // 
            this.Button5_4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_4.Location = new System.Drawing.Point(33, 522);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(154, 58);
            this.Button5_4.TabIndex = 7;
            this.Button5_4.Text = "問題5.4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 730);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.outputStrData);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.tbStringBuilder);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5_3_3);
            this.Controls.Add(this.button5_3_2);
            this.Controls.Add(this.button5_3_1);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.TextBoxWordCount);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button button5_3_1;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button button5_3_3;
        private System.Windows.Forms.TextBox TextBoxWordCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxCount;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.TextBox tbStringBuilder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputStrData;
        private System.Windows.Forms.TextBox outputStrData;
        private System.Windows.Forms.Button Button5_4;
    }
}

