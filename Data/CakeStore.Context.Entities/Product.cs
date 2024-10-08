﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CakeStore.Context.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    //public Guid? UserId { get; set; }
    public virtual ICollection<Image>? Images { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
    public virtual ICollection<OrderDetail>? OrderDetails { get; private set; }

    public virtual ICollection<Like>? Likes { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }

    public virtual User User { get; set; }
}
