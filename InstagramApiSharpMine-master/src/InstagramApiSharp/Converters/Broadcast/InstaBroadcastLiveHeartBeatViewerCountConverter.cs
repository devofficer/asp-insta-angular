﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using System;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters
{
    internal class InstaBroadcastLiveHeartBeatViewerCountConverter 
        : IObjectConverter<InstaBroadcastLiveHeartBeatViewerCount, InstaBroadcastLiveHeartBeatViewerCountResponse>
    {
        public InstaBroadcastLiveHeartBeatViewerCountResponse SourceObject { get; set; }

        public InstaBroadcastLiveHeartBeatViewerCount Convert()
        {
            if (SourceObject == null) throw new ArgumentNullException($"Source object");
            var heartbeat = new InstaBroadcastLiveHeartBeatViewerCount
            {
                CobroadcasterIds = SourceObject.CobroadcasterIds,
                IsTopLiveEligible = SourceObject.IsTopLiveEligible,
                OffsetToVideoStart = SourceObject.OffsetToVideoStart,
                TotalUniqueViewerCount = SourceObject.TotalUniqueViewerCount,
                ViewerCount = SourceObject.ViewerCount
            };
            try
            {
                heartbeat.BroadcastStatusType = (InstaBroadcastStatusType)Enum.Parse(typeof(InstaBroadcastStatusType), SourceObject.BroadcastStatus?.Replace("_", ""), true);
            }
            catch { }
            return heartbeat;
        }
    }
}
