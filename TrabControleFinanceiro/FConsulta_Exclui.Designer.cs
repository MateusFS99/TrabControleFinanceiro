﻿namespace TrabControleFinanceiro
{
    partial class FConsulta_Exclui
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsulta_Exclui));
			this.pnlBtn = new System.Windows.Forms.Panel();
			this.btnAction = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.lbPoint = new System.Windows.Forms.Label();
			this.ttbFiltro = new System.Windows.Forms.TextBox();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.cbOrdenar = new System.Windows.Forms.ComboBox();
			this.lbOrdenar = new System.Windows.Forms.Label();
			this.cbFiltrar = new System.Windows.Forms.ComboBox();
			this.lbFiltro = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvConsulta = new System.Windows.Forms.DataGridView();
			this.pnlBtn.SuspendLayout();
			this.pnlCampos.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlBtn
			// 
			this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
			this.pnlBtn.Controls.Add(this.btnAction);
			this.pnlBtn.Controls.Add(this.btnVoltar);
			this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBtn.Location = new System.Drawing.Point(0, 385);
			this.pnlBtn.Name = "pnlBtn";
			this.pnlBtn.Size = new System.Drawing.Size(643, 30);
			this.pnlBtn.TabIndex = 0;
			// 
			// btnAction
			// 
			this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAction.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAction.Location = new System.Drawing.Point(568, 0);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(75, 30);
			this.btnAction.TabIndex = 1;
			this.btnAction.Text = "button1";
			this.btnAction.UseVisualStyleBackColor = true;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
			this.btnVoltar.Location = new System.Drawing.Point(0, 0);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(77, 30);
			this.btnVoltar.TabIndex = 0;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
			// 
			// pnlCampos
			// 
			this.pnlCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
			this.pnlCampos.Controls.Add(this.lbPoint);
			this.pnlCampos.Controls.Add(this.ttbFiltro);
			this.pnlCampos.Controls.Add(this.btnFiltrar);
			this.pnlCampos.Controls.Add(this.cbOrdenar);
			this.pnlCampos.Controls.Add(this.lbOrdenar);
			this.pnlCampos.Controls.Add(this.cbFiltrar);
			this.pnlCampos.Controls.Add(this.lbFiltro);
			this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCampos.Location = new System.Drawing.Point(0, 0);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(643, 69);
			this.pnlCampos.TabIndex = 1;
			// 
			// lbPoint
			// 
			this.lbPoint.AutoSize = true;
			this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPoint.Location = new System.Drawing.Point(250, 33);
			this.lbPoint.Name = "lbPoint";
			this.lbPoint.Size = new System.Drawing.Size(12, 16);
			this.lbPoint.TabIndex = 4;
			this.lbPoint.Text = ":";
			// 
			// ttbFiltro
			// 
			this.ttbFiltro.Location = new System.Drawing.Point(266, 30);
			this.ttbFiltro.Name = "ttbFiltro";
			this.ttbFiltro.Size = new System.Drawing.Size(100, 20);
			this.ttbFiltro.TabIndex = 3;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
			this.btnFiltrar.Location = new System.Drawing.Point(556, 24);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(75, 30);
			this.btnFiltrar.TabIndex = 2;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFiltrar.UseVisualStyleBackColor = true;
			this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
			// 
			// cbOrdenar
			// 
			this.cbOrdenar.FormattingEnabled = true;
			this.cbOrdenar.Items.AddRange(new object[] {
            "Data",
            "Crédito/Débito",
            "Compensação",
            "Valor",
            "Tipo de Despesa"});
			this.cbOrdenar.Location = new System.Drawing.Point(12, 30);
			this.cbOrdenar.Name = "cbOrdenar";
			this.cbOrdenar.Size = new System.Drawing.Size(106, 21);
			this.cbOrdenar.TabIndex = 1;
			// 
			// lbOrdenar
			// 
			this.lbOrdenar.AutoSize = true;
			this.lbOrdenar.Location = new System.Drawing.Point(9, 14);
			this.lbOrdenar.Name = "lbOrdenar";
			this.lbOrdenar.Size = new System.Drawing.Size(66, 13);
			this.lbOrdenar.TabIndex = 0;
			this.lbOrdenar.Text = "Ordenar por:";
			// 
			// cbFiltrar
			// 
			this.cbFiltrar.FormattingEnabled = true;
			this.cbFiltrar.Items.AddRange(new object[] {
            "Período",
            "Débito",
            "Crédito",
            "Tipo de Despesa"});
			this.cbFiltrar.Location = new System.Drawing.Point(138, 30);
			this.cbFiltrar.Name = "cbFiltrar";
			this.cbFiltrar.Size = new System.Drawing.Size(106, 21);
			this.cbFiltrar.TabIndex = 1;
			// 
			// lbFiltro
			// 
			this.lbFiltro.AutoSize = true;
			this.lbFiltro.Location = new System.Drawing.Point(135, 14);
			this.lbFiltro.Name = "lbFiltro";
			this.lbFiltro.Size = new System.Drawing.Size(54, 13);
			this.lbFiltro.TabIndex = 0;
			this.lbFiltro.Text = "Filtrar Por:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvConsulta);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(643, 316);
			this.panel1.TabIndex = 2;
			// 
			// dgvConsulta
			// 
			this.dgvConsulta.AllowUserToAddRows = false;
			this.dgvConsulta.AllowUserToDeleteRows = false;
			this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
			this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvConsulta.Location = new System.Drawing.Point(0, 0);
			this.dgvConsulta.Name = "dgvConsulta";
			this.dgvConsulta.ReadOnly = true;
			this.dgvConsulta.Size = new System.Drawing.Size(643, 316);
			this.dgvConsulta.TabIndex = 0;
			// 
			// FConsulta_Exclui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 415);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.pnlBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FConsulta_Exclui";
			this.Text = "Consulta";
			this.pnlBtn.ResumeLayout(false);
			this.pnlCampos.ResumeLayout(false);
			this.pnlCampos.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel pnlBtn;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Panel pnlCampos;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.Label lbOrdenar;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.TextBox ttbFiltro;
        private System.Windows.Forms.Button btnFiltrar;
    }
}