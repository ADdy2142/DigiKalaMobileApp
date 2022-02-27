using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class CategoryRepository
    {
        private readonly List<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Title = "کالای دیجیتال",
                    Groups = new List<Group>
                    {
                        new Group
                        {
                            Id = 1,
                            Title = "لپ تاپ",
                            ImageUrl = "category_image_01.png"
                        },
                        new Group
                        {
                            Id = 2,
                            Title = "گوشی موبایل",
                            ImageUrl = "category_image_02.png"
                        },
                        new Group
                        {
                            Id = 3,
                            Title = "کامپیوتر",
                            ImageUrl = "category_image_05.png"
                        },
                        new Group
                        {
                            Id = 4,
                            Title = "تبلت",
                            ImageUrl = "category_image_03.jpg"
                        },
                        new Group
                        {
                            Id = 5,
                            Title = "دوربین",
                            ImageUrl = "category_image_04.png"
                        }
                    }
                },
                new Category
                {
                    Id = 2,
                    Title = "کالای دیجیتال",
                    Groups = new List<Group>
                    {
                        new Group
                        {
                            Id = 6,
                            Title = "لپ تاپ",
                            ImageUrl = "category_image_01.png"
                        },
                        new Group
                        {
                            Id = 7,
                            Title = "گوشی موبایل",
                            ImageUrl = "category_image_02.png"
                        },
                        new Group
                        {
                            Id = 8,
                            Title = "کامپیوتر",
                            ImageUrl = "category_image_05.png"
                        },
                        new Group
                        {
                            Id = 9,
                            Title = "تبلت",
                            ImageUrl = "category_image_03.jpg"
                        },
                        new Group
                        {
                            Id = 10,
                            Title = "دوربین",
                            ImageUrl = "category_image_04.png"
                        }
                    }
                },
                new Category
                {
                    Id = 3,
                    Title = "کالای دیجیتال",
                    Groups = new List<Group>
                    {
                        new Group
                        {
                            Id = 11,
                            Title = "لپ تاپ",
                            ImageUrl = "category_image_01.png"
                        },
                        new Group
                        {
                            Id = 12,
                            Title = "گوشی موبایل",
                            ImageUrl = "category_image_02.png"
                        },
                        new Group
                        {
                            Id = 13,
                            Title = "کامپیوتر",
                            ImageUrl = "category_image_05.png"
                        },
                        new Group
                        {
                            Id = 14,
                            Title = "تبلت",
                            ImageUrl = "category_image_03.jpg"
                        },
                        new Group
                        {
                            Id = 15,
                            Title = "دوربین",
                            ImageUrl = "category_image_04.png"
                        }
                    }
                },
                new Category
                {
                    Id = 4,
                    Title = "کالای دیجیتال",
                    Groups = new List<Group>
                    {
                        new Group
                        {
                            Id = 16,
                            Title = "لپ تاپ",
                            ImageUrl = "category_image_01.png"
                        },
                        new Group
                        {
                            Id = 17,
                            Title = "گوشی موبایل",
                            ImageUrl = "category_image_02.png"
                        },
                        new Group
                        {
                            Id = 18,
                            Title = "کامپیوتر",
                            ImageUrl = "category_image_05.png"
                        },
                        new Group
                        {
                            Id = 19,
                            Title = "تبلت",
                            ImageUrl = "category_image_03.jpg"
                        },
                        new Group
                        {
                            Id = 20,
                            Title = "دوربین",
                            ImageUrl = "category_image_04.png"
                        }
                    }
                },
                new Category
                {
                    Id = 5,
                    Title = "کالای دیجیتال",
                    Groups = new List<Group>
                    {
                        new Group
                        {
                            Id = 21,
                            Title = "لپ تاپ",
                            ImageUrl = "category_image_01.png"
                        },
                        new Group
                        {
                            Id = 22,
                            Title = "گوشی موبایل",
                            ImageUrl = "category_image_02.png"
                        },
                        new Group
                        {
                            Id = 23,
                            Title = "کامپیوتر",
                            ImageUrl = "category_image_05.png"
                        },
                        new Group
                        {
                            Id = 24,
                            Title = "تبلت",
                            ImageUrl = "category_image_03.jpg"
                        },
                        new Group
                        {
                            Id = 25,
                            Title = "دوربین",
                            ImageUrl = "category_image_04.png"
                        }
                    }
                },
                new Category
                {
                    Id = 6,
                    Title = "کالای دیجیتال",
                    Groups = new List<Group>
                    {
                        new Group
                        {
                            Id = 26,
                            Title = "لپ تاپ",
                            ImageUrl = "category_image_01.png"
                        },
                        new Group
                        {
                            Id = 27,
                            Title = "گوشی موبایل",
                            ImageUrl = "category_image_02.png"
                        },
                        new Group
                        {
                            Id = 28,
                            Title = "کامپیوتر",
                            ImageUrl = "category_image_05.png"
                        },
                        new Group
                        {
                            Id = 29,
                            Title = "تبلت",
                            ImageUrl = "category_image_03.jpg"
                        },
                        new Group
                        {
                            Id = 30,
                            Title = "دوربین",
                            ImageUrl = "category_image_04.png"
                        }
                    }
                }
            };
        }

        public IEnumerable<Category> GetAll()
        {
            return _categories;
        }
    }
}