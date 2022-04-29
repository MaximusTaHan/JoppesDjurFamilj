using JoppesDjurFamilj;

namespace JoppesGUI
{
    partial class Form1
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
            this.btnAnimals = new System.Windows.Forms.Button();
            this.outputDisplay = new System.Windows.Forms.RichTextBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.btnToys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radiobtnInteract = new System.Windows.Forms.RadioButton();
            this.radioBtnToyOpt = new System.Windows.Forms.RadioButton();
            this.inputField = new System.Windows.Forms.TextBox();
            this.inputHeader = new System.Windows.Forms.Label();
            this.outputMain = new System.Windows.Forms.RichTextBox();
            this.currentToy = new System.Windows.Forms.Label();
            this.currentPet = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnNewBall = new System.Windows.Forms.RadioButton();
            this.btnRefill = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnimals
            // 
            this.btnAnimals.Location = new System.Drawing.Point(12, 374);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(125, 49);
            this.btnAnimals.TabIndex = 0;
            this.btnAnimals.Text = "View Animals";
            this.btnAnimals.UseVisualStyleBackColor = true;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // outputDisplay
            // 
            this.outputDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputDisplay.Location = new System.Drawing.Point(159, 333);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(629, 144);
            this.outputDisplay.TabIndex = 1;
            this.outputDisplay.Text = "";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.Location = new System.Drawing.Point(3, 12);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(220, 30);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.Text = "Joppes Animal Family";
            // 
            // btnToys
            // 
            this.btnToys.Location = new System.Drawing.Point(12, 429);
            this.btnToys.Name = "btnToys";
            this.btnToys.Size = new System.Drawing.Size(125, 49);
            this.btnToys.TabIndex = 3;
            this.btnToys.Text = "View Toys";
            this.btnToys.UseVisualStyleBackColor = true;
            this.btnToys.Click += new System.EventHandler(this.btnToys_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 54);
            this.panel1.TabIndex = 4;
            // 
            // radiobtnInteract
            // 
            this.radiobtnInteract.Appearance = System.Windows.Forms.Appearance.Button;
            this.radiobtnInteract.Location = new System.Drawing.Point(12, 63);
            this.radiobtnInteract.Name = "radiobtnInteract";
            this.radiobtnInteract.Size = new System.Drawing.Size(125, 52);
            this.radiobtnInteract.TabIndex = 5;
            this.radiobtnInteract.TabStop = true;
            this.radiobtnInteract.Text = "Set Current Animal";
            this.radiobtnInteract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnInteract.UseVisualStyleBackColor = true;
            this.radiobtnInteract.CheckedChanged += new System.EventHandler(this.radiobtnInteract_CheckedChanged);
            // 
            // radioBtnToyOpt
            // 
            this.radioBtnToyOpt.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnToyOpt.Location = new System.Drawing.Point(12, 121);
            this.radioBtnToyOpt.Name = "radioBtnToyOpt";
            this.radioBtnToyOpt.Size = new System.Drawing.Size(125, 52);
            this.radioBtnToyOpt.TabIndex = 6;
            this.radioBtnToyOpt.TabStop = true;
            this.radioBtnToyOpt.Text = "Set Current Toy";
            this.radioBtnToyOpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnToyOpt.UseVisualStyleBackColor = true;
            this.radioBtnToyOpt.CheckedChanged += new System.EventHandler(this.radioBtnToyOpt_CheckedChanged);
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(159, 92);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(176, 23);
            this.inputField.TabIndex = 7;
            this.inputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputField_KeyDown);
            // 
            // inputHeader
            // 
            this.inputHeader.AutoSize = true;
            this.inputHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputHeader.Location = new System.Drawing.Point(159, 63);
            this.inputHeader.Name = "inputHeader";
            this.inputHeader.Size = new System.Drawing.Size(332, 21);
            this.inputHeader.TabIndex = 8;
            this.inputHeader.Text = "What would you like to do - options on the left";
            // 
            // outputMain
            // 
            this.outputMain.Location = new System.Drawing.Point(159, 177);
            this.outputMain.Name = "outputMain";
            this.outputMain.Size = new System.Drawing.Size(629, 136);
            this.outputMain.TabIndex = 9;
            this.outputMain.Text = "";
            // 
            // currentToy
            // 
            this.currentToy.AutoSize = true;
            this.currentToy.Location = new System.Drawing.Point(159, 122);
            this.currentToy.Name = "currentToy";
            this.currentToy.Size = new System.Drawing.Size(213, 15);
            this.currentToy.TabIndex = 10;
            this.currentToy.Text = "Current Toy: Chosen toy will Show here";
            // 
            // currentPet
            // 
            this.currentPet.AutoSize = true;
            this.currentPet.Location = new System.Drawing.Point(159, 149);
            this.currentPet.Name = "currentPet";
            this.currentPet.Size = new System.Drawing.Size(234, 15);
            this.currentPet.TabIndex = 11;
            this.currentPet.Text = "Current Pet: Chosen Pet will be shown here";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 249);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(125, 49);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(12, 304);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(125, 49);
            this.btnFeed.TabIndex = 13;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnNewBall
            // 
            this.btnNewBall.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewBall.Location = new System.Drawing.Point(12, 179);
            this.btnNewBall.Name = "btnNewBall";
            this.btnNewBall.Size = new System.Drawing.Size(61, 45);
            this.btnNewBall.TabIndex = 14;
            this.btnNewBall.TabStop = true;
            this.btnNewBall.Text = "New Ball";
            this.btnNewBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewBall.UseVisualStyleBackColor = true;
            this.btnNewBall.CheckedChanged += new System.EventHandler(this.btnNewBall_CheckedChanged);
            // 
            // btnRefill
            // 
            this.btnRefill.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRefill.Location = new System.Drawing.Point(76, 179);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(61, 45);
            this.btnRefill.TabIndex = 15;
            this.btnRefill.TabStop = true;
            this.btnRefill.Text = "Refill";
            this.btnRefill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.CheckedChanged += new System.EventHandler(this.btnRefill_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Make sure to choose a Pet and Toy before Interacting :)\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lists your pets/toys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "- Hit Enter to confirm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.btnNewBall);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.currentPet);
            this.Controls.Add(this.currentToy);
            this.Controls.Add(this.outputMain);
            this.Controls.Add(this.inputHeader);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.radioBtnToyOpt);
            this.Controls.Add(this.radiobtnInteract);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnToys);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.btnAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAnimals;
        private RichTextBox outputDisplay;
        private Label displayLabel;
        private Button btnToys;
        private Panel panel1;
        private RadioButton radiobtnInteract;
        private RadioButton radioBtnToyOpt;
        private TextBox inputField;
        private Label inputHeader;
        private RichTextBox outputMain;
        private Label currentToy;
        private Label currentPet;
        private Button btnPlay;
        private Button btnFeed;
        private RadioButton btnNewBall;
        private RadioButton btnRefill;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}