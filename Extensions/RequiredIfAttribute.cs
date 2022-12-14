
namespace System.ComponentModel.DataAnnotations;
public class RequiredIfAttribute : RequiredAttribute
{
    private string _DependentProperty;
    private object _TargetValue;

    public RequiredIfAttribute()
    {
        
    }
    public RequiredIfAttribute(string dependentProperty, object targetValue)
    {
        this._DependentProperty = dependentProperty;
        this._TargetValue = targetValue;
    }

    public static class ValueTypeHelper
    {
        public static bool IsNullable<T>(T t) { return false; }
        public static bool IsNullable<T>(T? t) where T : struct { return true; }
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (this._DependentProperty == null || this._TargetValue == null)
        {
            var val = value;

            if (val is Guid && (Guid?)val == Guid.Empty)
                val = null;

            if (!ValueTypeHelper.IsNullable(value) && val == null)
               return new ValidationResult(string.Format("{0} field must be value", validationContext.MemberName));
           
            return ValidationResult.Success;
        }

        var propertyTestedInfo = validationContext.ObjectType.GetProperty(this._DependentProperty);

        if (propertyTestedInfo == null)
        {
            return new ValidationResult(string.Format("{0} needs to be exist in this object.", this._DependentProperty));
        }

        var dependendValue = propertyTestedInfo.GetValue(validationContext.ObjectInstance, null);

        if (dependendValue == null)
        {
            return new ValidationResult(string.Format("{0} needs to be populated.", this._DependentProperty));
        }

        if (dependendValue.Equals(this._TargetValue))
        {
            var fieldValue = validationContext.ObjectType.GetProperty(validationContext.MemberName).GetValue(validationContext.ObjectInstance, null);


            if (fieldValue != null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("{0} cannot be null", validationContext.MemberName));
            }
        }
        else
        {
            // Must be ignored
            return ValidationResult.Success;
        }
    }
}