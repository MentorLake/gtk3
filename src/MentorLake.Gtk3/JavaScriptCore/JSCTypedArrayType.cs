namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Possible types of the elements contained in a typed array.
/// </para>
/// </summary>

[Flags]
public enum JSCTypedArrayType
{
/// <summary>
/// <para>
/// Not a typed array, or type unsupported.
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_NONE = 0,
/// <summary>
/// <para>
/// Array elements are 8-bit signed integers (int8_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_INT8 = 1,
/// <summary>
/// <para>
/// Array elements are 16-bit signed integers (int16_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_INT16 = 2,
/// <summary>
/// <para>
/// Array elements are 32-bit signed integers (int32_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_INT32 = 3,
/// <summary>
/// <para>
/// Array elements are 64-bit signed integers (int64_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_INT64 = 4,
/// <summary>
/// <para>
/// Array elements are 8-bit unsigned integers (uint8_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_UINT8 = 5,
/// <summary>
/// <para>
/// Array elements are 8-bit unsigned integers (uint8_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_UINT8_CLAMPED = 6,
/// <summary>
/// <para>
/// Array elements are 16-bit unsigned integers (uint16_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_UINT16 = 7,
/// <summary>
/// <para>
/// Array elements are 32-bit unsigned integers (uint32_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_UINT32 = 8,
/// <summary>
/// <para>
/// Array elements are 64-bit unsigned integers (uint64_t).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_UINT64 = 9,
/// <summary>
/// <para>
/// Array elements are 32-bit floating point numbers (float).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_FLOAT32 = 10,
/// <summary>
/// <para>
/// Array elements are 64-bit floating point numbers (double).
/// </para>
/// </summary>

	JSC_TYPED_ARRAY_FLOAT64 = 11
}
