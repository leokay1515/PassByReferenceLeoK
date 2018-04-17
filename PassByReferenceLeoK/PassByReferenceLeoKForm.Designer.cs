namespace PassByReferenceLeoK
{
    partial class frmPassByReferenceLeoK
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
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblRequest2 = new System.Windows.Forms.Label();
            this.nudRound = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(12, 9);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(177, 13);
            this.lblRequest.TabIndex = 0;
            this.lblRequest.Text = "Enter a number with decimals:";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(195, 6);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(130, 20);
            this.txtDecimal.TabIndex = 1;
            // 
            // lblRequest2
            // 
            this.lblRequest2.AutoSize = true;
            this.lblRequest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest2.Location = new System.Drawing.Point(12, 62);
            this.lblRequest2.Name = "lblRequest2";
            this.lblRequest2.Size = new System.Drawing.Size(311, 13);
            this.lblRequest2.TabIndex = 2;
            this.lblRequest2.Text = "How many decimal places would you like to round to?";
            // 
            // nudRound
            // 
            this.nudRound.Location = new System.Drawing.Point(329, 60);
            this.nudRound.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRound.Name = "nudRound";
            this.nudRound.Size = new System.Drawing.Size(36, 20);
            this.nudRound.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(164, 93);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(84, 26);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // frmPassByReferenceLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 144);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudRound);
            this.Controls.Add(this.lblRequest2);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblRequest);
            this.Name = "frmPassByReferenceLeoK";
            this.Text = "Pass By Reference by Leo Kay";
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblRequest2;
        private System.Windows.Forms.NumericUpDown nudRound;
        private System.Windows.Forms.Button btnRound;
    }
}

