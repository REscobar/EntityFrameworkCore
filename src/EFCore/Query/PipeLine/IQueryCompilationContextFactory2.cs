﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Query.PipeLine
{
    public interface IQueryCompilationContextFactory2
    {
        QueryCompilationContext2 Create(bool async);
    }
}
