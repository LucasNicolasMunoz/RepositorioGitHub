namespace SistemaFER_v02
{
    partial class frmPrincipal
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
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.pictureBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.panelContenedorCentral = new System.Windows.Forms.Panel();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenuHorizontal.Controls.Add(this.pictureBoxRestaurar);
            this.panelMenuHorizontal.Controls.Add(this.pictureBoxMaximizar);
            this.panelMenuHorizontal.Controls.Add(this.pictureBoxMinimizar);
            this.panelMenuHorizontal.Controls.Add(this.pictureBoxCerrar);
            this.panelMenuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1000, 30);
            this.panelMenuHorizontal.TabIndex = 1;
            // 
            // pictureBoxRestaurar
            // 
            this.pictureBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestaurar.Image = global::SistemaFER_v02.Properties.Resources.Normal;
            this.pictureBoxRestaurar.Location = new System.Drawing.Point(933, 8);
            this.pictureBoxRestaurar.Name = "pictureBoxRestaurar";
            this.pictureBoxRestaurar.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestaurar.TabIndex = 3;
            this.pictureBoxRestaurar.TabStop = false;
            this.pictureBoxRestaurar.Click += new System.EventHandler(this.pictureBoxRestaurar_Click);
            // 
            // pictureBoxMaximizar
            // 
            this.pictureBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMaximizar.Image = global::SistemaFER_v02.Properties.Resources.maximize3;
            this.pictureBoxMaximizar.Location = new System.Drawing.Point(933, 8);
            this.pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            this.pictureBoxMaximizar.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximizar.TabIndex = 2;
            this.pictureBoxMaximizar.TabStop = false;
            this.pictureBoxMaximizar.Visible = false;
            this.pictureBoxMaximizar.Click += new System.EventHandler(this.pictureBoxMaximizar_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = global::SistemaFER_v02.Properties.Resources.Minimize;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(889, 8);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = global::SistemaFER_v02.Properties.Resources.Close;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(975, 8);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelMenuVertical.Controls.Add(this.btnAgregarPedido);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 30);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(200, 620);
            this.panelMenuVertical.TabIndex = 2;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarPedido.FlatAppearance.BorderSize = 0;
            this.btnAgregarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPedido.Location = new System.Drawing.Point(0, 25);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(200, 37);
            this.btnAgregarPedido.TabIndex = 0;
            this.btnAgregarPedido.Text = "AGREGAR PEDIDO";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // panelContenedorCentral
            // 
            this.panelContenedorCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelContenedorCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorCentral.Location = new System.Drawing.Point(200, 30);
            this.panelContenedorCentral.Name = "panelContenedorCentral";
            this.panelContenedorCentral.Size = new System.Drawing.Size(800, 620);
            this.panelContenedorCentral.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelContenedorCentral);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenuHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelContenedorCentral;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxMaximizar;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxRestaurar;
        private System.Windows.Forms.Button btnAgregarPedido;
    }
}

