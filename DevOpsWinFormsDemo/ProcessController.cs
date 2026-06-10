using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsWinFormsDemo
{
    public class ProcessController
    {
        public bool IsRunning { get; private set; }

        public string Start()
        {
            if (IsRunning)
            {
                return "Process is already running.";
            }

            IsRunning = true;
            return "Process started.";
        }

        public string Stop()
        {
            if (!IsRunning)
            {
                return "Process is not running.";
            }

            IsRunning = false;
            return "Process stopped.";
        }

        public bool ID(String id)
        {
            if(id == "rorze")
                return true;
            else return false;
        }

        public bool PW(String pw)
        {
            if(pw == "123") return true;
            else return false;
        }

    }
}
