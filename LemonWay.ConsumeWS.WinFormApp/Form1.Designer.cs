namespace LemonWay.ConsumeWS.WinFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FS = new System.Windows.Forms.TextBox();
            this.txt_xtj = new System.Windows.Forms.RichTextBox();
            this.btn_compute_FS = new System.Windows.Forms.Button();
            this.btn_convert_json = new System.Windows.Forms.Button();
            this.lbl_result_fs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_json = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_execute_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fibonacci Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "XmlToJson Service";
            // 
            // txt_FS
            // 
            this.txt_FS.Location = new System.Drawing.Point(157, 46);
            this.txt_FS.Name = "txt_FS";
            this.txt_FS.Size = new System.Drawing.Size(126, 20);
            this.txt_FS.TabIndex = 2;
            // 
            // txt_xtj
            // 
            this.txt_xtj.Location = new System.Drawing.Point(17, 199);
            this.txt_xtj.Name = "txt_xtj";
            this.txt_xtj.Size = new System.Drawing.Size(316, 69);
            this.txt_xtj.TabIndex = 3;
            this.txt_xtj.Text = "";
            // 
            // btn_compute_FS
            // 
            this.btn_compute_FS.Location = new System.Drawing.Point(289, 46);
            this.btn_compute_FS.Name = "btn_compute_FS";
            this.btn_compute_FS.Size = new System.Drawing.Size(112, 23);
            this.btn_compute_FS.TabIndex = 4;
            this.btn_compute_FS.Text = "Compute Fibonancci";
            this.btn_compute_FS.UseVisualStyleBackColor = true;
            this.btn_compute_FS.Click += new System.EventHandler(this.btn_compute_FS_Click);
            // 
            // btn_convert_json
            // 
            this.btn_convert_json.AccessibleName = "r";
            this.btn_convert_json.Location = new System.Drawing.Point(339, 199);
            this.btn_convert_json.Name = "btn_convert_json";
            this.btn_convert_json.Size = new System.Drawing.Size(62, 23);
            this.btn_convert_json.TabIndex = 5;
            this.btn_convert_json.Text = "Convertir";
            this.btn_convert_json.UseVisualStyleBackColor = true;
            this.btn_convert_json.Click += new System.EventHandler(this.btn_convert_json_Click);
            // 
            // lbl_result_fs
            // 
            this.lbl_result_fs.AutoSize = true;
            this.lbl_result_fs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_fs.Location = new System.Drawing.Point(161, 81);
            this.lbl_result_fs.Name = "lbl_result_fs";
            this.lbl_result_fs.Size = new System.Drawing.Size(92, 31);
            this.lbl_result_fs.TabIndex = 6;
            this.lbl_result_fs.Text = "label3";
            this.lbl_result_fs.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entrer une valeur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entrer le XML à convertir en JSON";
            // 
            // txt_json
            // 
            this.txt_json.Enabled = false;
            this.txt_json.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_json.Location = new System.Drawing.Point(16, 302);
            this.txt_json.Name = "txt_json";
            this.txt_json.Size = new System.Drawing.Size(385, 144);
            this.txt_json.TabIndex = 9;
            this.txt_json.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "XML en JSON";
            // 
            // btn_execute_all
            // 
            this.btn_execute_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_execute_all.Location = new System.Drawing.Point(21, 526);
            this.btn_execute_all.Name = "btn_execute_all";
            this.btn_execute_all.Size = new System.Drawing.Size(376, 51);
            this.btn_execute_all.TabIndex = 11;
            this.btn_execute_all.Text = "Executer tous les services";
            this.btn_execute_all.UseVisualStyleBackColor = true;
            this.btn_execute_all.Click += new System.EventHandler(this.btn_execute_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 611);
            this.Controls.Add(this.btn_execute_all);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_json);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_result_fs);
            this.Controls.Add(this.btn_convert_json);
            this.Controls.Add(this.btn_compute_FS);
            this.Controls.Add(this.txt_xtj);
            this.Controls.Add(this.txt_FS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FS;
        private System.Windows.Forms.RichTextBox txt_xtj;
        private System.Windows.Forms.Button btn_compute_FS;
        private System.Windows.Forms.Button btn_convert_json;
        private System.Windows.Forms.Label lbl_result_fs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_json;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_execute_all;
    }
}
