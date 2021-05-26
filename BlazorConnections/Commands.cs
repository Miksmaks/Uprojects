using System;
using System.Collections.Generic;
using System.Text;
using SQL_PROJECT1.SQLConnections;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlazorConnections
{
    public class Commands
    {
        public User GetUserData(int Uid,DataContext db) 
        {
            var users = db.Users.ToList();
            var userc = new User();
            int mid = 0;
            foreach (var user in users) 
            {
                if (user.UserId == Uid && user.id > mid) 
                {
                    userc = user;
                    mid = user.id;
                }
            }
            return userc;
        }
        public Department GetDepartmentData(int Did, DataContext db) 
        {
            var departments = db.Departments.ToList();
            var departmentc = new Department();
            int mid = 0;
            foreach (var department in departments)
            {
                if (department.DepartmentId == Did && department.id > mid)
                {
                    departmentc = department;
                    mid = department.id;
                }
            }
            return departmentc;
        }
        public Employ GetEmployData(int Eid,DataContext db) 
        {
            var employs = db.Employs.ToList();
            var employc = new Employ();
            int mid = 0;
            foreach (var employ in employs)
            {
                if (employ.EmployId == Eid && employ.id > mid)
                {
                    employc = employ;
                    mid = employ.id;
                }
            }
            return employc;
        }
        public Post GetPostData(int Pid,DataContext db) 
        {
            var posts = db.Posts.ToList();
            var postc = new Post();
            int mid = 0;
            foreach (var post in posts)
            {
                if (post.PostId == Pid && post.id > mid)
                {
                    postc = post;
                    mid = post.id;
                }
            }
            return postc;
        }
    }
}
