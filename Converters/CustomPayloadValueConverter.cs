using System.Globalization;
using Microsoft.OData;
using Microsoft.OData.Edm;

class CustomPayloadValueConverter : ODataPayloadValueConverter
{
    public override object ConvertToPayloadValue(object value, IEdmTypeReference edmTypeReference)
    {
        if (value is DateTime)
        {
            return String.Format("{0:yyyy-MM-dd HH:mm:ss}", value, CultureInfo.InvariantCulture);
        }
        else if (value is Guid && (Guid)value == Guid.Empty)
        {
            return String.Empty;

            String? guid = "";

            Type type = guid.GetType();

            var primitiveTypeKind = EdmCoreModel.Instance.GetPrimitiveTypeKind(type.Name);
            var isNullable = true;
            EdmTypeReference typeReference = new EdmPrimitiveTypeReference(
                                        EdmCoreModel.Instance.GetPrimitiveType(primitiveTypeKind),
                                        isNullable);
               
            value = null;   
            return base.ConvertToPayloadValue(value, typeReference);
        }
        else
        {
            return base.ConvertToPayloadValue(value, edmTypeReference);
        }
    }


    
    public override object ConvertFromPayloadValue(object value, IEdmTypeReference edmTypeReference)
    {
        try
        {
            return base.ConvertFromPayloadValue(value, edmTypeReference);
        }
        catch (System.Exception)
        {
            
            throw;
        } 
     
    }
 
}