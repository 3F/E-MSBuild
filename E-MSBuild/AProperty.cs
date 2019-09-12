﻿/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2013-2019  Denis Kuzmin < x-3F@outlook.com > GitHub/3F
 * Copyright (c) E-MSBuild contributors: https://github.com/3F/E-MSBuild/graphs/contributors
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/

namespace net.r_eg.EvMSBuild
{
    public struct AProperty
    {
        /// <summary>
        /// Either complex phrase or simple property.
        /// For example:
        ///  * Property Function:   $([System.DateTime]::UtcNow.Ticks)
        ///  * Simple property:     $(Configuration)
        /// </summary>
        public bool complex;

        /// <summary>
        /// Prepared but unevaluated data, ie. the evaluation should be from this.
        /// </summary>
        public string unevaluated;

        /// <summary>
        /// The left definition of property.
        /// </summary>
        public string name;

        /// <summary>
        /// Specified scope where it was placed.
        /// </summary>
        public string scope;

        /// <summary>
        /// Initial data.
        /// </summary>
        public string raw;
    }
}
