﻿/*
 * Demoder.AnarchyData
 *
 * Copyright (c) 2012-2016 Marie Helene Kvello-Aune 
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either 
 * version 3 of the License.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public 
 * License along with this library.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using AODb.Common.Attributes;
using AODb.Data.Attributes;

namespace AODb.Data.Spells
{
    /// <summary>
    /// TODO: Figure out if this is the correct layout. All instances of this seem to return 'robe'!
    /// </summary>
    [SpellId(53054)]
    public class ChangeBodyMeshSpell : Spell
    {
        [StreamData(0)]
        public string A { get; set; }
    }
}