﻿using System;

namespace Tee.FamilyApp.Common.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}