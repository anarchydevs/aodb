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
    [SpellId(53204)]
    public class AttractorGfxEffectSpell : Spell
    {
        [StreamData(0)]
        public int A { get; set; }

        [StreamData(1)]
        public int B { get; set; }

        [StreamData(2)]
        public int C { get; set; }

        [StreamData(3)]
        public int D { get; set; }

        [StreamData(4)]
        public int E { get; set; }

        [StreamData(5)]
        public int F { get; set; }

        [StreamData(6)]
        public int G { get; set; }

        [StreamData(7)]
        public int H { get; set; }

        [StreamData(8)]
        public int I { get; set; }

        [StreamData(9)]
        public int J { get; set; }

        [StreamData(10)]
        public int K { get; set; }

        [StreamData(11)]
        public int L { get; set; }

        [StreamData(12)]
        public int M { get; set; }
    }
}