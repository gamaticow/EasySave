﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySave.Model
{
    class DifferentialBackupWork : BackupWork
    {
        public DifferentialBackupWork(string name, string sourceDirectory, string targetDirectory) : base(name, sourceDirectory, targetDirectory)
        {
            backupType = BackupType.DIFFERENTIAL;
        }
    }
}