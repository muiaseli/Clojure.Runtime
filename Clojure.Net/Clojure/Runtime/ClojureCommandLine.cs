﻿/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Eclipse Public License 1.0 (http://opensource.org/licenses/eclipse-1.0.php)
 *   which can be found in the file epl-v10.html at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Scripting.Hosting.Shell;

namespace clojure.runtime
{
    public class ClojureCommandLine : CommandLine
    {
        protected override string Logo
        {
            get { return "Clojure.net console ...enter forms:\n"; }
        }

        protected override string Prompt
        {
            get { return "CLJ> "; }
        }

        public override string PromptContinuation
        {
            get { return "...> "; }
        }
    }
}
