
namespace Homework
{
    partial class Homework_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework_Hello));
            this.labName = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txrName = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.labStar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(58, 84);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(92, 43);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.BackColor = System.Drawing.Color.Transparent;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(10, 152);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(140, 37);
            this.labEng.TabIndex = 1;
            this.labEng.Text = "英文姓名:";
            this.labEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.Location = new System.Drawing.Point(68, 222);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(82, 37);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "性別:";
            this.labSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(47, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "SayHello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(240, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Say Hi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txrName
            // 
            this.txrName.BackColor = System.Drawing.Color.Gainsboro;
            this.txrName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txrName.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold);
            this.txrName.Location = new System.Drawing.Point(145, 84);
            this.txrName.Name = "txrName";
            this.txrName.Size = new System.Drawing.Size(185, 39);
            this.txrName.TabIndex = 6;
            this.txrName.Text = "廖家毅";
            this.txrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEng
            // 
            this.txtEng.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtEng.Location = new System.Drawing.Point(145, 152);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(185, 39);
            this.txtEng.TabIndex = 7;
            this.txtEng.Text = "Dark";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtSex.Location = new System.Drawing.Point(145, 222);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(185, 39);
            this.txtSex.TabIndex = 8;
            this.txtSex.Text = "男性";
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStar
            // 
            this.txtStar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStar.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtStar.Location = new System.Drawing.Point(145, 287);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(185, 39);
            this.txtStar.TabIndex = 9;
            this.txtStar.Text = "獅子座";
            this.txtStar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.BackColor = System.Drawing.Color.Transparent;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.Location = new System.Drawing.Point(68, 287);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(82, 37);
            this.labStar.TabIndex = 3;
            this.labStar.Text = "星座:";
            this.labStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Homework_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txrName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homework_Hello";
            this.Text = "你好!C#";
            this.Load += new System.EventHandler(this.Homework_Hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txrName;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Label labStar;
    }
}