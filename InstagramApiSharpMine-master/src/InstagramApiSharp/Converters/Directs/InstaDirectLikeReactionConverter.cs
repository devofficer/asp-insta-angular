﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharpMine
 * 
 * IRANIAN DEVELOPERS
 */

using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Classes.ResponseWrappers;
using System;

namespace InstagramApiSharp.Converters
{
    class InstaDirectLikeReactionConverter : IObjectConverter<InstaDirectLikeReaction, InstaDirectLikeReactionResponse>
    {
        public InstaDirectLikeReactionResponse SourceObject { get; set; }

        public InstaDirectLikeReaction Convert()
        {
            if (SourceObject == null) throw new ArgumentNullException($"Source object");

            var likeReaction = new InstaDirectLikeReaction
            {
                SenderId = SourceObject.SenderId,
                ClientContext = SourceObject.ClientContext,
                Timestamp = SourceObject.Timestamp.FromUnixTimeSeconds()
            };
            return likeReaction;
        }
    }
}
