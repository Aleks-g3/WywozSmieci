using System;
using System.Collections.Generic;
using System.Text;

namespace WywozSmieci.Standard
{
    public class RejonService : IRejonService
    {
        private DataContext _dbPath;

        public RejonService(string dbPath)
        {
            _dbPath = new DataContext(dbPath);
        }

        public async Task<IEnumerable<Rejon>> GetRejons()
        {
            return await _dbPath.
        }
    }
}
