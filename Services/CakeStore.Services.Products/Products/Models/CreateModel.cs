﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CakeStore.Context.Entities;
using CakeStore.Context;
using CakeStore.Settings;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace CakeStore.Services.Products;

public class CreateModel
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<string> Categories { get; set; }

    public ICollection<IFormFile> Images { get; set; }


}



public class CreateBookModelValidator : AbstractValidator<CreateModel>
{
    public CreateBookModelValidator(IDbContextFactory<MainDbContext> contextFactory)
    {
        //RuleFor(x => x.Name).ProductTitle();

        //RuleFor(x => x.UserId)
        //    .NotEmpty().WithMessage("Author is required")
        //    .Must((id) =>
        //    {
        //        using var context = contextFactory.CreateDbContext();
        //        var found = context.Users.Any(a => a.Id == id);
        //        return found;
        //    }).WithMessage("Author not found");

        RuleFor(x => x.Description)
            .MaximumLength(1000).WithMessage("Maximum length is 1000");
    }
}