namespace DiGi.CityGML.Test
{
    partial class MainForm
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
            Button_Open = new Button();
            SuspendLayout();
            // 
            // Button_Open
            // 
            Button_Open.Location = new Point(12, 12);
            Button_Open.Name = "Button_Open";
            Button_Open.Size = new Size(94, 29);
            Button_Open.TabIndex = 0;
            Button_Open.Text = "Open";
            Button_Open.UseVisualStyleBackColor = true;
            Button_Open.Click += Button_Open_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Open);
            Name = "MainForm";
            Text = "CityGML Test";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Open;
    }
}
