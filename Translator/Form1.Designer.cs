namespace Translator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RTB_Chinese = new System.Windows.Forms.RichTextBox();
            this.RTB_English = new System.Windows.Forms.RichTextBox();
            this.GB_Chinese = new System.Windows.Forms.GroupBox();
            this.GB_English = new System.Windows.Forms.GroupBox();
            this.BT_CtoE = new System.Windows.Forms.Button();
            this.BT_EtoC = new System.Windows.Forms.Button();
            this.CB_Contrast = new System.Windows.Forms.CheckBox();
            this.GB_Chinese.SuspendLayout();
            this.GB_English.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB_Chinese
            // 
            this.RTB_Chinese.Location = new System.Drawing.Point(6, 24);
            this.RTB_Chinese.Name = "RTB_Chinese";
            this.RTB_Chinese.Size = new System.Drawing.Size(297, 468);
            this.RTB_Chinese.TabIndex = 0;
            this.RTB_Chinese.Text = "";
            // 
            // RTB_English
            // 
            this.RTB_English.Location = new System.Drawing.Point(6, 26);
            this.RTB_English.Name = "RTB_English";
            this.RTB_English.Size = new System.Drawing.Size(297, 468);
            this.RTB_English.TabIndex = 1;
            this.RTB_English.Text = "";
            // 
            // GB_Chinese
            // 
            this.GB_Chinese.Controls.Add(this.RTB_Chinese);
            this.GB_Chinese.Location = new System.Drawing.Point(12, 43);
            this.GB_Chinese.Name = "GB_Chinese";
            this.GB_Chinese.Size = new System.Drawing.Size(309, 500);
            this.GB_Chinese.TabIndex = 2;
            this.GB_Chinese.TabStop = false;
            this.GB_Chinese.Text = "汉";
            // 
            // GB_English
            // 
            this.GB_English.Controls.Add(this.RTB_English);
            this.GB_English.Location = new System.Drawing.Point(408, 43);
            this.GB_English.Name = "GB_English";
            this.GB_English.Size = new System.Drawing.Size(309, 500);
            this.GB_English.TabIndex = 3;
            this.GB_English.TabStop = false;
            this.GB_English.Text = "英";
            // 
            // BT_CtoE
            // 
            this.BT_CtoE.Location = new System.Drawing.Point(327, 215);
            this.BT_CtoE.Name = "BT_CtoE";
            this.BT_CtoE.Size = new System.Drawing.Size(75, 23);
            this.BT_CtoE.TabIndex = 4;
            this.BT_CtoE.Text = "->";
            this.BT_CtoE.UseVisualStyleBackColor = true;
            this.BT_CtoE.Click += new System.EventHandler(this.BT_CtoE_Click);
            // 
            // BT_EtoC
            // 
            this.BT_EtoC.Location = new System.Drawing.Point(327, 315);
            this.BT_EtoC.Name = "BT_EtoC";
            this.BT_EtoC.Size = new System.Drawing.Size(75, 23);
            this.BT_EtoC.TabIndex = 5;
            this.BT_EtoC.Text = "<-";
            this.BT_EtoC.UseVisualStyleBackColor = true;
            this.BT_EtoC.Click += new System.EventHandler(this.BT_EtoC_Click);
            // 
            // CB_Contrast
            // 
            this.CB_Contrast.AutoSize = true;
            this.CB_Contrast.Location = new System.Drawing.Point(12, 12);
            this.CB_Contrast.Name = "CB_Contrast";
            this.CB_Contrast.Size = new System.Drawing.Size(59, 19);
            this.CB_Contrast.TabIndex = 6;
            this.CB_Contrast.Text = "对照";
            this.CB_Contrast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.CB_Contrast);
            this.Controls.Add(this.BT_EtoC);
            this.Controls.Add(this.BT_CtoE);
            this.Controls.Add(this.GB_English);
            this.Controls.Add(this.GB_Chinese);
            this.Name = "Form1";
            this.Text = "Translator";
            this.GB_Chinese.ResumeLayout(false);
            this.GB_English.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Chinese;
        private System.Windows.Forms.RichTextBox RTB_English;
        private System.Windows.Forms.GroupBox GB_Chinese;
        private System.Windows.Forms.GroupBox GB_English;
        private System.Windows.Forms.Button BT_CtoE;
        private System.Windows.Forms.Button BT_EtoC;
        private System.Windows.Forms.CheckBox CB_Contrast;
    }
}

