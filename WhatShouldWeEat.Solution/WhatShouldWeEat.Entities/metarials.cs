using System;
using System.ComponentModel.DataAnnotations;

namespace WhatShouldWeEat.Entities
{
    public class metarials
    {
        public Int32? id
        {
            get;
            set;
        }
        [Required]
        public String metarialkey
        {
            get;
            set;
        }
        [Required]
        public String metarialname
        {
            get;
            set;
        }

        public Boolean isapproved
        {
            get;
            set;
        }
    }
}
