﻿using System;

namespace dotnetCampus.OpenXmlUnitConverter
{
    /// <summary>
    /// 采用 <see cref="Emu"/> 表示的点
    /// </summary>
    public readonly struct EmuPoint : IEquatable<EmuPoint>
    {
        /// <summary>
        /// 创建 <see cref="Emu"/> 表示的点
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public EmuPoint(Emu x, Emu y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// 表示 X 坐标
        /// </summary>
        public Emu X { get; }

        /// <summary>
        /// 表示 Y 坐标
        /// </summary>
        public Emu Y { get; }

        /// <inheritdoc />
        public bool Equals(EmuPoint other)
        {
            return X.Equals(other.X);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is EmuPoint other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return X.GetHashCode();
        }

        /// <summary>
        /// 判断相等
        /// </summary>
        public static bool operator ==(in EmuPoint left, in EmuPoint right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// 判断不相等
        /// </summary>
        public static bool operator !=(in EmuPoint left, in EmuPoint right)
        {
            return !left.Equals(right);
        }

        /// <inheritdoc />
        public override string ToString() => $"X={X} ;Y={Y}";
    }
}