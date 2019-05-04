/*
 * Created by SharpDevelop.
 * User: Uli Gibson
 * Date: 22/12/2015
 * Time: 02:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
//using System.Media;

namespace Contador_de_billetes
{
	/// <summary>
	/// Description of AcercaDe.
	/// </summary>
	public partial class AcercaDe : Form
	{
		public static bool checker = true;
		
		public AcercaDe()
		{
			InitializeComponent();
			
			// IMPEDIR MAXIMIZAR, MINIMIZAR Y CAMBIAR TAMAÑO DEL FORM
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			
			
			lblPrograma.Text = "Contador de billetes v"+MainForm.Version;
			
			var año = DateTime.Now.Year;
			
			lblDerechos.Text = "Todos los derechos reservados® copyright © 2010 - " +año;
			
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}		
	}
}
