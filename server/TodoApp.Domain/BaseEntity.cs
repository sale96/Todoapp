﻿using System;

namespace TodoApp.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
