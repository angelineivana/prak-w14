
namespace prak_w14
{
    partial class FormTeam
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelDisTeam = new System.Windows.Forms.Label();
            this.labelDisWorst = new System.Windows.Forms.Label();
            this.labelDisTop = new System.Windows.Forms.Label();
            this.labelDisStadium = new System.Windows.Forms.Label();
            this.labelDisManager = new System.Windows.Forms.Label();
            this.labelNamaTim = new System.Windows.Forms.Label();
            this.labelNamaMan = new System.Windows.Forms.Label();
            this.labelStad = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelWDis = new System.Windows.Forms.Label();
            this.dgvHasil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(99, 50);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 59);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(295, 50);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 59);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(197, 50);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(80, 59);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(394, 50);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(80, 59);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelDisTeam
            // 
            this.labelDisTeam.AutoSize = true;
            this.labelDisTeam.Location = new System.Drawing.Point(83, 136);
            this.labelDisTeam.Name = "labelDisTeam";
            this.labelDisTeam.Size = new System.Drawing.Size(103, 20);
            this.labelDisTeam.TabIndex = 4;
            this.labelDisTeam.Text = "Team Name :";
            // 
            // labelDisWorst
            // 
            this.labelDisWorst.AutoSize = true;
            this.labelDisWorst.Location = new System.Drawing.Point(56, 288);
            this.labelDisWorst.Name = "labelDisWorst";
            this.labelDisWorst.Size = new System.Drawing.Size(130, 20);
            this.labelDisWorst.TabIndex = 5;
            this.labelDisWorst.Text = "Worst Discipline :";
            // 
            // labelDisTop
            // 
            this.labelDisTop.AutoSize = true;
            this.labelDisTop.Location = new System.Drawing.Point(91, 252);
            this.labelDisTop.Name = "labelDisTop";
            this.labelDisTop.Size = new System.Drawing.Size(95, 20);
            this.labelDisTop.TabIndex = 6;
            this.labelDisTop.Text = "Top Scorer :";
            // 
            // labelDisStadium
            // 
            this.labelDisStadium.AutoSize = true;
            this.labelDisStadium.Location = new System.Drawing.Point(110, 216);
            this.labelDisStadium.Name = "labelDisStadium";
            this.labelDisStadium.Size = new System.Drawing.Size(76, 20);
            this.labelDisStadium.TabIndex = 7;
            this.labelDisStadium.Text = "Stadium :";
            // 
            // labelDisManager
            // 
            this.labelDisManager.AutoSize = true;
            this.labelDisManager.Location = new System.Drawing.Point(102, 175);
            this.labelDisManager.Name = "labelDisManager";
            this.labelDisManager.Size = new System.Drawing.Size(84, 20);
            this.labelDisManager.TabIndex = 8;
            this.labelDisManager.Text = "Manager : ";
            // 
            // labelNamaTim
            // 
            this.labelNamaTim.AutoSize = true;
            this.labelNamaTim.Location = new System.Drawing.Point(229, 136);
            this.labelNamaTim.Name = "labelNamaTim";
            this.labelNamaTim.Size = new System.Drawing.Size(21, 20);
            this.labelNamaTim.TabIndex = 9;
            this.labelNamaTim.Text = "...";
            // 
            // labelNamaMan
            // 
            this.labelNamaMan.AutoSize = true;
            this.labelNamaMan.Location = new System.Drawing.Point(229, 175);
            this.labelNamaMan.Name = "labelNamaMan";
            this.labelNamaMan.Size = new System.Drawing.Size(21, 20);
            this.labelNamaMan.TabIndex = 10;
            this.labelNamaMan.Text = "...";
            // 
            // labelStad
            // 
            this.labelStad.AutoSize = true;
            this.labelStad.Location = new System.Drawing.Point(229, 216);
            this.labelStad.Name = "labelStad";
            this.labelStad.Size = new System.Drawing.Size(21, 20);
            this.labelStad.TabIndex = 11;
            this.labelStad.Text = "...";
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(229, 252);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(21, 20);
            this.labelTopScorer.TabIndex = 12;
            this.labelTopScorer.Text = "...";
            // 
            // labelWDis
            // 
            this.labelWDis.AutoSize = true;
            this.labelWDis.Location = new System.Drawing.Point(229, 288);
            this.labelWDis.Name = "labelWDis";
            this.labelWDis.Size = new System.Drawing.Size(21, 20);
            this.labelWDis.TabIndex = 13;
            this.labelWDis.Text = "...";
            // 
            // dgvHasil
            // 
            this.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasil.Location = new System.Drawing.Point(27, 337);
            this.dgvHasil.Name = "dgvHasil";
            this.dgvHasil.RowHeadersWidth = 62;
            this.dgvHasil.RowTemplate.Height = 28;
            this.dgvHasil.Size = new System.Drawing.Size(777, 220);
            this.dgvHasil.TabIndex = 14;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 573);
            this.Controls.Add(this.dgvHasil);
            this.Controls.Add(this.labelWDis);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelStad);
            this.Controls.Add(this.labelNamaMan);
            this.Controls.Add(this.labelNamaTim);
            this.Controls.Add(this.labelDisManager);
            this.Controls.Add(this.labelDisStadium);
            this.Controls.Add(this.labelDisTop);
            this.Controls.Add(this.labelDisWorst);
            this.Controls.Add(this.labelDisTeam);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelDisTeam;
        private System.Windows.Forms.Label labelDisWorst;
        private System.Windows.Forms.Label labelDisTop;
        private System.Windows.Forms.Label labelDisStadium;
        private System.Windows.Forms.Label labelDisManager;
        private System.Windows.Forms.Label labelNamaTim;
        private System.Windows.Forms.Label labelNamaMan;
        private System.Windows.Forms.Label labelStad;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelWDis;
        private System.Windows.Forms.DataGridView dgvHasil;
    }
}

