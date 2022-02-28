using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SessionScheduler.Model
{
    public class Session
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Agenda { get; set; }
		public string Link { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int CourseId { get; set; }
	}
	public class SessionView
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Agenda { get; set; }
		public string Link { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int CourseId { get; set; }
		public string CourseName { get; set; }
	}

}
