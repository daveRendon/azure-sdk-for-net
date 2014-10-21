// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.WebSites;
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.WebSites
{
    /// <summary>
    /// The Windows Azure Web Sites management API provides a RESTful set of
    /// web services that interact with Windows Azure Web Sites service to
    /// manage your web sites. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Web Sites
    /// service.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public static partial class WebHostingPlanOperationsExtensions
    {
        /// <summary>
        /// Creates a new Web Hosting Plan or updates an existing one.  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Server Farm operation.
        /// </param>
        /// <returns>
        /// The Create Web Hosting Plan operation response.
        /// </returns>
        public static WebHostingPlanCreateOrUpdateResponse CreateOrUpdate(this IWebHostingPlanOperations operations, string resourceGroupName, WebHostingPlanCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebHostingPlanOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new Web Hosting Plan or updates an existing one.  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Server Farm operation.
        /// </param>
        /// <returns>
        /// The Create Web Hosting Plan operation response.
        /// </returns>
        public static Task<WebHostingPlanCreateOrUpdateResponse> CreateOrUpdateAsync(this IWebHostingPlanOperations operations, string resourceGroupName, WebHostingPlanCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// Required. The name of the Web Hosting Plan to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IWebHostingPlanOperations operations, string resourceGroupName, string webHostingPlanName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebHostingPlanOperations)s).DeleteAsync(resourceGroupName, webHostingPlanName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// Required. The name of the Web Hosting Plan to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IWebHostingPlanOperations operations, string resourceGroupName, string webHostingPlanName)
        {
            return operations.DeleteAsync(resourceGroupName, webHostingPlanName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets details of an existing Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// Required. The name of the Web Hosting Plan.
        /// </param>
        /// <returns>
        /// The Get Web Hosting Plan operation response.
        /// </returns>
        public static WebHostingPlanGetResponse Get(this IWebHostingPlanOperations operations, string resourceGroupName, string webHostingPlanName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebHostingPlanOperations)s).GetAsync(resourceGroupName, webHostingPlanName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets details of an existing Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// Required. The name of the Web Hosting Plan.
        /// </param>
        /// <returns>
        /// The Get Web Hosting Plan operation response.
        /// </returns>
        public static Task<WebHostingPlanGetResponse> GetAsync(this IWebHostingPlanOperations operations, string resourceGroupName, string webHostingPlanName)
        {
            return operations.GetAsync(resourceGroupName, webHostingPlanName, CancellationToken.None);
        }
        
        /// <summary>
        /// You can retrieve historical usage metrics for a site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166964.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// Required. The name of the web hosting plan.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Get Historical Usage Metrics
        /// Web hosting plan operation.
        /// </param>
        /// <returns>
        /// The Get Historical Usage Metrics Web hosting plan operation
        /// response.
        /// </returns>
        public static WebHostingPlanGetHistoricalUsageMetricsResponse GetHistoricalUsageMetrics(this IWebHostingPlanOperations operations, string resourceGroupName, string webHostingPlanName, WebHostingPlanGetHistoricalUsageMetricsParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebHostingPlanOperations)s).GetHistoricalUsageMetricsAsync(resourceGroupName, webHostingPlanName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can retrieve historical usage metrics for a site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166964.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// Required. The name of the web hosting plan.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Get Historical Usage Metrics
        /// Web hosting plan operation.
        /// </param>
        /// <returns>
        /// The Get Historical Usage Metrics Web hosting plan operation
        /// response.
        /// </returns>
        public static Task<WebHostingPlanGetHistoricalUsageMetricsResponse> GetHistoricalUsageMetricsAsync(this IWebHostingPlanOperations operations, string resourceGroupName, string webHostingPlanName, WebHostingPlanGetHistoricalUsageMetricsParameters parameters)
        {
            return operations.GetHistoricalUsageMetricsAsync(resourceGroupName, webHostingPlanName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets all Web Hosting Plans in a current subscription and Resource
        /// Group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// The List Web Hosting Plans operation response.
        /// </returns>
        public static WebHostingPlanListResponse List(this IWebHostingPlanOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebHostingPlanOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets all Web Hosting Plans in a current subscription and Resource
        /// Group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.WebSites.IWebHostingPlanOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// The List Web Hosting Plans operation response.
        /// </returns>
        public static Task<WebHostingPlanListResponse> ListAsync(this IWebHostingPlanOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
    }
}