﻿#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Javax.NServlet
{

    /// <summary>
    /// TODO: Class/Interface Information here
    /// </summary>
    /// <author>  
    ///     <a href="mailto:leopoldo.agdeppa@gmail.com">Leopoldo Lee Agdeppa III</a>
    /// </author>
    /// <date>
    /// Febraury 2009
    /// </date>
    public abstract class ServletRegistration
    {
        protected string description;
        protected bool isAsyncSupported;
        protected int loadOnStartup;

        public string Description
        {
            set
            {
                this.description = value;
            }
        }

        public bool AsyncSupported
        {
            set
            {
                isAsyncSupported = value;
            }
        }

        public int LoadOnStartup
        {
            set
            {
                this.loadOnStartup = value;
            }
        }

        public abstract void AddMapping(params string[] urlPatterns);

        public abstract void SetInitParameter(string name, string value);

        public abstract void SetInitParameters(Dictionary<string, string> initParameters);
    }
}