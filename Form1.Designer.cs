namespace WinFormsApp3
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
            Label1 = new Label();
            Label2 = new Label();
            LblArray = new Label();
            LblRezultat = new Label();
            TxtValoare = new TextBox();
            BtnGenerare = new Button();
            BtnAdauga = new Button();
            BtnAfisare = new Button();
            BtnMax = new Button();
            BtnMin = new Button();
            BtnSortareWhile = new Button();
            BtnSortareFor = new Button();
            TxtNr = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(119, 51);
            Label1.Name = "Label1";
            Label1.Size = new Size(116, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Number of elements";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(120, 78);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Value of element";
            // 
            // LblArray
            // 
            LblArray.AutoSize = true;
            LblArray.Location = new Point(123, 122);
            LblArray.Name = "LblArray";
            LblArray.Size = new Size(38, 15);
            LblArray.TabIndex = 2;
            LblArray.Text = "Array ";
            // 
            // LblRezultat
            // 
            LblRezultat.AutoSize = true;
            LblRezultat.Location = new Point(125, 160);
            LblRezultat.Name = "LblRezultat";
            LblRezultat.Size = new Size(39, 15);
            LblRezultat.TabIndex = 3;
            LblRezultat.Text = "Result";
            // 
            // TxtValoare
            // 
            TxtValoare.Location = new Point(294, 78);
            TxtValoare.Name = "TxtValoare";
            TxtValoare.Size = new Size(100, 23);
            TxtValoare.TabIndex = 4;
            // 
            // BtnGenerare
            // 
            BtnGenerare.Location = new Point(629, 43);
            BtnGenerare.Name = "BtnGenerare";
            BtnGenerare.Size = new Size(98, 23);
            BtnGenerare.TabIndex = 5;
            BtnGenerare.Text = "Generate array";
            BtnGenerare.UseVisualStyleBackColor = true;
            BtnGenerare.Click += BtnGenerare_Click;
            // 
            // BtnAdauga
            // 
            BtnAdauga.Location = new Point(629, 105);
            BtnAdauga.Name = "BtnAdauga";
            BtnAdauga.Size = new Size(98, 23);
            BtnAdauga.TabIndex = 6;
            BtnAdauga.Text = "Add";
            BtnAdauga.UseVisualStyleBackColor = true;
            BtnAdauga.Click += BtnAdauga_Click;
            // 
            // BtnAfisare
            // 
            BtnAfisare.Location = new Point(629, 160);
            BtnAfisare.Name = "BtnAfisare";
            BtnAfisare.Size = new Size(98, 23);
            BtnAfisare.TabIndex = 7;
            BtnAfisare.Text = "Show array";
            BtnAfisare.UseVisualStyleBackColor = true;
            BtnAfisare.Click += BtnAfisare_Click;
            // 
            // BtnMax
            // 
            BtnMax.Location = new Point(629, 291);
            BtnMax.Name = "BtnMax";
            BtnMax.Size = new Size(86, 57);
            BtnMax.TabIndex = 8;
            BtnMax.Text = "Identify maxim";
            BtnMax.UseVisualStyleBackColor = true;
            BtnMax.Click += BtnMax_Click;
            // 
            // BtnMin
            // 
            BtnMin.Location = new Point(485, 291);
            BtnMin.Name = "BtnMin";
            BtnMin.Size = new Size(75, 57);
            BtnMin.TabIndex = 9;
            BtnMin.Text = "Identify minim";
            BtnMin.UseVisualStyleBackColor = true;
            BtnMin.Click += BtnMin_Click;
            // 
            // BtnSortareWhile
            // 
            BtnSortareWhile.Location = new Point(353, 291);
            BtnSortareWhile.Name = "BtnSortareWhile";
            BtnSortareWhile.Size = new Size(75, 57);
            BtnSortareWhile.TabIndex = 10;
            BtnSortareWhile.Text = "Sortare with while";
            BtnSortareWhile.UseVisualStyleBackColor = true;
            BtnSortareWhile.Click += BtnSortareWhile_Click;
            // 
            // BtnSortareFor
            // 
            BtnSortareFor.Location = new Point(220, 291);
            BtnSortareFor.Name = "BtnSortareFor";
            BtnSortareFor.Size = new Size(75, 57);
            BtnSortareFor.TabIndex = 11;
            BtnSortareFor.Text = "Sort ascending";
            BtnSortareFor.UseVisualStyleBackColor = true;
            BtnSortareFor.Click += BtnSortareFor_Click;
            // 
            // TxtNr
            // 
            TxtNr.Location = new Point(294, 43);
            TxtNr.Name = "TxtNr";
            TxtNr.Size = new Size(100, 23);
            TxtNr.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(798, 431);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 13;
            label3.Text = "Made by Christian";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 446);
            Controls.Add(label3);
            Controls.Add(TxtNr);
            Controls.Add(BtnSortareFor);
            Controls.Add(BtnSortareWhile);
            Controls.Add(BtnMin);
            Controls.Add(BtnMax);
            Controls.Add(BtnAfisare);
            Controls.Add(BtnAdauga);
            Controls.Add(BtnGenerare);
            Controls.Add(TxtValoare);
            Controls.Add(LblRezultat);
            Controls.Add(LblArray);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private Label Label2;
        private Label LblArray;
        private Label LblRezultat;
        private TextBox TxtValoare;
        private Button BtnGenerare;
        private Button BtnAdauga;
        private Button BtnAfisare;
        private Button BtnMax;
        private Button BtnMin;
        private Button BtnSortareWhile;
        private Button BtnSortareFor;
        private TextBox TxtNr;
        private Label label3;
    }
}
