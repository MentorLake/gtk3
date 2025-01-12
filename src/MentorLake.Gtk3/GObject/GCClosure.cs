namespace MentorLake.Gtk3.GObject;

public class GCClosureHandle : BaseSafeHandle
{
}


public static class GCClosureHandleExtensions
{
	public static void GCclosureMarshalBooleanBoxedBoxed(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalBooleanBoxedBoxeDv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalBooleanFlags(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalBooleanFlagSv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalStringObjectPointer(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalStringObjectPointeRv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidBoolean(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOOLEAN(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidBooleaNv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOOLEANv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidBoxed(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidBoxeDv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidChar(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__CHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidChaRv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__CHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidDouble(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__DOUBLE(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidDoublEv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__DOUBLEv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidEnum(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ENUM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidEnuMv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ENUMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidFlags(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidFlagSv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidFloat(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLOAT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidFloaTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLOATv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidInt(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__INT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidInTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__INTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidLong(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__LONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidLonGv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__LONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidObject(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__OBJECT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidObjecTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__OBJECTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidParam(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__PARAM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidParaMv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__PARAMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidPointer(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidPointeRv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidString(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__STRING(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidStrinGv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__STRINGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidUchar(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UCHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidUchaRv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UCHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidUint(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidUintPointer(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidUintPointeRv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidUinTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidUlong(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ULONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidUlonGv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ULONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidVariant(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VARIANT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidVarianTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VARIANTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalVoidVoid(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VOID(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalVoidVoiDv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VOIDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void GCclosureMarshalGeneric(GClosureHandle closure, GValueHandle return_gvalue, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_generic(closure, return_gvalue, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void GCclosureMarshalGenericVa(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args_list, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_generic_va(closure, return_value, instance, args_list, marshal_data, n_params, param_types);
	}

	public static GClosureHandle GCclosureNew(IntPtr callback_func, IntPtr user_data, GClosureNotify destroy_data)
	{
		return GCClosureExterns.g_cclosure_new(callback_func, user_data, destroy_data);
	}

	public static GClosureHandle GCclosureNewObject(IntPtr callback_func, GObjectHandle @object)
	{
		return GCClosureExterns.g_cclosure_new_object(callback_func, @object);
	}

	public static GClosureHandle GCclosureNewObjectSwap(IntPtr callback_func, GObjectHandle @object)
	{
		return GCClosureExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

	public static GClosureHandle GCclosureNewSwap(IntPtr callback_func, IntPtr user_data, GClosureNotify destroy_data)
	{
		return GCClosureExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

}
internal class GCClosureExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXED(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_BOOLEAN__FLAGS(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_BOOLEAN__FLAGSv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTER(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTERv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__BOOLEAN(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__BOOLEANv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__BOXED(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__BOXEDv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__CHAR(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__CHARv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__DOUBLE(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__DOUBLEv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__ENUM(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__ENUMv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__FLAGS(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__FLAGSv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__FLOAT(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__FLOATv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__INT(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__INTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__LONG(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__LONGv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__OBJECT(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__OBJECTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__PARAM(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__PARAMv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__POINTER(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__POINTERv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__STRING(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__STRINGv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__UCHAR(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__UCHARv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__UINT(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__UINT_POINTER(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__UINT_POINTERv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__UINTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__ULONG(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__ULONGv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__VARIANT(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__VARIANTv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__VOID(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_VOID__VOIDv(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_generic(GClosureHandle closure, GValueHandle return_gvalue, uint n_param_values, GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_cclosure_marshal_generic_va(GClosureHandle closure, GValueHandle return_value, GTypeInstanceHandle instance, IntPtr args_list, IntPtr marshal_data, int n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_cclosure_new(IntPtr callback_func, IntPtr user_data, GClosureNotify destroy_data);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_cclosure_new_object(IntPtr callback_func, GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_cclosure_new_object_swap(IntPtr callback_func, GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_cclosure_new_swap(IntPtr callback_func, IntPtr user_data, GClosureNotify destroy_data);

}

public struct GCClosure
{
	public GClosure closure;
	public IntPtr callback;
}
