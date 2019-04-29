﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Gitter.Library;

namespace Blazor.Gitter.Core.Components.Shared
{
    public interface IAppState
    {
        event Action GotApiKey;
        event Action GotChatUser;
        event Action GotChatRooms;
        event Action OnChange;
        event Action<IChatMessage> GotMessageToQuote;
        event EventHandler ActivityTimeout;
        event EventHandler ActivityResumed;
        event EventHandler<DateTime> TimeoutChanged;
        bool HasApiKey { get; }
        bool HasChatRooms { get; }
        bool HasChatUser { get; }
        bool Initialised { get; }
        void TriggerLoggedIn();
        string GetApiKey();
        List<IChatRoom> GetMyRooms();
        IChatRoom GetRoom(string RoomId);
        IChatUser GetMyUser();
        DateTime GetTimeoutTime();
        Task Initialise();
        Task SaveApiKey();
        void SetApiKey(string value);
        void SetMyRooms(List<IChatRoom> value);
        void SetMyUser(IChatUser value);
        void RecordActivity();
        void QuoteMessage(IChatMessage message);
    }
}