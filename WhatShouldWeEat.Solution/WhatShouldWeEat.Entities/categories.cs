using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WhatShouldWeEat.Entities
{
    public class categories
    {
        public Int32? id
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
        [Required]
        public String categoryname
        {
            get;
            set;
        }

        public String categorydesc
        {
            get;
            set;
        }
    }
}
