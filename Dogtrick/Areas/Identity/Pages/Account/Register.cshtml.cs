// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
using Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dogtrick.Areas.Identity.Pages.Account
{
    public partial class RegisterModel : PageModel
    {
        
        [BindProperty]
        public InputModel Input { get; set; }
        private User NewMember { get; set; }
        public bool ErrorEmailMessage { get; set; } = true;
        public bool ErrorPasswordMessage { get; set; } = true;

        [Inject]
        public IUserRepository _userRepository { get; set; }


        public RegisterModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public class InputModel
        {
            
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]            
            public string ConfirmPassword { get; set; }
        }

        public async Task OnPostAsync()
        {
            ErrorPasswordMessage = CheckIfPasswordMatches();

            if(ErrorPasswordMessage != true)
            {
                return;
            }
            
            NewMember = await _userRepository.CheckIfMemberExists(Input.Email);

            if (NewMember != null)
            {
                ErrorEmailMessage = false;
                return;
            }

            NewMember = CreateNewMember();
            //_userRepository.RegisterNewMember(NewMember);
            NewMember = new User();
            Response.Redirect("/");            
        }

        private async Task<User> CheckIfMemberExists()
        {
            return await _userRepository.CheckIfMemberExists(Input.Email);            
        }

        private User CreateNewMember()
        {
            User user = new User() { 
                Id = Guid.NewGuid(), 
                Email = Input.Email,
                Password = Input.Password
            };

            return user;
        }

        private bool CheckIfPasswordMatches()
        {
            if (Input.Password == Input.ConfirmPassword)
            {
                return true;
            }

            return false;
        }
    }
}
