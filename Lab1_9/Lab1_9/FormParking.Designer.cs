
namespace Lab1_9
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonCreateBus = new System.Windows.Forms.Button();
            this.buttonCreateDoubleDecker = new System.Windows.Forms.Button();
            this.TakeLabel = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LabelPlace = new System.Windows.Forms.Label();
            this.groupTakeBus = new System.Windows.Forms.GroupBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupTakeBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1094, 558);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonCreateBus
            // 
            this.buttonCreateBus.Location = new System.Drawing.Point(1099, 11);
            this.buttonCreateBus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateBus.Name = "buttonCreateBus";
            this.buttonCreateBus.Size = new System.Drawing.Size(116, 57);
            this.buttonCreateBus.TabIndex = 1;
            this.buttonCreateBus.Text = "Припарковать автобус";
            this.buttonCreateBus.UseVisualStyleBackColor = true;
            this.buttonCreateBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // buttonCreateDoubleDecker
            // 
            this.buttonCreateDoubleDecker.Location = new System.Drawing.Point(1099, 72);
            this.buttonCreateDoubleDecker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateDoubleDecker.Name = "buttonCreateDoubleDecker";
            this.buttonCreateDoubleDecker.Size = new System.Drawing.Size(116, 72);
            this.buttonCreateDoubleDecker.TabIndex = 2;
            this.buttonCreateDoubleDecker.Text = "Припарковать двухэтажный автобус";
            this.buttonCreateDoubleDecker.UseVisualStyleBackColor = true;
            this.buttonCreateDoubleDecker.Click += new System.EventHandler(this.buttonSetDoubleDecker_Click);
            // 
            // TakeLabel
            // 
            this.TakeLabel.AutoSize = true;
            this.TakeLabel.Location = new System.Drawing.Point(18, 14);
            this.TakeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TakeLabel.Name = "TakeLabel";
            this.TakeLabel.Size = new System.Drawing.Size(92, 13);
            this.TakeLabel.TabIndex = 3;
            this.TakeLabel.Text = "Забрать автобус";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(56, 29);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(54, 20);
            this.maskedTextBox.TabIndex = 4;
            // 
            // LabelPlace
            // 
            this.LabelPlace.AutoSize = true;
            this.LabelPlace.Location = new System.Drawing.Point(12, 32);
            this.LabelPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlace.Name = "LabelPlace";
            this.LabelPlace.Size = new System.Drawing.Size(42, 13);
            this.LabelPlace.TabIndex = 5;
            this.LabelPlace.Text = "Место:";
            // 
            // groupTakeBus
            // 
            this.groupTakeBus.Controls.Add(this.buttonTakeBus);
            this.groupTakeBus.Controls.Add(this.TakeLabel);
            this.groupTakeBus.Controls.Add(this.maskedTextBox);
            this.groupTakeBus.Controls.Add(this.LabelPlace);
            this.groupTakeBus.Location = new System.Drawing.Point(1099, 157);
            this.groupTakeBus.Margin = new System.Windows.Forms.Padding(2);
            this.groupTakeBus.Name = "groupTakeBus";
            this.groupTakeBus.Padding = new System.Windows.Forms.Padding(2);
            this.groupTakeBus.Size = new System.Drawing.Size(140, 100);
            this.groupTakeBus.TabIndex = 6;
            this.groupTakeBus.TabStop = false;
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(15, 49);
            this.buttonTakeBus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(96, 25);
            this.buttonTakeBus.TabIndex = 6;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 677);
            this.Controls.Add(this.groupTakeBus);
            this.Controls.Add(this.buttonCreateDoubleDecker);
            this.Controls.Add(this.buttonCreateBus);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupTakeBus.ResumeLayout(false);
            this.groupTakeBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonCreateBus;
        private System.Windows.Forms.Button buttonCreateDoubleDecker;
        private System.Windows.Forms.Label TakeLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label LabelPlace;
        private System.Windows.Forms.GroupBox groupTakeBus;
        private System.Windows.Forms.Button buttonTakeBus;
    }
}