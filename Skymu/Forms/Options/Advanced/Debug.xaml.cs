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

using System.Windows.Controls;
using System.Windows.Navigation;

namespace Skymu.Forms.OptionPages.Advanced
{
    public partial class Debug : Page
    {
        public Debug()
        {
            InitializeComponent();
        }

        private void OURL(object sender, RequestNavigateEventArgs e) => Universal.OpenUrl(e.Uri.AbsoluteUri);
    }
}