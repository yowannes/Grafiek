using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using ZedGraph;
using System.Drawing;
using System.Drawing.Imaging;

namespace Grafiek
{
   class Program
   {
      static void Main( string[] args )
      {
		CreateTablePieChart("flavour.png");
      }
	  
	  static int CreateTablePieChart(string fn)
	  {
		GraphPane myPane = new GraphPane( new RectangleF( 0, 0, 640, 480 ), "Flavour", "X", "Y" );
  
		// Add some pie slices
		PieItem segment01 = myPane.AddPieSlice( 15, 	Color.Navy, 		Color.White, 45f, 0.10, 	"Salt" );
		PieItem segment02 = myPane.AddPieSlice( 20, 	Color.DarkRed, 		Color.White, 45f, 0.00, 	"Pepper" );
		PieItem segment03 = myPane.AddPieSlice( 26, 	Color.LimeGreen, 	Color.White, 45f, 0.00, 	"Nutmeg " );
		segment03.LabelDetail.FontSpec.FontColor = Color.Red;
				
		// Calculate the Axis Scale Ranges
		myPane.AxisChange();
		
		Bitmap bm = new Bitmap( 1, 1 );
        using ( Graphics g = Graphics.FromImage( bm ) )
            myPane.AxisChange( g );
		myPane.GetImage().Save(fn, ImageFormat.Png);
		
		return 3;
	  }
   }
}