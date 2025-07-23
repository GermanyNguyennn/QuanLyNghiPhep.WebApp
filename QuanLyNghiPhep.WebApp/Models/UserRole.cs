using System.Data;

namespace QuanLyNghiPhep.WebApp.Models
{
    public class UserRole
    {
        public Guid UserID { get; set; }  
        public int RoleID { get; set; }   

        public virtual User User { get; set; }  
        public virtual Roles Role { get; set; }  
    }

}
