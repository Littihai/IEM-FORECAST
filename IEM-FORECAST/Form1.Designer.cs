namespace IEM_FORECAST
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRun;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(50, 50);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(190, 30);
            this.btnRun.Text = "ISUZU";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnRun);
            this.Text = "ISUZU";
            this.ResumeLayout(false);
        }
    }
}
