﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelDiary.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> ValueOne { get; set; }
        public IEnumerable<Comment> ValueTwo { get; set; }
        public IEnumerable<Blog> ValueThree { get; set; }
    }
}