using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPS.Services
{
    public interface IEmailService
    {
        Task SendAsync(string email, string messageBody);
    }
}
