using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlanMate.Entities
{
	public class Event
	{
        public int Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }


        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsAllDay { get; set; }

        //Kategori ilişkisi

        [ForeignKey("Category")]

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}