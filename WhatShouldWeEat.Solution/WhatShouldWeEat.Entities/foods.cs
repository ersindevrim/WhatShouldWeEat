using System;
namespace WhatShouldWeEat.Entities
{
    public class foods
    {
        public Int32 id
        {
            get;
            set;
        }

        public String foodname
        {
            get;
            set;
        }

        public String foodkey
        {
            get;
            set;
        }

        public String categorykey
        {
            get;
            set;
        }

        public String filelocation
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
