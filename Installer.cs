﻿using System;
using System.Collections;
using System.ComponentModel;

namespace WindowsServiceTemplate
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }

        private string GetName()
        {
            return AppDomain.CurrentDomain.FriendlyName;
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            base.OnBeforeInstall(savedState);

            // set service name
            var name = GetName();
            serviceInstaller1.DisplayName = name;
            serviceInstaller1.ServiceName = name;
            serviceInstaller1.Description = name;
        }

        protected override void OnBeforeUninstall(IDictionary savedState)
        {
            base.OnBeforeUninstall(savedState);

            // set service name
            var name = GetName();
            serviceInstaller1.DisplayName = name;
            serviceInstaller1.ServiceName = name;
            serviceInstaller1.Description = name;
        }
    }
}