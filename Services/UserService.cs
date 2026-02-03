using System;

namespace BlazorWebApp.Services
{
    public class UserService
    {
        public string CurrentUser { get; private set; } = "Sueda Akça";
        public string Initials => GetInitials(CurrentUser);

        public event Action? OnChange;

        public void SetUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;
            CurrentUser = name;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        private string GetInitials(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "U";
            
            var parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 2)
            {
                return $"{parts[0][0]}{parts[1][0]}".ToUpper();
            }
            return name.Length > 0 ? name[0].ToString().ToUpper() : "U";
        }
    }
}
