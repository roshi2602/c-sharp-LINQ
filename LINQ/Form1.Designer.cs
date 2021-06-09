
namespace LINQ
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
            this.ID = new System.Windows.Forms.Label();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NAMEtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AGEtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CLASStextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GENDERtextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(128, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 16);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // IDtextbox
            // 
            this.IDtextbox.Location = new System.Drawing.Point(226, 51);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(185, 20);
            this.IDtextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NAMEtextbox
            // 
            this.NAMEtextbox.Location = new System.Drawing.Point(226, 91);
            this.NAMEtextbox.Name = "NAMEtextbox";
            this.NAMEtextbox.Size = new System.Drawing.Size(185, 20);
            this.NAMEtextbox.TabIndex = 1;
            this.NAMEtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "AGE\r\n";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // AGEtextbox
            // 
            this.AGEtextbox.Location = new System.Drawing.Point(226, 130);
            this.AGEtextbox.Name = "AGEtextbox";
            this.AGEtextbox.Size = new System.Drawing.Size(185, 20);
            this.AGEtextbox.TabIndex = 1;
            this.AGEtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "CLASS";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // CLASStextbox
            // 
            this.CLASStextbox.Location = new System.Drawing.Point(226, 210);
            this.CLASStextbox.Name = "CLASStextbox";
            this.CLASStextbox.Size = new System.Drawing.Size(185, 20);
            this.CLASStextbox.TabIndex = 1;
            this.CLASStextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "GENDER";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // GENDERtextbox
            // 
            this.GENDERtextbox.Location = new System.Drawing.Point(226, 176);
            this.GENDERtextbox.Name = "GENDERtextbox";
            this.GENDERtextbox.Size = new System.Drawing.Size(185, 20);
            this.GENDERtextbox.TabIndex = 1;
            this.GENDERtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "NEXT\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(443, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "PREVIOUS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GENDERtextbox);
            this.Controls.Add(this.CLASStextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AGEtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NAMEtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.Text = "STUDENT DETAILS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NAMEtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AGEtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CLASStextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GENDERtextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}