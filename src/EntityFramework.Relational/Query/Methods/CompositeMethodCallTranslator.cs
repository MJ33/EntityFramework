// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Microsoft.Framework.Logging;
using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Relational.Query.Methods
{
    public class CompositeMethodCallTranslator : IMethodCallTranslator
    {
        private ILogger _logger;

        public CompositeMethodCallTranslator([NotNull]ILogger logger)
        {
            _logger = logger;
        }

        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            return new EqualsTranslator(_logger).Translate(methodCallExpression)
                   ?? new StartsWithTranslator().Translate(methodCallExpression)
                   ?? new EndsWithTranslator().Translate(methodCallExpression)
                   ?? new ContainsTranslator().Translate(methodCallExpression);
        }
    }
}
