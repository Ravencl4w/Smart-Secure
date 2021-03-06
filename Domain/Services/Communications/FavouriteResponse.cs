using GoingTo_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Services.Communications
{
    public class FavouriteResponse : BaseResponse<Favourite>
    {
        public FavouriteResponse(string message) : base(message) { }
        public FavouriteResponse(Favourite favourite) : base(favourite) { }
    }
}
