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

using System;

namespace AODb.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class StatAttribute : Attribute
    {
        public uint[] Stats { get; private set; }

        public StatAttribute(params Stat[] stats)
        {
            this.Stats = new uint[stats.Length];
            for (int i = 0; i < stats.Length; i++)
            {
                this.Stats[i] = (uint)stats[i];
            }
        }
        public StatAttribute(uint[] statIDs)
        {
            this.Stats = statIDs;
        }
    }
}
