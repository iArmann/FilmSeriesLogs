﻿using System.Windows.Forms;

namespace TvSeriesLogs
{
	public partial class NotesForm : Form
	{
		public readonly int Id;
		public NotesForm(int Id)
		{
			this.Id = Id;
			InitializeComponent();
		}
	}
}
