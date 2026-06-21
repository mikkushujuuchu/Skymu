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

using Skymu.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;
using Yggdrasil.Enumerations;

namespace Skymu.Converters
{
    public class ConnectionStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is PresenceStatus stat)
            {
                return MainViewModel.GetIntFromStatus(stat);
            }
            return 0;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            return Binding.DoNothing;
        }
    }
}
