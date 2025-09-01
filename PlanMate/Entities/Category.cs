using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlanMate.Entities
{
	public class Category
	{
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}