using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.MenuItems
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IRepositoryManager repositoryManager;

        public MenuItemService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }
    }
}
