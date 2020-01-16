using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GreenDonut;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;

namespace hotchocolate_shell {
    public class QueryType : ObjectType<QueryType.Query> {
        public class Query
        {
            public bool BooleanMirror(
                bool boolToMirror
            )
            {
                return boolToMirror;
            }
        }
    }
}
