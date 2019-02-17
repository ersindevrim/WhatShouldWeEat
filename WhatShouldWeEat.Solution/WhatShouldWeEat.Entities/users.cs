using System;
using System.ComponentModel.DataAnnotations;

namespace WhatShouldWeEat.Entities
{
    public class users
    {
        public Int32? id
        {
            get;
            set;
        }
        [Required]
        public String username
        {
            get;
            set;
        }
        [Required]
        public String password
        {
            get;
            set;
        }
        [Required]
        public String mailadress
        {
            get;
            set;
        }

        public Boolean isadmin
        {
            get;
            set;
        }

        public String migroskey
        {
            get;
            set;
        }

        public String getirkey
        {
            get;
            set;
        }

        public Boolean isactive
        {
            get;
            set;
        }

        public String userkey
        {
            get;
            set;
        }

        public String profileimage
        {
            get;
            set;
        }
    }
}
