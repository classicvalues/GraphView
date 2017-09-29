﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphView
{
    internal class GremlinInVOp: GremlinTranslationOperator
    {
        public GremlinInVOp() {}

        internal override GremlinToSqlContext GetContext()
        {
            GremlinToSqlContext inputContext = GetInputContext();
            if (inputContext.PivotVariable == null)
            {
                throw new QueryCompilationException("The PivotVariable can't be null.");
            }

            inputContext.PivotVariable.InV(inputContext);

            return inputContext;
        }
    }
}
