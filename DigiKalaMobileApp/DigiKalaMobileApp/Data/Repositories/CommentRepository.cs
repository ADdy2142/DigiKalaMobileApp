using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class CommentRepository
    {
        private readonly List<Comment> _comments;

        public CommentRepository()
        {
            _comments = new List<Comment>
            {
                new Comment
                {
                    Id = 1,
                    Title = "عنوان",
                    Text = "دیدگاه کاربر",
                    CreateDate = "دیروز",
                    IsNegative = true,
                    Owner = "عادل بخشی"
                },
                new Comment
                {
                    Id = 2,
                    Title = "عنوان",
                    Text = "دیدگاه کاربر",
                    CreateDate = "دو هفته پیش",
                    IsNegative = false,
                    Owner = "عادل بخشی"
                },
                new Comment
                {
                    Id = 3,
                    Title = "عنوان",
                    Text = "دیدگاه کاربر",
                    CreateDate = "یک ماه پیش",
                    IsNegative = false,
                    Owner = "عادل بخشی"
                },
                new Comment
                {
                    Id = 4,
                    Title = "عنوان",
                    Text = "دیدگاه کاربر",
                    CreateDate = "سه ماه پیش",
                    IsNegative = false,
                    Owner = "عادل بخشی"
                },
                new Comment
                {
                    Id = 5,
                    Title = "عنوان",
                    Text = "دیدگاه کاربر",
                    CreateDate = "سه ماه پیش",
                    IsNegative = true,
                    Owner = "عادل بخشی"
                }
            };
        }

        public IEnumerable<Comment> GetAll()
        {
            return _comments;
        }
    }
}