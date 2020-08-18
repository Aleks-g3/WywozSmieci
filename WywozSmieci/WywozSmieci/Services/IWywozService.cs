using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WywozSmieci.Model;

namespace WywozSmieci.Services
{
    public interface IWywozService
    {
        Task<IEnumerable<Wywoz>> GetAsync();
        Task<bool> AddAsync(Wywoz wywoz);
    }
}
