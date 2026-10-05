using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x9cf3c3e3
{
    public static class _0xea9b069c
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xef00101c
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x48e02344
    {
        private static readonly _0x48e02344 _0xeec5e6d5 = new();
        public static readonly _0x48e02344[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xeec5e6d5,
            _0xeec5e6d5,
            _0xeec5e6d5,
        };
        private int _0x022b324f => 0;
        private int _0x9323aecc => 10;
        private string _0xd53f302d => _0x4cc8df9e._0xe3178a13(new byte[4] { 71, 111, 100, 127 }, 10);
        private string _0x8217272c => _0x4cc8df9e._0xe3178a13(new byte[8] { 161, 168, 187, 168, 161, 150, 221, 144 }, 237);

        private int _0xc4da0a6a
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x4cc8df9e._0xe3178a13(new byte[25] { 59, 13, 10, 10, 29, 22, 12, 63, 20, 23, 26, 25, 20, 59, 16, 25, 8, 12, 29, 10, 49, 22, 28, 29, 0 }, 120)))
                    PlayerPrefs.SetInt(_0x4cc8df9e._0xe3178a13(new byte[25] { 119, 65, 70, 70, 81, 90, 64, 115, 88, 91, 86, 85, 88, 119, 92, 85, 68, 64, 81, 70, 125, 90, 80, 81, 76 }, 52), 0);
                return PlayerPrefs.GetInt(_0x4cc8df9e._0xe3178a13(new byte[25] { 60, 10, 13, 13, 26, 17, 11, 56, 19, 16, 29, 30, 19, 60, 23, 30, 15, 11, 26, 13, 54, 17, 27, 26, 7 }, 127));
            }

            set => PlayerPrefs.SetInt(_0x4cc8df9e._0xe3178a13(new byte[25] { 141, 187, 188, 188, 171, 160, 186, 137, 162, 161, 172, 175, 162, 141, 166, 175, 190, 186, 171, 188, 135, 160, 170, 171, 182 }, 206), value);
        }

        public int _0xadf97365
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd53f302d}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xd53f302d}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xd53f302d}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xd53f302d}CurrentLevelIndex", value);
        }

        public int _0x689cd9f9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd53f302d}BestScore"))
                    this._0x689cd9f9 = 0;
                return PlayerPrefs.GetInt($"{this._0xd53f302d}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xd53f302d}BestScore", value);
        }

        public bool _0x9debb77c
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd53f302d}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xd53f302d}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xd53f302d}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xd53f302d}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x931bebe5
    {
        public static int _0x98ad77d8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x4cc8df9e._0xe3178a13(new byte[5] { 195, 239, 233, 238, 243 }, 128)))
                    PlayerPrefs.SetInt(_0x4cc8df9e._0xe3178a13(new byte[5] { 27, 55, 49, 54, 43 }, 88), 0);
                return PlayerPrefs.GetInt(_0x4cc8df9e._0xe3178a13(new byte[5] { 145, 189, 187, 188, 161 }, 210));
            }

            set
            {
                PlayerPrefs.SetInt(_0x4cc8df9e._0xe3178a13(new byte[5] { 141, 161, 167, 160, 189 }, 206), value);
                _0xfa2aadfc.Instance._0x6a12bbcd();
            }
        }
    }

    public static class _0xf290fefa
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x4cc8df9e
{
    internal static string _0xe3178a13(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}