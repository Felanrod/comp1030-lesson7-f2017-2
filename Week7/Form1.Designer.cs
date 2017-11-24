namespace Week7
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
            this.btnLoop1 = new System.Windows.Forms.Button();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.btnLoop2 = new System.Windows.Forms.Button();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.btnWhile1 = new System.Windows.Forms.Button();
            this.lblMsgWhile = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoop1
            // 
            this.btnLoop1.Location = new System.Drawing.Point(54, 29);
            this.btnLoop1.Name = "btnLoop1";
            this.btnLoop1.Size = new System.Drawing.Size(75, 23);
            this.btnLoop1.TabIndex = 0;
            this.btnLoop1.Text = "Loop 1";
            this.btnLoop1.UseVisualStyleBackColor = true;
            this.btnLoop1.Click += new System.EventHandler(this.btnLoop1_Click);
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(51, 65);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(143, 13);
            this.lblMsg1.TabIndex = 1;
            this.lblMsg1.Text = "Click the button to run a loop";
            // 
            // btnLoop2
            // 
            this.btnLoop2.Location = new System.Drawing.Point(54, 99);
            this.btnLoop2.Name = "btnLoop2";
            this.btnLoop2.Size = new System.Drawing.Size(75, 23);
            this.btnLoop2.TabIndex = 2;
            this.btnLoop2.Text = "Loop 2";
            this.btnLoop2.UseVisualStyleBackColor = true;
            this.btnLoop2.Click += new System.EventHandler(this.btnLoop2_Click);
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(51, 135);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(174, 13);
            this.lblMsg2.TabIndex = 3;
            this.lblMsg2.Text = "Click this button to run another loop";
            // 
            // btnWhile1
            // 
            this.btnWhile1.Location = new System.Drawing.Point(54, 162);
            this.btnWhile1.Name = "btnWhile1";
            this.btnWhile1.Size = new System.Drawing.Size(75, 23);
            this.btnWhile1.TabIndex = 4;
            this.btnWhile1.Text = "While Loop";
            this.btnWhile1.UseVisualStyleBackColor = true;
            this.btnWhile1.Click += new System.EventHandler(this.btnWhile1_Click);
            // 
            // lblMsgWhile
            // 
            this.lblMsgWhile.AutoSize = true;
            this.lblMsgWhile.Location = new System.Drawing.Point(54, 201);
            this.lblMsgWhile.Name = "lblMsgWhile";
            this.lblMsgWhile.Size = new System.Drawing.Size(171, 13);
            this.lblMsgWhile.TabIndex = 5;
            this.lblMsgWhile.Text = "Click this button to run a while loop";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(57, 242);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 6;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(57, 269);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(286, 258);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(175, 13);
            this.lblSum.TabIndex = 9;
            this.lblSum.Text = "Click the button to add the numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 325);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblMsgWhile);
            this.Controls.Add(this.btnWhile1);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.btnLoop2);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.btnLoop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoop1;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Button btnLoop2;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Button btnWhile1;
        private System.Windows.Forms.Label lblMsgWhile;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSum;
    }
}

