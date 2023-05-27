﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISuggestionWorkerServices
    {
        public Task GenerateSuggestionAll();
        public Task GenerateSuggestionXUser(int userId);
        public Task<List<int>> CountSuggestionsUsers(int valueRecalculate);

        public Task<List<int>> UsersNew();
    }
}
