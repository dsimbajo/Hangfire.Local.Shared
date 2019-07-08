using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Local.Client.Interface
{
    public interface IBackgroundJob
    {
        void Run();
    }
}
