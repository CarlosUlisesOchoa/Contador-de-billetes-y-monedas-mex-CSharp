/*
 * Created by SharpDevelop.
 * User: Uli Gibson
 * Date: 22/12/2015
 * Time: 10:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Contador_de_billetes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public const string Version = "1.5";
			
		public const string ValorDefecto = "0";
		
		public static double FadeForm = .05;
		
		public static int [] aux = new int[10];
		
		public static double auxC;
		
		public static bool checker = true;
		
		private readonly AcercaDe _AcercaDe = new AcercaDe();
		
		public MainForm()
		{
			
			InitializeComponent();
			
			// IMPEDIR MAXIMIZAR Y CAMBIAR TAMAÑO DEL FORM
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			
	         ToolTip Ayuda = new ToolTip();

	         this.Text = "Contador de billetes v"+Version;
	         
			Ayuda.SetToolTip(this.lblTotal, "Copiar al portapapeles");
			
			// BILLETE DE 20
			Ayuda.SetToolTip(this.pictureBox1, "Billete de 20");
			txt20.GotFocus += Txt20_GotFocus;
			txt20.LostFocus += Txt20_LostFocus;
			txt20.KeyPress += Txt20_KeyPress;
			
			// BILLETE DE 50
			Ayuda.SetToolTip(this.pictureBox2, "Billete de 50");
			txt50.GotFocus += Txt50_GotFocus;
			txt50.LostFocus += Txt50_LostFocus;
			txt50.KeyPress += Txt50_KeyPress;

			// BILLETE DE 100
			Ayuda.SetToolTip(this.pictureBox3, "Billete de 100");
			txt100.GotFocus += Txt100_GotFocus;
			txt100.LostFocus += Txt100_LostFocus;
			txt100.KeyPress += Txt100_KeyPress;

			// BILLETE DE 200
			Ayuda.SetToolTip(this.pictureBox4, "Billete de 200");
			txt200.GotFocus += Txt200_GotFocus;
			txt200.LostFocus += Txt200_LostFocus;
			txt200.KeyPress += Txt200_KeyPress;

			// BILLETE DE 500
			Ayuda.SetToolTip(this.pictureBox5, "Billete de 500");
			txt500.GotFocus += Txt500_GotFocus;
			txt500.LostFocus += Txt500_LostFocus;
			txt500.KeyPress += Txt500_KeyPress;

			// BILLETE DE 1000
			Ayuda.SetToolTip(this.pictureBox6, "Billete de 1000");
			txt1000.GotFocus += Txt1000_GotFocus;
			txt1000.LostFocus += Txt1000_LostFocus;
			txt1000.KeyPress += Txt1000_KeyPress;

			
		/* ===================== MONEDAS ====================== */
	
		// MONEDA DE 50 CENTAVOS
			Ayuda.SetToolTip(this.Monpb50c, "Moneda de 50¢");
			Montxt50c.GotFocus += Montxt50c_GotFocus;
			Montxt50c.LostFocus += Montxt50c_LostFocus;
			Montxt50c.KeyPress += Montxt50c_KeyPress;
		// MONEDA DE 1 PESO
			Ayuda.SetToolTip(this.Monpb1p, "Moneda de 1 Peso");
			Montxt1p.GotFocus += Montxt1p_GotFocus;
			Montxt1p.LostFocus += Montxt1p_LostFocus;
			Montxt1p.KeyPress += Montxt1p_KeyPress;
		// MONEDA DE 2 PESOS
			Ayuda.SetToolTip(this.Monpb2p, "Moneda de 2 Pesos");
			Montxt2p.GotFocus += Montxt2p_GotFocus;
			Montxt2p.LostFocus += Montxt2p_LostFocus;
			Montxt2p.KeyPress += Montxt2p_KeyPress;
		// MONEDA DE 5 PESOS
			Ayuda.SetToolTip(this.Monpb5p, "Moneda de 5 Pesos");
			Montxt5p.GotFocus += Montxt5p_GotFocus;
			Montxt5p.LostFocus += Montxt5p_LostFocus;
			Montxt5p.KeyPress += Montxt5p_KeyPress;
		// MONEDA DE 10 PESOS
			Ayuda.SetToolTip(this.Monpb10p, "Moneda de 10 Pesos");
			Montxt10p.GotFocus += Montxt10p_GotFocus;
			Montxt10p.LostFocus += Montxt10p_LostFocus;
			Montxt10p.KeyPress += Montxt10p_KeyPress;

			
		}

		// VALOR POR DEFECTO DE CADA CAMPO '0'
		private void Txt20_GotFocus(object sender, EventArgs e) { txt20.Text = txt20.Text == ValorDefecto ? string.Empty : txt20.Text; }
		private void Txt20_LostFocus(object sender, EventArgs e) { txt20.Text = txt20.Text == string.Empty ? ValorDefecto : txt20.Text; }
		
		// 50
		private void Txt50_GotFocus(object sender, EventArgs e) { txt50.Text = txt50.Text == ValorDefecto ? string.Empty : txt50.Text; }
		private void Txt50_LostFocus(object sender, EventArgs e) { txt50.Text = txt50.Text == string.Empty ? ValorDefecto : txt50.Text; }
		// 100
		private void Txt100_GotFocus(object sender, EventArgs e) { txt100.Text = txt100.Text == ValorDefecto ? string.Empty : txt100.Text; }
		private void Txt100_LostFocus(object sender, EventArgs e) { txt100.Text = txt100.Text == string.Empty ? ValorDefecto : txt100.Text; }
		// 200
		private void Txt200_GotFocus(object sender, EventArgs e) { txt200.Text = txt200.Text == ValorDefecto ? string.Empty : txt200.Text; }
		private void Txt200_LostFocus(object sender, EventArgs e) { txt200.Text = txt200.Text == string.Empty ? ValorDefecto : txt200.Text; }
		// 500
		private void Txt500_GotFocus(object sender, EventArgs e) { txt500.Text = txt500.Text == ValorDefecto ? string.Empty : txt500.Text; }
		private void Txt500_LostFocus(object sender, EventArgs e) { txt500.Text = txt500.Text == string.Empty ? ValorDefecto : txt500.Text; }
		// 1000
		private void Txt1000_GotFocus(object sender, EventArgs e) { txt1000.Text = txt1000.Text == ValorDefecto ? string.Empty : txt1000.Text; }
		private void Txt1000_LostFocus(object sender, EventArgs e) { txt1000.Text = txt1000.Text == string.Empty ? ValorDefecto : txt1000.Text; }
		
		/* ================== MONEDAS ================== */
		
		// 50c
		private void Montxt50c_GotFocus(object sender, EventArgs e) { Montxt50c.Text = Montxt50c.Text == ValorDefecto ? string.Empty : Montxt50c.Text; }
		private void Montxt50c_LostFocus(object sender, EventArgs e) { Montxt50c.Text = Montxt50c.Text == string.Empty ? ValorDefecto : Montxt50c.Text; }
		// 1 Peso
		private void Montxt1p_GotFocus(object sender, EventArgs e) { Montxt1p.Text = Montxt1p.Text == ValorDefecto ? string.Empty : Montxt1p.Text; }
		private void Montxt1p_LostFocus(object sender, EventArgs e) { Montxt1p.Text = Montxt1p.Text == string.Empty ? ValorDefecto : Montxt1p.Text; }
		// 2 Pesos
		private void Montxt2p_GotFocus(object sender, EventArgs e) { Montxt2p.Text = Montxt2p.Text == ValorDefecto ? string.Empty : Montxt2p.Text; }
		private void Montxt2p_LostFocus(object sender, EventArgs e) { Montxt2p.Text = Montxt2p.Text == string.Empty ? ValorDefecto : Montxt2p.Text; }		
		// 5 Pesos
		private void Montxt5p_GotFocus(object sender, EventArgs e) { Montxt5p.Text = Montxt5p.Text == ValorDefecto ? string.Empty : Montxt5p.Text; }
		private void Montxt5p_LostFocus(object sender, EventArgs e) { Montxt5p.Text = Montxt5p.Text == string.Empty ? ValorDefecto : Montxt5p.Text; }
		// 10 Pesos
		private void Montxt10p_GotFocus(object sender, EventArgs e) { Montxt10p.Text = Montxt10p.Text == ValorDefecto ? string.Empty : Montxt10p.Text; }
		private void Montxt10p_LostFocus(object sender, EventArgs e) { Montxt10p.Text = Montxt10p.Text == string.Empty ? ValorDefecto : Montxt10p.Text; }		
		/* ============================================================================================================== */
		
		
		// EVITAR QUE SE INGRESEN LETRAS O SIMBOLOS (SOLO SE PUEDEN INGRESAR NUMEROS Y BORRAR)
		private void Txt20_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }
		
		private void Txt50_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }
		private void Txt100_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }
		private void Txt200_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }
		private void Txt500_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }
		private void Txt1000_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }		

		/* ================== MONEDAS ================== */
		private void Montxt50c_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }		
		private void Montxt1p_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }	
		private void Montxt2p_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }	
		private void Montxt5p_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }	
		private void Montxt10p_KeyPress(object sender, KeyPressEventArgs e) { if( (e.KeyChar == (char)Keys.Enter) ){ this.SelectNextControl( (Control)sender, true, true, true, true); } if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; return; } }	
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			Fade.Start();
			this.Height = 358;
			this.lblTotal0.Location = new Point(149, 275);
			this.lblTotal.Location = new Point(240, 275);
			this.lblTotal.TextAlign = ContentAlignment.TopLeft;
			this.lblTotal0.TextAlign = ContentAlignment.TopLeft;
	
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (checker == true){
				if(this.Opacity == 1) Fade.Stop();
				this.Opacity += FadeForm;
				
			}
			else {
				
				if(this.Opacity < FadeForm) { Fade.Stop(); this.Close(); }
				this.Opacity -= FadeForm;
			}
		}
		public double Sumar(string quecosa){
			double total = 0.00D;
			if(quecosa.Equals("TODO"))
			{
				for(int i = 0; i < aux.Length; i++){
					total += aux[i];
				}
				total += auxC;
			}
			if(quecosa.Equals("BILLETES"))
			{
				for(int i = 0; i < 6; i++){
					total += aux[i];
				}
		   }
			if(quecosa.Equals("MONEDAS"))
			{
				for(int i = 6; i < aux.Length; i++){
					total += aux[i];
				}
				total += auxC;
		   }
			return total;
		}
		
		public void ActualizarTotal(){
			lblTotal.Text = Sumar("TODO").ToString("C", CultureInfo.CreateSpecificCulture("es-MX"));
			lblDbilletes.Text = "Dinero en billetes:     "+Sumar("BILLETES").ToString("C", CultureInfo.CreateSpecificCulture("es-MX"));
			lblDmoedas.Text = "Dinero en monedas: "+Sumar("MONEDAS").ToString("C", CultureInfo.CreateSpecificCulture("es-MX"));
		}
		
		void Txt20TextChanged(object sender, EventArgs e)
		{
			if(txt20.Text.Length > 1 && txt20.Text[0] == '0') { txt20.Text = txt20.Text[1].ToString(); txt20.SelectionStart = 1; }
				
			Int32.TryParse(txt20.Text, out aux[0]);
			
			aux[0] = aux[0]*20;
				
			ActualizarTotal();
		}
		void Txt50TextChanged(object sender, EventArgs e)
		{
			if(txt50.Text.Length > 1 && txt50.Text[0] == '0') { txt50.Text = txt50.Text[1].ToString(); txt50.SelectionStart = 1; }
			
			Int32.TryParse(txt50.Text, out aux[1]);
			
			aux[1] = aux[1]*50;
				
			ActualizarTotal();
		}
		void Txt100TextChanged(object sender, EventArgs e)
		{
			if(txt100.Text.Length > 1 && txt100.Text[0] == '0') { txt100.Text = txt100.Text[1].ToString(); txt100.SelectionStart = 1; }
			
			Int32.TryParse(txt100.Text, out aux[2]);
			
			aux[2] = aux[2]*100;
				
			ActualizarTotal();
		}
		void Txt200TextChanged(object sender, EventArgs e)
		{
			if(txt200.Text.Length > 1 && txt200.Text[0] == '0') { txt200.Text = txt200.Text[1].ToString(); txt200.SelectionStart = 1; }
			
			Int32.TryParse(txt200.Text, out aux[3]);
			
			aux[3] = aux[3]*200;
				
			ActualizarTotal();
		}
		void Txt500TextChanged(object sender, EventArgs e)
		{
			if(txt500.Text.Length > 1 && txt500.Text[0] == '0') { txt500.Text = txt500.Text[1].ToString(); txt500.SelectionStart = 1; }
			
			Int32.TryParse(txt500.Text, out aux[4]);
			
			aux[4] = aux[4]*500;
				
			ActualizarTotal();
		}
		void Txt1000TextChanged(object sender, EventArgs e)
		{
			if(txt1000.Text.Length > 1 && txt1000.Text[0] == '0') { txt1000.Text = txt1000.Text[1].ToString(); txt1000.SelectionStart = 1; }
			
			Int32.TryParse(txt1000.Text, out aux[5]);
			
			aux[5] = aux[5]*1000;
				
			ActualizarTotal();
		}
		
		void Montxt50cTextChanged(object sender, EventArgs e)
		{
			if(Montxt50c.Text.Length > 1 && Montxt50c.Text[0] == '0') { Montxt50c.Text = Montxt50c.Text[1].ToString(); Montxt50c.SelectionStart = 1; }
			
			Double.TryParse(Montxt50c.Text, out auxC);
			
			auxC = (auxC)/2;
				
			ActualizarTotal();
		}
		void Montxt1pTextChanged(object sender, EventArgs e)
		{
			if(Montxt1p.Text.Length > 1 && Montxt1p.Text[0] == '0') { Montxt1p.Text = Montxt1p.Text[1].ToString(); Montxt1p.SelectionStart = 1; }
			
			Int32.TryParse(Montxt1p.Text, out aux[6]);
				
			ActualizarTotal();	
		}
		void Montxt2pTextChanged(object sender, EventArgs e)
		{
			if(Montxt2p.Text.Length > 1 && Montxt2p.Text[0] == '0') { Montxt2p.Text = Montxt2p.Text[1].ToString(); Montxt2p.SelectionStart = 1; }
			
			Int32.TryParse(Montxt2p.Text, out aux[7]);
			
			aux[7] = aux[7]*2;
				
			ActualizarTotal();
		}
		void Montxt5pTextChanged(object sender, EventArgs e)
		{
			if(Montxt5p.Text.Length > 1 && Montxt5p.Text[0] == '0') { Montxt5p.Text = Montxt5p.Text[1].ToString(); Montxt5p.SelectionStart = 1; }
			
			Int32.TryParse(Montxt5p.Text, out aux[8]);
			
			aux[8] = aux[8]*5;
				
			ActualizarTotal();
		}
		void Montxt10pTextChanged(object sender, EventArgs e)
		{
			if(Montxt10p.Text.Length > 1 && Montxt10p.Text[0] == '0') { Montxt10p.Text = Montxt10p.Text[1].ToString(); Montxt10p.SelectionStart = 1; }
			
			Int32.TryParse(Montxt10p.Text, out aux[9]);
			
			aux[9] = aux[9]*10;
				
			ActualizarTotal();
		}	
		
		void LimpiarTodoToolStripMenuItemClick(object sender, EventArgs e)
		{
			Limpiar("TODO");
		}
	
	
		private void Limpiar(string quecosa){
			if (quecosa == "TODO")
			{
		        foreach (Control c in this.Controls)
		        {
		        	if (c is TextBox) {
	
	        			((TextBox)c).Text = ValorDefecto;
		        	}
				}
				for (int i = 0; i < aux.Length; i++)
				{
					aux[i] = 0;
				}
				txt20.Text = String.Empty;
				txt20.Focus();
		        ActualizarTotal();
			}
			if (quecosa == "MONEDAS")
			{
				for (int i = 6; i < aux.Length; i++)
				{
					aux[i] = 0;
				}
				auxC = 0.0D;
			}
		}		
		void LblTotalClick(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(lblTotal.Text);
		}
        
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
		    if (!_AcercaDe.Visible)
		    {
		    	int x = this.Left + (this.Width / 2) - (_AcercaDe.Width / 2);     
				int y = this.Top + (this.Height / 2) - (_AcercaDe.Height / 2);  
				_AcercaDe.Show();
				_AcercaDe.Location = new Point(x, y);
		    }
		    else
		    {
		        _AcercaDe.Activate();
		    }
		}		
		private void OMonedas()
		{
    		foreach (Control c in this.Controls)
        	{
				if (c.Name.Contains("Mon")){
    				if( c is TextBox )
    				{
    					c.Text = ValorDefecto;
    				}
    				if(c.Visible == false) c.Visible = true;
    				else c.Visible = false;
    			}
			}	
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (checker == true) 
			{
				e.Cancel = true;
				checker = false;
				Fade.Start();
			}
		}
		void MonedasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.monedasToolStripMenuItem.Checked == true) { 
				if( this.detallarToolStripMenuItem.Checked == true ) this.DetallarToolStripMenuItemClick(null, null);
				this.monedasToolStripMenuItem.Checked = false;
				this.Height = 358;
				this.lblTotal0.Location = new Point(149, 275);
				this.lblTotal.Location = new Point(240, 275);					
			}
			else if (this.monedasToolStripMenuItem.Checked == false) { 
				this.monedasToolStripMenuItem.Checked = true; 
				this.Height = 562;
				this.lblTotal0.Location = new Point(149, 484);
				this.lblTotal.Location = new Point(240, 485);				
			}
			OMonedas();
			Limpiar("MONEDAS");
		}
		void DetallarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.monedasToolStripMenuItem.Checked == false) this.MonedasToolStripMenuItemClick(null, null);
			
			if (this.detallarToolStripMenuItem.Checked == true) { 
				this.detallarToolStripMenuItem.Checked = false;
				lblDbilletes.Visible = false;
				lblDmoedas.Visible = false;				
			}
			else if (this.detallarToolStripMenuItem.Checked == false) { 
				this.detallarToolStripMenuItem.Checked = true; 
				lblDbilletes.Visible = true;
				lblDmoedas.Visible = true;
			}
		}
	}
}
