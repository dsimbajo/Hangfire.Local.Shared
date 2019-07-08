using Hangfire.Local.Client.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hangfire.Local.Client.Model
{
   
    public class JobOne : IBackgroundJob
    {
        [DisplayName("JobOne")]
        public void Run()
        {
            var client = new BackgroundJobClient();
            client.Enqueue(() => Console.WriteLine("Job One"));
        }
    }
}
