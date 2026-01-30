using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorWebApp.Services
{
    public class TabInfo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string Icon { get; set; } = "bi-file-earmark";
    }

    public class TabService
    {
        public List<TabInfo> Tabs { get; private set; } = new();
        public event Action? OnChange;

        public void AddTab(string title, string url, string icon = "bi-file-earmark")
        {
            var existingTab = Tabs.FirstOrDefault(t => t.Url == url);
            if (existingTab != null)
            {
                SetActiveTab(existingTab.Id);
                return;
            }

            // Deactivate all
            foreach (var t in Tabs) t.IsActive = false;

            var newTab = new TabInfo
            {
                Title = title,
                Url = url,
                IsActive = true,
                Icon = icon
            };
            Tabs.Add(newTab);
            NotifyStateChanged();
        }

        public void SetActiveTab(string id)
        {
            foreach (var t in Tabs)
            {
                t.IsActive = (t.Id == id);
            }
            NotifyStateChanged();
        }

        public void RemoveTab(string id)
        {
            var tabToRemove = Tabs.FirstOrDefault(t => t.Id == id);
            if (tabToRemove != null)
            {
                bool wasActive = tabToRemove.IsActive;
                Tabs.Remove(tabToRemove);
                
                if (wasActive && Tabs.Any())
                {
                    Tabs.Last().IsActive = true;
                }
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
