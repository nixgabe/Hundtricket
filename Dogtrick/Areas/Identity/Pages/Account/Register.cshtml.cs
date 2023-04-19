// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
using Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dogtrick.Areas.Identity.Pages.Account
{
    public partial class RegisterModel : PageModel
    {
        
        [BindProperty]
        public InputModel Input { get; set; }
        private User NewMember { get; set; }
        private UserProfile NewProfile { get; set; }
        private UserHobbies HobbiesLikes { get; set; }
        
        private UserPreferences NewPreferences { get; set; }


        public bool ErrorEmailMessage { get; set; } = true;
        public bool ErrorPasswordMessage { get; set; } = true;
        public bool UserCreated { get; set; } = false;

        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IUserHobbiesRepository _userHobbiesRepository { get; set; }
        [Inject]
        public IUserPreferencesRepository _userPreferencesRepository { get; set; }
        [Inject]
        public IUserProfileRepository _userProfileRepository { get; set; }
        [Inject]
        public SignInManager<IdentityUser> SignInManager { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }


        public RegisterModel(IUserRepository userRepository, IUserHobbiesRepository userHobbiesRepository, 
             IUserPreferencesRepository userPreferencesRepository, IUserProfileRepository userProfileRepository, SignInManager<IdentityUser> signInManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _userRepository = userRepository;
            _userHobbiesRepository = userHobbiesRepository;            
            _userPreferencesRepository = userPreferencesRepository;
            _userProfileRepository = userProfileRepository;
            SignInManager = signInManager;
            AuthenticationStateProvider = authenticationStateProvider;
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
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public int Age { get; set; }
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

            CreateUserHobbies();
            CreateUserPreferences();
            CreateNewProfile();
            NewMember = CreateNewMember();
            
            //_userHobbiesRepository.AddMemberHobbies(HobbiesLikes);
            //_userPreferencesRepository.AddUserPreferences(NewPreferences);
            //_userProfileRepository.AddUserProfile(NewProfile);
            //_userRepository.RegisterNewMember(NewMember);

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
                FirstName = Input.FirstName,
                LastName = Input.LastName,
                Age = Input.Age,
                Email = Input.Email,
                Password = Input.Password,
                UserProfileId = NewProfile.Id
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
    
        private void CreateNewProfile()
        {
            CreateUserHobbies();

            UserProfile userProfile = new UserProfile()
            {
                Id = Guid.NewGuid(),
                UserHobbiesId = HobbiesLikes.Id,  
                UserPreferencesId = NewPreferences.Id
            };

            NewProfile = userProfile;
        }

        private void CreateUserHobbies()
        {
            UserHobbies userLikes = new UserHobbies()
            {
                Id = Guid.NewGuid()
            };

            HobbiesLikes = userLikes;           
        }

        private void CreateUserPreferences()
        {
            UserPreferences userPreferences = new UserPreferences()
            {
                Id = Guid.NewGuid()
            };

            NewPreferences = userPreferences;
        }
    }
}
