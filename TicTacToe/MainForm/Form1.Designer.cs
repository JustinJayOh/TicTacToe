namespace MainForm
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
            this.topLeftButton = new System.Windows.Forms.Button();
            this.topMiddleButton = new System.Windows.Forms.Button();
            this.topRightButton = new System.Windows.Forms.Button();
            this.middleLeftButton = new System.Windows.Forms.Button();
            this.middleButton = new System.Windows.Forms.Button();
            this.middleRightButton = new System.Windows.Forms.Button();
            this.bottomLeftButton = new System.Windows.Forms.Button();
            this.bottomMiddleButton = new System.Windows.Forms.Button();
            this.bottomRightButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topLeftButton
            // 
            this.topLeftButton.Location = new System.Drawing.Point(93, 85);
            this.topLeftButton.Name = "topLeftButton";
            this.topLeftButton.Size = new System.Drawing.Size(72, 68);
            this.topLeftButton.TabIndex = 0;
            this.topLeftButton.UseVisualStyleBackColor = true;
            this.topLeftButton.Click += new System.EventHandler(this.topLeftButton_Click);
            // 
            // topMiddleButton
            // 
            this.topMiddleButton.Location = new System.Drawing.Point(171, 85);
            this.topMiddleButton.Name = "topMiddleButton";
            this.topMiddleButton.Size = new System.Drawing.Size(71, 68);
            this.topMiddleButton.TabIndex = 1;
            this.topMiddleButton.UseVisualStyleBackColor = true;
            this.topMiddleButton.Click += new System.EventHandler(this.topMiddleButton_Click);
            // 
            // topRightButton
            // 
            this.topRightButton.Location = new System.Drawing.Point(248, 85);
            this.topRightButton.Name = "topRightButton";
            this.topRightButton.Size = new System.Drawing.Size(71, 68);
            this.topRightButton.TabIndex = 2;
            this.topRightButton.UseVisualStyleBackColor = true;
            this.topRightButton.Click += new System.EventHandler(this.topRightButton_Click);
            // 
            // middleLeftButton
            // 
            this.middleLeftButton.Location = new System.Drawing.Point(93, 159);
            this.middleLeftButton.Name = "middleLeftButton";
            this.middleLeftButton.Size = new System.Drawing.Size(72, 68);
            this.middleLeftButton.TabIndex = 3;
            this.middleLeftButton.UseVisualStyleBackColor = true;
            this.middleLeftButton.Click += new System.EventHandler(this.middleLeftButton_Click);
            // 
            // middleButton
            // 
            this.middleButton.Location = new System.Drawing.Point(171, 159);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(71, 68);
            this.middleButton.TabIndex = 4;
            this.middleButton.UseVisualStyleBackColor = true;
            this.middleButton.Click += new System.EventHandler(this.middleButton_Click);
            // 
            // middleRightButton
            // 
            this.middleRightButton.Location = new System.Drawing.Point(248, 159);
            this.middleRightButton.Name = "middleRightButton";
            this.middleRightButton.Size = new System.Drawing.Size(71, 68);
            this.middleRightButton.TabIndex = 5;
            this.middleRightButton.UseVisualStyleBackColor = true;
            this.middleRightButton.Click += new System.EventHandler(this.middleRightButton_Click);
            // 
            // bottomLeftButton
            // 
            this.bottomLeftButton.Location = new System.Drawing.Point(93, 233);
            this.bottomLeftButton.Name = "bottomLeftButton";
            this.bottomLeftButton.Size = new System.Drawing.Size(72, 71);
            this.bottomLeftButton.TabIndex = 6;
            this.bottomLeftButton.UseVisualStyleBackColor = true;
            this.bottomLeftButton.Click += new System.EventHandler(this.bottomLeftButton_Click);
            // 
            // bottomMiddleButton
            // 
            this.bottomMiddleButton.Location = new System.Drawing.Point(171, 233);
            this.bottomMiddleButton.Name = "bottomMiddleButton";
            this.bottomMiddleButton.Size = new System.Drawing.Size(71, 71);
            this.bottomMiddleButton.TabIndex = 7;
            this.bottomMiddleButton.UseVisualStyleBackColor = true;
            this.bottomMiddleButton.Click += new System.EventHandler(this.bottomMiddleButton_Click);
            // 
            // bottomRightButton
            // 
            this.bottomRightButton.Location = new System.Drawing.Point(248, 233);
            this.bottomRightButton.Name = "bottomRightButton";
            this.bottomRightButton.Size = new System.Drawing.Size(71, 71);
            this.bottomRightButton.TabIndex = 8;
            this.bottomRightButton.UseVisualStyleBackColor = true;
            this.bottomRightButton.Click += new System.EventHandler(this.bottomRightButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(522, 95);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(100, 49);
            this.newGameButton.TabIndex = 9;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameInfoLabel
            // 
            this.gameInfoLabel.Location = new System.Drawing.Point(477, 159);
            this.gameInfoLabel.Name = "gameInfoLabel";
            this.gameInfoLabel.Size = new System.Drawing.Size(193, 145);
            this.gameInfoLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 417);
            this.Controls.Add(this.gameInfoLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.bottomRightButton);
            this.Controls.Add(this.bottomMiddleButton);
            this.Controls.Add(this.bottomLeftButton);
            this.Controls.Add(this.middleRightButton);
            this.Controls.Add(this.middleButton);
            this.Controls.Add(this.middleLeftButton);
            this.Controls.Add(this.topRightButton);
            this.Controls.Add(this.topMiddleButton);
            this.Controls.Add(this.topLeftButton);
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button topLeftButton;
        private System.Windows.Forms.Button topMiddleButton;
        private System.Windows.Forms.Button topRightButton;
        private System.Windows.Forms.Button middleLeftButton;
        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button middleRightButton;
        private System.Windows.Forms.Button bottomLeftButton;
        private System.Windows.Forms.Button bottomMiddleButton;
        private System.Windows.Forms.Button bottomRightButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label gameInfoLabel;
    }
}

