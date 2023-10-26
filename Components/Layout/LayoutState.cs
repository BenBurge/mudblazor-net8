namespace NET8SERVER.Components.Layout
{
    public class LayoutState
    {
        public event Action? OnChange;

        public bool IsDrawerOpen { get; private set; }

        public bool IsDarkMode { get; private set; }

        public void ToggleDrawer()
        {
            IsDrawerOpen = !IsDrawerOpen;
            NotifyStateChanged();
        }

        public void ToggleDarkMode()
        {
            IsDarkMode = !IsDarkMode;
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
