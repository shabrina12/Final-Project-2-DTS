﻿using Microsoft.AspNetCore.Mvc;
using Web_API.Base;
using Web_API.Models;
using Web_API.Repository.Contracts;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountRolesController : GeneralController<IAccountRoleRepository, AccountRole, int>
    {
        public AccountRolesController(IAccountRoleRepository repository) : base(repository)
        {
            
        }
    }
}
