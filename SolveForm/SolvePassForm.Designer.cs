
namespace SolveForm
{
    partial class SolvePassForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Solve = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(280, 17);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(94, 29);
            this.Solve.TabIndex = 0;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 12);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(243, 34);
            this.txtPass.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(280, 61);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 29);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(91, 50);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(164, 27);
            this.result.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PassWord";
            // 
            // SolvePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.Solve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SolvePassForm";
            this.Text = "Solve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
    }
}

