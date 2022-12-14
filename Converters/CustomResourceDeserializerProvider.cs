using Microsoft.AspNetCore.OData.Formatter.Deserialization;
using Microsoft.OData;
using Microsoft.OData.Edm;

public class CustomResourceDeserializerProvider : ODataDeserializerProvider
{
    public CustomResourceDeserializerProvider(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    

    public override IODataEdmTypeDeserializer GetEdmTypeDeserializer(IEdmTypeReference edmType, bool isDelta = false)
    {
        return new CustomResourceDeserializer(this); // base.GetEdmTypeDeserializer(edmType, isDelta);
    }
}