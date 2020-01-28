namespace SharpEyes
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btn_Get = new System.Windows.Forms.Button();
            this.btn_Set = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_Intensity = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.slider1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(197, 159);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(75, 23);
            this.btn_Get.TabIndex = 1;
            this.btn_Get.Text = "Get";
            this.btn_Get.UseVisualStyleBackColor = true;
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(197, 130);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 2;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(179, 79);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "[LOGGER]";
            // 
            // lbl_Intensity
            // 
            this.lbl_Intensity.AutoSize = true;
            this.lbl_Intensity.Location = new System.Drawing.Point(77, 9);
            this.lbl_Intensity.Name = "lbl_Intensity";
            this.lbl_Intensity.Size = new System.Drawing.Size(16, 13);
            this.lbl_Intensity.TabIndex = 4;
            this.lbl_Intensity.Text = "...";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(197, 103);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(76, 18);
            this.tb1.TabIndex = 2147483647;
            this.tb1.Text = "test";
            // 
            // txtEditor
            // 
            this.txtEditor.AllowDrop = true;
            this.txtEditor.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditor.Location = new System.Drawing.Point(12, 208);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(260, 16);
            this.txtEditor.TabIndex = 6;
            this.txtEditor.Text = "1.1.1";
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
            // 
            // slider1
            // 
            this.slider1.AutoSize = false;
            this.slider1.BackColor = System.Drawing.SystemColors.Control;
            this.slider1.LargeChange = 1;
            this.slider1.Location = new System.Drawing.Point(12, 23);
            this.slider1.Maximum = 6500;
            this.slider1.Minimum = 1000;
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(143, 23);
            this.slider1.TabIndex = 5;
            this.slider1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider1.Value = 6499;
            this.slider1.ValueChanged += new System.EventHandler(this.slider1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "6500K";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 60);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbl_Intensity);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.btn_Get);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpEyes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_Intensity;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.TrackBar slider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

