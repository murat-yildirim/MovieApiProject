using MovieApi.Domain.Entities;
using MovieApiProject.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApiProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiProject.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categorys.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            await _context.SaveChangesAsync();
        }
    }
}
