﻿using LiteDB;
using TvSeriesLogsDb.Helper;

namespace TvSeriesLogsDb
{
	// I don't have the knowledge for notes. it's related to linking the collections I guess.
	public class SeriesNotes { }
	public class Series
	{
		[BsonId]
		public int Id { get; set; }
		public string Name { get; set; }
		public ushort Seasons { get; set; }
		public SeenStatus Status { get; set; }
		public SeriesDetail Detail { get; set; }
		public SeriesSchedule Schedule { get; set; }
	}
}
