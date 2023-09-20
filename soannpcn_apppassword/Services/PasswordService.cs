using soannpcn_apppassword.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace soannpcn_apppassword.Services
{
    public class PasswordService : Data
    {
        readonly List<Data> appData;

        public PasswordService() 
        {
            appData = new List<Data>()
            {
                new Data() { Id = Guid.NewGuid().ToString(), ServiceName = "Instagram" , Username = "Soann" },
                new Data() { Id = Guid.NewGuid().ToString(), ServiceName = "Snapchat" , Username = "Snap" },
                new Data() { Id = Guid.NewGuid().ToString(), ServiceName = "Netflix" , Username = "Soann" },
                new Data() { Id = Guid.NewGuid().ToString(), ServiceName = "Youtube" , Username = "Soann" },

            };
        }


        public async Task<IEnumerable<Data>> GetAppAsync ( bool forceRefresh = false)
        {
            return await Task.FromResult(appData);

        }

        
    }
}
