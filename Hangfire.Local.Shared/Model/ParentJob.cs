using Hangfire.Local.Client.Interface;
using Hangfire.Local.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Hangfire.Local.Shared.Model
{
    public class ParentJob : IBackgroundJob
    {
        private readonly List<IBackgroundJob> _backgroundJobs;

        public ParentJob()
        {
            _backgroundJobs = new List<IBackgroundJob>();
            //_backgroundJobs.Add(new JobOne());
            //_backgroundJobs.Add(new JobTwo());
            //_backgroundJobs.Add(new JobThree());
            //_backgroundJobs.Add(new JobFour());
            //_backgroundJobs.Add(new JobFive());
        }

        [DisplayName("ParentJob")]
        public void Run()
        {
            foreach (var background in _backgroundJobs)
            {
                BackgroundJob.Enqueue(() => background.Run());
            }
        }
    }
}
