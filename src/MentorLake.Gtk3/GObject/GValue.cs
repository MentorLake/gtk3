namespace MentorLake.GObject;

public class GValueHandle : BaseSafeHandle
{
}


public static class GValueExtensions
{
	public static void Copy(this MentorLake.GObject.GValueHandle src_value, MentorLake.GObject.GValueHandle dest_value)
	{
		GValueExterns.g_value_copy(src_value, dest_value);
	}

	public static IntPtr DupBoxed(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_dup_boxed(value);
	}

	public static MentorLake.GObject.GObjectHandle DupObject(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_dup_object(value);
	}

	public static MentorLake.GObject.GParamSpecHandle DupParam(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_dup_param(value);
	}

	public static string DupString(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_dup_string(value);
	}

	public static MentorLake.GLib.GVariantHandle DupVariant(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_dup_variant(value);
	}

	public static bool FitsPointer(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_fits_pointer(value);
	}

	public static bool GetBoolean(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_boolean(value);
	}

	public static IntPtr GetBoxed(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_boxed(value);
	}

	public static char GetChar(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_char(value);
	}

	public static double GetDouble(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_double(value);
	}

	public static int GetEnum(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_enum(value);
	}

	public static uint GetFlags(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_flags(value);
	}

	public static float GetFloat(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_float(value);
	}

	public static MentorLake.GObject.GType GetGtype(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_gtype(value);
	}

	public static int GetInt(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_int(value);
	}

	public static long GetInt64(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_int64(value);
	}

	public static long GetLong(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_long(value);
	}

	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_object(value);
	}

	public static MentorLake.GObject.GParamSpecHandle GetParam(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_param(value);
	}

	public static IntPtr GetPointer(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_pointer(value);
	}

	public static byte GetSchar(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_schar(value);
	}

	public static string GetString(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_string(value);
	}

	public static char GetUchar(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_uchar(value);
	}

	public static uint GetUint(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_uint(value);
	}

	public static ulong GetUint64(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_uint64(value);
	}

	public static ulong GetUlong(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_ulong(value);
	}

	public static MentorLake.GLib.GVariantHandle GetVariant(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_get_variant(value);
	}

	public static MentorLake.GObject.GValueHandle Init(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType g_type)
	{
		return GValueExterns.g_value_init(value, g_type);
	}

	public static void InitFromInstance(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GTypeInstanceHandle instance)
	{
		GValueExterns.g_value_init_from_instance(value, instance);
	}

	public static IntPtr PeekPointer(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_peek_pointer(value);
	}

	public static MentorLake.GObject.GValueHandle Reset(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_reset(value);
	}

	public static void SetBoolean(this MentorLake.GObject.GValueHandle value, bool v_boolean)
	{
		GValueExterns.g_value_set_boolean(value, v_boolean);
	}

	public static void SetBoxed(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		GValueExterns.g_value_set_boxed(value, v_boxed);
	}

	public static void SetBoxedTakeOwnership(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		GValueExterns.g_value_set_boxed_take_ownership(value, v_boxed);
	}

	public static void SetChar(this MentorLake.GObject.GValueHandle value, char v_char)
	{
		GValueExterns.g_value_set_char(value, v_char);
	}

	public static void SetDouble(this MentorLake.GObject.GValueHandle value, double v_double)
	{
		GValueExterns.g_value_set_double(value, v_double);
	}

	public static void SetEnum(this MentorLake.GObject.GValueHandle value, int v_enum)
	{
		GValueExterns.g_value_set_enum(value, v_enum);
	}

	public static void SetFlags(this MentorLake.GObject.GValueHandle value, uint v_flags)
	{
		GValueExterns.g_value_set_flags(value, v_flags);
	}

	public static void SetFloat(this MentorLake.GObject.GValueHandle value, float v_float)
	{
		GValueExterns.g_value_set_float(value, v_float);
	}

	public static void SetGtype(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType v_gtype)
	{
		GValueExterns.g_value_set_gtype(value, v_gtype);
	}

	public static void SetInstance(this MentorLake.GObject.GValueHandle value, IntPtr instance)
	{
		GValueExterns.g_value_set_instance(value, instance);
	}

	public static void SetInt(this MentorLake.GObject.GValueHandle value, int v_int)
	{
		GValueExterns.g_value_set_int(value, v_int);
	}

	public static void SetInt64(this MentorLake.GObject.GValueHandle value, long v_int64)
	{
		GValueExterns.g_value_set_int64(value, v_int64);
	}

	public static void SetInternedString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		GValueExterns.g_value_set_interned_string(value, v_string);
	}

	public static void SetLong(this MentorLake.GObject.GValueHandle value, long v_long)
	{
		GValueExterns.g_value_set_long(value, v_long);
	}

	public static void SetObject(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GObjectHandle v_object)
	{
		GValueExterns.g_value_set_object(value, v_object);
	}

	public static void SetObjectTakeOwnership(this MentorLake.GObject.GValueHandle value, IntPtr v_object)
	{
		GValueExterns.g_value_set_object_take_ownership(value, v_object);
	}

	public static void SetParam(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GParamSpecHandle param)
	{
		GValueExterns.g_value_set_param(value, param);
	}

	public static void SetParamTakeOwnership(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GParamSpecHandle param)
	{
		GValueExterns.g_value_set_param_take_ownership(value, param);
	}

	public static void SetPointer(this MentorLake.GObject.GValueHandle value, IntPtr v_pointer)
	{
		GValueExterns.g_value_set_pointer(value, v_pointer);
	}

	public static void SetSchar(this MentorLake.GObject.GValueHandle value, byte v_char)
	{
		GValueExterns.g_value_set_schar(value, v_char);
	}

	public static void SetStaticBoxed(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		GValueExterns.g_value_set_static_boxed(value, v_boxed);
	}

	public static void SetStaticString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		GValueExterns.g_value_set_static_string(value, v_string);
	}

	public static void SetString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		GValueExterns.g_value_set_string(value, v_string);
	}

	public static void SetStringTakeOwnership(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		GValueExterns.g_value_set_string_take_ownership(value, v_string);
	}

	public static void SetUchar(this MentorLake.GObject.GValueHandle value, char v_uchar)
	{
		GValueExterns.g_value_set_uchar(value, v_uchar);
	}

	public static void SetUint(this MentorLake.GObject.GValueHandle value, uint v_uint)
	{
		GValueExterns.g_value_set_uint(value, v_uint);
	}

	public static void SetUint64(this MentorLake.GObject.GValueHandle value, ulong v_uint64)
	{
		GValueExterns.g_value_set_uint64(value, v_uint64);
	}

	public static void SetUlong(this MentorLake.GObject.GValueHandle value, ulong v_ulong)
	{
		GValueExterns.g_value_set_ulong(value, v_ulong);
	}

	public static void SetVariant(this MentorLake.GObject.GValueHandle value, MentorLake.GLib.GVariantHandle variant)
	{
		GValueExterns.g_value_set_variant(value, variant);
	}

	public static string StealString(this MentorLake.GObject.GValueHandle value)
	{
		return GValueExterns.g_value_steal_string(value);
	}

	public static void TakeBoxed(this MentorLake.GObject.GValueHandle value, IntPtr v_boxed)
	{
		GValueExterns.g_value_take_boxed(value, v_boxed);
	}

	public static void TakeObject(this MentorLake.GObject.GValueHandle value, IntPtr v_object)
	{
		GValueExterns.g_value_take_object(value, v_object);
	}

	public static void TakeParam(this MentorLake.GObject.GValueHandle value, MentorLake.GObject.GParamSpecHandle param)
	{
		GValueExterns.g_value_take_param(value, param);
	}

	public static void TakeString(this MentorLake.GObject.GValueHandle value, string v_string)
	{
		GValueExterns.g_value_take_string(value, v_string);
	}

	public static void TakeVariant(this MentorLake.GObject.GValueHandle value, MentorLake.GLib.GVariantHandle variant)
	{
		GValueExterns.g_value_take_variant(value, variant);
	}

	public static bool Transform(this MentorLake.GObject.GValueHandle src_value, MentorLake.GObject.GValueHandle dest_value)
	{
		return GValueExterns.g_value_transform(src_value, dest_value);
	}

	public static void Unset(this MentorLake.GObject.GValueHandle value)
	{
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
	internal static extern MentorLake.GObject.GObjectHandle g_value_dup_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_value_dup_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_value_dup_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
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
	internal static extern MentorLake.GObject.GObjectHandle g_value_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_value_get_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_value_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern byte g_value_get_schar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_value_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern char g_value_get_uchar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_value_get_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_value_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_value_get_ulong([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_value_get_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueHandle g_value_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType g_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_init_from_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_value_peek_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
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
	internal static extern void g_value_set_uchar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, char v_uchar);

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

public struct GValue
{
	public _Value__data__union[] data;
	public static void RegisterTransformFunc(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type, MentorLake.GObject.GValueTransform transform_func)
	{
		GValueExterns.g_value_register_transform_func(src_type, dest_type, transform_func);
	}

	public static bool TypeCompatible(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GValueExterns.g_value_type_compatible(src_type, dest_type);
	}

	public static bool TypeTransformable(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GValueExterns.g_value_type_transformable(src_type, dest_type);
	}

}
