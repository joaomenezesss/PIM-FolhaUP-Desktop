﻿namespace PIM_FolhaUP_Desktop.Views
{
    partial class FrmManualUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManualUsuario));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFolhaUp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.imglIcones6 = new System.Windows.Forms.ImageList(this.components);
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lblDireitos);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(261, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(464, 345);
            this.panel6.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Empresa: Para buscar todos os dados de uma empresa existente é necessário " +
    "apertar o botão Buscar no menu lateral, informar o CNPJ da empresa e em seguida " +
    "apertar o botão \"Buscar\".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Excluir Empresa: Para excluir uma empresa existente é necessário apertar o botão " +
    "Excluir no menu lateral, informar o CNPJ da empresa e em seguida apertr o botão " +
    "\"Excluir\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireitos.Location = new System.Drawing.Point(285, 331);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(179, 14);
            this.lblDireitos.TabIndex = 3;
            this.lblDireitos.Text = "FolhaUP - Todos os direitos reservados";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(435, 54);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cadastrar Empresa: Para cadastrar uma nova empresa é necessário apertar o botão \"" +
    "Inserir\" no menu lateral e inserir todos os dados corretamente nos campos, após " +
    "isso apertar o botão \"Cadastrar\".";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(126, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "MANUAL DO USUÁRIO:";
            // 
            // lblFolhaUp
            // 
            this.lblFolhaUp.AutoSize = true;
            this.lblFolhaUp.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolhaUp.ForeColor = System.Drawing.Color.Indigo;
            this.lblFolhaUp.Location = new System.Drawing.Point(445, 9);
            this.lblFolhaUp.Name = "lblFolhaUp";
            this.lblFolhaUp.Size = new System.Drawing.Size(102, 30);
            this.lblFolhaUp.TabIndex = 11;
            this.lblFolhaUp.Text = "FolhaUp!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnRetornar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 450);
            this.panel1.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSair.ImageKey = "failure.png";
            this.btnSair.ImageList = this.imglIcones6;
            this.btnSair.Location = new System.Drawing.Point(98, 150);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(88, 65);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "  Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // imglIcones6
            // 
            this.imglIcones6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglIcones6.ImageStream")));
            this.imglIcones6.TransparentColor = System.Drawing.Color.Transparent;
            this.imglIcones6.Images.SetKeyName(0, "back.png");
            this.imglIcones6.Images.SetKeyName(1, "delete.png");
            this.imglIcones6.Images.SetKeyName(2, "failure.png");
            this.imglIcones6.Images.SetKeyName(3, "pen.png");
            this.imglIcones6.Images.SetKeyName(4, "register.png");
            this.imglIcones6.Images.SetKeyName(5, "search.png");
            // 
            // btnRetornar
            // 
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnRetornar.ImageKey = "back.png";
            this.btnRetornar.ImageList = this.imglIcones6;
            this.btnRetornar.Location = new System.Drawing.Point(1, 150);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRetornar.Size = new System.Drawing.Size(92, 65);
            this.btnRetornar.TabIndex = 7;
            this.btnRetornar.Text = " Voltar";
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVoltar.ImageKey = "failure.png";
            this.btnVoltar.Location = new System.Drawing.Point(0, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVoltar.Size = new System.Drawing.Size(186, 65);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "  Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.logoFolhaUp;
            this.pictureBox1.Location = new System.Drawing.Point(0, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManualUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblFolhaUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManualUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManualUsuario";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFolhaUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imglIcones6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}