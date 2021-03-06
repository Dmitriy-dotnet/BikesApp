﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bikes.DAL.Entities.Abstract
{
    public abstract class BaseEntity
    {
        private DateTime _createdAt;

        public BaseEntity()
        {
            _createdAt = UpdatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = (value == null || value == DateTime.MinValue) ? DateTime.Now : value;
        }
        public DateTime UpdatedAt { get; set; }
    }
}
