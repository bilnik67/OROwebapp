using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OROApp.Models;
using Microsoft.EntityFrameworkCore;

namespace OROApp.Services
{
    public interface IOROappService
    {
        Task VoegnieuweBestelling(UserModel userModel);
        Task<List<UserModel>> GetUserModels();
        Task DeleteBestelling(int bestellingID);
    }
    public class OROAppService : IOROappService
    {
        
        public async Task VoegnieuweBestelling(UserModel userModel)
        {
            using (var context = new DemoContext())
            {
                await context.users.AddAsync(userModel);
                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteBestelling(int bestellingID)
        {
            using (var context = new DemoContext())
            {
                var oudebestelling = await context.users.FindAsync(bestellingID);
                if (oudebestelling != null)
                {
                    context.users.Remove(oudebestelling);
                    await context.SaveChangesAsync();
                }

            }
        }
        public async Task<List<UserModel>> GetUserModels()
        {
            using (var context = new DemoContext())
            {
                return await context.users.ToListAsync();
            }
        }

            
    }
}
