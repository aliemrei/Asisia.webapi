using Microsoft.AspNetCore.OData.Formatter.Deserialization;
using Microsoft.AspNetCore.OData.Formatter.Wrapper;
using Microsoft.OData;
using Microsoft.OData.Edm;

public class CustomResourceDeserializer : ODataResourceDeserializer
{
    public CustomResourceDeserializer(IODataDeserializerProvider deserializerProvider) : base(deserializerProvider)
    {
    }

    public override void ApplyNestedProperty(object resource, ODataNestedResourceInfoWrapper resourceInfoWrapper, IEdmStructuredTypeReference structuredType, ODataDeserializerContext readContext)
    {
        try
        {
            base.ApplyNestedProperty(resource, resourceInfoWrapper, structuredType, readContext);
        }
        catch (System.Exception)
        {
             
        }
        
    }
}