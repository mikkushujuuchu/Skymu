/*==========================================================*/
// Copyright © The Skymu Team and other contributors.
// For any inquiries or concerns, email contact@skymu.app.
/*==========================================================*/
// Modification or redistribution of this code is contingent
// on your agreement to be bound by the terms of our license.
// If you do not wish to abide by those terms, you may not
// modify or distribute any original code from the project.
/*==========================================================*/
// License: https://skymu.app/legal/AGPLv3
// SPDX-License-Identifier: AGPL-3.0-or-later
/*==========================================================*/

using System;
using System.Diagnostics;
using Microsoft.Win32;
using Skymu.Preferences;

#pragma warning disable CA1416

namespace Skymu.Windows
{
    internal class AutoLaunch
    {
        internal const bool BootstrapValue = true;
        internal static bool Get()
        {
            using (
                RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run",
                    false
                )
            )
            {
                if (key == null)
                {
                    Set(BootstrapValue);
                    return BootstrapValue;
                }

                object value = key.GetValue(Universal.NAME);

                if (value == null)
                {
                    Set(BootstrapValue);
                    return BootstrapValue;
                }

                string currentPath = "\"" + Process.GetCurrentProcess().MainModule.FileName + "\"";

                return string.Equals(
                    value.ToString(),
                    currentPath,
                    StringComparison.OrdinalIgnoreCase
                );
            }
        }

        internal static void Set(bool yes)
        {
            using (
                RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run",
                    true
                )
            )
            {
                if (yes)
                    key.SetValue(
                        Universal.NAME,
                        "\"" + Process.GetCurrentProcess().MainModule.FileName + "\""
                    );
                else
                    key.DeleteValue(Universal.NAME, false);
            }
        }
    }
}
