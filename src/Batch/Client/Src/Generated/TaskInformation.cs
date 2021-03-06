// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The compute node's task info class.
    /// </summary>
    public partial class TaskInformation : IPropertyMetadata
    {
        private readonly TaskExecutionInformation executionInformation;
        private readonly string jobId;
        private readonly int? subtaskId;
        private readonly string taskId;
        private readonly Common.TaskState taskState;
        private readonly string taskUrl;

        #region Constructors

        internal TaskInformation(Models.TaskInformation protocolObject)
        {
            this.executionInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExecutionInfo, o => new TaskExecutionInformation(o).Freeze());
            this.jobId = protocolObject.JobId;
            this.subtaskId = protocolObject.SubtaskId;
            this.taskId = protocolObject.TaskId;
            this.taskState = UtilitiesInternal.MapEnum<Models.TaskState, Common.TaskState>(protocolObject.TaskState);
            this.taskUrl = protocolObject.TaskUrl;
        }

        #endregion Constructors

        #region TaskInformation

        /// <summary>
        /// Gets the execution information for the task.
        /// </summary>
        public TaskExecutionInformation ExecutionInformation
        {
            get { return this.executionInformation; }
        }

        /// <summary>
        /// Gets the job id.
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
        }

        /// <summary>
        /// Gets the subtask id.
        /// </summary>
        public int? SubtaskId
        {
            get { return this.subtaskId; }
        }

        /// <summary>
        /// Gets the task id.
        /// </summary>
        public string TaskId
        {
            get { return this.taskId; }
        }

        /// <summary>
        /// Gets the task state.
        /// </summary>
        public Common.TaskState TaskState
        {
            get { return this.taskState; }
        }

        /// <summary>
        /// Gets the task URL.
        /// </summary>
        public string TaskUrl
        {
            get { return this.taskUrl; }
        }

        #endregion // TaskInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods


        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<TaskInformation> ConvertFromProtocolCollection(IEnumerable<Models.TaskInformation> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<TaskInformation> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new TaskInformation(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<TaskInformation> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.TaskInformation> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<TaskInformation> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new TaskInformation(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<TaskInformation> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.TaskInformation> protoCollection)
        {
            IReadOnlyList<TaskInformation> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new TaskInformation(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}