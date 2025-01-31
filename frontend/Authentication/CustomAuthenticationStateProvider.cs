﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Data;
using DNPAssignment1FamilyManagementSystem.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace DNPAssignment1FamilyManagementSystem.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;
        private readonly IUserService userService;

        private User cachedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            Console.WriteLine($"{this} {nameof(GetAuthenticationStateAsync)} was called");
            var identity = new ClaimsIdentity();
            if (cachedUser == null)
            {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    User tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    await ValidateLogin(tmp.Username, tmp.Password);
                }
            }
            else
            {
                identity = SetupClaimsForUser(cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }


        public async Task ValidateLogin(string username, string password)
        {
            Console.WriteLine($"{this} {nameof(ValidateLogin)} was called");

            Console.WriteLine("Validating log in");
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter password");

            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                Console.WriteLine($"{this} Calling validation service");
                User user = await userService.ValidateUserAsync(username, password);
                Console.WriteLine(user.Username);
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
               await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                cachedUser = user;
            }
            catch (ArgumentException e)
            {
                throw;
            }

            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }
        
        public void Logout() {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        
        
        private ClaimsIdentity SetupClaimsForUser(User user) {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            claims.Add(new Claim("Role", user.Role));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}