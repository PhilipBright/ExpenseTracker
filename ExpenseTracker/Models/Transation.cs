using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
	public class Transation
	{
		[Key]
		public int TransactionId { get; set; }

		//Category ID

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

		public DateTime Time { get; set; } = DateTime.Now;

	}
}

