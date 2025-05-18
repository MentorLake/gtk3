namespace MentorLake.GObject;

public class GObjectGlobalFunctions
{
	public static IntPtr BoxedCopy(MentorLake.GObject.GType boxed_type, IntPtr src_boxed)
	{
		return GObjectGlobalFunctionsExterns.g_boxed_copy(boxed_type, src_boxed);
	}

	public static void BoxedFree(MentorLake.GObject.GType boxed_type, IntPtr boxed)
	{
		GObjectGlobalFunctionsExterns.g_boxed_free(boxed_type, boxed);
	}

	public static MentorLake.GObject.GType BoxedTypeRegisterStatic(string name, MentorLake.GObject.GBoxedCopyFunc boxed_copy, MentorLake.GObject.GBoxedFreeFunc boxed_free)
	{
		return GObjectGlobalFunctionsExterns.g_boxed_type_register_static(name, boxed_copy, boxed_free);
	}

	public static void CclosureMarshalBooleanBoxedBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalBooleanFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_BOOLEAN__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalStringObjectPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_STRING__OBJECT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidBoolean(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__BOOLEAN(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidChar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__CHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidDouble(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__DOUBLE(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidEnum(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__ENUM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidFloat(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__FLOAT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidInt(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__INT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidLong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__LONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidObject(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__OBJECT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidParam(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__PARAM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidString(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__STRING(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidUchar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__UCHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidUint(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__UINT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidUintPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__UINT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidUlong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__ULONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidVariant(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__VARIANT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalVoidVoid(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__VOID(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void CclosureMarshalGeneric(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_gvalue, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_generic(closure, return_gvalue, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static MentorLake.GObject.GClosureHandle CclosureNew(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new(callback_func, user_data, destroy_data);
	}

	public static MentorLake.GObject.GClosureHandle CclosureNewObject(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new_object(callback_func, @object);
	}

	public static MentorLake.GObject.GClosureHandle CclosureNewObjectSwap(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

	public static MentorLake.GObject.GClosureHandle CclosureNewSwap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

	public static void ClearObject(IntPtr object_ptr)
	{
		GObjectGlobalFunctionsExterns.g_clear_object(object_ptr);
	}

	public static void ClearSignalHandler(ulong handler_id_ptr, MentorLake.GObject.GObjectHandle instance)
	{
		GObjectGlobalFunctionsExterns.g_clear_signal_handler(handler_id_ptr, instance);
	}

	public static void EnumCompleteTypeInfo(MentorLake.GObject.GType g_enum_type, out MentorLake.GObject.GTypeInfo info, MentorLake.GObject.GEnumValueHandle const_values)
	{
		GObjectGlobalFunctionsExterns.g_enum_complete_type_info(g_enum_type, out info, const_values);
	}

	public static MentorLake.GObject.GEnumValueHandle EnumGetValue(MentorLake.GObject.GEnumClassHandle enum_class, int value)
	{
		return GObjectGlobalFunctionsExterns.g_enum_get_value(enum_class, value);
	}

	public static MentorLake.GObject.GEnumValueHandle EnumGetValueByName(MentorLake.GObject.GEnumClassHandle enum_class, string name)
	{
		return GObjectGlobalFunctionsExterns.g_enum_get_value_by_name(enum_class, name);
	}

	public static MentorLake.GObject.GEnumValueHandle EnumGetValueByNick(MentorLake.GObject.GEnumClassHandle enum_class, string nick)
	{
		return GObjectGlobalFunctionsExterns.g_enum_get_value_by_nick(enum_class, nick);
	}

	public static MentorLake.GObject.GType EnumRegisterStatic(string name, MentorLake.GObject.GEnumValue[] const_static_values)
	{
		return GObjectGlobalFunctionsExterns.g_enum_register_static(name, const_static_values);
	}

	public static string EnumToString(MentorLake.GObject.GType g_enum_type, int value)
	{
		return GObjectGlobalFunctionsExterns.g_enum_to_string(g_enum_type, value);
	}

	public static void FlagsCompleteTypeInfo(MentorLake.GObject.GType g_flags_type, out MentorLake.GObject.GTypeInfo info, MentorLake.GObject.GFlagsValueHandle const_values)
	{
		GObjectGlobalFunctionsExterns.g_flags_complete_type_info(g_flags_type, out info, const_values);
	}

	public static MentorLake.GObject.GFlagsValueHandle FlagsGetFirstValue(MentorLake.GObject.GFlagsClassHandle flags_class, uint value)
	{
		return GObjectGlobalFunctionsExterns.g_flags_get_first_value(flags_class, value);
	}

	public static MentorLake.GObject.GFlagsValueHandle FlagsGetValueByName(MentorLake.GObject.GFlagsClassHandle flags_class, string name)
	{
		return GObjectGlobalFunctionsExterns.g_flags_get_value_by_name(flags_class, name);
	}

	public static MentorLake.GObject.GFlagsValueHandle FlagsGetValueByNick(MentorLake.GObject.GFlagsClassHandle flags_class, string nick)
	{
		return GObjectGlobalFunctionsExterns.g_flags_get_value_by_nick(flags_class, nick);
	}

	public static MentorLake.GObject.GType FlagsRegisterStatic(string name, MentorLake.GObject.GFlagsValue[] const_static_values)
	{
		return GObjectGlobalFunctionsExterns.g_flags_register_static(name, const_static_values);
	}

	public static string FlagsToString(MentorLake.GObject.GType flags_type, uint value)
	{
		return GObjectGlobalFunctionsExterns.g_flags_to_string(flags_type, value);
	}

	public static MentorLake.GObject.GType GtypeGetType()
	{
		return GObjectGlobalFunctionsExterns.g_gtype_get_type();
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecBoolean(string name, string nick, string blurb, bool default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_boolean(name, nick, blurb, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecBoxed(string name, string nick, string blurb, MentorLake.GObject.GType boxed_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_boxed(name, nick, blurb, boxed_type, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecChar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_char(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecDouble(string name, string nick, string blurb, double minimum, double maximum, double default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_double(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecEnum(string name, string nick, string blurb, MentorLake.GObject.GType enum_type, int default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_enum(name, nick, blurb, enum_type, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecFlags(string name, string nick, string blurb, MentorLake.GObject.GType flags_type, uint default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_flags(name, nick, blurb, flags_type, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecFloat(string name, string nick, string blurb, float minimum, float maximum, float default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_float(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecGtype(string name, string nick, string blurb, MentorLake.GObject.GType is_a_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_gtype(name, nick, blurb, is_a_type, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecInt(string name, string nick, string blurb, int minimum, int maximum, int default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_int(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecInt64(string name, string nick, string blurb, long minimum, long maximum, long default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_int64(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecLong(string name, string nick, string blurb, long minimum, long maximum, long default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_long(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecObject(string name, string nick, string blurb, MentorLake.GObject.GType object_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_object(name, nick, blurb, object_type, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecOverride(string name, MentorLake.GObject.GParamSpecHandle overridden)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_override(name, overridden);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecParam(string name, string nick, string blurb, MentorLake.GObject.GType param_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_param(name, nick, blurb, param_type, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecPointer(string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_pointer(name, nick, blurb, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecString(string name, string nick, string blurb, string default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_string(name, nick, blurb, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_uchar(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_uint(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUint64(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_uint64(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUlong(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_ulong(name, nick, blurb, minimum, maximum, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUnichar(string name, string nick, string blurb, char default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_unichar(name, nick, blurb, default_value, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecValueArray(string name, string nick, string blurb, MentorLake.GObject.GParamSpecHandle element_spec, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_value_array(name, nick, blurb, element_spec, flags);
	}

	public static MentorLake.GObject.GParamSpecHandle ParamSpecVariant(string name, string nick, string blurb, MentorLake.GLib.GVariantTypeHandle type, MentorLake.GLib.GVariantHandle default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_variant(name, nick, blurb, type, default_value, flags);
	}

	public static MentorLake.GObject.GType ParamTypeRegisterStatic(string name, MentorLake.GObject.GParamSpecTypeInfoHandle pspec_info)
	{
		return GObjectGlobalFunctionsExterns.g_param_type_register_static(name, pspec_info);
	}

	public static bool ParamValueConvert(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle src_value, MentorLake.GObject.GValueHandle dest_value, bool strict_validation)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_convert(pspec, src_value, dest_value, strict_validation);
	}

	public static bool ParamValueDefaults(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_defaults(pspec, value);
	}

	public static bool ParamValueIsValid(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_is_valid(pspec, value);
	}

	public static void ParamValueSetDefault(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		GObjectGlobalFunctionsExterns.g_param_value_set_default(pspec, value);
	}

	public static bool ParamValueValidate(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_validate(pspec, value);
	}

	public static int ParamValuesCmp(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value1, MentorLake.GObject.GValueHandle value2)
	{
		return GObjectGlobalFunctionsExterns.g_param_values_cmp(pspec, value1, value2);
	}

	public static MentorLake.GObject.GType PointerTypeRegisterStatic(string name)
	{
		return GObjectGlobalFunctionsExterns.g_pointer_type_register_static(name);
	}

	public static bool SignalAccumulatorFirstWins(MentorLake.GObject.GSignalInvocationHintHandle ihint, MentorLake.GObject.GValueHandle return_accu, MentorLake.GObject.GValueHandle handler_return, IntPtr dummy)
	{
		return GObjectGlobalFunctionsExterns.g_signal_accumulator_first_wins(ihint, return_accu, handler_return, dummy);
	}

	public static bool SignalAccumulatorTrueHandled(MentorLake.GObject.GSignalInvocationHintHandle ihint, MentorLake.GObject.GValueHandle return_accu, MentorLake.GObject.GValueHandle handler_return, IntPtr dummy)
	{
		return GObjectGlobalFunctionsExterns.g_signal_accumulator_true_handled(ihint, return_accu, handler_return, dummy);
	}

	public static ulong SignalAddEmissionHook(uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GSignalEmissionHook hook_func, IntPtr hook_data, MentorLake.GLib.GDestroyNotify data_destroy)
	{
		return GObjectGlobalFunctionsExterns.g_signal_add_emission_hook(signal_id, detail, hook_func, hook_data, data_destroy);
	}

	public static void SignalChainFromOverridden(MentorLake.GObject.GValue[] instance_and_params, MentorLake.GObject.GValueHandle return_value)
	{
		GObjectGlobalFunctionsExterns.g_signal_chain_from_overridden(instance_and_params, return_value);
	}

	public static void SignalChainFromOverriddenHandler(MentorLake.GObject.GTypeInstanceHandle instance, IntPtr @__arglist)
	{
		GObjectGlobalFunctionsExterns.g_signal_chain_from_overridden_handler(instance, @__arglist);
	}

	public static ulong SignalConnectClosure(MentorLake.GObject.GObjectHandle instance, string detailed_signal, MentorLake.GObject.GClosureHandle closure, bool after)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_closure(instance, detailed_signal, closure, after);
	}

	public static ulong SignalConnectClosureById(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, bool after)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_closure_by_id(instance, signal_id, detail, closure, after);
	}

	public static ulong SignalConnectData(MentorLake.GObject.GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, MentorLake.GObject.GClosureNotify destroy_data, MentorLake.GObject.GConnectFlags connect_flags)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_data(instance, detailed_signal, c_handler, data, destroy_data, connect_flags);
	}

	public static ulong SignalConnectObject(MentorLake.GObject.GTypeInstanceHandle instance, string detailed_signal, MentorLake.GObject.GCallback c_handler, MentorLake.GObject.GObjectHandle gobject, MentorLake.GObject.GConnectFlags connect_flags)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_object(instance, detailed_signal, c_handler, gobject, connect_flags);
	}

	public static void SignalEmit(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, IntPtr @__arglist)
	{
		GObjectGlobalFunctionsExterns.g_signal_emit(instance, signal_id, detail, @__arglist);
	}

	public static void SignalEmitByName(MentorLake.GObject.GObjectHandle instance, string detailed_signal, IntPtr @__arglist)
	{
		GObjectGlobalFunctionsExterns.g_signal_emit_by_name(instance, detailed_signal, @__arglist);
	}

	public static void SignalEmitValist(MentorLake.GObject.GTypeInstanceHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, IntPtr var_args)
	{
		GObjectGlobalFunctionsExterns.g_signal_emit_valist(instance, signal_id, detail, var_args);
	}

	public static void SignalEmitv(MentorLake.GObject.GValue[] instance_and_params, uint signal_id, MentorLake.GLib.GQuark detail, ref MentorLake.GObject.GValue return_value)
	{
		GObjectGlobalFunctionsExterns.g_signal_emitv(instance_and_params, signal_id, detail, ref return_value);
	}

	public static MentorLake.GObject.GSignalInvocationHintHandle SignalGetInvocationHint(MentorLake.GObject.GObjectHandle instance)
	{
		return GObjectGlobalFunctionsExterns.g_signal_get_invocation_hint(instance);
	}

	public static void SignalHandlerBlock(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_handler_block(instance, handler_id);
	}

	public static void SignalHandlerDisconnect(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_handler_disconnect(instance, handler_id);
	}

	public static ulong SignalHandlerFind(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handler_find(instance, mask, signal_id, detail, closure, func, data);
	}

	public static bool SignalHandlerIsConnected(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handler_is_connected(instance, handler_id);
	}

	public static void SignalHandlerUnblock(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_handler_unblock(instance, handler_id);
	}

	public static uint SignalHandlersBlockMatched(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handlers_block_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static void SignalHandlersDestroy(MentorLake.GObject.GObjectHandle instance)
	{
		GObjectGlobalFunctionsExterns.g_signal_handlers_destroy(instance);
	}

	public static uint SignalHandlersDisconnectMatched(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handlers_disconnect_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static uint SignalHandlersUnblockMatched(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handlers_unblock_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static bool SignalHasHandlerPending(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, bool may_be_blocked)
	{
		return GObjectGlobalFunctionsExterns.g_signal_has_handler_pending(instance, signal_id, detail, may_be_blocked);
	}

	public static bool SignalIsValidName(string name)
	{
		return GObjectGlobalFunctionsExterns.g_signal_is_valid_name(name);
	}

	public static uint[] SignalListIds(MentorLake.GObject.GType itype, out uint n_ids)
	{
		return GObjectGlobalFunctionsExterns.g_signal_list_ids(itype, out n_ids);
	}

	public static uint SignalLookup(string name, MentorLake.GObject.GType itype)
	{
		return GObjectGlobalFunctionsExterns.g_signal_lookup(name, itype);
	}

	public static string SignalName(uint signal_id)
	{
		return GObjectGlobalFunctionsExterns.g_signal_name(signal_id);
	}

	public static uint SignalNew(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, uint class_offset, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist)
	{
		return GObjectGlobalFunctionsExterns.g_signal_new(signal_name, itype, signal_flags, class_offset, accumulator, accu_data, c_marshaller, return_type, n_params, @__arglist);
	}

	public static uint SignalNewClassHandler(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GCallback class_handler, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist)
	{
		return GObjectGlobalFunctionsExterns.g_signal_new_class_handler(signal_name, itype, signal_flags, class_handler, accumulator, accu_data, c_marshaller, return_type, n_params, @__arglist);
	}

	public static uint SignalNewValist(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GClosureHandle class_closure, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr args)
	{
		return GObjectGlobalFunctionsExterns.g_signal_new_valist(signal_name, itype, signal_flags, class_closure, accumulator, accu_data, c_marshaller, return_type, n_params, args);
	}

	public static uint SignalNewv(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GClosureHandle class_closure, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, MentorLake.GObject.GType[] param_types)
	{
		return GObjectGlobalFunctionsExterns.g_signal_newv(signal_name, itype, signal_flags, class_closure, accumulator, accu_data, c_marshaller, return_type, n_params, param_types);
	}

	public static void SignalOverrideClassClosure(uint signal_id, MentorLake.GObject.GType instance_type, MentorLake.GObject.GClosureHandle class_closure)
	{
		GObjectGlobalFunctionsExterns.g_signal_override_class_closure(signal_id, instance_type, class_closure);
	}

	public static void SignalOverrideClassHandler(string signal_name, MentorLake.GObject.GType instance_type, MentorLake.GObject.GCallback class_handler)
	{
		GObjectGlobalFunctionsExterns.g_signal_override_class_handler(signal_name, instance_type, class_handler);
	}

	public static bool SignalParseName(string detailed_signal, MentorLake.GObject.GType itype, out uint signal_id_p, out MentorLake.GLib.GQuark detail_p, bool force_detail_quark)
	{
		return GObjectGlobalFunctionsExterns.g_signal_parse_name(detailed_signal, itype, out signal_id_p, out detail_p, force_detail_quark);
	}

	public static void SignalQuery(uint signal_id, out MentorLake.GObject.GSignalQuery query)
	{
		GObjectGlobalFunctionsExterns.g_signal_query(signal_id, out query);
	}

	public static void SignalRemoveEmissionHook(uint signal_id, ulong hook_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_remove_emission_hook(signal_id, hook_id);
	}

	public static void SignalSetVaMarshaller(uint signal_id, MentorLake.GObject.GType instance_type, MentorLake.GObject.GSignalCVaMarshaller va_marshaller)
	{
		GObjectGlobalFunctionsExterns.g_signal_set_va_marshaller(signal_id, instance_type, va_marshaller);
	}

	public static void SignalStopEmission(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail)
	{
		GObjectGlobalFunctionsExterns.g_signal_stop_emission(instance, signal_id, detail);
	}

	public static void SignalStopEmissionByName(MentorLake.GObject.GObjectHandle instance, string detailed_signal)
	{
		GObjectGlobalFunctionsExterns.g_signal_stop_emission_by_name(instance, detailed_signal);
	}

	public static MentorLake.GObject.GClosureHandle SignalTypeCclosureNew(MentorLake.GObject.GType itype, uint struct_offset)
	{
		return GObjectGlobalFunctionsExterns.g_signal_type_cclosure_new(itype, struct_offset);
	}

	public static void SourceSetClosure(MentorLake.GLib.GSourceHandle source, MentorLake.GObject.GClosureHandle closure)
	{
		GObjectGlobalFunctionsExterns.g_source_set_closure(source, closure);
	}

	public static void SourceSetDummyCallback(MentorLake.GLib.GSourceHandle source)
	{
		GObjectGlobalFunctionsExterns.g_source_set_dummy_callback(source);
	}

	public static string StrdupValueContents(MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_strdup_value_contents(value);
	}

	public static void TypeAddClassCacheFunc(IntPtr cache_data, MentorLake.GObject.GTypeClassCacheFunc cache_func)
	{
		GObjectGlobalFunctionsExterns.g_type_add_class_cache_func(cache_data, cache_func);
	}

	public static void TypeAddClassPrivate(MentorLake.GObject.GType class_type, UIntPtr private_size)
	{
		GObjectGlobalFunctionsExterns.g_type_add_class_private(class_type, private_size);
	}

	public static int TypeAddInstancePrivate(MentorLake.GObject.GType class_type, UIntPtr private_size)
	{
		return GObjectGlobalFunctionsExterns.g_type_add_instance_private(class_type, private_size);
	}

	public static void TypeAddInterfaceCheck(IntPtr check_data, MentorLake.GObject.GTypeInterfaceCheckFunc check_func)
	{
		GObjectGlobalFunctionsExterns.g_type_add_interface_check(check_data, check_func);
	}

	public static void TypeAddInterfaceDynamic(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GTypePluginHandle plugin)
	{
		GObjectGlobalFunctionsExterns.g_type_add_interface_dynamic(instance_type, interface_type, plugin);
	}

	public static void TypeAddInterfaceStatic(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GInterfaceInfoHandle info)
	{
		GObjectGlobalFunctionsExterns.g_type_add_interface_static(instance_type, interface_type, info);
	}

	public static MentorLake.GObject.GTypeClassHandle TypeCheckClassCast(MentorLake.GObject.GTypeClassHandle g_class, MentorLake.GObject.GType is_a_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_class_cast(g_class, is_a_type);
	}

	public static bool TypeCheckClassIsA(MentorLake.GObject.GTypeClassHandle g_class, MentorLake.GObject.GType is_a_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_class_is_a(g_class, is_a_type);
	}

	public static bool TypeCheckInstance(MentorLake.GObject.GTypeInstanceHandle instance)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance(instance);
	}

	public static MentorLake.GObject.GTypeInstanceHandle TypeCheckInstanceCast(MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType iface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance_cast(instance, iface_type);
	}

	public static bool TypeCheckInstanceIsA(MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType iface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance_is_a(instance, iface_type);
	}

	public static bool TypeCheckInstanceIsFundamentallyA(MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType fundamental_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance_is_fundamentally_a(instance, fundamental_type);
	}

	public static bool TypeCheckIsValueType(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_is_value_type(type);
	}

	public static bool TypeCheckValue(MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_value(value);
	}

	public static bool TypeCheckValueHolds(MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_value_holds(value, type);
	}

	public static MentorLake.GObject.GType[] TypeChildren(MentorLake.GObject.GType type, out uint n_children)
	{
		return GObjectGlobalFunctionsExterns.g_type_children(type, out n_children);
	}

	public static void TypeClassAdjustPrivateOffset(IntPtr g_class, int private_size_or_offset)
	{
		GObjectGlobalFunctionsExterns.g_type_class_adjust_private_offset(g_class, private_size_or_offset);
	}

	public static MentorLake.GObject.GTypeClassHandle TypeClassPeek(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_class_peek(type);
	}

	public static MentorLake.GObject.GTypeClassHandle TypeClassPeekStatic(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_class_peek_static(type);
	}

	public static MentorLake.GObject.GTypeClassHandle TypeClassRef(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_class_ref(type);
	}

	public static MentorLake.GObject.GTypeInstanceHandle TypeCreateInstance(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_create_instance(type);
	}

	public static MentorLake.GObject.GTypeInterfaceHandle TypeDefaultInterfacePeek(MentorLake.GObject.GType g_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_default_interface_peek(g_type);
	}

	public static MentorLake.GObject.GTypeInterfaceHandle TypeDefaultInterfaceRef(MentorLake.GObject.GType g_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_default_interface_ref(g_type);
	}

	public static void TypeDefaultInterfaceUnref(MentorLake.GObject.GTypeInterfaceHandle g_iface)
	{
		GObjectGlobalFunctionsExterns.g_type_default_interface_unref(g_iface);
	}

	public static uint TypeDepth(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_depth(type);
	}

	public static void TypeEnsure(MentorLake.GObject.GType type)
	{
		GObjectGlobalFunctionsExterns.g_type_ensure(type);
	}

	public static void TypeFreeInstance(MentorLake.GObject.GTypeInstanceHandle instance)
	{
		GObjectGlobalFunctionsExterns.g_type_free_instance(instance);
	}

	public static MentorLake.GObject.GType TypeFromName(string name)
	{
		return GObjectGlobalFunctionsExterns.g_type_from_name(name);
	}

	public static MentorLake.GObject.GType TypeFundamental(MentorLake.GObject.GType type_id)
	{
		return GObjectGlobalFunctionsExterns.g_type_fundamental(type_id);
	}

	public static MentorLake.GObject.GType TypeFundamentalNext()
	{
		return GObjectGlobalFunctionsExterns.g_type_fundamental_next();
	}

	public static int TypeGetInstanceCount(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_get_instance_count(type);
	}

	public static MentorLake.GObject.GTypePluginHandle TypeGetPlugin(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_get_plugin(type);
	}

	public static IntPtr TypeGetQdata(MentorLake.GObject.GType type, MentorLake.GLib.GQuark quark)
	{
		return GObjectGlobalFunctionsExterns.g_type_get_qdata(type, quark);
	}

	public static uint TypeGetTypeRegistrationSerial()
	{
		return GObjectGlobalFunctionsExterns.g_type_get_type_registration_serial();
	}

	public static void TypeInit()
	{
		GObjectGlobalFunctionsExterns.g_type_init();
	}

	public static void TypeInitWithDebugFlags(MentorLake.GObject.GTypeDebugFlags debug_flags)
	{
		GObjectGlobalFunctionsExterns.g_type_init_with_debug_flags(debug_flags);
	}

	public static void TypeInterfaceAddPrerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type)
	{
		GObjectGlobalFunctionsExterns.g_type_interface_add_prerequisite(interface_type, prerequisite_type);
	}

	public static MentorLake.GObject.GTypePluginHandle TypeInterfaceGetPlugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_get_plugin(instance_type, interface_type);
	}

	public static MentorLake.GObject.GType TypeInterfaceInstantiatablePrerequisite(MentorLake.GObject.GType interface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_instantiatable_prerequisite(interface_type);
	}

	public static MentorLake.GObject.GTypeInterfaceHandle TypeInterfacePeek(MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_peek(instance_class, iface_type);
	}

	public static MentorLake.GObject.GType[] TypeInterfacePrerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_prerequisites(interface_type, out n_prerequisites);
	}

	public static MentorLake.GObject.GType[] TypeInterfaces(MentorLake.GObject.GType type, out uint n_interfaces)
	{
		return GObjectGlobalFunctionsExterns.g_type_interfaces(type, out n_interfaces);
	}

	public static bool TypeIsA(MentorLake.GObject.GType type, MentorLake.GObject.GType is_a_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_is_a(type, is_a_type);
	}

	public static string TypeName(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_name(type);
	}

	public static string TypeNameFromClass(MentorLake.GObject.GTypeClassHandle g_class)
	{
		return GObjectGlobalFunctionsExterns.g_type_name_from_class(g_class);
	}

	public static string TypeNameFromInstance(MentorLake.GObject.GTypeInstanceHandle instance)
	{
		return GObjectGlobalFunctionsExterns.g_type_name_from_instance(instance);
	}

	public static MentorLake.GObject.GType TypeNextBase(MentorLake.GObject.GType leaf_type, MentorLake.GObject.GType root_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_next_base(leaf_type, root_type);
	}

	public static MentorLake.GObject.GType TypeParent(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_parent(type);
	}

	public static MentorLake.GLib.GQuark TypeQname(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_qname(type);
	}

	public static void TypeQuery(MentorLake.GObject.GType type, out MentorLake.GObject.GTypeQuery query)
	{
		GObjectGlobalFunctionsExterns.g_type_query(type, out query);
	}

	public static MentorLake.GObject.GType TypeRegisterDynamic(MentorLake.GObject.GType parent_type, string type_name, MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_dynamic(parent_type, type_name, plugin, flags);
	}

	public static MentorLake.GObject.GType TypeRegisterFundamental(MentorLake.GObject.GType type_id, string type_name, MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeFundamentalInfoHandle finfo, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_fundamental(type_id, type_name, info, finfo, flags);
	}

	public static MentorLake.GObject.GType TypeRegisterStatic(MentorLake.GObject.GType parent_type, string type_name, MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_static(parent_type, type_name, info, flags);
	}

	public static MentorLake.GObject.GType TypeRegisterStaticSimple(MentorLake.GObject.GType parent_type, string type_name, uint class_size, MentorLake.GObject.GClassInitFunc class_init, uint instance_size, MentorLake.GObject.GInstanceInitFunc instance_init, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_static_simple(parent_type, type_name, class_size, class_init, instance_size, instance_init, flags);
	}

	public static void TypeRemoveClassCacheFunc(IntPtr cache_data, MentorLake.GObject.GTypeClassCacheFunc cache_func)
	{
		GObjectGlobalFunctionsExterns.g_type_remove_class_cache_func(cache_data, cache_func);
	}

	public static void TypeRemoveInterfaceCheck(IntPtr check_data, MentorLake.GObject.GTypeInterfaceCheckFunc check_func)
	{
		GObjectGlobalFunctionsExterns.g_type_remove_interface_check(check_data, check_func);
	}

	public static void TypeSetQdata(MentorLake.GObject.GType type, MentorLake.GLib.GQuark quark, IntPtr data)
	{
		GObjectGlobalFunctionsExterns.g_type_set_qdata(type, quark, data);
	}

	public static bool TypeTestFlags(MentorLake.GObject.GType type, uint flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_test_flags(type, flags);
	}

	public static MentorLake.GObject.GTypeValueTableHandle TypeValueTablePeek(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_value_table_peek(type);
	}

	public static void ValueRegisterTransformFunc(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type, MentorLake.GObject.GValueTransform transform_func)
	{
		GObjectGlobalFunctionsExterns.g_value_register_transform_func(src_type, dest_type, transform_func);
	}

	public static bool ValueTypeCompatible(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GObjectGlobalFunctionsExterns.g_value_type_compatible(src_type, dest_type);
	}

	public static bool ValueTypeTransformable(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GObjectGlobalFunctionsExterns.g_value_type_transformable(src_type, dest_type);
	}

	public static MentorLake.GObject.GType VariantGetGtype()
	{
		return GObjectGlobalFunctionsExterns.g_variant_get_gtype();
	}

}

internal class GObjectGlobalFunctionsExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_boxed_copy(MentorLake.GObject.GType boxed_type, IntPtr src_boxed);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_boxed_free(MentorLake.GObject.GType boxed_type, IntPtr boxed);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_boxed_type_register_static(string name, MentorLake.GObject.GBoxedCopyFunc boxed_copy, MentorLake.GObject.GBoxedFreeFunc boxed_free);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXED([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_BOOLEAN__FLAGS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTER([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__BOOLEAN([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__BOXED([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__CHAR([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__DOUBLE([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__ENUM([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__FLAGS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__FLOAT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__INT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__LONG([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__OBJECT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__PARAM([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__POINTER([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__STRING([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UCHAR([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UINT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UINT_POINTER([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__ULONG([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__VARIANT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__VOID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_generic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_gvalue, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_object(MentorLake.GObject.GCallback callback_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_object_swap(MentorLake.GObject.GCallback callback_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_swap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_clear_object(IntPtr object_ptr);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_clear_signal_handler(ulong handler_id_ptr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_enum_complete_type_info(MentorLake.GObject.GType g_enum_type, out MentorLake.GObject.GTypeInfo info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumValueHandle>))] MentorLake.GObject.GEnumValueHandle const_values);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumValueHandle>))]
	internal static extern MentorLake.GObject.GEnumValueHandle g_enum_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumClassHandle>))] MentorLake.GObject.GEnumClassHandle enum_class, int value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumValueHandle>))]
	internal static extern MentorLake.GObject.GEnumValueHandle g_enum_get_value_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumClassHandle>))] MentorLake.GObject.GEnumClassHandle enum_class, string name);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumValueHandle>))]
	internal static extern MentorLake.GObject.GEnumValueHandle g_enum_get_value_by_nick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumClassHandle>))] MentorLake.GObject.GEnumClassHandle enum_class, string nick);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_enum_register_static(string name, MentorLake.GObject.GEnumValue[] const_static_values);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_enum_to_string(MentorLake.GObject.GType g_enum_type, int value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_flags_complete_type_info(MentorLake.GObject.GType g_flags_type, out MentorLake.GObject.GTypeInfo info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsValueHandle>))] MentorLake.GObject.GFlagsValueHandle const_values);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsValueHandle>))]
	internal static extern MentorLake.GObject.GFlagsValueHandle g_flags_get_first_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsClassHandle>))] MentorLake.GObject.GFlagsClassHandle flags_class, uint value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsValueHandle>))]
	internal static extern MentorLake.GObject.GFlagsValueHandle g_flags_get_value_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsClassHandle>))] MentorLake.GObject.GFlagsClassHandle flags_class, string name);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsValueHandle>))]
	internal static extern MentorLake.GObject.GFlagsValueHandle g_flags_get_value_by_nick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsClassHandle>))] MentorLake.GObject.GFlagsClassHandle flags_class, string nick);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_flags_register_static(string name, MentorLake.GObject.GFlagsValue[] const_static_values);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_flags_to_string(MentorLake.GObject.GType flags_type, uint value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_gtype_get_type();

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_boolean(string name, string nick, string blurb, bool default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_boxed(string name, string nick, string blurb, MentorLake.GObject.GType boxed_type, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_char(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_double(string name, string nick, string blurb, double minimum, double maximum, double default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_enum(string name, string nick, string blurb, MentorLake.GObject.GType enum_type, int default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_flags(string name, string nick, string blurb, MentorLake.GObject.GType flags_type, uint default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_float(string name, string nick, string blurb, float minimum, float maximum, float default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_gtype(string name, string nick, string blurb, MentorLake.GObject.GType is_a_type, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_int(string name, string nick, string blurb, int minimum, int maximum, int default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_int64(string name, string nick, string blurb, long minimum, long maximum, long default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_long(string name, string nick, string blurb, long minimum, long maximum, long default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_object(string name, string nick, string blurb, MentorLake.GObject.GType object_type, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_override(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle overridden);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_param(string name, string nick, string blurb, MentorLake.GObject.GType param_type, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_pointer(string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_string(string name, string nick, string blurb, string default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_uchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_uint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_uint64(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_ulong(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_unichar(string name, string nick, string blurb, char default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_value_array(string name, string nick, string blurb, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle element_spec, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_variant(string name, string nick, string blurb, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle default_value, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_param_type_register_static(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecTypeInfoHandle>))] MentorLake.GObject.GParamSpecTypeInfoHandle pspec_info);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_param_value_convert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle src_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle dest_value, bool strict_validation);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_param_value_defaults([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_param_value_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_value_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_param_value_validate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_param_values_cmp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value2);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_pointer_type_register_static(string name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_signal_accumulator_first_wins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalInvocationHintHandle>))] MentorLake.GObject.GSignalInvocationHintHandle ihint, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_accu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle handler_return, IntPtr dummy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_signal_accumulator_true_handled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalInvocationHintHandle>))] MentorLake.GObject.GSignalInvocationHintHandle ihint, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_accu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle handler_return, IntPtr dummy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_signal_add_emission_hook(uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GSignalEmissionHook hook_func, IntPtr hook_data, MentorLake.GLib.GDestroyNotify data_destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_chain_from_overridden(MentorLake.GObject.GValue[] instance_and_params, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_chain_from_overridden_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_signal_connect_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, string detailed_signal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, bool after);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_signal_connect_closure_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, bool after);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_signal_connect_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, MentorLake.GObject.GClosureNotify destroy_data, MentorLake.GObject.GConnectFlags connect_flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_signal_connect_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, string detailed_signal, MentorLake.GObject.GCallback c_handler, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle gobject, MentorLake.GObject.GConnectFlags connect_flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_emit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_emit_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, string detailed_signal, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_emit_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_emitv(MentorLake.GObject.GValue[] instance_and_params, uint signal_id, MentorLake.GLib.GQuark detail, ref MentorLake.GObject.GValue return_value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalInvocationHintHandle>))]
	internal static extern MentorLake.GObject.GSignalInvocationHintHandle g_signal_get_invocation_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_handler_block([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, ulong handler_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_handler_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, ulong handler_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern ulong g_signal_handler_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_signal_handler_is_connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, ulong handler_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_handler_unblock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, ulong handler_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_handlers_block_matched([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_handlers_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_handlers_disconnect_matched([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_handlers_unblock_matched([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_signal_has_handler_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, bool may_be_blocked);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_signal_is_valid_name(string name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint[] g_signal_list_ids(MentorLake.GObject.GType itype, out uint n_ids);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_lookup(string name, MentorLake.GObject.GType itype);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_signal_name(uint signal_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_new(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, uint class_offset, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_new_class_handler(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GCallback class_handler, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_new_valist(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle class_closure, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr args);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_signal_newv(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle class_closure, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_override_class_closure(uint signal_id, MentorLake.GObject.GType instance_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle class_closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_override_class_handler(string signal_name, MentorLake.GObject.GType instance_type, MentorLake.GObject.GCallback class_handler);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_signal_parse_name(string detailed_signal, MentorLake.GObject.GType itype, out uint signal_id_p, out MentorLake.GLib.GQuark detail_p, bool force_detail_quark);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_query(uint signal_id, out MentorLake.GObject.GSignalQuery query);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_remove_emission_hook(uint signal_id, ulong hook_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_set_va_marshaller(uint signal_id, MentorLake.GObject.GType instance_type, MentorLake.GObject.GSignalCVaMarshaller va_marshaller);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_stop_emission([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_stop_emission_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, string detailed_signal);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_signal_type_cclosure_new(MentorLake.GObject.GType itype, uint struct_offset);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_source_set_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_source_set_dummy_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup_value_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_add_class_cache_func(IntPtr cache_data, MentorLake.GObject.GTypeClassCacheFunc cache_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_add_class_private(MentorLake.GObject.GType class_type, UIntPtr private_size);

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_type_add_instance_private(MentorLake.GObject.GType class_type, UIntPtr private_size);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_add_interface_check(IntPtr check_data, MentorLake.GObject.GTypeInterfaceCheckFunc check_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_add_interface_dynamic(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_add_interface_static(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GInterfaceInfoHandle>))] MentorLake.GObject.GInterfaceInfoHandle info);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_check_class_cast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class, MentorLake.GObject.GType is_a_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_class_is_a([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class, MentorLake.GObject.GType is_a_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))]
	internal static extern MentorLake.GObject.GTypeInstanceHandle g_type_check_instance_cast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType iface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_instance_is_a([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType iface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_instance_is_fundamentally_a([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType fundamental_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_is_value_type(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_check_value_holds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType[] g_type_children(MentorLake.GObject.GType type, out uint n_children);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_adjust_private_offset(IntPtr g_class, int private_size_or_offset);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek_static(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_ref(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))]
	internal static extern MentorLake.GObject.GTypeInstanceHandle g_type_create_instance(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_default_interface_peek(MentorLake.GObject.GType g_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_default_interface_ref(MentorLake.GObject.GType g_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_default_interface_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_type_depth(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_ensure(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_free_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_from_name(string name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_fundamental(MentorLake.GObject.GType type_id);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_fundamental_next();

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_type_get_instance_count(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))]
	internal static extern MentorLake.GObject.GTypePluginHandle g_type_get_plugin(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_type_get_qdata(MentorLake.GObject.GType type, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	internal static extern uint g_type_get_type_registration_serial();

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_init();

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_init_with_debug_flags(MentorLake.GObject.GTypeDebugFlags debug_flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_interface_add_prerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))]
	internal static extern MentorLake.GObject.GTypePluginHandle g_type_interface_get_plugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_interface_instantiatable_prerequisite(MentorLake.GObject.GType interface_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_interface_peek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType[] g_type_interface_prerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType[] g_type_interfaces(MentorLake.GObject.GType type, out uint n_interfaces);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_is_a(MentorLake.GObject.GType type, MentorLake.GObject.GType is_a_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_type_name(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_type_name_from_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_type_name_from_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_next_base(MentorLake.GObject.GType leaf_type, MentorLake.GObject.GType root_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_parent(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_type_qname(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_query(MentorLake.GObject.GType type, out MentorLake.GObject.GTypeQuery query);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_register_dynamic(MentorLake.GObject.GType parent_type, string type_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GTypeFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_register_fundamental(MentorLake.GObject.GType type_id, string type_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInfoHandle>))] MentorLake.GObject.GTypeInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeFundamentalInfoHandle>))] MentorLake.GObject.GTypeFundamentalInfoHandle finfo, MentorLake.GObject.GTypeFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_register_static(MentorLake.GObject.GType parent_type, string type_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInfoHandle>))] MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_register_static_simple(MentorLake.GObject.GType parent_type, string type_name, uint class_size, MentorLake.GObject.GClassInitFunc class_init, uint instance_size, MentorLake.GObject.GInstanceInitFunc instance_init, MentorLake.GObject.GTypeFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_remove_class_cache_func(IntPtr cache_data, MentorLake.GObject.GTypeClassCacheFunc cache_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_remove_interface_check(IntPtr check_data, MentorLake.GObject.GTypeInterfaceCheckFunc check_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_set_qdata(MentorLake.GObject.GType type, MentorLake.GLib.GQuark quark, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_test_flags(MentorLake.GObject.GType type, uint flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeValueTableHandle>))]
	internal static extern MentorLake.GObject.GTypeValueTableHandle g_type_value_table_peek(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_register_transform_func(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type, MentorLake.GObject.GValueTransform transform_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_type_compatible(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_value_type_transformable(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_variant_get_gtype();

}
