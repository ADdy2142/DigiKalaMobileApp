using DigiKalaMobileApp.DataAccess.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.DataAccess.Services.UnitOfWork
{
    public class UnitOfWork
    {
        private SearchMatchRepository _searchMatchCaseRepository;

        public SearchMatchRepository SearchMatchCases
        {
            get
            {
                if (_searchMatchCaseRepository == null)
                    _searchMatchCaseRepository = new SearchMatchRepository();

                return _searchMatchCaseRepository;
            }
        }
    }
}