namespace CurrencyConverter
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
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_from = new System.Windows.Forms.Label();
            this.lab_to = new System.Windows.Forms.Label();
            this.tb_from_value = new System.Windows.Forms.TextBox();
            this.tb_to_value = new System.Windows.Forms.TextBox();
            this.lab_amount_from = new System.Windows.Forms.Label();
            this.tb_amount_from_value = new System.Windows.Forms.TextBox();
            this.lab_amount_to = new System.Windows.Forms.Label();
            this.lab_amount_to_value = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.BackColor = System.Drawing.Color.White;
            this.lab_title.Font = new System.Drawing.Font("Fredoka One", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(396, 44);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(449, 53);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "Currency Converter";
            // 
            // lab_from
            // 
            this.lab_from.AutoSize = true;
            this.lab_from.BackColor = System.Drawing.Color.White;
            this.lab_from.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_from.Location = new System.Drawing.Point(128, 193);
            this.lab_from.Name = "lab_from";
            this.lab_from.Size = new System.Drawing.Size(96, 36);
            this.lab_from.TabIndex = 1;
            this.lab_from.Text = "From:";
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.BackColor = System.Drawing.Color.White;
            this.lab_to.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_to.Location = new System.Drawing.Point(775, 193);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(58, 36);
            this.lab_to.TabIndex = 2;
            this.lab_to.Text = "To:";
            // 
            // tb_from_value
            // 
            this.tb_from_value.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_from_value.Location = new System.Drawing.Point(233, 190);
            this.tb_from_value.Name = "tb_from_value";
            this.tb_from_value.Size = new System.Drawing.Size(148, 44);
            this.tb_from_value.TabIndex = 3;
            // 
            // tb_to_value
            // 
            this.tb_to_value.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_to_value.Location = new System.Drawing.Point(843, 190);
            this.tb_to_value.Name = "tb_to_value";
            this.tb_to_value.Size = new System.Drawing.Size(148, 44);
            this.tb_to_value.TabIndex = 4;
            // 
            // lab_amount_from
            // 
            this.lab_amount_from.AutoSize = true;
            this.lab_amount_from.BackColor = System.Drawing.Color.White;
            this.lab_amount_from.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_amount_from.Location = new System.Drawing.Point(86, 270);
            this.lab_amount_from.Name = "lab_amount_from";
            this.lab_amount_from.Size = new System.Drawing.Size(138, 36);
            this.lab_amount_from.TabIndex = 5;
            this.lab_amount_from.Text = "Amount:";
            // 
            // tb_amount_from_value
            // 
            this.tb_amount_from_value.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amount_from_value.Location = new System.Drawing.Point(233, 262);
            this.tb_amount_from_value.Name = "tb_amount_from_value";
            this.tb_amount_from_value.Size = new System.Drawing.Size(259, 44);
            this.tb_amount_from_value.TabIndex = 6;
            this.tb_amount_from_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_amount_from_value_KeyDown);
            // 
            // lab_amount_to
            // 
            this.lab_amount_to.AutoSize = true;
            this.lab_amount_to.BackColor = System.Drawing.Color.White;
            this.lab_amount_to.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_amount_to.Location = new System.Drawing.Point(695, 265);
            this.lab_amount_to.Name = "lab_amount_to";
            this.lab_amount_to.Size = new System.Drawing.Size(138, 36);
            this.lab_amount_to.TabIndex = 7;
            this.lab_amount_to.Text = "Amount:";
            // 
            // lab_amount_to_value
            // 
            this.lab_amount_to_value.AutoSize = true;
            this.lab_amount_to_value.BackColor = System.Drawing.Color.White;
            this.lab_amount_to_value.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_amount_to_value.Location = new System.Drawing.Point(845, 265);
            this.lab_amount_to_value.Name = "lab_amount_to_value";
            this.lab_amount_to_value.Size = new System.Drawing.Size(76, 36);
            this.lab_amount_to_value.TabIndex = 8;
            this.lab_amount_to_value.Text = "N/A";
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.Lime;
            this.btn_convert.Font = new System.Drawing.Font("Fredoka One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.Location = new System.Drawing.Point(495, 390);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(239, 59);
            this.btn_convert.TabIndex = 9;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::CurrencyConverter.Properties.Resources.dollar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 553);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lab_amount_to_value);
            this.Controls.Add(this.lab_amount_to);
            this.Controls.Add(this.tb_amount_from_value);
            this.Controls.Add(this.lab_amount_from);
            this.Controls.Add(this.tb_to_value);
            this.Controls.Add(this.tb_from_value);
            this.Controls.Add(this.lab_to);
            this.Controls.Add(this.lab_from);
            this.Controls.Add(this.lab_title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_from;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.TextBox tb_from_value;
        private System.Windows.Forms.TextBox tb_to_value;
        private System.Windows.Forms.Label lab_amount_from;
        private System.Windows.Forms.TextBox tb_amount_from_value;
        private System.Windows.Forms.Label lab_amount_to;
        private System.Windows.Forms.Label lab_amount_to_value;
        private System.Windows.Forms.Button btn_convert;
    }
}

