
namespace PersonasHospital
{
    partial class FormMod
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
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnModList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDniMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(308, 362);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(119, 58);
            this.btnCancelarMod.TabIndex = 17;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            // 
            // btnModList
            // 
            this.btnModList.Location = new System.Drawing.Point(50, 362);
            this.btnModList.Name = "btnModList";
            this.btnModList.Size = new System.Drawing.Size(119, 58);
            this.btnModList.TabIndex = 16;
            this.btnModList.Text = "Modificar";
            this.btnModList.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Modifique los datos de la persona seleccionada";
            // 
            // txtDniMod
            // 
            this.txtDniMod.Location = new System.Drawing.Point(50, 271);
            this.txtDniMod.Name = "txtDniMod";
            this.txtDniMod.Size = new System.Drawing.Size(377, 22);
            this.txtDniMod.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dni";
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Location = new System.Drawing.Point(50, 191);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(377, 22);
            this.txtApellidoMod.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(50, 116);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(377, 22);
            this.txtNombreMod.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // FormMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 456);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnModList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDniMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.label1);
            this.Name = "FormMod";
            this.Text = "FormMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Button btnModList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDniMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label label1;
    }
}