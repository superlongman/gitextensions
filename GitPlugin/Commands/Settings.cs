﻿using System;
using System.Collections.Generic;
using System.Text;
using EnvDTE;

namespace GitPlugin.Commands
{
    public class Settings : ItemCommandBase
    {
        public Settings()
            : base(true, true)
        {
        }

        public override void OnExecute(SelectedItem item, string fileName, OutputWindowPane pane)
        {
            RunGitEx("settings", fileName);
        }

        public override bool IsEnabled(EnvDTE80.DTE2 application)
        {
            return true;
        }
    }
}
