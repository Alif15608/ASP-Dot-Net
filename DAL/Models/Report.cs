﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Report
    {
        [Key]
        public int Report_Id { get; set; }

        public DateTime Report_Date { get; set; }
        [Required]
        public string Income { get; set; }
        [Required]
        public string Expense { get; set; }
        [ForeignKey("Transactions")]
        public int T_ID { get; set; }

        public virtual Transaction Transactions { get; set; }

        [ForeignKey("Bookings")]
        public int B_ID { get; set; }

        public virtual Booking Bookings { get; set; }
        
    }
}
