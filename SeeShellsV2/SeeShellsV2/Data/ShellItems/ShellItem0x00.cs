﻿#region copyright
// SeeShells Copyright (c) 2019-2020 Aleksandar Stoyanov, Bridget Woodye, Klayton Killough, 
// Richard Leinecker, Sara Frackiewicz, Yara As-Saidi
// SeeShells is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// SeeShells is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License along with this program;
// if not, see <https://www.gnu.org/licenses>
#endregion
using System.Collections.Generic;

namespace SeeShellsV2.Data
{
    // TODO (Devon): Figure out what this ShellItem is supposed to be
    //               Maybe Signature based items? https://github.com/libyal/libfwsi/blob/main/documentation/Windows%20Shell%20Item%20format.asciidoc#4-signature-based-shell-items
    public class ShellItem0x00 : ShellItem, IShellItem
    {
        public string Guid // Signature?
        {
            init => fields["Guid"] = value;
            get => fields.GetClassOrDefault("Guid", string.Empty);
        }

        public ShellItem0x00() { }

        public ShellItem0x00(byte[] buf)
        {
            fields["Size"] = Block.UnpackWord(buf, 0x00);
            fields["Type"] = Block.UnpackByte(buf, 0x02);

            if (Size == 0x20)
            {
                fields["Guid"] = Block.UnpackGuid(buf, 0x0E);

                if (KnownGuids.dict.ContainsKey(Guid))
                    fields["Description"] = string.Format("{{{0}}}", KnownGuids.dict[Guid]);
                else
                    fields["Description"] = string.Format("{{{0}}}", Guid);
            }
        }
    }
}