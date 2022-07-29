
namespace PersonasHospital
{
    partial class FormAñadir
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAdd = new System.Windows.Forms.TextBox();
            this.txtApellidoAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddlist = new System.Windows.Forms.Button();
            this.btnCancelarAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreAdd
            // 
            this.txtNombreAdd.Location = new System.Drawing.Point(56, 134);
            this.txtNombreAdd.Name = "txtNombreAdd";
            this.txtNombreAdd.Size = new System.Drawing.Size(377, 22);
            this.txtNombreAdd.TabIndex = 1;
            // 
            // txtApellidoAdd
            // 
            this.txtApellidoAdd.Location = new System.Drawing.Point(56, 209);
            this.txtApellidoAdd.Name = "txtApellidoAdd";
            this.txtApellidoAdd.Size = new System.Drawing.Size(377, 22);
            this.txtApellidoAdd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtDniAdd
            // 
            this.txtDniAdd.Location = new System.Drawing.Point(56, 289);
            this.txtDniAdd.Name = "txtDniAdd";
            this.txtDniAdd.Size = new System.Drawing.Size(377, 22);
            this.txtDniAdd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Introduzca los datos de la persona que quiere añadir a la lista";
            // 
            // btnAddlist
            // 
            this.btnAddlist.Location = new System.Drawing.Point(56, 377);
            this.btnAddlist.Name = "btnAddlist";
            this.btnAddlist.Size = new System.Drawing.Size(119, 58);
            this.btnAddlist.TabIndex = 7;
            this.btnAddlist.Text = "Añadir";
            this.btnAddlist.UseVisualStyleBackColor = true;
            this.btnAddlist.Click += new System.EventHandler(this.btnAddlist_Click);
            // 
            // btnCancelarAdd
            // 
            this.btnCancelarAdd.Location = new System.Drawing.Point(314, 377);
            this.btnCancelarAdd.Name = "btnCancelarAdd";
            this.btnCancelarAdd.Size = new System.Drawing.Size(119, 58);
            this.btnCancelarAdd.TabIndex = 8;
            this.btnCancelarAdd.Text = "Cancelar";
            this.btnCancelarAdd.UseVisualStyleBackColor = true;
            this.btnCancelarAdd.Click += new System.EventHandler(this.btnCancelarAdd_Click);
            // 
            // FormAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 507);
            this.Controls.Add(this.btnCancelarAdd);
            this.Controls.Add(this.btnAddlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDniAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAdd);
            this.Controls.Add(this.label1);
            this.Name = "FormAñadir";
            this.Text = "FormAñadir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAdd;
        private System.Windows.Forms.TextBox txtApellidoAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddlist;
        private System.Windows.Forms.Button btnCancelarAdd;
    }
}