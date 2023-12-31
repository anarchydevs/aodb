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
    /// 
    /// </summary>
    /// <remarks>
    /// Seems to behave identical to ModifySpell in 18.5.4.0.
    /// </remarks>
    [SpellId(53012)]
    [SpellFormat("Modify {Stat} {|right|}{Amount}{|/right|}")]
    public class SkillSpell : Spell
    {
        [StreamData(0)]
        public Stat Stat { get; set; }

        [StreamData(1)]
        [Interpolate]
        [BelongsTo("Stat")]
        public int Amount { get; set; }

        [StreamData(2)]
        public int C { get; set; }
    }
}