using System.Collections.Generic;
using HotChocolate.Types;

namespace hotchocolate_shell
{
    public class MutationType : ObjectType<MutationType.Mutation>
    {
        public class Mutation
        {
            public List<string> MutateSomething(
                bool randomArgument
            )
            {
                return new List<string>();
            }
        }
    }
}