
namespace Petrezselyem_211130
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlak_szama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlak_osszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUjPalyazat = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.keretosszeg,
            this.szamlak_szama,
            this.szamlak_osszege});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 317);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // keretosszeg
            // 
            this.keretosszeg.HeaderText = "keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // szamlak_szama
            // 
            this.szamlak_szama.HeaderText = "Számlák száma";
            this.szamlak_szama.Name = "szamlak_szama";
            // 
            // szamlak_osszege
            // 
            this.szamlak_osszege.HeaderText = "számlák összege";
            this.szamlak_osszege.Name = "szamlak_osszege";
            // 
            // btnUjPalyazat
            // 
            this.btnUjPalyazat.BackColor = System.Drawing.Color.Green;
            this.btnUjPalyazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjPalyazat.ForeColor = System.Drawing.Color.White;
            this.btnUjPalyazat.Location = new System.Drawing.Point(71, 360);
            this.btnUjPalyazat.Name = "btnUjPalyazat";
            this.btnUjPalyazat.Size = new System.Drawing.Size(270, 78);
            this.btnUjPalyazat.TabIndex = 2;
            this.btnUjPalyazat.Text = "Új pályázat";
            this.btnUjPalyazat.UseVisualStyleBackColor = false;
            this.btnUjPalyazat.Click += new System.EventHandler(this.btnUjPalyazat_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.ForeColor = System.Drawing.Color.White;
            this.btnKilepes.Location = new System.Drawing.Point(447, 360);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(270, 78);
            this.btnKilepes.TabIndex = 2;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = false;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnUjPalyazat);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlak_szama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlak_osszege;
        private System.Windows.Forms.Button btnUjPalyazat;
        private System.Windows.Forms.Button btnKilepes;
    }
}

