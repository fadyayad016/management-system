
namespace projectBorrow
{
    partial class Disply
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_display_20 = new System.Windows.Forms.Button();
            this.btn_display_30 = new System.Windows.Forms.Button();
            this.Grid_Disaply = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Disaply)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_display_20
            // 
            this.btn_display_20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_display_20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display_20.ForeColor = System.Drawing.Color.White;
            this.btn_display_20.Location = new System.Drawing.Point(368, 18);
            this.btn_display_20.Name = "btn_display_20";
            this.btn_display_20.Size = new System.Drawing.Size(112, 45);
            this.btn_display_20.TabIndex = 7;
            this.btn_display_20.Text = "System 20%";
            this.btn_display_20.UseVisualStyleBackColor = false;
            // 
            // btn_display_30
            // 
            this.btn_display_30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_display_30.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display_30.ForeColor = System.Drawing.Color.White;
            this.btn_display_30.Location = new System.Drawing.Point(511, 18);
            this.btn_display_30.Name = "btn_display_30";
            this.btn_display_30.Size = new System.Drawing.Size(112, 45);
            this.btn_display_30.TabIndex = 8;
            this.btn_display_30.Text = "System 30%";
            this.btn_display_30.UseVisualStyleBackColor = false;
            // 
            // Grid_Disaply
            // 
            this.Grid_Disaply.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Disaply.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Disaply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Disaply.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grid_Disaply.Location = new System.Drawing.Point(12, 85);
            this.Grid_Disaply.Name = "Grid_Disaply";
            this.Grid_Disaply.RowHeadersWidth = 51;
            this.Grid_Disaply.RowTemplate.Height = 24;
            this.Grid_Disaply.Size = new System.Drawing.Size(750, 238);
            this.Grid_Disaply.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 28);
            this.label13.TabIndex = 77;
            this.label13.Text = "Disply all Customers!";
            // 
            // Disply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(768, 334);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Grid_Disaply);
            this.Controls.Add(this.btn_display_30);
            this.Controls.Add(this.btn_display_20);
            this.Name = "Disply";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Disaply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_display_20;
        private System.Windows.Forms.Button btn_display_30;
        private System.Windows.Forms.DataGridView Grid_Disaply;
        private System.Windows.Forms.Label label13;
    }
}