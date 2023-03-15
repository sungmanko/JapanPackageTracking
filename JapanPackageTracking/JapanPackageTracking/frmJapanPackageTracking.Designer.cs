namespace JapanPackageTracking
{
    partial class frmJapanPackageTracking
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.rbYubin = new System.Windows.Forms.RadioButton();
            this.rbYamato = new System.Windows.Forms.RadioButton();
            this.rbSagawa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbYubin
            // 
            this.rbYubin.AutoSize = true;
            this.rbYubin.Checked = true;
            this.rbYubin.Location = new System.Drawing.Point(22, 40);
            this.rbYubin.Name = "rbYubin";
            this.rbYubin.Size = new System.Drawing.Size(73, 19);
            this.rbYubin.TabIndex = 0;
            this.rbYubin.TabStop = true;
            this.rbYubin.Text = "郵便局";
            this.rbYubin.UseVisualStyleBackColor = true;
            // 
            // rbYamato
            // 
            this.rbYamato.AutoSize = true;
            this.rbYamato.Location = new System.Drawing.Point(111, 40);
            this.rbYamato.Name = "rbYamato";
            this.rbYamato.Size = new System.Drawing.Size(107, 19);
            this.rbYamato.TabIndex = 1;
            this.rbYamato.Text = "ヤマト宅急便";
            this.rbYamato.UseVisualStyleBackColor = true;
            // 
            // rbSagawa
            // 
            this.rbSagawa.AutoSize = true;
            this.rbSagawa.Location = new System.Drawing.Point(224, 40);
            this.rbSagawa.Name = "rbSagawa";
            this.rbSagawa.Size = new System.Drawing.Size(88, 19);
            this.rbSagawa.TabIndex = 2;
            this.rbSagawa.Text = "佐川急便";
            this.rbSagawa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYubin);
            this.groupBox1.Controls.Add(this.rbSagawa);
            this.groupBox1.Controls.Add(this.rbYamato);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会社種別";
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(85, 115);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(202, 22);
            this.txtTrackingNumber.TabIndex = 4;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Location = new System.Drawing.Point(12, 118);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(67, 15);
            this.lblTrackingNumber.TabIndex = 5;
            this.lblTrackingNumber.Text = "追跡番号";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(293, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 169);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTrackingNumber);
            this.Controls.Add(this.txtTrackingNumber);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TOSUN_荷物宅配追跡システム";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbYubin;
        private System.Windows.Forms.RadioButton rbYamato;
        private System.Windows.Forms.RadioButton rbSagawa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Button btnSearch;
    }
}

