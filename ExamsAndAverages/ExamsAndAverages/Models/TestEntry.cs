using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * Course:          ACST 3330
 * Section:         01
 * Name:            Sarah Hanserry
 * Professor:       Nagappan
 * Assignment #:    Lab 3
 */

namespace ExamsAndAverages.Models
{
    public class TestEntry
    {
        public String name { get; set; }
        public int amount { get; set; }
        public double sum { get; set; }

        public TestEntry(String name)
        {
            this.name = name;
            amount = 0;
            sum = 0;
        }

        public override String ToString()
        {
            return name + " " + amount + " entries, average = " +
                    ((amount == 0) ? "0" : string.Format("{0:0.##}", sum / amount));
        }
    }
}