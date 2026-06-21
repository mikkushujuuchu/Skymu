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

namespace Skymu.Enumerations
{
    public enum WindowFrame
    {
        SkypeAero,
        SkypeBasic,
        Native,
        SkypeAeroCustom,
    };

    public enum Soundpack
    {
        Enhanced,
        Skype2,
        Skype7,
        Skype8,
    };

    public enum NotificationTriggerType
    {
        ALL = 1,
        PING = 2,
        DM = 4,
        PDM = PING | DM,
    }
}
