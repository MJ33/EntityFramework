// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Reflection;
using Microsoft.Data.Entity.SqlServer.Design.ReverseEngineering;

namespace Microsoft.Data.Entity.SqlServer.Design.Tests
{
    public class ApiConsistencyTest : ApiConsistencyTestBase
    {
        protected override Assembly TargetAssembly
        {
            get { return typeof(SqlServerMetadataModelProvider).Assembly; }
        }
    }
}
