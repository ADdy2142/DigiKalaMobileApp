using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.ViewModels
{
    public class SearchViewModel : ViewModelBase
    {
        private string _searchText;

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                SearchForMatchCases();
            }
        }

        private ObservableCollection<SearchMatch> _searchMatches;

        public ObservableCollection<SearchMatch> SearchMatches
        {
            get => _searchMatches;
            set
            {
                _searchMatches = value;
                OnPropertyChanged(nameof(SearchMatches));
            }
        }

        public SearchViewModel()
        {
            SearchMatches = new ObservableCollection<SearchMatch>();
        }

        private void SearchForMatchCases()
        {
            var searchMatches = UnitOfWork.SearchMatchCases.GetAll(SearchText);
            SearchMatches = new ObservableCollection<SearchMatch>(searchMatches);
        }
    }
}