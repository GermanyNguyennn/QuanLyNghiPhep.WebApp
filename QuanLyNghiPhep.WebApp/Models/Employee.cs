﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNghiPhep.WebApp.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("Mã nhân viên")]
        [StringLength(20, MinimumLength = 5)]
        public string? Employee_ID { get; set; }

        [Required]
        [DisplayName("Họ và tên")]
        [StringLength(100, MinimumLength = 3)]
        public string? FullName { get; set; }

        [Required]
        [DisplayName("Ngày sinh")]
        public DateTime? Dob { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DisplayName("Số điện thoại")]
        [Phone]
        public string? PhoneNumber { get; set; }

        [DisplayName("Chức vụ")]
        public string? Title_id { get; set; }

        [DisplayName("Chức danh")]
        public virtual Titles Title { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
        public virtual ICollection<LeaveBalance> LeaveBalances { get; set; }
        public virtual ICollection<LeaveRequest> ApprovedLeaveRequests { get; set; }
        public virtual ICollection<DepartmentEmployee> DepartmentEmployees { get; set; } = new List<DepartmentEmployee>();
    }

}


