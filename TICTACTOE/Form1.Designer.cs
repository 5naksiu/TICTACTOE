
namespace TICTACTOE
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tl = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.Button();
            this.tr = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.cc = new System.Windows.Forms.Button();
            this.bl = new System.Windows.Forms.Button();
            this.cr = new System.Windows.Forms.Button();
            this.br = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.br, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bc, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tl
            // 
            this.tl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl.Location = new System.Drawing.Point(3, 3);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(151, 96);
            this.tl.TabIndex = 0;
            this.tl.UseVisualStyleBackColor = true;
            this.tl.Click += new System.EventHandler(this.Mark);
            // 
            // tc
            // 
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(160, 3);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(151, 96);
            this.tc.TabIndex = 1;
            this.tc.UseVisualStyleBackColor = true;
            this.tc.Click += new System.EventHandler(this.Mark);
            // 
            // tr
            // 
            this.tr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tr.Location = new System.Drawing.Point(317, 3);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(152, 96);
            this.tr.TabIndex = 2;
            this.tr.UseVisualStyleBackColor = true;
            this.tr.Click += new System.EventHandler(this.Mark);
            // 
            // cl
            // 
            this.cl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cl.Location = new System.Drawing.Point(3, 105);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(151, 96);
            this.cl.TabIndex = 3;
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.Mark);
            // 
            // cc
            // 
            this.cc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cc.Location = new System.Drawing.Point(160, 105);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(151, 96);
            this.cc.TabIndex = 4;
            this.cc.UseVisualStyleBackColor = true;
            this.cc.Click += new System.EventHandler(this.Mark);
            // 
            // bl
            // 
            this.bl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bl.Location = new System.Drawing.Point(3, 207);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(151, 95);
            this.bl.TabIndex = 6;
            this.bl.UseVisualStyleBackColor = true;
            this.bl.Click += new System.EventHandler(this.Mark);
            // 
            // cr
            // 
            this.cr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr.Location = new System.Drawing.Point(317, 105);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(152, 96);
            this.cr.TabIndex = 5;
            this.cr.UseVisualStyleBackColor = true;
            this.cr.Click += new System.EventHandler(this.Mark);
            // 
            // br
            // 
            this.br.Dock = System.Windows.Forms.DockStyle.Fill;
            this.br.Location = new System.Drawing.Point(317, 207);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(152, 95);
            this.br.TabIndex = 8;
            this.br.UseVisualStyleBackColor = true;
            this.br.Click += new System.EventHandler(this.Mark);
            // 
            // bc
            // 
            this.bc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bc.Location = new System.Drawing.Point(160, 207);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(151, 95);
            this.bc.TabIndex = 7;
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny ruch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(109, 347);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerLabel.TabIndex = 4;
            this.PlayerLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 381);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Button tc;
        private System.Windows.Forms.Button tr;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button cc;
        private System.Windows.Forms.Button bl;
        private System.Windows.Forms.Button cr;
        private System.Windows.Forms.Button br;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Label PlayerLabel;
    }
}

