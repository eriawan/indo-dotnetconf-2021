namespace SampleNetFxWinformsApp
{
    partial class MainForm
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
            this.btnDisplayRuntimeInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayRuntimeInfo
            // 
            this.btnDisplayRuntimeInfo.Location = new System.Drawing.Point(296, 201);
            this.btnDisplayRuntimeInfo.Name = "btnDisplayRuntimeInfo";
            this.btnDisplayRuntimeInfo.Size = new System.Drawing.Size(225, 23);
            this.btnDisplayRuntimeInfo.TabIndex = 0;
            this.btnDisplayRuntimeInfo.Text = "Display .NET runtime information";
            this.btnDisplayRuntimeInfo.UseVisualStyleBackColor = true;
            this.btnDisplayRuntimeInfo.Click += new System.EventHandler(this.btnDisplayRuntimeInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayRuntimeInfo);
            this.Name = "MainForm";
            this.Text = "Hello Winforms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayRuntimeInfo;
    }
}

