namespace MentorLake.Gtk3.GObject;

public class GValueHandle : BaseSafeHandle
{
}


public static class GValueHandleExtensions
{
	public static T Copy<T>(this T src_value, GValueHandle dest_value) where T : GValueHandle
	{
		GValueExterns.g_value_copy(src_value, dest_value);
		return src_value;
	}

	public static IntPtr DupBoxed(this GValueHandle value)
	{
		return GValueExterns.g_value_dup_boxed(value);
	}

	public static GObjectHandle DupObject(this GValueHandle value)
	{
		return GValueExterns.g_value_dup_object(value);
	}

	public static GParamSpecHandle DupParam(this GValueHandle value)
	{
		return GValueExterns.g_value_dup_param(value);
	}

	public static string DupString(this GValueHandle value)
	{
		return GValueExterns.g_value_dup_string(value);
	}

	public static GVariantHandle DupVariant(this GValueHandle value)
	{
		return GValueExterns.g_value_dup_variant(value);
	}

	public static bool FitsPointer(this GValueHandle value)
	{
		return GValueExterns.g_value_fits_pointer(value);
	}

	public static bool GetBoolean(this GValueHandle value)
	{
		return GValueExterns.g_value_get_boolean(value);
	}

	public static IntPtr GetBoxed(this GValueHandle value)
	{
		return GValueExterns.g_value_get_boxed(value);
	}

	public static char GetChar(this GValueHandle value)
	{
		return GValueExterns.g_value_get_char(value);
	}

	public static double GetDouble(this GValueHandle value)
	{
		return GValueExterns.g_value_get_double(value);
	}

	public static int GetEnum(this GValueHandle value)
	{
		return GValueExterns.g_value_get_enum(value);
	}

	public static uint GetFlags(this GValueHandle value)
	{
		return GValueExterns.g_value_get_flags(value);
	}

	public static float GetFloat(this GValueHandle value)
	{
		return GValueExterns.g_value_get_float(value);
	}

	public static GType GetGtype(this GValueHandle value)
	{
		return GValueExterns.g_value_get_gtype(value);
	}

	public static int GetInt(this GValueHandle value)
	{
		return GValueExterns.g_value_get_int(value);
	}

	public static long GetInt64(this GValueHandle value)
	{
		return GValueExterns.g_value_get_int64(value);
	}

	public static long GetLong(this GValueHandle value)
	{
		return GValueExterns.g_value_get_long(value);
	}

	public static GObjectHandle GetObject(this GValueHandle value)
	{
		return GValueExterns.g_value_get_object(value);
	}

	public static GParamSpecHandle GetParam(this GValueHandle value)
	{
		return GValueExterns.g_value_get_param(value);
	}

	public static IntPtr GetPointer(this GValueHandle value)
	{
		return GValueExterns.g_value_get_pointer(value);
	}

	public static byte GetSchar(this GValueHandle value)
	{
		return GValueExterns.g_value_get_schar(value);
	}

	public static string GetString(this GValueHandle value)
	{
		return GValueExterns.g_value_get_string(value);
	}

	public static char GetUchar(this GValueHandle value)
	{
		return GValueExterns.g_value_get_uchar(value);
	}

	public static uint GetUint(this GValueHandle value)
	{
		return GValueExterns.g_value_get_uint(value);
	}

	public static ulong GetUint64(this GValueHandle value)
	{
		return GValueExterns.g_value_get_uint64(value);
	}

	public static ulong GetUlong(this GValueHandle value)
	{
		return GValueExterns.g_value_get_ulong(value);
	}

	public static GVariantHandle GetVariant(this GValueHandle value)
	{
		return GValueExterns.g_value_get_variant(value);
	}

	public static GValueHandle Init(this GValueHandle value, GType g_type)
	{
		return GValueExterns.g_value_init(value, g_type);
	}

	public static T InitFromInstance<T>(this T value, GTypeInstanceHandle instance) where T : GValueHandle
	{
		GValueExterns.g_value_init_from_instance(value, instance);
		return value;
	}

	public static IntPtr PeekPointer(this GValueHandle value)
	{
		return GValueExterns.g_value_peek_pointer(value);
	}

	public static GValueHandle Reset(this GValueHandle value)
	{
		return GValueExterns.g_value_reset(value);
	}

	public static T SetBoolean<T>(this T value, bool v_boolean) where T : GValueHandle
	{
		GValueExterns.g_value_set_boolean(value, v_boolean);
		return value;
	}

	public static T SetBoxed<T>(this T value, IntPtr v_boxed) where T : GValueHandle
	{
		GValueExterns.g_value_set_boxed(value, v_boxed);
		return value;
	}

	public static T SetBoxedTakeOwnership<T>(this T value, IntPtr v_boxed) where T : GValueHandle
	{
		GValueExterns.g_value_set_boxed_take_ownership(value, v_boxed);
		return value;
	}

	public static T SetChar<T>(this T value, char v_char) where T : GValueHandle
	{
		GValueExterns.g_value_set_char(value, v_char);
		return value;
	}

	public static T SetDouble<T>(this T value, double v_double) where T : GValueHandle
	{
		GValueExterns.g_value_set_double(value, v_double);
		return value;
	}

	public static T SetEnum<T>(this T value, int v_enum) where T : GValueHandle
	{
		GValueExterns.g_value_set_enum(value, v_enum);
		return value;
	}

	public static T SetFlags<T>(this T value, uint v_flags) where T : GValueHandle
	{
		GValueExterns.g_value_set_flags(value, v_flags);
		return value;
	}

	public static T SetFloat<T>(this T value, float v_float) where T : GValueHandle
	{
		GValueExterns.g_value_set_float(value, v_float);
		return value;
	}

	public static T SetGtype<T>(this T value, GType v_gtype) where T : GValueHandle
	{
		GValueExterns.g_value_set_gtype(value, v_gtype);
		return value;
	}

	public static T SetInstance<T>(this T value, IntPtr instance) where T : GValueHandle
	{
		GValueExterns.g_value_set_instance(value, instance);
		return value;
	}

	public static T SetInt<T>(this T value, int v_int) where T : GValueHandle
	{
		GValueExterns.g_value_set_int(value, v_int);
		return value;
	}

	public static T SetInt64<T>(this T value, long v_int64) where T : GValueHandle
	{
		GValueExterns.g_value_set_int64(value, v_int64);
		return value;
	}

	public static T SetInternedString<T>(this T value, string v_string) where T : GValueHandle
	{
		GValueExterns.g_value_set_interned_string(value, v_string);
		return value;
	}

	public static T SetLong<T>(this T value, long v_long) where T : GValueHandle
	{
		GValueExterns.g_value_set_long(value, v_long);
		return value;
	}

	public static T SetObject<T>(this T value, GObjectHandle v_object) where T : GValueHandle
	{
		GValueExterns.g_value_set_object(value, v_object);
		return value;
	}

	public static T SetObjectTakeOwnership<T>(this T value, IntPtr v_object) where T : GValueHandle
	{
		GValueExterns.g_value_set_object_take_ownership(value, v_object);
		return value;
	}

	public static T SetParam<T>(this T value, GParamSpecHandle param) where T : GValueHandle
	{
		GValueExterns.g_value_set_param(value, param);
		return value;
	}

	public static T SetParamTakeOwnership<T>(this T value, GParamSpecHandle param) where T : GValueHandle
	{
		GValueExterns.g_value_set_param_take_ownership(value, param);
		return value;
	}

	public static T SetPointer<T>(this T value, IntPtr v_pointer) where T : GValueHandle
	{
		GValueExterns.g_value_set_pointer(value, v_pointer);
		return value;
	}

	public static T SetSchar<T>(this T value, byte v_char) where T : GValueHandle
	{
		GValueExterns.g_value_set_schar(value, v_char);
		return value;
	}

	public static T SetStaticBoxed<T>(this T value, IntPtr v_boxed) where T : GValueHandle
	{
		GValueExterns.g_value_set_static_boxed(value, v_boxed);
		return value;
	}

	public static T SetStaticString<T>(this T value, string v_string) where T : GValueHandle
	{
		GValueExterns.g_value_set_static_string(value, v_string);
		return value;
	}

	public static T SetString<T>(this T value, string v_string) where T : GValueHandle
	{
		GValueExterns.g_value_set_string(value, v_string);
		return value;
	}

	public static T SetStringTakeOwnership<T>(this T value, string v_string) where T : GValueHandle
	{
		GValueExterns.g_value_set_string_take_ownership(value, v_string);
		return value;
	}

	public static T SetUchar<T>(this T value, char v_uchar) where T : GValueHandle
	{
		GValueExterns.g_value_set_uchar(value, v_uchar);
		return value;
	}

	public static T SetUint<T>(this T value, uint v_uint) where T : GValueHandle
	{
		GValueExterns.g_value_set_uint(value, v_uint);
		return value;
	}

	public static T SetUint64<T>(this T value, ulong v_uint64) where T : GValueHandle
	{
		GValueExterns.g_value_set_uint64(value, v_uint64);
		return value;
	}

	public static T SetUlong<T>(this T value, ulong v_ulong) where T : GValueHandle
	{
		GValueExterns.g_value_set_ulong(value, v_ulong);
		return value;
	}

	public static T SetVariant<T>(this T value, GVariantHandle variant) where T : GValueHandle
	{
		GValueExterns.g_value_set_variant(value, variant);
		return value;
	}

	public static string StealString(this GValueHandle value)
	{
		return GValueExterns.g_value_steal_string(value);
	}

	public static T TakeBoxed<T>(this T value, IntPtr v_boxed) where T : GValueHandle
	{
		GValueExterns.g_value_take_boxed(value, v_boxed);
		return value;
	}

	public static T TakeObject<T>(this T value, IntPtr v_object) where T : GValueHandle
	{
		GValueExterns.g_value_take_object(value, v_object);
		return value;
	}

	public static T TakeParam<T>(this T value, GParamSpecHandle param) where T : GValueHandle
	{
		GValueExterns.g_value_take_param(value, param);
		return value;
	}

	public static T TakeString<T>(this T value, string v_string) where T : GValueHandle
	{
		GValueExterns.g_value_take_string(value, v_string);
		return value;
	}

	public static T TakeVariant<T>(this T value, GVariantHandle variant) where T : GValueHandle
	{
		GValueExterns.g_value_take_variant(value, variant);
		return value;
	}

	public static bool Transform(this GValueHandle src_value, GValueHandle dest_value)
	{
		return GValueExterns.g_value_transform(src_value, dest_value);
	}

	public static T Unset<T>(this T value) where T : GValueHandle
	{
		GValueExterns.g_value_unset(value);
		return value;
	}

	public static void RegisterTransformFunc(GType src_type, GType dest_type, GValueTransform transform_func)
	{
		GValueExterns.g_value_register_transform_func(src_type, dest_type, transform_func);
	}

	public static bool TypeCompatible(GType src_type, GType dest_type)
	{
		return GValueExterns.g_value_type_compatible(src_type, dest_type);
	}

	public static bool TypeTransformable(GType src_type, GType dest_type)
	{
		return GValueExterns.g_value_type_transformable(src_type, dest_type);
	}

}
internal class GValueExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_value_copy(GValueHandle src_value, GValueHandle dest_value);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_value_dup_boxed(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_value_dup_object(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_value_dup_param(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern string g_value_dup_string(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GVariantHandle g_value_dup_variant(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_value_fits_pointer(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_value_get_boolean(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_value_get_boxed(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern char g_value_get_char(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern double g_value_get_double(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern int g_value_get_enum(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_value_get_flags(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern float g_value_get_float(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_value_get_gtype(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern int g_value_get_int(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern long g_value_get_int64(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern long g_value_get_long(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_value_get_object(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_value_get_param(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_value_get_pointer(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern byte g_value_get_schar(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern string g_value_get_string(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern char g_value_get_uchar(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_value_get_uint(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_value_get_uint64(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_value_get_ulong(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GVariantHandle g_value_get_variant(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GValueHandle g_value_init(GValueHandle value, GType g_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_init_from_instance(GValueHandle value, GTypeInstanceHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_value_peek_pointer(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GValueHandle g_value_reset(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_boolean(GValueHandle value, bool v_boolean);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_boxed(GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_boxed_take_ownership(GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_char(GValueHandle value, char v_char);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_double(GValueHandle value, double v_double);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_enum(GValueHandle value, int v_enum);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_flags(GValueHandle value, uint v_flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_float(GValueHandle value, float v_float);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_gtype(GValueHandle value, GType v_gtype);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_instance(GValueHandle value, IntPtr instance);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_int(GValueHandle value, int v_int);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_int64(GValueHandle value, long v_int64);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_interned_string(GValueHandle value, string v_string);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_long(GValueHandle value, long v_long);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_object(GValueHandle value, GObjectHandle v_object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_object_take_ownership(GValueHandle value, IntPtr v_object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_param(GValueHandle value, GParamSpecHandle param);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_param_take_ownership(GValueHandle value, GParamSpecHandle param);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_pointer(GValueHandle value, IntPtr v_pointer);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_schar(GValueHandle value, byte v_char);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_static_boxed(GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_static_string(GValueHandle value, string v_string);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_string(GValueHandle value, string v_string);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_string_take_ownership(GValueHandle value, string v_string);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_uchar(GValueHandle value, char v_uchar);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_uint(GValueHandle value, uint v_uint);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_uint64(GValueHandle value, ulong v_uint64);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_ulong(GValueHandle value, ulong v_ulong);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_set_variant(GValueHandle value, GVariantHandle variant);

	[DllImport(Libraries.GObject)]
	internal static extern string g_value_steal_string(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_take_boxed(GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_take_object(GValueHandle value, IntPtr v_object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_take_param(GValueHandle value, GParamSpecHandle param);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_take_string(GValueHandle value, string v_string);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_take_variant(GValueHandle value, GVariantHandle variant);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_value_transform(GValueHandle src_value, GValueHandle dest_value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_unset(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_value_register_transform_func(GType src_type, GType dest_type, GValueTransform transform_func);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_value_type_compatible(GType src_type, GType dest_type);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_value_type_transformable(GType src_type, GType dest_type);

}

public struct GValue
{
	public None data;
}
