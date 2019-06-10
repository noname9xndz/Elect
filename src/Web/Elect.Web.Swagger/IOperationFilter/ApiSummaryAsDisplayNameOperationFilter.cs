﻿#region	License

//--------------------------------------------------
// <License>
//     <Copyright> 2018 © Top Nguyen </Copyright>
//     <Url> http://topnguyen.net/ </Url>
//     <Author> Top </Author>
//     <Project> Elect </Project>
//     <File>
//         <Name> ApiDocGroupOperationFilter.cs </Name>
//         <Created> 10/04/2018 4:10:27 PM </Created>
//         <Key> 1e25bcf7-26c3-43ab-8936-019614e62f20 </Key>
//     </File>
//     <Summary>
//         ApiDocGroupOperationFilter.cs is a part of Elect
//     </Summary>
// <License>
//--------------------------------------------------

#endregion License

using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Elect.Web.Swagger.IOperationFilter
{
    public class ApiSummaryAsDisplayNameOperationFilter : Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            context.ApiDescription.ActionDescriptor.DisplayName =
                string.IsNullOrWhiteSpace(context.ApiDescription.ActionDescriptor.DisplayName)
                    ? operation.Summary
                    : context.ApiDescription.ActionDescriptor.DisplayName;
        }
    }
}