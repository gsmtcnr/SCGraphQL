﻿using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class OrderInputGraphType : InputObjectGraphType<OrderDto>, IScoppedGraphType
    {
        public OrderInputGraphType()
        {
            Field(s => s.UserId);
            Field(s => s.UserAddressId);
            Field(s => s.TotalPrice);
        }
    }
}
