/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 1/8/2019
 * Time: 8:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NguyenTranNhatMinh_1706020050
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Line = new System.Windows.Forms.ToolStripButton();
			this.sbTG = new System.Windows.Forms.ToolStripButton();
			this.sbHT = new System.Windows.Forms.ToolStripButton();
			this.sbSave = new System.Windows.Forms.ToolStripButton();
			this.sbLoad = new System.Windows.Forms.ToolStripButton();
			this.PbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Line,
									this.sbTG,
									this.sbHT,
									this.sbSave,
									this.sbLoad});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(648, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Line
			// 
			this.Line.AccessibleName = "\t\t\tthis.sbLoad.Click += new System.EventHandler(this.SbLoadClick);";
			this.Line.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
			this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(81, 35);
			this.Line.Text = "Đường thẳng";
			this.Line.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// sbTG
			// 
			this.sbTG.Image = ((System.Drawing.Image)(resources.GetObject("sbTG.Image")));
			this.sbTG.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.sbTG.Name = "sbTG";
			this.sbTG.Size = new System.Drawing.Size(81, 35);
			this.sbTG.Text = "Tam giác cân";
			this.sbTG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// sbHT
			// 
			this.sbHT.Image = ((System.Drawing.Image)(resources.GetObject("sbHT.Image")));
			this.sbHT.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.sbHT.Name = "sbHT";
			this.sbHT.Size = new System.Drawing.Size(61, 35);
			this.sbHT.Text = "Hình thoi";
			this.sbHT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// sbSave
			// 
			this.sbSave.Name = "sbSave";
			this.sbSave.Size = new System.Drawing.Size(35, 35);
			this.sbSave.Text = "Save";
			this.sbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.sbSave.Click += new System.EventHandler(this.SbSaveClick);
			// 
			// sbLoad
			// 
			this.sbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.sbLoad.Name = "sbLoad";
			this.sbLoad.Size = new System.Drawing.Size(37, 35);
			this.sbLoad.Text = "Load";
			this.sbLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.sbLoad.Click += new System.EventHandler(this.SbLoadClick);
			// 
			// PbDraw
			// 
			this.PbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PbDraw.Location = new System.Drawing.Point(0, 38);
			this.PbDraw.Name = "PbDraw";
			this.PbDraw.Size = new System.Drawing.Size(648, 282);
			this.PbDraw.TabIndex = 1;
			this.PbDraw.TabStop = false;
			this.PbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.PbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.PbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(648, 320);
			this.Controls.Add(this.PbDraw);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "NguyenTranNhatMinh-1706020050";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox PbDraw;
		private System.Windows.Forms.ToolStripButton sbLoad;
		private System.Windows.Forms.ToolStripButton sbSave;
		private System.Windows.Forms.ToolStripButton sbHT;
		private System.Windows.Forms.ToolStripButton sbTG;
		private System.Windows.Forms.ToolStripButton Line;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
