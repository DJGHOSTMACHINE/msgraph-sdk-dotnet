// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Groups.Item.Sites.Item.Lists.Item.ContentTypes.GetCompatibleHubContentTypes
{
    [Obsolete("This class is obsolete. Use GetCompatibleHubContentTypesGetResponse instead.")]
    #pragma warning disable CS1591
    public class GetCompatibleHubContentTypesResponse : Microsoft.Graph.Groups.Item.Sites.Item.Lists.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Groups.Item.Sites.Item.Lists.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Groups.Item.Sites.Item.Lists.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Groups.Item.Sites.Item.Lists.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse();
        }
    }
}
