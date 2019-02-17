using System;
using System.ComponentModel.DataAnnotations;

namespace WhatShouldWeEat.Entities
{
    public class dimensions
    {
        public Int32? id
        {
            get;
            set;
        }
        [Required]
        public String dimkey
        {
            get;
            set;
        }
        [Required]
        public String dimname
        {
            get;
            set;
        }
    }
}
