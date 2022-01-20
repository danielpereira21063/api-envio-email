using Microsoft.AspNetCore.Mvc;
using SendEmailTeste.Models;
using SendEmailTeste.Services;
using System;
using System.Threading.Tasks;
namespace AspEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : Controller
    {
        private readonly IMailService mailService;
        public EmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }


        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] EmailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}