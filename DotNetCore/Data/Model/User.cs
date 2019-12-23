using Data.Base;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public User(UserVM userVM)
        {
            this.Username = userVM.Username;
            this.Email = userVM.Email;
            this.Password = userVM.Password;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }
        public void Update(UserVM userVM)
        {
            this.Username = userVM.Username;
            this.Email = userVM.Email;
            this.Password = userVM.Password;
            this.UpdateDate = DateTimeOffset.Now;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now;
        }
    }
}
