namespace Algortimiek_CircusTrein
{
    partial class CircusTrein
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
            this.CbbEetSoort = new System.Windows.Forms.ComboBox();
            this.TbNaam = new System.Windows.Forms.TextBox();
            this.CbbFormaat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LvAnimals = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.NameCLM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeCLM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EatingKindCLM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointsCLM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbWagons = new System.Windows.Forms.ListBox();
            this.LbAntimalsInWagon = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbbEetSoort
            // 
            this.CbbEetSoort.FormattingEnabled = true;
            this.CbbEetSoort.Location = new System.Drawing.Point(14, 142);
            this.CbbEetSoort.Name = "CbbEetSoort";
            this.CbbEetSoort.Size = new System.Drawing.Size(121, 21);
            this.CbbEetSoort.TabIndex = 0;
            // 
            // TbNaam
            // 
            this.TbNaam.Location = new System.Drawing.Point(11, 93);
            this.TbNaam.Name = "TbNaam";
            this.TbNaam.Size = new System.Drawing.Size(121, 20);
            this.TbNaam.TabIndex = 1;
            // 
            // CbbFormaat
            // 
            this.CbbFormaat.FormattingEnabled = true;
            this.CbbFormaat.Location = new System.Drawing.Point(14, 190);
            this.CbbFormaat.Name = "CbbFormaat";
            this.CbbFormaat.Size = new System.Drawing.Size(121, 21);
            this.CbbFormaat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Circustrein";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eetsoort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formaat";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(14, 229);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(121, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Voeg toe";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LvAnimals
            // 
            this.LvAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCLM,
            this.SizeCLM,
            this.EatingKindCLM,
            this.PointsCLM});
            this.LvAnimals.Location = new System.Drawing.Point(191, 77);
            this.LvAnimals.Name = "LvAnimals";
            this.LvAnimals.Size = new System.Drawing.Size(302, 173);
            this.LvAnimals.TabIndex = 4;
            this.LvAnimals.UseCompatibleStateImageBehavior = false;
            this.LvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Naam";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(191, 256);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(909, 40);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // NameCLM
            // 
            this.NameCLM.Text = "Naam";
            // 
            // SizeCLM
            // 
            this.SizeCLM.Text = "Grote";
            this.SizeCLM.Width = 73;
            // 
            // EatingKindCLM
            // 
            this.EatingKindCLM.Text = "Eet soort";
            this.EatingKindCLM.Width = 72;
            // 
            // PointsCLM
            // 
            this.PointsCLM.Text = "Punten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wagons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dieren";
            // 
            // LbWagons
            // 
            this.LbWagons.FormattingEnabled = true;
            this.LbWagons.Location = new System.Drawing.Point(514, 77);
            this.LbWagons.Name = "LbWagons";
            this.LbWagons.Size = new System.Drawing.Size(285, 173);
            this.LbWagons.TabIndex = 7;
            // 
            // LbAntimalsInWagon
            // 
            this.LbAntimalsInWagon.FormattingEnabled = true;
            this.LbAntimalsInWagon.Location = new System.Drawing.Point(815, 77);
            this.LbAntimalsInWagon.Name = "LbAntimalsInWagon";
            this.LbAntimalsInWagon.Size = new System.Drawing.Size(285, 173);
            this.LbAntimalsInWagon.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(810, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Animals in wagon";
            // 
            // CircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 308);
            this.Controls.Add(this.LbAntimalsInWagon);
            this.Controls.Add(this.LbWagons);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.LvAnimals);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNaam);
            this.Controls.Add(this.CbbFormaat);
            this.Controls.Add(this.CbbEetSoort);
            this.Name = "CircusTrein";
            this.Text = "Dieren Circus Berekenaar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbbEetSoort;
        private System.Windows.Forms.TextBox TbNaam;
        private System.Windows.Forms.ComboBox CbbFormaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView LvAnimals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.ColumnHeader NameCLM;
        private System.Windows.Forms.ColumnHeader SizeCLM;
        private System.Windows.Forms.ColumnHeader EatingKindCLM;
        private System.Windows.Forms.ColumnHeader PointsCLM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LbWagons;
        private System.Windows.Forms.ListBox LbAntimalsInWagon;
        private System.Windows.Forms.Label label7;
    }
}

