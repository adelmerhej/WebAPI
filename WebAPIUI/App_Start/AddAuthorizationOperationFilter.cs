using System.Collections.Generic;
using System.Web.Http.Description;
using Swashbuckle.Swagger;

namespace WebAPIUI.App_Start
{
    public class AddAuthorizationOperationFilter : IOperationFilter
    {
        #region Implementation of IOperationFilter
        /// <summary>
        /// Applies the operation filter.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "access token",
                required = false,
                type = "string"
            });
        }

        #endregion
    }
}