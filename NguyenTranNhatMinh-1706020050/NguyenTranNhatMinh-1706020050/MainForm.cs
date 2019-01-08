/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 1/8/2019
 * Time: 8:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace NguyenTranNhatMinh_1706020050
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Point d1 = new Point();
		Point d2 = new Point();
		bool isDrawing = false;
		Point cs = new Point();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PbDrawMouseUp(object sender, MouseEventArgs e)
		{
			d2.x = e.X;
			d2.y = e.Y;
			System.Drawing.Graphics g = PbDraw.CreateGraphics();
			g.DrawLine(new Pen(Color.Black,3),d1.x,d1.y,d2.x,d2.y);
			isDrawing = false;
		}
		
		
		void PbDrawMouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Graphics g = PbDraw.CreateGraphics();
			if(isDrawing == true)
			{
			g.DrawLine(new Pen(Color.White),d1.x,d1.y,d2.x,d2.y);
			d2.x = e.X;
			d2.y = e.Y;
			g.DrawLine( new Pen(Color.Black),d1.x,d1.y,d2.x,d2.y);
			}
		}
		
		void PbDrawMouseDown(object sender, MouseEventArgs e)
		{
			isDrawing = true;
			d1.x = e.X;
			d1.y = e.Y;
		}
		
		void SbSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog Save = new SaveFileDialog();
			Save.Filter = "Json Files|*.json|All Files|*.*";
			if(Save.ShowDialog() == DialogResult.OK)
			{
				string sFileName = Save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(cs);
				StreamWriter writer ;
				writer = new StreamWriter(sFileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("Saved !");
			}
		}
		void SbLoadClick(object sender, EventArgs e)
		{
           	OpenFileDialog Load = new OpenFileDialog();
			Load.Filter = "Json Files|*.json|All Files|*.*";
			if(Load.ShowDialog() == DialogResult.OK)
			{
				string sFileName = Load.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<Point>>(json);
				foreach (var element in deserializeObject) {
			
				}
				MessageBox.Show("Load OK !");
			}
		}

	}
}