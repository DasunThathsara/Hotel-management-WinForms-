using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel_management
{
    partial class Home
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
            RDetails = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            RDetails.Location = new Point(195, 119);
            RDetails.Name = "button1";
            RDetails.Size = new Size(392, 72);
            RDetails.TabIndex = 0;
            RDetails.Text = "Reservation Details";
            RDetails.UseVisualStyleBackColor = true;
            RDetails.Click += Reservation_Btn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RDetails);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button RDetails;
    }
}