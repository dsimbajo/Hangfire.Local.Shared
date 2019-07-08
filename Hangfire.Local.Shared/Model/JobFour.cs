using Hangfire.Local.Client.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hangfire.Local.Shared.Model
{
    public class JobFour : IBackgroundJob
    {
        [DisplayName("JobFour")]
        public void Run()
        {
            var client = new BackgroundJobClient();
            client.Enqueue(() => Console.WriteLine("Job Four"));
        }
    }
}
