﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore.Context.Entities;

public class Like : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public int ProductId { get; set; }

    public virtual Product Product { get; set; }
}
