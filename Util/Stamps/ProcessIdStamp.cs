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

namespace log4net.Util.Stamps
{
    /// <summary>
    /// Set a process id number property value on the event.
    /// </summary>
    /// <author>Robert Sevcik</author>
    public class ProcessIdStamp : Stamp
    {
        /// <summary>
        /// Create stamp value - process id
        /// </summary>
        /// <param name="loggingEvent">event to stamp</param>
        /// <returns>value to set as a stamp</returns>
        protected override object GetValue(Core.LoggingEvent loggingEvent)
        {
            return GetProcessId();
        }
    }
}
