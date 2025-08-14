namespace MentorLake.GObject;

/// <summary>
/// <para>
/// An opaque structure used to hold different types of values.
/// </para>
/// <para>
/// The data within the structure has protected scope: it is accessible only
/// to functions within a #GTypeValueTable structure, or implementations of
/// the g_value_*() API. That is, code portions which implement new fundamental
/// types.
/// </para>
/// <para>
/// #GValue users cannot make any assumptions about how data is stored
/// within the 2 element @data union, and the @g_type member should
/// only be accessed through the G_VALUE_TYPE() macro.
/// </para>
/// </summary>

public class GValueHandle : BaseSafeHandle
{
}


public static class GValueExtensions
{
/// <summary>
/// <para>
/// Copies the value of @src_value into @dest_value.
/// </para>
/// </summary>

/// <param name="src_value">
/// An initialized #GValue structure.
/// </param>
/// <param name="dest_value">
/// An initialized #GValue structure of the same type as @src_value.
/// </param>

	public static void Copy(this MentorLake.GObject.GValueHandle src_value, MentorLake.GObject.GValueHandle dest_value)
	{
		if (src_value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_copy(src_value, dest_value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_BOXED derived #GValue.  Upon getting,
/// the boxed value is duplicated and needs to be later freed with
/// g_boxed_free(), e.g. like: g_boxed_free (G_VALUE_TYPE (@value),
/// return_value);
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_BOXED derived type
/// </param>
/// <return>
/// boxed contents of @value
/// </return>

	public static IntPtr DupBoxed(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_dup_boxed(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_OBJECT derived #GValue, increasing
/// its reference count. If the contents of the #GValue are %NULL, then
/// %NULL will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_OBJECT
/// </param>
/// <return>
/// object content of @value,
///          should be unreferenced when no longer needed.
/// </return>

	public static MentorLake.GObject.GObjectHandle DupObject(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_dup_object(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_PARAM #GValue, increasing its
/// reference count.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_PARAM
/// </param>
/// <return>
/// #GParamSpec content of @value, should be
///     unreferenced when no longer needed.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle DupParam(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_dup_param(value);
	}

/// <summary>
/// <para>
/// Get a copy the contents of a %G_TYPE_STRING #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <return>
/// a newly allocated copy of the string content of @value
/// </return>

	public static string DupString(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_dup_string(value);
	}

/// <summary>
/// <para>
/// Get the contents of a variant #GValue, increasing its refcount. The returned
/// #GVariant is never floating.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_VARIANT
/// </param>
/// <return>
/// variant contents of @value (may be %NULL);
///    should be unreffed using g_variant_unref() when no longer needed
/// </return>

	public static MentorLake.GLib.GVariantHandle DupVariant(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_dup_variant(value);
	}

/// <summary>
/// <para>
/// Determines if @value will fit inside the size of a pointer value.
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// An initialized #GValue structure.
/// </param>
/// <return>
/// %TRUE if @value will fit inside a pointer value.
/// </return>

	public static bool FitsPointer(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_fits_pointer(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_BOOLEAN #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_BOOLEAN
/// </param>
/// <return>
/// boolean contents of @value
/// </return>

	public static bool GetBoolean(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_boolean(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_BOXED derived #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_BOXED derived type
/// </param>
/// <return>
/// boxed contents of @value
/// </return>

	public static IntPtr GetBoxed(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_boxed(value);
	}

/// <summary>
/// <para>
/// Do not use this function; it is broken on platforms where the %char
/// type is unsigned, such as ARM and PowerPC.  See g_value_get_schar().
/// </para>
/// <para>
/// Get the contents of a %G_TYPE_CHAR #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_CHAR
/// </param>
/// <return>
/// character contents of @value
/// </return>

	public static char GetChar(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_char(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_DOUBLE #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_DOUBLE
/// </param>
/// <return>
/// double contents of @value
/// </return>

	public static double GetDouble(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_double(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_ENUM #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_ENUM
/// </param>
/// <return>
/// enum contents of @value
/// </return>

	public static int GetEnum(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_enum(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_FLAGS #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_FLAGS
/// </param>
/// <return>
/// flags contents of @value
/// </return>

	public static uint GetFlags(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_flags(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_FLOAT #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_FLOAT
/// </param>
/// <return>
/// float contents of @value
/// </return>

	public static float GetFloat(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_float(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_GTYPE #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_GTYPE
/// </param>
/// <return>
/// the #GType stored in @value
/// </return>

	public static MentorLake.GObject.GType GetGtype(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_gtype(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_INT #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_INT
/// </param>
/// <return>
/// integer contents of @value
/// </return>

	public static int GetInt(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_int(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_INT64 #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_INT64
/// </param>
/// <return>
/// 64bit integer contents of @value
/// </return>

	public static long GetInt64(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_int64(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_LONG #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_LONG
/// </param>
/// <return>
/// long integer contents of @value
/// </return>

	public static long GetLong(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_long(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_OBJECT derived #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_OBJECT derived type
/// </param>
/// <return>
/// object contents of @value
/// </return>

	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_object(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_PARAM #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_PARAM
/// </param>
/// <return>
/// #GParamSpec content of @value
/// </return>

	public static MentorLake.GObject.GParamSpecHandle GetParam(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_param(value);
	}

/// <summary>
/// <para>
/// Get the contents of a pointer #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_POINTER
/// </param>
/// <return>
/// pointer contents of @value
/// </return>

	public static IntPtr GetPointer(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_pointer(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_CHAR #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_CHAR
/// </param>
/// <return>
/// signed 8 bit integer contents of @value
/// </return>

	public static byte GetSchar(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_schar(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_STRING #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <return>
/// string content of @value
/// </return>

	public static string GetString(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_string(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_UCHAR #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_UCHAR
/// </param>
/// <return>
/// unsigned character contents of @value
/// </return>

	public static byte GetUchar(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_uchar(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_UINT #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_UINT
/// </param>
/// <return>
/// unsigned integer contents of @value
/// </return>

	public static uint GetUint(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_uint(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_UINT64 #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_UINT64
/// </param>
/// <return>
/// unsigned 64bit integer contents of @value
/// </return>

	public static ulong GetUint64(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_uint64(value);
	}

/// <summary>
/// <para>
/// Get the contents of a %G_TYPE_ULONG #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_ULONG
/// </param>
/// <return>
/// unsigned long integer contents of @value
/// </return>

	public static ulong GetUlong(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_ulong(value);
	}

/// <summary>
/// <para>
/// Get the contents of a variant #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_VARIANT
/// </param>
/// <return>
/// variant contents of @value (may be %NULL)
/// </return>

	public static MentorLake.GLib.GVariantHandle GetVariant(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_get_variant(value);
	}

/// <summary>
/// <para>
/// Initializes @value with the default value of @type.
/// </para>
/// </summary>

/// <param name="value">
/// A zero-filled (uninitialized) #GValue structure.
/// </param>
/// <param name="g_type">
/// Type the #GValue should hold values of.
/// </param>
/// <return>
/// the #GValue structure that has been passed in
/// </return>

	public static MentorLake.GObject.GValueHandle Init(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType g_type)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_init(value, g_type);
	}

/// <summary>
/// <para>
/// Initializes and sets @value from an instantiatable type via the
/// value_table's collect_value() function.
/// </para>
/// <para>
/// Note: The @value will be initialised with the exact type of
/// @instance.  If you wish to set the @value's type to a different GType
/// (such as a parent class GType), you need to manually call
/// g_value_init() and g_value_set_instance().
/// </para>
/// </summary>

/// <param name="value">
/// An uninitialized #GValue structure.
/// </param>
/// <param name="instance">
/// the instance
/// </param>

	public static void InitFromInstance(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GTypeInstanceHandle instance)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_init_from_instance(value, instance);
	}

/// <summary>
/// <para>
/// Returns the value contents as pointer. This function asserts that
/// g_value_fits_pointer() returned %TRUE for the passed in value.
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// An initialized #GValue structure
/// </param>
/// <return>
/// the value contents as pointer
/// </return>

	public static IntPtr PeekPointer(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_peek_pointer(value);
	}

/// <summary>
/// <para>
/// Clears the current value in @value and resets it to the default value
/// (as if the value had just been initialized).
/// </para>
/// </summary>

/// <param name="value">
/// An initialized #GValue structure.
/// </param>
/// <return>
/// the #GValue structure that has been passed in
/// </return>

	public static MentorLake.GObject.GValueHandle Reset(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_reset(value);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_BOOLEAN #GValue to @v_boolean.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_BOOLEAN
/// </param>
/// <param name="v_boolean">
/// boolean value to be set
/// </param>

	public static void SetBoolean(this MentorLake.GObject.GValueHandle value, bool v_boolean)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_boolean(value, v_boolean);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_BOXED derived #GValue to @v_boxed.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_BOXED derived type
/// </param>
/// <param name="v_boxed">
/// boxed value to be set
/// </param>

	public static void SetBoxed(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_boxed(value, v_boxed);
	}

/// <summary>
/// <para>
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_BOXED derived type
/// </param>
/// <param name="v_boxed">
/// duplicated unowned boxed value to be set
/// </param>

	public static void SetBoxedTakeOwnership(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_boxed_take_ownership(value, v_boxed);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_CHAR #GValue to @v_char.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_CHAR
/// </param>
/// <param name="v_char">
/// character value to be set
/// </param>

	public static void SetChar(this MentorLake.GObject.GValueHandle value, char v_char)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_char(value, v_char);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_DOUBLE #GValue to @v_double.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_DOUBLE
/// </param>
/// <param name="v_double">
/// double value to be set
/// </param>

	public static void SetDouble(this MentorLake.GObject.GValueHandle value, double v_double)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_double(value, v_double);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_ENUM #GValue to @v_enum.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_ENUM
/// </param>
/// <param name="v_enum">
/// enum value to be set
/// </param>

	public static void SetEnum(this MentorLake.GObject.GValueHandle value, int v_enum)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_enum(value, v_enum);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_FLAGS #GValue to @v_flags.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue whose type is derived from %G_TYPE_FLAGS
/// </param>
/// <param name="v_flags">
/// flags value to be set
/// </param>

	public static void SetFlags(this MentorLake.GObject.GValueHandle value, uint v_flags)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_flags(value, v_flags);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_FLOAT #GValue to @v_float.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_FLOAT
/// </param>
/// <param name="v_float">
/// float value to be set
/// </param>

	public static void SetFloat(this MentorLake.GObject.GValueHandle value, float v_float)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_float(value, v_float);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_GTYPE #GValue to @v_gtype.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_GTYPE
/// </param>
/// <param name="v_gtype">
/// #GType to be set
/// </param>

	public static void SetGtype(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType v_gtype)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_gtype(value, v_gtype);
	}

/// <summary>
/// <para>
/// Sets @value from an instantiatable type via the
/// value_table's collect_value() function.
/// </para>
/// </summary>

/// <param name="value">
/// An initialized #GValue structure.
/// </param>
/// <param name="instance">
/// the instance
/// </param>

	public static void SetInstance(this MentorLake.GObject.GValueHandle value, IntPtr instance)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_instance(value, instance);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_INT #GValue to @v_int.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_INT
/// </param>
/// <param name="v_int">
/// integer value to be set
/// </param>

	public static void SetInt(this MentorLake.GObject.GValueHandle value, int v_int)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_int(value, v_int);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_INT64 #GValue to @v_int64.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_INT64
/// </param>
/// <param name="v_int64">
/// 64bit integer value to be set
/// </param>

	public static void SetInt64(this MentorLake.GObject.GValueHandle value, long v_int64)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_int64(value, v_int64);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_STRING #GValue to @v_string.  The string is
/// assumed to be static and interned (canonical, for example from
/// g_intern_string()), and is thus not duplicated when setting the #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <param name="v_string">
/// static string to be set
/// </param>

	public static void SetInternedString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_interned_string(value, v_string);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_LONG #GValue to @v_long.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_LONG
/// </param>
/// <param name="v_long">
/// long integer value to be set
/// </param>

	public static void SetLong(this MentorLake.GObject.GValueHandle value, long v_long)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_long(value, v_long);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_OBJECT derived #GValue to @v_object.
/// </para>
/// <para>
/// g_value_set_object() increases the reference count of @v_object
/// (the #GValue holds a reference to @v_object).  If you do not wish
/// to increase the reference count of the object (i.e. you wish to
/// pass your current reference to the #GValue because you no longer
/// need it), use g_value_take_object() instead.
/// </para>
/// <para>
/// It is important that your #GValue holds a reference to @v_object (either its
/// own, or one it has taken) to ensure that the object won't be destroyed while
/// the #GValue still exists).
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_OBJECT derived type
/// </param>
/// <param name="v_object">
/// object value to be set
/// </param>

	public static void SetObject(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GObjectHandle v_object)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_object(value, v_object);
	}

/// <summary>
/// <para>
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_OBJECT derived type
/// </param>
/// <param name="v_object">
/// object value to be set
/// </param>

	public static void SetObjectTakeOwnership(this MentorLake.GObject.GValueHandle value, IntPtr v_object)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_object_take_ownership(value, v_object);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_PARAM #GValue to @param.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_PARAM
/// </param>
/// <param name="param">
/// the #GParamSpec to be set
/// </param>

	public static void SetParam(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GParamSpecHandle param)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_param(value, param);
	}

/// <summary>
/// <para>
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_PARAM
/// </param>
/// <param name="param">
/// the #GParamSpec to be set
/// </param>

	public static void SetParamTakeOwnership(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GParamSpecHandle param)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_param_take_ownership(value, param);
	}

/// <summary>
/// <para>
/// Set the contents of a pointer #GValue to @v_pointer.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_POINTER
/// </param>
/// <param name="v_pointer">
/// pointer value to be set
/// </param>

	public static void SetPointer(this MentorLake.GObject.GValueHandle value, IntPtr v_pointer)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_pointer(value, v_pointer);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_CHAR #GValue to @v_char.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_CHAR
/// </param>
/// <param name="v_char">
/// signed 8 bit integer to be set
/// </param>

	public static void SetSchar(this MentorLake.GObject.GValueHandle value, byte v_char)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_schar(value, v_char);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_BOXED derived #GValue to @v_boxed.
/// </para>
/// <para>
/// The boxed value is assumed to be static, and is thus not duplicated
/// when setting the #GValue.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_BOXED derived type
/// </param>
/// <param name="v_boxed">
/// static boxed value to be set
/// </param>

	public static void SetStaticBoxed(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_static_boxed(value, v_boxed);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_STRING #GValue to @v_string.
/// The string is assumed to be static, and is thus not duplicated
/// when setting the #GValue.
/// </para>
/// <para>
/// If the the string is a canonical string, using g_value_set_interned_string()
/// is more appropriate.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <param name="v_string">
/// static string to be set
/// </param>

	public static void SetStaticString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_static_string(value, v_string);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_STRING #GValue to a copy of @v_string.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <param name="v_string">
/// caller-owned string to be duplicated for the #GValue
/// </param>

	public static void SetString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_string(value, v_string);
	}

/// <summary>
/// <para>
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <param name="v_string">
/// duplicated unowned string to be set
/// </param>

	public static void SetStringTakeOwnership(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_string_take_ownership(value, v_string);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_UCHAR #GValue to @v_uchar.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_UCHAR
/// </param>
/// <param name="v_uchar">
/// unsigned character value to be set
/// </param>

	public static void SetUchar(this MentorLake.GObject.GValueHandle value, byte v_uchar)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_uchar(value, v_uchar);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_UINT #GValue to @v_uint.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_UINT
/// </param>
/// <param name="v_uint">
/// unsigned integer value to be set
/// </param>

	public static void SetUint(this MentorLake.GObject.GValueHandle value, uint v_uint)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_uint(value, v_uint);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_UINT64 #GValue to @v_uint64.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_UINT64
/// </param>
/// <param name="v_uint64">
/// unsigned 64bit integer value to be set
/// </param>

	public static void SetUint64(this MentorLake.GObject.GValueHandle value, ulong v_uint64)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_uint64(value, v_uint64);
	}

/// <summary>
/// <para>
/// Set the contents of a %G_TYPE_ULONG #GValue to @v_ulong.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_ULONG
/// </param>
/// <param name="v_ulong">
/// unsigned long integer value to be set
/// </param>

	public static void SetUlong(this MentorLake.GObject.GValueHandle value, ulong v_ulong)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_ulong(value, v_ulong);
	}

/// <summary>
/// <para>
/// Set the contents of a variant #GValue to @variant.
/// If the variant is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_VARIANT
/// </param>
/// <param name="variant">
/// a #GVariant, or %NULL
/// </param>

	public static void SetVariant(this MentorLake.GObject.GValueHandle value, MentorLake.GLib.GVariantHandle variant)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_set_variant(value, variant);
	}

/// <summary>
/// <para>
/// Steal ownership on contents of a %G_TYPE_STRING #GValue.
/// As a result of this operation the value's contents will be reset to %NULL.
/// </para>
/// <para>
/// The purpose of this call is to provide a way to avoid an extra copy
/// when some object have been serialized into string through #GValue API.
/// </para>
/// <para>
/// NOTE: for safety and compatibility purposes, if #GValue contains
/// static string, or an interned one, this function will return a copy
/// of the string. Otherwise the transfer notation would be ambiguous.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <return>
/// string content of @value;
///  Should be freed with g_free() when no longer needed.
/// </return>

	public static string StealString(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_steal_string(value);
	}

/// <summary>
/// <para>
/// Sets the contents of a %G_TYPE_BOXED derived #GValue to @v_boxed
/// and takes over the ownership of the caller’s reference to @v_boxed;
/// the caller doesn’t have to unref it any more.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_BOXED derived type
/// </param>
/// <param name="v_boxed">
/// duplicated unowned boxed value to be set
/// </param>

	public static void TakeBoxed(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_take_boxed(value, v_boxed);
	}

/// <summary>
/// <para>
/// Sets the contents of a %G_TYPE_OBJECT derived #GValue to @v_object
/// and takes over the ownership of the caller’s reference to @v_object;
/// the caller doesn’t have to unref it any more (i.e. the reference
/// count of the object is not increased).
/// </para>
/// <para>
/// If you want the #GValue to hold its own reference to @v_object, use
/// g_value_set_object() instead.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of %G_TYPE_OBJECT derived type
/// </param>
/// <param name="v_object">
/// object value to be set
/// </param>

	public static void TakeObject(this MentorLake.GObject.GValueHandle value, IntPtr v_object)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_take_object(value, v_object);
	}

/// <summary>
/// <para>
/// Sets the contents of a %G_TYPE_PARAM #GValue to @param and takes
/// over the ownership of the caller’s reference to @param; the caller
/// doesn’t have to unref it any more.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_PARAM
/// </param>
/// <param name="param">
/// the #GParamSpec to be set
/// </param>

	public static void TakeParam(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GParamSpecHandle param)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_take_param(value, param);
	}

/// <summary>
/// <para>
/// Sets the contents of a %G_TYPE_STRING #GValue to @v_string.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_STRING
/// </param>
/// <param name="v_string">
/// string to take ownership of
/// </param>

	public static void TakeString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_take_string(value, v_string);
	}

/// <summary>
/// <para>
/// Set the contents of a variant #GValue to @variant, and takes over
/// the ownership of the caller's reference to @variant;
/// the caller doesn't have to unref it any more (i.e. the reference
/// count of the variant is not increased).
/// </para>
/// <para>
/// If @variant was floating then its floating reference is converted to
/// a hard reference.
/// </para>
/// <para>
/// If you want the #GValue to hold its own reference to @variant, use
/// g_value_set_variant() instead.
/// </para>
/// <para>
/// This is an internal function introduced mainly for C marshallers.
/// </para>
/// </summary>

/// <param name="value">
/// a valid #GValue of type %G_TYPE_VARIANT
/// </param>
/// <param name="variant">
/// a #GVariant, or %NULL
/// </param>

	public static void TakeVariant(this MentorLake.GObject.GValueHandle value, MentorLake.GLib.GVariantHandle variant)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_take_variant(value, variant);
	}

/// <summary>
/// <para>
/// Tries to cast the contents of @src_value into a type appropriate
/// to store in @dest_value, e.g. to transform a %G_TYPE_INT value
/// into a %G_TYPE_FLOAT value. Performing transformations between
/// value types might incur precision lossage. Especially
/// transformations into strings might reveal seemingly arbitrary
/// results and shouldn't be relied upon for production code (such
/// as rcfile value or object property serialization).
/// </para>
/// </summary>

/// <param name="src_value">
/// Source value.
/// </param>
/// <param name="dest_value">
/// Target value.
/// </param>
/// <return>
/// Whether a transformation rule was found and could be applied.
///  Upon failing transformations, @dest_value is left untouched.
/// </return>

	public static bool Transform(this MentorLake.GObject.GValueHandle src_value, MentorLake.GObject.GValueHandle dest_value)
	{
		if (src_value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		return GValueExterns.g_value_transform(src_value, dest_value);
	}

/// <summary>
/// <para>
/// Clears the current value in @value (if any) and "unsets" the type,
/// this releases all resources associated with this GValue. An unset
/// value is the same as an uninitialized (zero-filled) #GValue
/// structure.
/// </para>
/// </summary>

/// <param name="value">
/// An initialized #GValue structure.
/// </param>

	public static void Unset(this MentorLake.GObject.GValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GValue)");
		GValueExterns.g_value_unset(value);
	}


	public static GValue Dereference(this GValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GValue>(x.DangerousGetHandle());
}
internal class GValueExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle src_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle dest_value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_value_dup_boxed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_value_dup_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_value_dup_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_value_dup_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_value_dup_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_fits_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_value_get_boxed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern char g_value_get_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern double g_value_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_value_get_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_value_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern float g_value_get_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_value_get_gtype([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_value_get_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern long g_value_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern long g_value_get_long([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_value_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_value_get_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_value_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern byte g_value_get_schar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_value_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern byte g_value_get_uchar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_value_get_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_value_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_value_get_ulong([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_value_get_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))]
	internal static extern MentorLake.GObject.GValueHandle g_value_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType g_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_init_from_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_value_peek_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))]
	internal static extern MentorLake.GObject.GValueHandle g_value_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, bool v_boolean);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_boxed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_boxed);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_boxed_take_ownership([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_boxed);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, char v_char);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, double v_double);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, int v_enum);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, uint v_flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, float v_float);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_gtype([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType v_gtype);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, int v_int);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, long v_int64);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_interned_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, string v_string);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_long([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, long v_long);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle v_object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_object_take_ownership([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle param);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_param_take_ownership([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle param);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_pointer);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_schar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, byte v_char);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_static_boxed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_boxed);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_static_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, string v_string);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, string v_string);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_string_take_ownership([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, string v_string);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_uchar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, byte v_uchar);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, uint v_uint);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, ulong v_uint64);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_ulong([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, ulong v_ulong);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_set_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_value_steal_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_take_boxed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_boxed);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_take_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, IntPtr v_object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_take_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle param);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_take_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, string v_string);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_take_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_transform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle src_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle dest_value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_register_transform_func(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type, MentorLake.GObject.GValueTransform transform_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_type_compatible(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_type_transformable(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type);

}

/// <summary>
/// <para>
/// An opaque structure used to hold different types of values.
/// </para>
/// <para>
/// The data within the structure has protected scope: it is accessible only
/// to functions within a #GTypeValueTable structure, or implementations of
/// the g_value_*() API. That is, code portions which implement new fundamental
/// types.
/// </para>
/// <para>
/// #GValue users cannot make any assumptions about how data is stored
/// within the 2 element @data union, and the @g_type member should
/// only be accessed through the G_VALUE_TYPE() macro.
/// </para>
/// </summary>

public struct GValue
{
	
[MarshalAs(UnmanagedType.ByValArray)] public _Value__data__union[] data;
/// <summary>
/// <para>
/// Registers a value transformation function for use in g_value_transform().
/// A previously registered transformation function for @src_type and @dest_type
/// will be replaced.
/// </para>
/// </summary>

/// <param name="src_type">
/// Source type.
/// </param>
/// <param name="dest_type">
/// Target type.
/// </param>
/// <param name="transform_func">
/// a function which transforms values of type @src_type
///  into value of type @dest_type
/// </param>

	public static void RegisterTransformFunc(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type, MentorLake.GObject.GValueTransform transform_func)
	{
		GValueExterns.g_value_register_transform_func(src_type, dest_type, transform_func);
	}

/// <summary>
/// <para>
/// Returns whether a #GValue of type @src_type can be copied into
/// a #GValue of type @dest_type.
/// </para>
/// </summary>

/// <param name="src_type">
/// source type to be copied.
/// </param>
/// <param name="dest_type">
/// destination type for copying.
/// </param>
/// <return>
/// %TRUE if g_value_copy() is possible with @src_type and @dest_type.
/// </return>

	public static bool TypeCompatible(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GValueExterns.g_value_type_compatible(src_type, dest_type);
	}

/// <summary>
/// <para>
/// Check whether g_value_transform() is able to transform values
/// of type @src_type into values of type @dest_type. Note that for
/// the types to be transformable, they must be compatible or a
/// transformation function must be registered.
/// </para>
/// </summary>

/// <param name="src_type">
/// Source type.
/// </param>
/// <param name="dest_type">
/// Target type.
/// </param>
/// <return>
/// %TRUE if the transformation is possible, %FALSE otherwise.
/// </return>

	public static bool TypeTransformable(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GValueExterns.g_value_type_transformable(src_type, dest_type);
	}

}
