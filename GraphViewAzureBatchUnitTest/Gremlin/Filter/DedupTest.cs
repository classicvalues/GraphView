﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphViewAzureBatchUnitTest.Gremlin.Filter
{
    /// <summary>
    /// Not Support Dedup in parallel mode now
    /// </summary>
    [TestClass]
    [Ignore]
    public class DedupTest : AbstractAzureBatchGremlinTest
    {
    }
}