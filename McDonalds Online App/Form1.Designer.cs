namespace McDonalds_Online_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.burgersLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.burgersOutput = new System.Windows.Forms.TextBox();
            this.friesOutput = new System.Windows.Forms.TextBox();
            this.drinksOutput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.cashTenderdOutput = new System.Windows.Forms.TextBox();
            this.cashTenderdLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "McDonalds ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // burgersLabel
            // 
            this.burgersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersLabel.Location = new System.Drawing.Point(12, 69);
            this.burgersLabel.Name = "burgersLabel";
            this.burgersLabel.Size = new System.Drawing.Size(183, 37);
            this.burgersLabel.TabIndex = 1;
            this.burgersLabel.Text = "Number Of Burgers";
            this.burgersLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // friesLabel
            // 
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(12, 94);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(155, 27);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number Of Fries";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(12, 121);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(169, 27);
            this.drinksLabel.TabIndex = 3;
            this.drinksLabel.Text = "Number Of Drinks";
            // 
            // burgersOutput
            // 
            this.burgersOutput.Location = new System.Drawing.Point(201, 73);
            this.burgersOutput.Name = "burgersOutput";
            this.burgersOutput.Size = new System.Drawing.Size(100, 20);
            this.burgersOutput.TabIndex = 4;
            // 
            // friesOutput
            // 
            this.friesOutput.Location = new System.Drawing.Point(201, 99);
            this.friesOutput.Name = "friesOutput";
            this.friesOutput.Size = new System.Drawing.Size(100, 20);
            this.friesOutput.TabIndex = 5;
            // 
            // drinksOutput
            // 
            this.drinksOutput.Location = new System.Drawing.Point(201, 125);
            this.drinksOutput.Name = "drinksOutput";
            this.drinksOutput.Size = new System.Drawing.Size(100, 20);
            this.drinksOutput.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.Yellow;
            this.calculateButton.Location = new System.Drawing.Point(16, 164);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(285, 38);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(12, 226);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(169, 27);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.Location = new System.Drawing.Point(201, 231);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(100, 20);
            this.subTotalOutput.TabIndex = 9;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(201, 257);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 20);
            this.taxOutput.TabIndex = 10;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(201, 283);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 20);
            this.totalOutput.TabIndex = 11;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 253);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(169, 27);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 284);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(169, 27);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total";
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.ForeColor = System.Drawing.Color.Yellow;
            this.calculateChangeButton.Location = new System.Drawing.Point(16, 362);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(285, 38);
            this.calculateChangeButton.TabIndex = 14;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // cashTenderdOutput
            // 
            this.cashTenderdOutput.Location = new System.Drawing.Point(201, 326);
            this.cashTenderdOutput.Name = "cashTenderdOutput";
            this.cashTenderdOutput.Size = new System.Drawing.Size(100, 20);
            this.cashTenderdOutput.TabIndex = 15;
            // 
            // cashTenderdLabel
            // 
            this.cashTenderdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTenderdLabel.Location = new System.Drawing.Point(12, 326);
            this.cashTenderdLabel.Name = "cashTenderdLabel";
            this.cashTenderdLabel.Size = new System.Drawing.Size(169, 27);
            this.cashTenderdLabel.TabIndex = 16;
            this.cashTenderdLabel.Text = "Cash Tendered";
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(201, 416);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 20);
            this.changeOutput.TabIndex = 17;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 416);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(169, 27);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.ForeColor = System.Drawing.Color.Yellow;
            this.printReceiptButton.Location = new System.Drawing.Point(16, 456);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(285, 38);
            this.printReceiptButton.TabIndex = 21;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(346, 73);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(369, 370);
            this.receiptLabel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(727, 519);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.cashTenderdLabel);
            this.Controls.Add(this.cashTenderdOutput);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinksOutput);
            this.Controls.Add(this.friesOutput);
            this.Controls.Add(this.burgersOutput);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgersLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mcdonalds App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label burgersLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox burgersOutput;
        private System.Windows.Forms.TextBox friesOutput;
        private System.Windows.Forms.TextBox drinksOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.TextBox subTotalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.TextBox cashTenderdOutput;
        private System.Windows.Forms.Label cashTenderdLabel;
        private System.Windows.Forms.TextBox changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label receiptLabel;
    }
}

