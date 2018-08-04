﻿using System;
using Tweetinvi.Events;
using Tweetinvi.Models.Webhooks;

namespace Tweetinvi.Core.Public.Streaming
{
    public interface IAccountActivityStream
    {
        long UserId { get; set; }

        EventHandler<TweetReceivedEventArgs> TweetCreated { get; set; }
        EventHandler<TweetFavouritedEventArgs> TweetFavourited { get; set; }
        EventHandler<UserFollowedEventArgs> UserFollowed { get; set; }
        EventHandler<UserBlockedEventArgs> UserBlocked { get; set; }
        EventHandler<UserMutedEventArgs> UserMuted { get; set; }
        EventHandler<UserRevokedAppPermissionsEventArgs> UserRevokedAppPermissions { get; set; }
        EventHandler<MessageEventArgs> MessageReceived { get; set; }
        EventHandler<MessageEventArgs> MessageSent { get; set; }
        EventHandler<UnmanagedMessageReceivedEventArgs> UnmanagedEventReceived { get; set; }
        EventHandler<JsonObjectEventArgs> JsonObjectReceived { get; set; }

        void WebhookMessageReceived(IWebhookMessage message);
    }
}