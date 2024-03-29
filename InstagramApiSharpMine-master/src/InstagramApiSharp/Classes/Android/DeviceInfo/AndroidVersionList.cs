﻿using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Android.DeviceInfo
{
    public class AndroidVersionList
    {
        public static AndroidVersionList GetVersionList() => new AndroidVersionList();

        public List<AndroidVersion> AndroidVersions()
        {
            return new List<AndroidVersion>
            {
                new AndroidVersion
                {
                    Codename = "Lollipop",
                    VersionNumber = "5.1.0",
                    APILevel = "22"
                },
                new AndroidVersion
                {
                    Codename = "Marshmallow",
                    VersionNumber = "6.0.0",
                    APILevel = "23"
                },
                new AndroidVersion
                {
                    Codename = "Nougat",
                    VersionNumber = "7.0.0",
                    APILevel = "24"
                },
                new AndroidVersion
                {
                    Codename = "Nougat",
                    VersionNumber = "7.1.0",
                    APILevel = "25"
                },
                new AndroidVersion
                {
                    Codename = "Oreo",
                    VersionNumber = "8.0.0",
                    APILevel = "26"
                },
                new AndroidVersion
                {
                    Codename = "Oreo",
                    VersionNumber = "8.1.0",
                    APILevel = "27"
                },
                new AndroidVersion
                {
                    Codename = "Pie",
                    VersionNumber = "9.0.0",
                    APILevel = "28"
                },
                new AndroidVersion
                {
                    Codename = "Android 10",
                    VersionNumber = "10.0.0",
                    APILevel = "29"
                },
                new AndroidVersion
                {
                    Codename = "Android 11",
                    VersionNumber = "11.0.0",
                    APILevel = "30"
                }
            };
        }
    }
}
