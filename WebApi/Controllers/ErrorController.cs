﻿using Microsoft.AspNetCore.Mvc;
using WebApi.Errors;

namespace WebApi.Controllers
{
    [Route("errors")]
    [ApiController]
    public class ErrorController : BaseController
    {
        /*public IActionResult Error(int code)
        {
            return new ObjectResult(new CodeErrorResponse(code));
        }*/
    }
}
