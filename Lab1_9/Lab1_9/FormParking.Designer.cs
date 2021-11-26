
namespace DegtyarevBus
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
            this.TakeLabel = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LabelPlace = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.addParking = new System.Windows.Forms.Button();
            this.ParkingLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1130, 587);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeBus);
            this.groupBox1.Controls.Add(this.TakeLabel);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.LabelPlace);
            this.groupBox1.Location = new System.Drawing.Point(1132, 365);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(140, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(1136, 90);
            this.listBoxParkings.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(128, 82);
            this.listBoxParkings.TabIndex = 7;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1140, 177);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить парковку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1136, 24);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(128, 20);
            this.textBoxNewLevelName.TabIndex = 9;
            // 
            // addParking
            // 
            this.addParking.Location = new System.Drawing.Point(1136, 50);
            this.addParking.Name = "addParking";
            this.addParking.Size = new System.Drawing.Size(135, 35);
            this.addParking.TabIndex = 10;
            this.addParking.Text = "Добавить парковку";
            this.addParking.UseVisualStyleBackColor = true;
            this.addParking.TextChanged += new System.EventHandler(this.buttonAddParking_Click);
            this.addParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // ParkingLabel
            // 
            this.ParkingLabel.AutoSize = true;
            this.ParkingLabel.Location = new System.Drawing.Point(1173, 8);
            this.ParkingLabel.Name = "ParkingLabel";
            this.ParkingLabel.Size = new System.Drawing.Size(60, 13);
            this.ParkingLabel.TabIndex = 11;
            this.ParkingLabel.Text = "Парковки:";
            this.ParkingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1140, 264);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 53);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить автобус";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 679);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ParkingLabel);
            this.Controls.Add(this.addParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Label TakeLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label LabelPlace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button addParking;
        private System.Windows.Forms.Label ParkingLabel;
        private System.Windows.Forms.Button buttonAdd;
    }
}