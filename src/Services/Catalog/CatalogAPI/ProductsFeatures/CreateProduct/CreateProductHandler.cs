﻿using BuildingBlocks.CQRS;
using CatalogAPI.Models;
using MediatR;
using System.Windows.Input;

namespace CatalogAPI.ProductsFeatures.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price): ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create Product entity from command Project

            //save to database

            //return createProductResult result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,
            };

            //TODO
            //save to database
            //return result

            return new CreateProductResult(Guid.NewGuid());

        }
    }
}
