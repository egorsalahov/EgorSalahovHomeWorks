using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.AsyncAwait
{
    public class ConfigHW
    {
        private bool flag = false;
        private string _configuration;

        private ConfigHW() { }


        public static async Task<ConfigHW> CreateAsync() 
        {
            var timely = new ConfigHW(); //пустой

            await timely.InitializeAsync(); //асинхронная инициализация

            return timely; //готовый объект
        }


        private async Task InitializeAsync()
        {
            _configuration = await File.ReadAllTextAsync("config.json");

            flag = true;
        }

    }
}
