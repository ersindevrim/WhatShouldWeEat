using System;
using System.ComponentModel.DataAnnotations;

namespace WhatShouldWeEat.Entities
{
    public class foods
    {
        public Int32? id
        {
            get;
            set;
        }
        [Required]
        public String foodname
        {
            get;
            set;
        }
        [Required]
        public String foodkey
        {
            get;
            set;
        }
        [Required]
        public String categorykey
        {
            get;
            set;
        }

        public Boolean isapproved
        {
            get;
            set;
        }

        public String imagelocation
        {
            get;
            set;
        }
    }
}
