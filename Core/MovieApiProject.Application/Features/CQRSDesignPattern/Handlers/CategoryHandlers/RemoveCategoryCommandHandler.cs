using MovieApiProject.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApiProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiProject.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveCategoryCommand command)
        {
            var value = await _context.Categorys.FindAsync(command.CategoryId);
            _context.Categorys.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
