﻿namespace Tunify_Platform.Models.DTO
{
    public class AccountDTO
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public IList<string> Roles { get; set; }
    }
}