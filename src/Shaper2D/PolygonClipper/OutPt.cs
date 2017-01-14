﻿// <copyright file="OutPt.cs" company="Scott Williams">
// Copyright (c) Scott Williams and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace Shaper2D.PolygonClipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// ??
    /// </summary>
    internal class OutPt
    {
#pragma warning disable SA1401 // Field must be private
        /// <summary>
        /// The index
        /// </summary>
        internal int Idx;

        /// <summary>
        /// The pt
        /// </summary>
        internal System.Numerics.Vector2 Pt;

        /// <summary>
        /// The next
        /// </summary>
        internal OutPt Next;

        /// <summary>
        /// The previous
        /// </summary>
        internal OutPt Prev;
#pragma warning restore SA1401 // Field must be private
    }
}