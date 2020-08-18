using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WywozSmieci.Model;
using WywozSmieci.Services;

namespace WywozSmieci.Database
{
    public class WywozService: IWywozService
    {
        private DatabaseContext _databaseContext;

        public WywozService(string dbPath)
        {
            _databaseContext = new DatabaseContext(dbPath);
        }

        public async Task<IEnumerable<Wywoz>> GetAsync()
        {
            try
            {
                var wywozy = await _databaseContext.Wywozs.ToListAsync();
                
                if (wywozy.Count==0)
                {
                    //await AddAsync(new Wywoz
                    //{
                    //     rejon="Banino I",
                    //     Data=new DateTime(2020,5,8),
                    //     Typ="Tworzywa Sztuczne"
                    //});
                }
                

                return wywozy;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
        public async Task<bool> AddAsync(Wywoz wywoz)
        {
            try
            {
                var tracking = await _databaseContext.Wywozs.AddAsync(wywoz);

                await _databaseContext.SaveChangesAsync();

                var isAdded = tracking.State == EntityState.Added;

                return isAdded;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
