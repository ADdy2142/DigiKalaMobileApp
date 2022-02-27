using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class SearchMatchRepository
    {
        private readonly List<SearchMatch> _searchMatches;

        public SearchMatchRepository()
        {
            _searchMatches = new List<SearchMatch>
            {
                new SearchMatch { Text = "مورد مشابه اول" },
                new SearchMatch { Text = "مورد مشابه دوم" },
                new SearchMatch { Text = "مورد مشابه سوم" },
                new SearchMatch { Text = "مورد مشابه چهارم" },
                new SearchMatch { Text = "مورد مشابه پنجم" },
                new SearchMatch { Text = "مورد مشابه ششم" },
                new SearchMatch { Text = "مورد مشابه هفتم" },
                new SearchMatch { Text = "مورد مشابه هشتم" },
                new SearchMatch { Text = "مورد مشابه نهم" },
                new SearchMatch { Text = "مورد مشابه دهم" },
                new SearchMatch { Text = "مورد مشابه یازدهم" },
                new SearchMatch { Text = "مورد مشابه دوازدهم" },
                new SearchMatch { Text = "مورد مشابه سیزدهم" },
                new SearchMatch { Text = "مورد مشابه چهاردهم" },
                new SearchMatch { Text = "مورد مشابه پانزدهم" },
                new SearchMatch { Text = "مورد مشابه شانزدهم" },
                new SearchMatch { Text = "مورد مشابه هفدهم" },
                new SearchMatch { Text = "مورد مشابه هجدهم" },
                new SearchMatch { Text = "مورد مشابه نوزدهم" },
                new SearchMatch { Text = "مورد مشابه بیستم" },
                new SearchMatch { Text = "مورد مشابه بیست و یکم" },
                new SearchMatch { Text = "مورد مشابه بیست و دوم" },
                new SearchMatch { Text = "مورد مشابه بیست و سوم" },
                new SearchMatch { Text = "مورد مشابه بیست و چهارم" },
                new SearchMatch { Text = "مورد مشابه بیست و پنجم" },
                new SearchMatch { Text = "مورد مشابه بیست و ششم" },
                new SearchMatch { Text = "مورد مشابه بیست و هفتم" },
                new SearchMatch { Text = "مورد مشابه بیست و هشتم" },
                new SearchMatch { Text = "مورد مشابه بیست و نهم" },
                new SearchMatch { Text = "مورد مشابه سی ام" },
            };
        }

        public IEnumerable<SearchMatch> GetAll(string searchText = null, int count = 10)
        {
            return string.IsNullOrEmpty(searchText) ? new List<SearchMatch>() : _searchMatches.Where(sm => sm.Text.Contains(searchText)).Take(count);
        }
    }
}