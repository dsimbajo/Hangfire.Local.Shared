using Hangfire;
using Hangfire.Local.Client.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hangfire.Local.Client.Model
{
    public class JobTwo : IBackgroundJob
    {
        [DisplayName("JobTwo")]
        [AutomaticRetry(Attempts = 5)]
        public void Run()
        {
            var client = new BackgroundJobClient();
            client.Enqueue(() => Console.WriteLine("Job Two"));
        }
    }
}
