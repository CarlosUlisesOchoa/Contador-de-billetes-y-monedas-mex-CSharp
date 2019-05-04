/*
 * Created by SharpDevelop.
 * User: Uli Gibson
 * Date: 22/12/2015
 * Time: 10:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Contador_de_billetes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox txt20;
		private System.Windows.Forms.TextBox txt50;
		private System.Windows.Forms.TextBox txt100;
		private System.Windows.Forms.TextBox txt200;
		private System.Windows.Forms.TextBox txt500;
		private System.Windows.Forms.TextBox txt1000;
		private System.Windows.Forms.Label lblTotal0;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem limpiarTodoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.Timer Fade;
		private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem;
		private System.Windows.Forms.TextBox Montxt10p;
		private System.Windows.Forms.TextBox Montxt5p;
		private System.Windows.Forms.TextBox Montxt2p;
		private System.Windows.Forms.TextBox Montxt1p;
		private System.Windows.Forms.TextBox Montxt50c;
		private System.Windows.Forms.PictureBox Monpb10p;
		private System.Windows.Forms.PictureBox Monpb5p;
		private System.Windows.Forms.PictureBox Monpb2p;
		private System.Windows.Forms.PictureBox Monpb1p;
		private System.Windows.Forms.PictureBox Monpb50c;
		private System.Windows.Forms.ToolStripMenuItem detallarToolStripMenuItem;
		private System.Windows.Forms.Label lblDbilletes;
		private System.Windows.Forms.Label lblDmoedas;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.txt20 = new System.Windows.Forms.TextBox();
			this.txt50 = new System.Windows.Forms.TextBox();
			this.txt100 = new System.Windows.Forms.TextBox();
			this.txt200 = new System.Windows.Forms.TextBox();
			this.txt500 = new System.Windows.Forms.TextBox();
			this.txt1000 = new System.Windows.Forms.TextBox();
			this.lblTotal0 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.limpiarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detallarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Fade = new System.Windows.Forms.Timer(this.components);
			this.Montxt10p = new System.Windows.Forms.TextBox();
			this.Montxt5p = new System.Windows.Forms.TextBox();
			this.Montxt2p = new System.Windows.Forms.TextBox();
			this.Montxt1p = new System.Windows.Forms.TextBox();
			this.Montxt50c = new System.Windows.Forms.TextBox();
			this.Monpb10p = new System.Windows.Forms.PictureBox();
			this.Monpb5p = new System.Windows.Forms.PictureBox();
			this.Monpb2p = new System.Windows.Forms.PictureBox();
			this.Monpb1p = new System.Windows.Forms.PictureBox();
			this.Monpb50c = new System.Windows.Forms.PictureBox();
			this.lblDbilletes = new System.Windows.Forms.Label();
			this.lblDmoedas = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Monpb10p)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb5p)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb2p)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb1p)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb50c)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 114);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 188);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 50);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(269, 40);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 50);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(269, 114);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 50);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(269, 188);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 50);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// txt20
			// 
			this.txt20.Location = new System.Drawing.Point(118, 53);
			this.txt20.MaxLength = 5;
			this.txt20.Name = "txt20";
			this.txt20.ShortcutsEnabled = false;
			this.txt20.Size = new System.Drawing.Size(73, 20);
			this.txt20.TabIndex = 0;
			this.txt20.Text = "0";
			this.txt20.TextChanged += new System.EventHandler(this.Txt20TextChanged);
			// 
			// txt50
			// 
			this.txt50.Location = new System.Drawing.Point(118, 127);
			this.txt50.MaxLength = 5;
			this.txt50.Name = "txt50";
			this.txt50.ShortcutsEnabled = false;
			this.txt50.Size = new System.Drawing.Size(73, 20);
			this.txt50.TabIndex = 1;
			this.txt50.Text = "0";
			this.txt50.TextChanged += new System.EventHandler(this.Txt50TextChanged);
			// 
			// txt100
			// 
			this.txt100.Location = new System.Drawing.Point(118, 202);
			this.txt100.MaxLength = 5;
			this.txt100.Name = "txt100";
			this.txt100.ShortcutsEnabled = false;
			this.txt100.Size = new System.Drawing.Size(73, 20);
			this.txt100.TabIndex = 2;
			this.txt100.Text = "0";
			this.txt100.TextChanged += new System.EventHandler(this.Txt100TextChanged);
			// 
			// txt200
			// 
			this.txt200.Location = new System.Drawing.Point(375, 53);
			this.txt200.MaxLength = 5;
			this.txt200.Name = "txt200";
			this.txt200.ShortcutsEnabled = false;
			this.txt200.Size = new System.Drawing.Size(73, 20);
			this.txt200.TabIndex = 3;
			this.txt200.Text = "0";
			this.txt200.TextChanged += new System.EventHandler(this.Txt200TextChanged);
			// 
			// txt500
			// 
			this.txt500.Location = new System.Drawing.Point(375, 127);
			this.txt500.MaxLength = 5;
			this.txt500.Name = "txt500";
			this.txt500.ShortcutsEnabled = false;
			this.txt500.Size = new System.Drawing.Size(73, 20);
			this.txt500.TabIndex = 4;
			this.txt500.Text = "0";
			this.txt500.TextChanged += new System.EventHandler(this.Txt500TextChanged);
			// 
			// txt1000
			// 
			this.txt1000.Location = new System.Drawing.Point(375, 202);
			this.txt1000.MaxLength = 5;
			this.txt1000.Name = "txt1000";
			this.txt1000.ShortcutsEnabled = false;
			this.txt1000.Size = new System.Drawing.Size(73, 20);
			this.txt1000.TabIndex = 5;
			this.txt1000.Text = "0";
			this.txt1000.TextChanged += new System.EventHandler(this.Txt1000TextChanged);
			// 
			// lblTotal0
			// 
			this.lblTotal0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal0.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblTotal0.Location = new System.Drawing.Point(0, 484);
			this.lblTotal0.Name = "lblTotal0";
			this.lblTotal0.Size = new System.Drawing.Size(249, 44);
			this.lblTotal0.TabIndex = 12;
			this.lblTotal0.Text = "TOTAL:";
			this.lblTotal0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTotal
			// 
			this.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lblTotal.Location = new System.Drawing.Point(240, 485);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(261, 43);
			this.lblTotal.TabIndex = 13;
			this.lblTotal.Text = "$0";
			this.lblTotal.Click += new System.EventHandler(this.LblTotalClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.limpiarTodoToolStripMenuItem,
			this.ediciónToolStripMenuItem,
			this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(501, 24);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// limpiarTodoToolStripMenuItem
			// 
			this.limpiarTodoToolStripMenuItem.Name = "limpiarTodoToolStripMenuItem";
			this.limpiarTodoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.limpiarTodoToolStripMenuItem.Text = "Limpiar todo";
			this.limpiarTodoToolStripMenuItem.Click += new System.EventHandler(this.LimpiarTodoToolStripMenuItemClick);
			// 
			// ediciónToolStripMenuItem
			// 
			this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.monedasToolStripMenuItem,
			this.detallarToolStripMenuItem});
			this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
			this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.ediciónToolStripMenuItem.Text = "Edición";
			// 
			// monedasToolStripMenuItem
			// 
			this.monedasToolStripMenuItem.Name = "monedasToolStripMenuItem";
			this.monedasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.monedasToolStripMenuItem.Text = "Monedas";
			this.monedasToolStripMenuItem.Click += new System.EventHandler(this.MonedasToolStripMenuItemClick);
			// 
			// detallarToolStripMenuItem
			// 
			this.detallarToolStripMenuItem.Name = "detallarToolStripMenuItem";
			this.detallarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.detallarToolStripMenuItem.Text = "Detallar";
			this.detallarToolStripMenuItem.Click += new System.EventHandler(this.DetallarToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// Fade
			// 
			this.Fade.Interval = 10;
			this.Fade.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// Montxt10p
			// 
			this.Montxt10p.Location = new System.Drawing.Point(375, 350);
			this.Montxt10p.MaxLength = 5;
			this.Montxt10p.Name = "Montxt10p";
			this.Montxt10p.ShortcutsEnabled = false;
			this.Montxt10p.Size = new System.Drawing.Size(73, 20);
			this.Montxt10p.TabIndex = 23;
			this.Montxt10p.Text = "0";
			this.Montxt10p.Visible = false;
			this.Montxt10p.TextChanged += new System.EventHandler(this.Montxt10pTextChanged);
			// 
			// Montxt5p
			// 
			this.Montxt5p.Location = new System.Drawing.Point(375, 276);
			this.Montxt5p.MaxLength = 5;
			this.Montxt5p.Name = "Montxt5p";
			this.Montxt5p.ShortcutsEnabled = false;
			this.Montxt5p.Size = new System.Drawing.Size(73, 20);
			this.Montxt5p.TabIndex = 21;
			this.Montxt5p.Text = "0";
			this.Montxt5p.Visible = false;
			this.Montxt5p.TextChanged += new System.EventHandler(this.Montxt5pTextChanged);
			// 
			// Montxt2p
			// 
			this.Montxt2p.Location = new System.Drawing.Point(118, 425);
			this.Montxt2p.MaxLength = 5;
			this.Montxt2p.Name = "Montxt2p";
			this.Montxt2p.ShortcutsEnabled = false;
			this.Montxt2p.Size = new System.Drawing.Size(73, 20);
			this.Montxt2p.TabIndex = 19;
			this.Montxt2p.Text = "0";
			this.Montxt2p.Visible = false;
			this.Montxt2p.TextChanged += new System.EventHandler(this.Montxt2pTextChanged);
			// 
			// Montxt1p
			// 
			this.Montxt1p.Location = new System.Drawing.Point(118, 350);
			this.Montxt1p.MaxLength = 5;
			this.Montxt1p.Name = "Montxt1p";
			this.Montxt1p.ShortcutsEnabled = false;
			this.Montxt1p.Size = new System.Drawing.Size(73, 20);
			this.Montxt1p.TabIndex = 17;
			this.Montxt1p.Text = "0";
			this.Montxt1p.Visible = false;
			this.Montxt1p.TextChanged += new System.EventHandler(this.Montxt1pTextChanged);
			// 
			// Montxt50c
			// 
			this.Montxt50c.Location = new System.Drawing.Point(118, 276);
			this.Montxt50c.MaxLength = 5;
			this.Montxt50c.Name = "Montxt50c";
			this.Montxt50c.ShortcutsEnabled = false;
			this.Montxt50c.Size = new System.Drawing.Size(73, 20);
			this.Montxt50c.TabIndex = 15;
			this.Montxt50c.Text = "0";
			this.Montxt50c.Visible = false;
			this.Montxt50c.TextChanged += new System.EventHandler(this.Montxt50cTextChanged);
			// 
			// Monpb10p
			// 
			this.Monpb10p.Image = ((System.Drawing.Image)(resources.GetObject("Monpb10p.Image")));
			this.Monpb10p.Location = new System.Drawing.Point(269, 337);
			this.Monpb10p.Name = "Monpb10p";
			this.Monpb10p.Size = new System.Drawing.Size(100, 50);
			this.Monpb10p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Monpb10p.TabIndex = 24;
			this.Monpb10p.TabStop = false;
			this.Monpb10p.Visible = false;
			// 
			// Monpb5p
			// 
			this.Monpb5p.Image = ((System.Drawing.Image)(resources.GetObject("Monpb5p.Image")));
			this.Monpb5p.Location = new System.Drawing.Point(269, 263);
			this.Monpb5p.Name = "Monpb5p";
			this.Monpb5p.Size = new System.Drawing.Size(100, 50);
			this.Monpb5p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Monpb5p.TabIndex = 22;
			this.Monpb5p.TabStop = false;
			this.Monpb5p.Visible = false;
			// 
			// Monpb2p
			// 
			this.Monpb2p.Image = ((System.Drawing.Image)(resources.GetObject("Monpb2p.Image")));
			this.Monpb2p.Location = new System.Drawing.Point(12, 411);
			this.Monpb2p.Name = "Monpb2p";
			this.Monpb2p.Size = new System.Drawing.Size(100, 50);
			this.Monpb2p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Monpb2p.TabIndex = 20;
			this.Monpb2p.TabStop = false;
			this.Monpb2p.Visible = false;
			// 
			// Monpb1p
			// 
			this.Monpb1p.Image = ((System.Drawing.Image)(resources.GetObject("Monpb1p.Image")));
			this.Monpb1p.Location = new System.Drawing.Point(12, 337);
			this.Monpb1p.Name = "Monpb1p";
			this.Monpb1p.Size = new System.Drawing.Size(100, 50);
			this.Monpb1p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Monpb1p.TabIndex = 18;
			this.Monpb1p.TabStop = false;
			this.Monpb1p.Visible = false;
			// 
			// Monpb50c
			// 
			this.Monpb50c.Image = ((System.Drawing.Image)(resources.GetObject("Monpb50c.Image")));
			this.Monpb50c.Location = new System.Drawing.Point(12, 263);
			this.Monpb50c.Name = "Monpb50c";
			this.Monpb50c.Size = new System.Drawing.Size(100, 50);
			this.Monpb50c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Monpb50c.TabIndex = 16;
			this.Monpb50c.TabStop = false;
			this.Monpb50c.Visible = false;
			// 
			// lblDbilletes
			// 
			this.lblDbilletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDbilletes.Location = new System.Drawing.Point(244, 422);
			this.lblDbilletes.Name = "lblDbilletes";
			this.lblDbilletes.Size = new System.Drawing.Size(255, 23);
			this.lblDbilletes.TabIndex = 25;
			this.lblDbilletes.Text = "Dinero en billetes:     $0.00";
			this.lblDbilletes.Visible = false;
			// 
			// lblDmoedas
			// 
			this.lblDmoedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDmoedas.Location = new System.Drawing.Point(244, 445);
			this.lblDmoedas.Name = "lblDmoedas";
			this.lblDmoedas.Size = new System.Drawing.Size(255, 23);
			this.lblDmoedas.TabIndex = 26;
			this.lblDmoedas.Text = "Dinero en monedas: $0.00";
			this.lblDmoedas.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 523);
			this.Controls.Add(this.lblDmoedas);
			this.Controls.Add(this.lblDbilletes);
			this.Controls.Add(this.Montxt10p);
			this.Controls.Add(this.Montxt5p);
			this.Controls.Add(this.Montxt2p);
			this.Controls.Add(this.Montxt1p);
			this.Controls.Add(this.Montxt50c);
			this.Controls.Add(this.Monpb10p);
			this.Controls.Add(this.Monpb5p);
			this.Controls.Add(this.Monpb2p);
			this.Controls.Add(this.Monpb1p);
			this.Controls.Add(this.Monpb50c);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblTotal0);
			this.Controls.Add(this.txt1000);
			this.Controls.Add(this.txt500);
			this.Controls.Add(this.txt200);
			this.Controls.Add(this.txt100);
			this.Controls.Add(this.txt50);
			this.Controls.Add(this.txt20);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contador de billetes";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Monpb10p)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb5p)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb2p)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb1p)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Monpb50c)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
