using Entities;
using Infrastructure.Overviews;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Dogtrick.Pages
{
    public partial class PrivateMessage
    {
        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IMessageService _messageService { get; set; }
        [Inject]
        public IPrivateMessageOverview _privateMessageOverview { get; set; }

        //Who we send to
        [Parameter]
        public string UserId { get; set; }
        private Guid ParsedUserId { get; set; }
        public User User { get; set; }
        public string MemberId { get; set; }
        public List<Message> AllPrivateDmMessages { get; set; }
        public List<Message> PrivateDmMessages { get; set; } = new List<Message>();

        public string? userInput;
        public string? messageInput;
        private HubConnection hubConnection;

        protected override async Task OnInitializedAsync()
        {
            ParsedUserId = Guid.Parse(UserId);
            User = await _userRepository.GetMemberOnId(ParsedUserId);
            MemberId = _messageService.MemberId;

            //Here we check if conversation has happened
            _privateMessageOverview.SetConversationId(UserId, MemberId);

            hubConnection = new HubConnectionBuilder()
            .WithUrl(Navigation.ToAbsoluteUri("/chathub"))
            .Build();

            hubConnection.On<Message>("ReceiveMessage", (message) =>
            {
                PrivateDmMessages = _messageService.SendMessage(message);
                PrivateDmMessages = _messageService.GetCurrentConversation(message.ToUserId, message.FromUserId);
                InvokeAsync(StateHasChanged);
            });

            await hubConnection.StartAsync();
            messageInput = "";
        }

        private async Task Send()
        {
            var userId = User.Id.ToString();

            Message message = new Message();
            message.ToUserId = userId;
            message.FromUserId = MemberId;
            message.MessageText = messageInput;
            message.TimeStamp = DateTime.Now;
            message.ConversationId = _messageService.ConversationId;

            if (hubConnection is not null)
            {
                await hubConnection.SendAsync("SendMessage", message);
            }

            messageInput = "";
        }

        public bool IsConnected =>
            hubConnection?.State == HubConnectionState.Connected;

        public async ValueTask DisposeAsync()
        {
            if (hubConnection is not null)
            {
                await hubConnection.DisposeAsync();
            }
        }

        public void ReportConversation()
        {
            var memberId = Guid.Parse(MemberId);
            _privateMessageOverview.ReportConversation(PrivateDmMessages, memberId, ParsedUserId);
        }
    }
}
