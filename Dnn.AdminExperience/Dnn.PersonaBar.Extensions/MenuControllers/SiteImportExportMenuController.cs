﻿// 
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// 
using System.Collections.Generic;
using Dnn.PersonaBar.Library.Controllers;
using Dnn.PersonaBar.Library.Model;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;

namespace Dnn.PersonaBar.SiteImportExport.MenuControllers
{
    public class AdminMenuController : IMenuItemController
    {
        public void UpdateParameters(MenuItem menuItem)
        {
            
        }

        public bool Visible(MenuItem menuItem)
        {
            var user = UserController.Instance.GetCurrentUserInfo();
            return user.IsSuperUser;
        }

        public IDictionary<string, object> GetSettings(MenuItem menuItem)
        {
            var settings = new Dictionary<string, object>();
            return settings;
        }
    }
}
