using EventEaseAppNew.Models;
using System;


namespace EventEaseAppNew.Services
{
    public class SessionState
    {
        public User? CurrentUser { get; private set; } = null;

        public event Action? OnUserUpdated;

        public void SetUser(User user)
        {
            CurrentUser = user;
            OnUserUpdated?.Invoke();
        }

        public void ClearUser()
        {
            CurrentUser = null;
            OnUserUpdated?.Invoke();
        }
    }
}
