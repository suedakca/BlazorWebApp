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
        /// <summary>
        /// Stores the state of the tab (e.g., filter criteria, search terms) to persist data when switching tabs.
        /// </summary>
        public Dictionary<string, object> State { get; set; } = new();
    }

    public class TabService
    {
        public List<TabInfo> Tabs { get; private set; } = new();
        public event Action? OnChange;

        public void AddTab(string title, string url, string icon = "bi-file-earmark", string? id = null)
        {
            // If ID is provided, check if exists and update
            if (!string.IsNullOrEmpty(id))
            {
                var existingTabById = Tabs.FirstOrDefault(t => t.Id == id);
                if (existingTabById != null)
                {
                    existingTabById.Title = title;
                    existingTabById.Url = url;
                    SetActiveTab(id);
                    return;
                }
            }

            // Fallback to URL check if no ID or ID not found (but URL might exist for different ID)
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
                Id = id ?? Guid.NewGuid().ToString(),
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

        public T? GetActiveTabState<T>(string key)
        {
            var activeTab = Tabs.FirstOrDefault(t => t.IsActive);
            if (activeTab != null && activeTab.State.ContainsKey(key))
            {
                if (activeTab.State[key] is T typedValue)
                {
                    return typedValue;
                }
                
                // Handle potential JSON deserialization issues if state was serialized
                try 
                {
                    return (T)Convert.ChangeType(activeTab.State[key], typeof(T));
                }
                catch
                {
                    return default;
                }
            }
            return default;
        }

        public void SetActiveTabState(string key, object value)
        {
            var activeTab = Tabs.FirstOrDefault(t => t.IsActive);
            if (activeTab != null)
            {
                activeTab.State[key] = value;
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
