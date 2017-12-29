namespace MissionPlanner
{
    partial class Engineering_mode_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engineering_mode_form));
            this.comfirm_eng = new MissionPlanner.Controls.MyButton();
            this.cancel_eng = new MissionPlanner.Controls.MyButton();
            this.PassWord_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comfirm_eng
            // 
            this.comfirm_eng.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comfirm_eng.BGGradBot = System.Drawing.Color.DodgerBlue;
            this.comfirm_eng.BGGradTop = System.Drawing.Color.Gold;
            this.comfirm_eng.Location = new System.Drawing.Point(79, 266);
            this.comfirm_eng.Name = "comfirm_eng";
            this.comfirm_eng.Size = new System.Drawing.Size(82, 38);
            this.comfirm_eng.TabIndex = 0;
            this.comfirm_eng.Text = "confirm";
            this.comfirm_eng.UseVisualStyleBackColor = false;
            this.comfirm_eng.Click += new System.EventHandler(this.comfirm_eng_Click);
            // 
            // cancel_eng
            // 
            this.cancel_eng.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_eng.BGGradBot = System.Drawing.Color.DodgerBlue;
            this.cancel_eng.BGGradTop = System.Drawing.Color.Gold;
            this.cancel_eng.Location = new System.Drawing.Point(205, 266);
            this.cancel_eng.Name = "cancel_eng";
            this.cancel_eng.Size = new System.Drawing.Size(82, 38);
            this.cancel_eng.TabIndex = 1;
            this.cancel_eng.Text = "cancel";
            this.cancel_eng.UseVisualStyleBackColor = false;
            this.cancel_eng.Click += new System.EventHandler(this.cancel_eng_Click);
            // 
            // PassWord_textbox
            // 
            this.PassWord_textbox.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassWord_textbox.Location = new System.Drawing.Point(183, 198);
            this.PassWord_textbox.Name = "PassWord_textbox";
            this.PassWord_textbox.Size = new System.Drawing.Size(152, 41);
            this.PassWord_textbox.TabIndex = 2;
            this.PassWord_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWord_textbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "PassWord:";
            // 
            // Engineering_mode_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.splashdark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWord_textbox);
            this.Controls.Add(this.cancel_eng);
            this.Controls.Add(this.comfirm_eng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 375);
            this.Name = "Engineering_mode_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "广州笨笨网络科技有限公司";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton comfirm_eng;
        private Controls.MyButton cancel_eng;
        private System.Windows.Forms.TextBox PassWord_textbox;
        private System.Windows.Forms.Label label1;
    }
}