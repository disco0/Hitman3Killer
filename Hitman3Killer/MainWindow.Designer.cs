namespace Hitman3Killer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listLog = new System.Windows.Forms.ListBox();
            this.checkDisableAltF4 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnKeyHook = new System.Windows.Forms.Button();
            this.checkTrace = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listLog
            // 
            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.Font = new System.Drawing.Font("Iosevka Extended", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLog.FormattingEnabled = true;
            this.listLog.HorizontalScrollbar = true;
            this.listLog.ItemHeight = 14;
            this.listLog.Location = new System.Drawing.Point(6, 0);
            this.listLog.Name = "listLog";
            this.listLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listLog.Size = new System.Drawing.Size(459, 217);
            this.listLog.TabIndex = 6;
            // 
            // checkDisableAltF4
            // 
            this.checkDisableAltF4.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkDisableAltF4.Location = new System.Drawing.Point(0, 53);
            this.checkDisableAltF4.Name = "checkDisableAltF4";
            this.checkDisableAltF4.Size = new System.Drawing.Size(147, 17);
            this.checkDisableAltF4.TabIndex = 14;
            this.checkDisableAltF4.Text = "Hook Alt+F4";
            this.checkDisableAltF4.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Location = new System.Drawing.Point(0, 27);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 26);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnKeyHook
            // 
            this.btnKeyHook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeyHook.Location = new System.Drawing.Point(0, 0);
            this.btnKeyHook.Margin = new System.Windows.Forms.Padding(5);
            this.btnKeyHook.Name = "btnKeyHook";
            this.btnKeyHook.Size = new System.Drawing.Size(147, 27);
            this.btnKeyHook.TabIndex = 12;
            this.btnKeyHook.Text = "Install Keyboard Hook";
            this.btnKeyHook.UseVisualStyleBackColor = true;
            this.btnKeyHook.Click += new System.EventHandler(this.btnKeyHook_Click);
            // 
            // checkTrace
            // 
            this.checkTrace.AutoSize = true;
            this.checkTrace.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkTrace.Location = new System.Drawing.Point(0, 70);
            this.checkTrace.Name = "checkTrace";
            this.checkTrace.Size = new System.Drawing.Size(147, 17);
            this.checkTrace.TabIndex = 15;
            this.checkTrace.Text = "Log Hooked Keys";
            this.checkTrace.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listLog);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkTrace);
            this.splitContainer1.Panel2.Controls.Add(this.checkDisableAltF4);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnKeyHook);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.splitContainer1.Size = new System.Drawing.Size(620, 217);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 16;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 217);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(636, 235);
            this.Name = "MainWindow";
            this.Text = "Hitman3 Killer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.CheckBox checkDisableAltF4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnKeyHook;
        private System.Windows.Forms.CheckBox checkTrace;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

