﻿/*
 * Created by SharpDevelop.
 * User: Uli Gibson
 * Date: 22/12/2015
 * Time: 02:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Contador_de_billetes
{
	partial class AcercaDe
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblDerechos;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblPrograma;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblDerechos = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblPrograma = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 153);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(158, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(576, 69);
			this.label1.TabIndex = 1;
			this.label1.Text = "Uli Gibson";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(158, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(562, 205);
			this.label2.TabIndex = 2;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Yo";
			// 
			// lblDerechos
			// 
			this.lblDerechos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lblDerechos.Location = new System.Drawing.Point(1, 339);
			this.lblDerechos.Name = "lblDerechos";
			this.lblDerechos.Size = new System.Drawing.Size(739, 35);
			this.lblDerechos.TabIndex = 4;
			this.lblDerechos.Text = "Todos los derechos reservados® copyright © 2010 - 20##";
			this.lblDerechos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(27, 256);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(97, 94);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// lblPrograma
			// 
			this.lblPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrograma.Location = new System.Drawing.Point(24, 353);
			this.lblPrograma.Name = "lblPrograma";
			this.lblPrograma.Size = new System.Drawing.Size(138, 20);
			this.lblPrograma.TabIndex = 6;
			this.lblPrograma.Text = "Contador de billetes v0.0";
			// 
			// AcercaDe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 382);
			this.Controls.Add(this.lblPrograma);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblDerechos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AcercaDe";
			this.Text = "Acerca del desarrollador";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
