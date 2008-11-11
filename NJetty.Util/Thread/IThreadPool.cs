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
using System.Threading;


// Author: Leopoldo Lee Agdeppa III
// Email: leopoldo.agdeppa@gmail.com
// Date: November 2008

namespace NJetty.Util.Thread
{
    public interface IThreadPool
    {
        // TODO: remove this note, equivalent to public abstract boolean dispatch(Runnable job);
        bool Dispatch(ThreadStart job);

        /// <summary>
        /// Blocks until the thread pool is stopped.
        /// </summary>
        void Join();

        /// <summary>
        /// The total number of threads currently in the pool
        /// </summary>
        // TODO: remove this note: equivalent to int getThreads()
        int Threads
        {
            get;
        }

        /// <summary>
        /// The number of idle threads in the pool
        /// </summary>
        int IdleThreads
        {
            get;
        }

        /// <summary>
        /// True if the pool is low on threads
        /// </summary>
        bool IsLowOnThreads
        {
            get;
        }
    }
}
