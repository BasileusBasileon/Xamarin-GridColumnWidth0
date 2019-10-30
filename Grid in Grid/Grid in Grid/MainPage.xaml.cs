using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grid_in_Grid
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			SizeChanged += MainPage_SizeChanged;
		}

		private void MainPage_SizeChanged(object sender, EventArgs e)
		{
			topGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });

			double height = Height;
			double width = Width;
			double columnWidth;
			if (height > width)
				columnWidth = width + ((height - width) / 2);
			else
				columnWidth = height + ((width - height) / 2);
			topGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(columnWidth, GridUnitType.Absolute) });

			SizeChanged -= MainPage_SizeChanged;
		}
	}
}
