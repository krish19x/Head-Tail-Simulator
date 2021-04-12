
namespace Head_Tail_Simulator
{
    partial class Form1
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
            this.Headbtn = new System.Windows.Forms.Button();
            this.TailBtn = new System.Windows.Forms.Button();
            this.FlipBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutPutBox = new System.Windows.Forms.PictureBox();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Countlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutPutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Headbtn
            // 
            this.Headbtn.BackColor = System.Drawing.Color.GhostWhite;
            this.Headbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.Headbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Headbtn.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headbtn.ForeColor = System.Drawing.Color.Orange;
            this.Headbtn.Location = new System.Drawing.Point(0, 1);
            this.Headbtn.Name = "Headbtn";
            this.Headbtn.Size = new System.Drawing.Size(119, 250);
            this.Headbtn.TabIndex = 0;
            this.Headbtn.Text = "HEAD";
            this.Headbtn.UseVisualStyleBackColor = false;
            this.Headbtn.Click += new System.EventHandler(this.Headbtn_Click);
            // 
            // TailBtn
            // 
            this.TailBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.TailBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.TailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TailBtn.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailBtn.ForeColor = System.Drawing.Color.Orange;
            this.TailBtn.Location = new System.Drawing.Point(348, 1);
            this.TailBtn.Name = "TailBtn";
            this.TailBtn.Size = new System.Drawing.Size(119, 250);
            this.TailBtn.TabIndex = 1;
            this.TailBtn.Text = "TAIL";
            this.TailBtn.UseVisualStyleBackColor = false;
            this.TailBtn.Click += new System.EventHandler(this.TailBtn_Click);
            // 
            // FlipBtn
            // 
            this.FlipBtn.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipBtn.Location = new System.Drawing.Point(0, 254);
            this.FlipBtn.Name = "FlipBtn";
            this.FlipBtn.Size = new System.Drawing.Size(467, 88);
            this.FlipBtn.TabIndex = 3;
            this.FlipBtn.Text = "FLIP";
            this.FlipBtn.UseVisualStyleBackColor = true;
            this.FlipBtn.Click += new System.EventHandler(this.FlipBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(177, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "You Win";
            // 
            // OutPutBox
            // 
            this.OutPutBox.Location = new System.Drawing.Point(125, 1);
            this.OutPutBox.Name = "OutPutBox";
            this.OutPutBox.Size = new System.Drawing.Size(217, 217);
            this.OutPutBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutPutBox.TabIndex = 2;
            this.OutPutBox.TabStop = false;
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.Location = new System.Drawing.Point(0, 254);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(467, 88);
            this.tryAgainBtn.TabIndex = 5;
            this.tryAgainBtn.Text = "try again";
            this.tryAgainBtn.UseVisualStyleBackColor = true;
            this.tryAgainBtn.Visible = false;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "WIN-LOSE";
            // 
            // Countlbl
            // 
            this.Countlbl.AutoSize = true;
            this.Countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countlbl.Location = new System.Drawing.Point(204, 369);
            this.Countlbl.Name = "Countlbl";
            this.Countlbl.Size = new System.Drawing.Size(46, 24);
            this.Countlbl.TabIndex = 7;
            this.Countlbl.Text = "0 - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(468, 396);
            this.Controls.Add(this.Countlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlipBtn);
            this.Controls.Add(this.OutPutBox);
            this.Controls.Add(this.TailBtn);
            this.Controls.Add(this.Headbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutPutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Headbtn;
        private System.Windows.Forms.Button TailBtn;
        private System.Windows.Forms.PictureBox OutPutBox;
        private System.Windows.Forms.Button FlipBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tryAgainBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Countlbl;
    }
}

