using Entities;
using Infrastructure.Repository;
using Infrastructure.Service;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR.Client;

namespace Dogtrick.Pages
{
    partial class Index
    {
        public List<DogViewModel> Dogs { get; set; }

        public User User { get; set; }
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public IDogPicturesRepository _dogPicturesRepository { get; set; }
        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IMemberService _memberService { get; set; }

        private HubConnection? hubConnection;
        public List<string> messages = new List<string>();
        public List<Message> MessagesList { get; set; } 
        public string? userInput;
        public string? messageInput;


        protected override async Task OnInitializedAsync()
        {
            MessagesList = _memberService.GetChatMessages();

            hubConnection = new HubConnectionBuilder()
            .WithUrl(Navigation.ToAbsoluteUri("/chathub"))
            .Build();

            hubConnection.On<Message>("ReceiveMessage", (message) =>
            {
                MessagesList = _memberService.SendMessage(message);
                InvokeAsync(StateHasChanged);
            });

            await hubConnection.StartAsync();
            messageInput = "";
        }

        private async Task Send()
        {
            
            Message message = new Message();
            message.MessageText = messageInput;
            message.TimeStamp = DateTime.Now;
            message.FromUserId = _memberService.MemberId;

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
    }
}
