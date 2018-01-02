namespace WFAbstraction
{
    partial class Set
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
            this.btnChangeSets = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FirstSetInputText = new System.Windows.Forms.Label();
            this.SecondSetInputText = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbUnion = new System.Windows.Forms.RadioButton();
            this.rbIntersection = new System.Windows.Forms.RadioButton();
            this.rbDifference = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbNotEqual = new System.Windows.Forms.RadioButton();
            this.rbMoreOrEqual = new System.Windows.Forms.RadioButton();
            this.rbLessOrEqual = new System.Windows.Forms.RadioButton();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.rbDisplaySet = new System.Windows.Forms.RadioButton();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbOperationChose = new System.Windows.Forms.GroupBox();
            this.gbOperationChose.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeSets
            // 
            this.btnChangeSets.Location = new System.Drawing.Point(15, 90);
            this.btnChangeSets.Name = "btnChangeSets";
            this.btnChangeSets.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSets.TabIndex = 0;
            this.btnChangeSets.Text = "Change sets";
            this.btnChangeSets.UseVisualStyleBackColor = true;
            this.btnChangeSets.Click += new System.EventHandler(this.btnChangeSets_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FirstSetInputText
            // 
            this.FirstSetInputText.AutoSize = true;
            this.FirstSetInputText.Location = new System.Drawing.Point(12, 9);
            this.FirstSetInputText.Name = "FirstSetInputText";
            this.FirstSetInputText.Size = new System.Drawing.Size(310, 13);
            this.FirstSetInputText.TabIndex = 2;
            this.FirstSetInputText.Text = "Enter the elements of the first set, separating them with a comma";
            this.FirstSetInputText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SecondSetInputText
            // 
            this.SecondSetInputText.AutoSize = true;
            this.SecondSetInputText.Location = new System.Drawing.Point(12, 48);
            this.SecondSetInputText.Name = "SecondSetInputText";
            this.SecondSetInputText.Size = new System.Drawing.Size(329, 13);
            this.SecondSetInputText.TabIndex = 3;
            this.SecondSetInputText.Text = "Enter the elements of the second set, separating them with a comma";
            this.SecondSetInputText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 64);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 20);
            this.textBox2.TabIndex = 4;
            // 
            // rbUnion
            // 
            this.rbUnion.AutoSize = true;
            this.rbUnion.Location = new System.Drawing.Point(6, 34);
            this.rbUnion.Name = "rbUnion";
            this.rbUnion.Size = new System.Drawing.Size(53, 17);
            this.rbUnion.TabIndex = 6;
            this.rbUnion.TabStop = true;
            this.rbUnion.Text = "Union";
            this.rbUnion.UseVisualStyleBackColor = true;
            // 
            // rbIntersection
            // 
            this.rbIntersection.AutoSize = true;
            this.rbIntersection.Location = new System.Drawing.Point(6, 57);
            this.rbIntersection.Name = "rbIntersection";
            this.rbIntersection.Size = new System.Drawing.Size(80, 17);
            this.rbIntersection.TabIndex = 7;
            this.rbIntersection.TabStop = true;
            this.rbIntersection.Text = "Intersection";
            this.rbIntersection.UseVisualStyleBackColor = true;
            // 
            // rbDifference
            // 
            this.rbDifference.AutoSize = true;
            this.rbDifference.Location = new System.Drawing.Point(6, 80);
            this.rbDifference.Name = "rbDifference";
            this.rbDifference.Size = new System.Drawing.Size(74, 17);
            this.rbDifference.TabIndex = 8;
            this.rbDifference.TabStop = true;
            this.rbDifference.Text = "Difference";
            this.rbDifference.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Location = new System.Drawing.Point(127, 80);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(47, 17);
            this.rbLess.TabIndex = 9;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "Less";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            this.rbMore.AutoSize = true;
            this.rbMore.Location = new System.Drawing.Point(127, 57);
            this.rbMore.Name = "rbMore";
            this.rbMore.Size = new System.Drawing.Size(49, 17);
            this.rbMore.TabIndex = 10;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "More";
            this.rbMore.UseVisualStyleBackColor = true;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Location = new System.Drawing.Point(127, 34);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(52, 17);
            this.rbEqual.TabIndex = 11;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Equal";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbNotEqual
            // 
            this.rbNotEqual.AutoSize = true;
            this.rbNotEqual.Location = new System.Drawing.Point(185, 34);
            this.rbNotEqual.Name = "rbNotEqual";
            this.rbNotEqual.Size = new System.Drawing.Size(72, 17);
            this.rbNotEqual.TabIndex = 12;
            this.rbNotEqual.TabStop = true;
            this.rbNotEqual.Text = "Not Equal";
            this.rbNotEqual.UseVisualStyleBackColor = true;
            // 
            // rbMoreOrEqual
            // 
            this.rbMoreOrEqual.AutoSize = true;
            this.rbMoreOrEqual.Location = new System.Drawing.Point(185, 57);
            this.rbMoreOrEqual.Name = "rbMoreOrEqual";
            this.rbMoreOrEqual.Size = new System.Drawing.Size(91, 17);
            this.rbMoreOrEqual.TabIndex = 13;
            this.rbMoreOrEqual.TabStop = true;
            this.rbMoreOrEqual.Text = "More or Equal";
            this.rbMoreOrEqual.UseVisualStyleBackColor = true;
            // 
            // rbLessOrEqual
            // 
            this.rbLessOrEqual.AutoSize = true;
            this.rbLessOrEqual.Location = new System.Drawing.Point(185, 80);
            this.rbLessOrEqual.Name = "rbLessOrEqual";
            this.rbLessOrEqual.Size = new System.Drawing.Size(89, 17);
            this.rbLessOrEqual.TabIndex = 14;
            this.rbLessOrEqual.TabStop = true;
            this.rbLessOrEqual.Text = "Less or Equal";
            this.rbLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Location = new System.Drawing.Point(6, 127);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(92, 17);
            this.rbSum.TabIndex = 15;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "Display a Sum";
            this.rbSum.UseVisualStyleBackColor = true;
            // 
            // rbDisplaySet
            // 
            this.rbDisplaySet.AutoSize = true;
            this.rbDisplaySet.Location = new System.Drawing.Point(6, 150);
            this.rbDisplaySet.Name = "rbDisplaySet";
            this.rbDisplaySet.Size = new System.Drawing.Size(87, 17);
            this.rbDisplaySet.TabIndex = 16;
            this.rbDisplaySet.TabStop = true;
            this.rbDisplaySet.Text = "Display a Set";
            this.rbDisplaySet.UseVisualStyleBackColor = true;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(6, 173);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(75, 23);
            this.btnShowResults.TabIndex = 17;
            this.btnShowResults.Text = "Show results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Operations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Comparison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Display";
            // 
            // gbOperationChose
            // 
            this.gbOperationChose.Controls.Add(this.rbMoreOrEqual);
            this.gbOperationChose.Controls.Add(this.rbLess);
            this.gbOperationChose.Controls.Add(this.rbIntersection);
            this.gbOperationChose.Controls.Add(this.btnShowResults);
            this.gbOperationChose.Controls.Add(this.rbMore);
            this.gbOperationChose.Controls.Add(this.rbDisplaySet);
            this.gbOperationChose.Controls.Add(this.rbUnion);
            this.gbOperationChose.Controls.Add(this.rbSum);
            this.gbOperationChose.Controls.Add(this.rbEqual);
            this.gbOperationChose.Controls.Add(this.label4);
            this.gbOperationChose.Controls.Add(this.label6);
            this.gbOperationChose.Controls.Add(this.label5);
            this.gbOperationChose.Controls.Add(this.rbNotEqual);
            this.gbOperationChose.Controls.Add(this.rbLessOrEqual);
            this.gbOperationChose.Controls.Add(this.rbDifference);
            this.gbOperationChose.Location = new System.Drawing.Point(15, 119);
            this.gbOperationChose.Name = "gbOperationChose";
            this.gbOperationChose.Size = new System.Drawing.Size(324, 233);
            this.gbOperationChose.TabIndex = 23;
            this.gbOperationChose.TabStop = false;
            this.gbOperationChose.Text = "Choose an operation";
            // 
            // Set
            // 
            this.ClientSize = new System.Drawing.Size(351, 364);
            this.Controls.Add(this.gbOperationChose);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SecondSetInputText);
            this.Controls.Add(this.FirstSetInputText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnChangeSets);
            this.Name = "Set";
            this.Text = "Sets";
            this.gbOperationChose.ResumeLayout(false);
            this.gbOperationChose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnChangeSets;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FirstSetInputText;
        private System.Windows.Forms.Label SecondSetInputText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbUnion;
        private System.Windows.Forms.RadioButton rbIntersection;
        private System.Windows.Forms.RadioButton rbDifference;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbNotEqual;
        private System.Windows.Forms.RadioButton rbMoreOrEqual;
        private System.Windows.Forms.RadioButton rbLessOrEqual;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.RadioButton rbDisplaySet;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOperationChose;
    }
}

