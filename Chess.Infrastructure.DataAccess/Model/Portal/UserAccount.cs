using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class UserAccount
    {
        public string ApplicationName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Email { get; set; }
        public int FailedPasswordAnswerAttemptCount { get; set; }
        public int FailedPasswordAttemptWindowStart { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime LastLockoutDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public string LoweredEmail { get; set; }
        public string LoweredUsername { get; set; }
        public string Password { get; set; }
        public string PasswordAnswer { get; set; }
        public string PasswordQuestion { get; set; }
        public string Salt { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}
