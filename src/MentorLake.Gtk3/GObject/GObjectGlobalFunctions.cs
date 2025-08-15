namespace MentorLake.GObject;

public class GObjectGlobalFunctions
{
/// <summary>
/// <para>
/// Provide a copy of a boxed structure @src_boxed which is of type @boxed_type.
/// </para>
/// </summary>

/// <param name="boxed_type">
/// The type of @src_boxed.
/// </param>
/// <param name="src_boxed">
/// The boxed structure to be copied.
/// </param>
/// <return>
/// The newly created copy of the boxed
///    structure.
/// </return>

	public static IntPtr BoxedCopy(MentorLake.GObject.GType boxed_type, IntPtr src_boxed)
	{
		return GObjectGlobalFunctionsExterns.g_boxed_copy(boxed_type, src_boxed);
	}

/// <summary>
/// <para>
/// Free the boxed structure @boxed which is of type @boxed_type.
/// </para>
/// </summary>

/// <param name="boxed_type">
/// The type of @boxed.
/// </param>
/// <param name="boxed">
/// The boxed structure to be freed.
/// </param>

	public static void BoxedFree(MentorLake.GObject.GType boxed_type, IntPtr boxed)
	{
		GObjectGlobalFunctionsExterns.g_boxed_free(boxed_type, boxed);
	}

/// <summary>
/// <para>
/// This function creates a new %G_TYPE_BOXED derived type id for a new
/// boxed type with name @name.
/// </para>
/// <para>
/// Boxed type handling functions have to be provided to copy and free
/// opaque boxed structures of this type.
/// </para>
/// <para>
/// For the general case, it is recommended to use G_DEFINE_BOXED_TYPE()
/// instead of calling g_boxed_type_register_static() directly. The macro
/// will create the appropriate `*_get_type()` function for the boxed type.
/// </para>
/// </summary>

/// <param name="name">
/// Name of the new boxed type.
/// </param>
/// <param name="boxed_copy">
/// Boxed structure copy function.
/// </param>
/// <param name="boxed_free">
/// Boxed structure free function.
/// </param>
/// <return>
/// New %G_TYPE_BOXED derived type id for @name.
/// </return>

	public static MentorLake.GObject.GType BoxedTypeRegisterStatic(string name, MentorLake.GObject.GBoxedCopyFunc boxed_copy, MentorLake.GObject.GBoxedFreeFunc boxed_free)
	{
		return GObjectGlobalFunctionsExterns.g_boxed_type_register_static(name, boxed_copy, boxed_free);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with handlers that
/// take two boxed pointers as arguments and return a boolean.  If you
/// have such a signal, you will probably also need to use an
/// accumulator, such as g_signal_accumulator_true_handled().
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalBooleanBoxedBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with handlers that
/// take a flags type as an argument and return a boolean.  If you have
/// such a signal, you will probably also need to use an accumulator,
/// such as g_signal_accumulator_true_handled().
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalBooleanFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_BOOLEAN__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with handlers that
/// take a #GObject and a pointer and produce a string.  It is highly
/// unlikely that your signal handler fits this description.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalStringObjectPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_STRING__OBJECT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// boolean argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidBoolean(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__BOOLEAN(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument which is any boxed pointer type.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// character argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidChar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__CHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with one
/// double-precision floating point argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidDouble(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__DOUBLE(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument with an enumerated type.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidEnum(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__ENUM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument with a flags types.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with one
/// single-precision floating point argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidFloat(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__FLOAT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidInt(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__INT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with with a single
/// long integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidLong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__LONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// #GObject argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidObject(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__OBJECT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument of type #GParamSpec.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidParam(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__PARAM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single raw
/// pointer argument type.
/// </para>
/// <para>
/// If it is possible, it is better to use one of the more specific
/// functions such as g_cclosure_marshal_VOID__OBJECT() or
/// g_cclosure_marshal_VOID__OBJECT().
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single string
/// argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidString(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__STRING(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// unsigned character argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidUchar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__UCHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with with a single
/// unsigned integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidUint(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__UINT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with an unsigned int
/// and a pointer as arguments.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidUintPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__UINT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// unsigned long integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidUlong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__ULONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// #GVariant argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidVariant(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__VARIANT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with no arguments.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalVoidVoid(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_VOID__VOID(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A generic marshaller function implemented via
/// [libffi](http://sourceware.org/libffi/).
/// </para>
/// <para>
/// Normally this function is not passed explicitly to g_signal_new(),
/// but used automatically by GLib when specifying a %NULL marshaller.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_gvalue">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn&apos;t return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void CclosureMarshalGeneric(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_gvalue, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GObjectGlobalFunctionsExterns.g_cclosure_marshal_generic(closure, return_gvalue, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// Creates a new closure which invokes @callback_func with @user_data as
/// the last parameter.
/// </para>
/// <para>
/// @destroy_data will be called as a finalize notifier on the #GClosure.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="user_data">
/// user data to pass to @callback_func
/// </param>
/// <param name="destroy_data">
/// destroy notify to be called when @user_data is no longer used
/// </param>
/// <return>
/// a floating reference to a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle CclosureNew(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new(callback_func, user_data, destroy_data);
	}

/// <summary>
/// <para>
/// A variant of g_cclosure_new() which uses @object as @user_data and
/// calls g_object_watch_closure() on @object and the created
/// closure. This function is useful when you have a callback closely
/// associated with a #GObject, and want the callback to no longer run
/// after the object is is freed.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="@object">
/// a #GObject pointer to pass to @callback_func
/// </param>
/// <return>
/// a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle CclosureNewObject(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new_object(callback_func, @object);
	}

/// <summary>
/// <para>
/// A variant of g_cclosure_new_swap() which uses @object as @user_data
/// and calls g_object_watch_closure() on @object and the created
/// closure. This function is useful when you have a callback closely
/// associated with a #GObject, and want the callback to no longer run
/// after the object is is freed.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="@object">
/// a #GObject pointer to pass to @callback_func
/// </param>
/// <return>
/// a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle CclosureNewObjectSwap(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

/// <summary>
/// <para>
/// Creates a new closure which invokes @callback_func with @user_data as
/// the first parameter.
/// </para>
/// <para>
/// @destroy_data will be called as a finalize notifier on the #GClosure.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="user_data">
/// user data to pass to @callback_func
/// </param>
/// <param name="destroy_data">
/// destroy notify to be called when @user_data is no longer used
/// </param>
/// <return>
/// a floating reference to a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle CclosureNewSwap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GObjectGlobalFunctionsExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

/// <summary>
/// <para>
/// Clears a reference to a #GObject.
/// </para>
/// <para>
/// @object_ptr must not be %NULL.
/// </para>
/// <para>
/// If the reference is %NULL then this function does nothing.
/// Otherwise, the reference count of the object is decreased and the
/// pointer is set to %NULL.
/// </para>
/// <para>
/// A macro is also included that allows this function to be used without
/// pointer casts.
/// </para>
/// </summary>

/// <param name="object_ptr">
/// a pointer to a #GObject reference
/// </param>

	public static void ClearObject(IntPtr object_ptr)
	{
		GObjectGlobalFunctionsExterns.g_clear_object(object_ptr);
	}

/// <summary>
/// <para>
/// Disconnects a handler from @instance so it will not be called during
/// any future or currently ongoing emissions of the signal it has been
/// connected to. The @handler_id_ptr is then set to zero, which is never a valid handler ID value (see g_signal_connect()).
/// </para>
/// <para>
/// If the handler ID is 0 then this function does nothing.
/// </para>
/// <para>
/// There is also a macro version of this function so that the code
/// will be inlined.
/// </para>
/// </summary>

/// <param name="handler_id_ptr">
/// A pointer to a handler ID (of type #gulong) of the handler to be disconnected.
/// </param>
/// <param name="instance">
/// The instance to remove the signal handler from.
///   This pointer may be %NULL or invalid, if the handler ID is zero.
/// </param>

	public static void ClearSignalHandler(ulong handler_id_ptr, MentorLake.GObject.GObjectHandle instance)
	{
		GObjectGlobalFunctionsExterns.g_clear_signal_handler(handler_id_ptr, instance);
	}

/// <summary>
/// <para>
/// This function is meant to be called from the `complete_type_info`
/// function of a #GTypePlugin implementation, as in the following
/// example:
/// </para>
/// <code>
/// static void
/// static void
/// my_enum_complete_type_info (GTypePlugin     *plugin,
///                             GType            g_type,
///                             GTypeInfo       *info,
///                             GTypeValueTable *value_table)
/// {
///   static const GEnumValue values[] = {
///     { MY_ENUM_FOO, &quot;MY_ENUM_FOO&quot;, &quot;foo&quot; },
///     { MY_ENUM_BAR, &quot;MY_ENUM_BAR&quot;, &quot;bar&quot; },
///     { 0, NULL, NULL }
///   };
/// 
///   g_enum_complete_type_info (type, info, values);
/// }
/// </code>
/// </summary>

/// <param name="g_enum_type">
/// the type identifier of the type being completed
/// </param>
/// <param name="info">
/// the #GTypeInfo struct to be filled in
/// </param>
/// <param name="const_values">
/// An array of #GEnumValue structs for the possible
///  enumeration values. The array is terminated by a struct with all
///  members being 0.
/// </param>

	public static void EnumCompleteTypeInfo(MentorLake.GObject.GType g_enum_type, out MentorLake.GObject.GTypeInfo info, MentorLake.GObject.GEnumValueHandle const_values)
	{
		GObjectGlobalFunctionsExterns.g_enum_complete_type_info(g_enum_type, out info, const_values);
	}

/// <summary>
/// <para>
/// Returns the #GEnumValue for a value.
/// </para>
/// </summary>

/// <param name="enum_class">
/// a #GEnumClass
/// </param>
/// <param name="value">
/// the value to look up
/// </param>
/// <return>
/// the #GEnumValue for @value, or %NULL
///          if @value is not a member of the enumeration
/// </return>

	public static MentorLake.GObject.GEnumValueHandle EnumGetValue(MentorLake.GObject.GEnumClassHandle enum_class, int value)
	{
		return GObjectGlobalFunctionsExterns.g_enum_get_value(enum_class, value);
	}

/// <summary>
/// <para>
/// Looks up a #GEnumValue by name.
/// </para>
/// </summary>

/// <param name="enum_class">
/// a #GEnumClass
/// </param>
/// <param name="name">
/// the name to look up
/// </param>
/// <return>
/// the #GEnumValue with name @name,
///          or %NULL if the enumeration doesn&apos;t have a member
///          with that name
/// </return>

	public static MentorLake.GObject.GEnumValueHandle EnumGetValueByName(MentorLake.GObject.GEnumClassHandle enum_class, string name)
	{
		return GObjectGlobalFunctionsExterns.g_enum_get_value_by_name(enum_class, name);
	}

/// <summary>
/// <para>
/// Looks up a #GEnumValue by nickname.
/// </para>
/// </summary>

/// <param name="enum_class">
/// a #GEnumClass
/// </param>
/// <param name="nick">
/// the nickname to look up
/// </param>
/// <return>
/// the #GEnumValue with nickname @nick,
///          or %NULL if the enumeration doesn&apos;t have a member
///          with that nickname
/// </return>

	public static MentorLake.GObject.GEnumValueHandle EnumGetValueByNick(MentorLake.GObject.GEnumClassHandle enum_class, string nick)
	{
		return GObjectGlobalFunctionsExterns.g_enum_get_value_by_nick(enum_class, nick);
	}

/// <summary>
/// <para>
/// Registers a new static enumeration type with the name @name.
/// </para>
/// <para>
/// It is normally more convenient to let [glib-mkenums][glib-mkenums],
/// generate a my_enum_get_type() function from a usual C enumeration
/// definition  than to write one yourself using g_enum_register_static().
/// </para>
/// </summary>

/// <param name="name">
/// A nul-terminated string used as the name of the new type.
/// </param>
/// <param name="const_static_values">
/// An array of
///  #GEnumValue structs for the possible enumeration values. The array is
///  terminated by a struct with all members being 0. GObject keeps a
///  reference to the data, so it cannot be stack-allocated.
/// </param>
/// <return>
/// The new type identifier.
/// </return>

	public static MentorLake.GObject.GType EnumRegisterStatic(string name, MentorLake.GObject.GEnumValue[] const_static_values)
	{
		return GObjectGlobalFunctionsExterns.g_enum_register_static(name, const_static_values);
	}

/// <summary>
/// <para>
/// Pretty-prints @value in the form of the enum’s name.
/// </para>
/// <para>
/// This is intended to be used for debugging purposes. The format of the output
/// may change in the future.
/// </para>
/// </summary>

/// <param name="g_enum_type">
/// the type identifier of a #GEnumClass type
/// </param>
/// <param name="value">
/// the value
/// </param>
/// <return>
/// a newly-allocated text string
/// </return>

	public static string EnumToString(MentorLake.GObject.GType g_enum_type, int value)
	{
		return GObjectGlobalFunctionsExterns.g_enum_to_string(g_enum_type, value);
	}

/// <summary>
/// <para>
/// This function is meant to be called from the complete_type_info()
/// function of a #GTypePlugin implementation, see the example for
/// g_enum_complete_type_info() above.
/// </para>
/// </summary>

/// <param name="g_flags_type">
/// the type identifier of the type being completed
/// </param>
/// <param name="info">
/// the #GTypeInfo struct to be filled in
/// </param>
/// <param name="const_values">
/// An array of #GFlagsValue structs for the possible
///  enumeration values. The array is terminated by a struct with all
///  members being 0.
/// </param>

	public static void FlagsCompleteTypeInfo(MentorLake.GObject.GType g_flags_type, out MentorLake.GObject.GTypeInfo info, MentorLake.GObject.GFlagsValueHandle const_values)
	{
		GObjectGlobalFunctionsExterns.g_flags_complete_type_info(g_flags_type, out info, const_values);
	}

/// <summary>
/// <para>
/// Returns the first #GFlagsValue which is set in @value.
/// </para>
/// </summary>

/// <param name="flags_class">
/// a #GFlagsClass
/// </param>
/// <param name="value">
/// the value
/// </param>
/// <return>
/// the first #GFlagsValue which is set in
///          @value, or %NULL if none is set
/// </return>

	public static MentorLake.GObject.GFlagsValueHandle FlagsGetFirstValue(MentorLake.GObject.GFlagsClassHandle flags_class, uint value)
	{
		return GObjectGlobalFunctionsExterns.g_flags_get_first_value(flags_class, value);
	}

/// <summary>
/// <para>
/// Looks up a #GFlagsValue by name.
/// </para>
/// </summary>

/// <param name="flags_class">
/// a #GFlagsClass
/// </param>
/// <param name="name">
/// the name to look up
/// </param>
/// <return>
/// the #GFlagsValue with name @name,
///          or %NULL if there is no flag with that name
/// </return>

	public static MentorLake.GObject.GFlagsValueHandle FlagsGetValueByName(MentorLake.GObject.GFlagsClassHandle flags_class, string name)
	{
		return GObjectGlobalFunctionsExterns.g_flags_get_value_by_name(flags_class, name);
	}

/// <summary>
/// <para>
/// Looks up a #GFlagsValue by nickname.
/// </para>
/// </summary>

/// <param name="flags_class">
/// a #GFlagsClass
/// </param>
/// <param name="nick">
/// the nickname to look up
/// </param>
/// <return>
/// the #GFlagsValue with nickname @nick,
///          or %NULL if there is no flag with that nickname
/// </return>

	public static MentorLake.GObject.GFlagsValueHandle FlagsGetValueByNick(MentorLake.GObject.GFlagsClassHandle flags_class, string nick)
	{
		return GObjectGlobalFunctionsExterns.g_flags_get_value_by_nick(flags_class, nick);
	}

/// <summary>
/// <para>
/// Registers a new static flags type with the name @name.
/// </para>
/// <para>
/// It is normally more convenient to let [glib-mkenums][glib-mkenums]
/// generate a my_flags_get_type() function from a usual C enumeration
/// definition than to write one yourself using g_flags_register_static().
/// </para>
/// </summary>

/// <param name="name">
/// A nul-terminated string used as the name of the new type.
/// </param>
/// <param name="const_static_values">
/// An array of
///  #GFlagsValue structs for the possible flags values. The array is
///  terminated by a struct with all members being 0. GObject keeps a
///  reference to the data, so it cannot be stack-allocated.
/// </param>
/// <return>
/// The new type identifier.
/// </return>

	public static MentorLake.GObject.GType FlagsRegisterStatic(string name, MentorLake.GObject.GFlagsValue[] const_static_values)
	{
		return GObjectGlobalFunctionsExterns.g_flags_register_static(name, const_static_values);
	}

/// <summary>
/// <para>
/// Pretty-prints @value in the form of the flag names separated by ` | ` and
/// sorted. Any extra bits will be shown at the end as a hexadecimal number.
/// </para>
/// <para>
/// This is intended to be used for debugging purposes. The format of the output
/// may change in the future.
/// </para>
/// </summary>

/// <param name="flags_type">
/// the type identifier of a #GFlagsClass type
/// </param>
/// <param name="value">
/// the value
/// </param>
/// <return>
/// a newly-allocated text string
/// </return>

	public static string FlagsToString(MentorLake.GObject.GType flags_type, uint value)
	{
		return GObjectGlobalFunctionsExterns.g_flags_to_string(flags_type, value);
	}



	public static MentorLake.GObject.GType GtypeGetType()
	{
		return GObjectGlobalFunctionsExterns.g_gtype_get_type();
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecBoolean instance specifying a %G_TYPE_BOOLEAN
/// property. In many cases, it may be more appropriate to use an enum with
/// g_param_spec_enum(), both to improve code clarity by using explicitly named
/// values, and to allow for more values to be added in future without breaking
/// API.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecBoolean(string name, string nick, string blurb, bool default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_boolean(name, nick, blurb, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecBoxed instance specifying a %G_TYPE_BOXED
/// derived property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="boxed_type">
/// %G_TYPE_BOXED derived type of this property
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecBoxed(string name, string nick, string blurb, MentorLake.GObject.GType boxed_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_boxed(name, nick, blurb, boxed_type, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecChar instance specifying a %G_TYPE_CHAR property.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecChar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_char(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecDouble instance specifying a %G_TYPE_DOUBLE
/// property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecDouble(string name, string nick, string blurb, double minimum, double maximum, double default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_double(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecEnum instance specifying a %G_TYPE_ENUM
/// property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="enum_type">
/// a #GType derived from %G_TYPE_ENUM
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecEnum(string name, string nick, string blurb, MentorLake.GObject.GType enum_type, int default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_enum(name, nick, blurb, enum_type, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecFlags instance specifying a %G_TYPE_FLAGS
/// property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="flags_type">
/// a #GType derived from %G_TYPE_FLAGS
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecFlags(string name, string nick, string blurb, MentorLake.GObject.GType flags_type, uint default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_flags(name, nick, blurb, flags_type, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecFloat instance specifying a %G_TYPE_FLOAT property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecFloat(string name, string nick, string blurb, float minimum, float maximum, float default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_float(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecGType instance specifying a
/// %G_TYPE_GTYPE property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="is_a_type">
/// a #GType whose subtypes are allowed as values
///  of the property (use %G_TYPE_NONE for any type)
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecGtype(string name, string nick, string blurb, MentorLake.GObject.GType is_a_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_gtype(name, nick, blurb, is_a_type, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecInt instance specifying a %G_TYPE_INT property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecInt(string name, string nick, string blurb, int minimum, int maximum, int default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_int(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecInt64 instance specifying a %G_TYPE_INT64 property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecInt64(string name, string nick, string blurb, long minimum, long maximum, long default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_int64(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecLong instance specifying a %G_TYPE_LONG property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecLong(string name, string nick, string blurb, long minimum, long maximum, long default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_long(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecBoxed instance specifying a %G_TYPE_OBJECT
/// derived property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="object_type">
/// %G_TYPE_OBJECT derived type of this property
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecObject(string name, string nick, string blurb, MentorLake.GObject.GType object_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_object(name, nick, blurb, object_type, flags);
	}

/// <summary>
/// <para>
/// Creates a new property of type #GParamSpecOverride. This is used
/// to direct operations to another paramspec, and will not be directly
/// useful unless you are implementing a new base type similar to GObject.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the property.
/// </param>
/// <param name="overridden">
/// The property that is being overridden
/// </param>
/// <return>
/// the newly created #GParamSpec
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecOverride(string name, MentorLake.GObject.GParamSpecHandle overridden)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_override(name, overridden);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecParam instance specifying a %G_TYPE_PARAM
/// property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="param_type">
/// a #GType derived from %G_TYPE_PARAM
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecParam(string name, string nick, string blurb, MentorLake.GObject.GType param_type, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_param(name, nick, blurb, param_type, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecPointer instance specifying a pointer property.
/// Where possible, it is better to use g_param_spec_object() or
/// g_param_spec_boxed() to expose memory management information.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecPointer(string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_pointer(name, nick, blurb, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecString instance.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecString(string name, string nick, string blurb, string default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_string(name, nick, blurb, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecUChar instance specifying a %G_TYPE_UCHAR property.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_uchar(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecUInt instance specifying a %G_TYPE_UINT property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_uint(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecUInt64 instance specifying a %G_TYPE_UINT64
/// property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUint64(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_uint64(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecULong instance specifying a %G_TYPE_ULONG
/// property.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="minimum">
/// minimum value for the property specified
/// </param>
/// <param name="maximum">
/// maximum value for the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUlong(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_ulong(name, nick, blurb, minimum, maximum, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecUnichar instance specifying a %G_TYPE_UINT
/// property. #GValue structures for this property can be accessed with
/// g_value_set_uint() and g_value_get_uint().
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="default_value">
/// default value for the property specified
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecUnichar(string name, string nick, string blurb, char default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_unichar(name, nick, blurb, default_value, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecValueArray instance specifying a
/// %G_TYPE_VALUE_ARRAY property. %G_TYPE_VALUE_ARRAY is a
/// %G_TYPE_BOXED type, as such, #GValue structures for this property
/// can be accessed with g_value_set_boxed() and g_value_get_boxed().
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="element_spec">
/// a #GParamSpec describing the elements contained in
///  arrays of this property, may be %NULL
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// a newly created parameter specification
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecValueArray(string name, string nick, string blurb, MentorLake.GObject.GParamSpecHandle element_spec, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_value_array(name, nick, blurb, element_spec, flags);
	}

/// <summary>
/// <para>
/// Creates a new #GParamSpecVariant instance specifying a #GVariant
/// property.
/// </para>
/// <para>
/// If @default_value is floating, it is consumed.
/// </para>
/// <para>
/// See g_param_spec_internal() for details on property names.
/// </para>
/// </summary>

/// <param name="name">
/// canonical name of the property specified
/// </param>
/// <param name="nick">
/// nick name for the property specified
/// </param>
/// <param name="blurb">
/// description of the property specified
/// </param>
/// <param name="type">
/// a #GVariantType
/// </param>
/// <param name="default_value">
/// a #GVariant of type @type to
///                 use as the default value, or %NULL
/// </param>
/// <param name="flags">
/// flags for the property specified
/// </param>
/// <return>
/// the newly created #GParamSpec
/// </return>

	public static MentorLake.GObject.GParamSpecHandle ParamSpecVariant(string name, string nick, string blurb, MentorLake.GLib.GVariantTypeHandle type, MentorLake.GLib.GVariantHandle default_value, MentorLake.GObject.GParamFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_param_spec_variant(name, nick, blurb, type, default_value, flags);
	}

/// <summary>
/// <para>
/// Registers @name as the name of a new static type derived
/// from %G_TYPE_PARAM.
/// </para>
/// <para>
/// The type system uses the information contained in the #GParamSpecTypeInfo
/// structure pointed to by @info to manage the #GParamSpec type and its
/// instances.
/// </para>
/// </summary>

/// <param name="name">
/// 0-terminated string used as the name of the new #GParamSpec type.
/// </param>
/// <param name="pspec_info">
/// The #GParamSpecTypeInfo for this #GParamSpec type.
/// </param>
/// <return>
/// The new type identifier.
/// </return>

	public static MentorLake.GObject.GType ParamTypeRegisterStatic(string name, MentorLake.GObject.GParamSpecTypeInfoHandle pspec_info)
	{
		return GObjectGlobalFunctionsExterns.g_param_type_register_static(name, pspec_info);
	}

/// <summary>
/// <para>
/// Transforms @src_value into @dest_value if possible, and then
/// validates @dest_value, in order for it to conform to @pspec.  If
/// @strict_validation is %TRUE this function will only succeed if the
/// transformed @dest_value complied to @pspec without modifications.
/// </para>
/// <para>
/// See also g_value_type_transformable(), g_value_transform() and
/// g_param_value_validate().
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="src_value">
/// source #GValue
/// </param>
/// <param name="dest_value">
/// destination #GValue of correct type for @pspec
/// </param>
/// <param name="strict_validation">
/// %TRUE requires @dest_value to conform to @pspec
/// without modifications
/// </param>
/// <return>
/// %TRUE if transformation and validation were successful,
///  %FALSE otherwise and @dest_value is left untouched.
/// </return>

	public static bool ParamValueConvert(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle src_value, MentorLake.GObject.GValueHandle dest_value, bool strict_validation)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_convert(pspec, src_value, dest_value, strict_validation);
	}

/// <summary>
/// <para>
/// Checks whether @value contains the default value as specified in @pspec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="value">
/// a #GValue of correct type for @pspec
/// </param>
/// <return>
/// whether @value contains the canonical default for this @pspec
/// </return>

	public static bool ParamValueDefaults(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_defaults(pspec, value);
	}

/// <summary>
/// <para>
/// Return whether the contents of @value comply with the specifications
/// set out by @pspec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="value">
/// a #GValue of correct type for @pspec
/// </param>
/// <return>
/// whether the contents of @value comply with the specifications
///   set out by @pspec.
/// </return>

	public static bool ParamValueIsValid(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_is_valid(pspec, value);
	}

/// <summary>
/// <para>
/// Sets @value to its default value as specified in @pspec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="value">
/// a #GValue of correct type for @pspec; since 2.64, you
///   can also pass an empty #GValue, initialized with %G_VALUE_INIT
/// </param>

	public static void ParamValueSetDefault(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		GObjectGlobalFunctionsExterns.g_param_value_set_default(pspec, value);
	}

/// <summary>
/// <para>
/// Ensures that the contents of @value comply with the specifications
/// set out by @pspec. For example, a #GParamSpecInt might require
/// that integers stored in @value may not be smaller than -42 and not be
/// greater than +42. If @value contains an integer outside of this range,
/// it is modified accordingly, so the resulting value will fit into the
/// range -42 .. +42.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="value">
/// a #GValue of correct type for @pspec
/// </param>
/// <return>
/// whether modifying @value was necessary to ensure validity
/// </return>

	public static bool ParamValueValidate(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_param_value_validate(pspec, value);
	}

/// <summary>
/// <para>
/// Compares @value1 with @value2 according to @pspec, and return -1, 0 or +1,
/// if @value1 is found to be less than, equal to or greater than @value2,
/// respectively.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="value1">
/// a #GValue of correct type for @pspec
/// </param>
/// <param name="value2">
/// a #GValue of correct type for @pspec
/// </param>
/// <return>
/// -1, 0 or +1, for a less than, equal to or greater than result
/// </return>

	public static int ParamValuesCmp(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GValueHandle value1, MentorLake.GObject.GValueHandle value2)
	{
		return GObjectGlobalFunctionsExterns.g_param_values_cmp(pspec, value1, value2);
	}

/// <summary>
/// <para>
/// Creates a new %G_TYPE_POINTER derived type id for a new
/// pointer type with name @name.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the new pointer type.
/// </param>
/// <return>
/// a new %G_TYPE_POINTER derived type id for @name.
/// </return>

	public static MentorLake.GObject.GType PointerTypeRegisterStatic(string name)
	{
		return GObjectGlobalFunctionsExterns.g_pointer_type_register_static(name);
	}

/// <summary>
/// <para>
/// A predefined #GSignalAccumulator for signals intended to be used as a
/// hook for application code to provide a particular value.  Usually
/// only one such value is desired and multiple handlers for the same
/// signal don&apos;t make much sense (except for the case of the default
/// handler defined in the class structure, in which case you will
/// usually want the signal connection to override the class handler).
/// </para>
/// <para>
/// This accumulator will use the return value from the first signal
/// handler that is run as the return value for the signal and not run
/// any further handlers (ie: the first handler &quot;wins&quot;).
/// </para>
/// </summary>

/// <param name="ihint">
/// standard #GSignalAccumulator parameter
/// </param>
/// <param name="return_accu">
/// standard #GSignalAccumulator parameter
/// </param>
/// <param name="handler_return">
/// standard #GSignalAccumulator parameter
/// </param>
/// <param name="dummy">
/// standard #GSignalAccumulator parameter
/// </param>
/// <return>
/// standard #GSignalAccumulator result
/// </return>

	public static bool SignalAccumulatorFirstWins(MentorLake.GObject.GSignalInvocationHintHandle ihint, MentorLake.GObject.GValueHandle return_accu, MentorLake.GObject.GValueHandle handler_return, IntPtr dummy)
	{
		return GObjectGlobalFunctionsExterns.g_signal_accumulator_first_wins(ihint, return_accu, handler_return, dummy);
	}

/// <summary>
/// <para>
/// A predefined #GSignalAccumulator for signals that return a
/// boolean values. The behavior that this accumulator gives is
/// that a return of %TRUE stops the signal emission: no further
/// callbacks will be invoked, while a return of %FALSE allows
/// the emission to continue. The idea here is that a %TRUE return
/// indicates that the callback handled the signal, and no further
/// handling is needed.
/// </para>
/// </summary>

/// <param name="ihint">
/// standard #GSignalAccumulator parameter
/// </param>
/// <param name="return_accu">
/// standard #GSignalAccumulator parameter
/// </param>
/// <param name="handler_return">
/// standard #GSignalAccumulator parameter
/// </param>
/// <param name="dummy">
/// standard #GSignalAccumulator parameter
/// </param>
/// <return>
/// standard #GSignalAccumulator result
/// </return>

	public static bool SignalAccumulatorTrueHandled(MentorLake.GObject.GSignalInvocationHintHandle ihint, MentorLake.GObject.GValueHandle return_accu, MentorLake.GObject.GValueHandle handler_return, IntPtr dummy)
	{
		return GObjectGlobalFunctionsExterns.g_signal_accumulator_true_handled(ihint, return_accu, handler_return, dummy);
	}

/// <summary>
/// <para>
/// Adds an emission hook for a signal, which will get called for any emission
/// of that signal, independent of the instance. This is possible only
/// for signals which don&apos;t have %G_SIGNAL_NO_HOOKS flag set.
/// </para>
/// </summary>

/// <param name="signal_id">
/// the signal identifier, as returned by g_signal_lookup().
/// </param>
/// <param name="detail">
/// the detail on which to call the hook.
/// </param>
/// <param name="hook_func">
/// a #GSignalEmissionHook function.
/// </param>
/// <param name="hook_data">
/// user data for @hook_func.
/// </param>
/// <param name="data_destroy">
/// a #GDestroyNotify for @hook_data.
/// </param>
/// <return>
/// the hook id, for later use with g_signal_remove_emission_hook().
/// </return>

	public static ulong SignalAddEmissionHook(uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GSignalEmissionHook hook_func, IntPtr hook_data, MentorLake.GLib.GDestroyNotify data_destroy)
	{
		return GObjectGlobalFunctionsExterns.g_signal_add_emission_hook(signal_id, detail, hook_func, hook_data, data_destroy);
	}

/// <summary>
/// <para>
/// Calls the original class closure of a signal. This function should only
/// be called from an overridden class closure; see
/// g_signal_override_class_closure() and
/// g_signal_override_class_handler().
/// </para>
/// </summary>

/// <param name="instance_and_params">
/// the argument list of the signal emission.
///  The first element in the array is a #GValue for the instance the signal
///  is being emitted on. The rest are any arguments to be passed to the signal.
/// </param>
/// <param name="return_value">
/// Location for the return value.
/// </param>

	public static void SignalChainFromOverridden(MentorLake.GObject.GValue[] instance_and_params, MentorLake.GObject.GValueHandle return_value)
	{
		GObjectGlobalFunctionsExterns.g_signal_chain_from_overridden(instance_and_params, return_value);
	}

/// <summary>
/// <para>
/// Calls the original class closure of a signal. This function should
/// only be called from an overridden class closure; see
/// g_signal_override_class_closure() and
/// g_signal_override_class_handler().
/// </para>
/// </summary>

/// <param name="instance">
/// the instance the signal is being
///    emitted on.
/// </param>
/// <param name="@__arglist">
/// parameters to be passed to the parent class closure, followed by a
///  location for the return value. If the return type of the signal
///  is %G_TYPE_NONE, the return value location can be omitted.
/// </param>

	public static void SignalChainFromOverriddenHandler(MentorLake.GObject.GTypeInstanceHandle instance, IntPtr @__arglist)
	{
		GObjectGlobalFunctionsExterns.g_signal_chain_from_overridden_handler(instance, @__arglist);
	}

/// <summary>
/// <para>
/// Connects a closure to a signal for a particular object.
/// </para>
/// <para>
/// If @closure is a floating reference (see g_closure_sink()), this function
/// takes ownership of @closure.
/// </para>
/// <para>
/// This function cannot fail. If the given signal name doesn’t exist,
/// a critical warning is emitted. No validation is performed on the
/// ‘detail’ string when specified in @detailed_signal, other than a
/// non-empty check.
/// </para>
/// <para>
/// Refer to the [signals documentation](signals.html) for more
/// details.
/// </para>
/// </summary>

/// <param name="instance">
/// the instance to connect to.
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;.
/// </param>
/// <param name="closure">
/// the closure to connect.
/// </param>
/// <param name="after">
/// whether the handler should be called before or after the
///  default handler of the signal.
/// </param>
/// <return>
/// the handler ID (always greater than 0)
/// </return>

	public static ulong SignalConnectClosure(MentorLake.GObject.GObjectHandle instance, string detailed_signal, MentorLake.GObject.GClosureHandle closure, bool after)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_closure(instance, detailed_signal, closure, after);
	}

/// <summary>
/// <para>
/// Connects a closure to a signal for a particular object.
/// </para>
/// <para>
/// If @closure is a floating reference (see g_closure_sink()), this function
/// takes ownership of @closure.
/// </para>
/// <para>
/// This function cannot fail. If the given signal name doesn’t exist,
/// a critical warning is emitted. No validation is performed on the
/// ‘detail’ string when specified in @detailed_signal, other than a
/// non-empty check.
/// </para>
/// <para>
/// Refer to the [signals documentation](signals.html) for more
/// details.
/// </para>
/// </summary>

/// <param name="instance">
/// the instance to connect to.
/// </param>
/// <param name="signal_id">
/// the id of the signal.
/// </param>
/// <param name="detail">
/// the detail.
/// </param>
/// <param name="closure">
/// the closure to connect.
/// </param>
/// <param name="after">
/// whether the handler should be called before or after the
///  default handler of the signal.
/// </param>
/// <return>
/// the handler ID (always greater than 0)
/// </return>

	public static ulong SignalConnectClosureById(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, bool after)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_closure_by_id(instance, signal_id, detail, closure, after);
	}

/// <summary>
/// <para>
/// Connects a #GCallback function to a signal for a particular object. Similar
/// to g_signal_connect(), but allows to provide a #GClosureNotify for the data
/// which will be called when the signal handler is disconnected and no longer
/// used. Specify @connect_flags if you need `..._after()` or
/// `..._swapped()` variants of this function.
/// </para>
/// <para>
/// This function cannot fail. If the given signal name doesn’t exist,
/// a critical warning is emitted. No validation is performed on the
/// ‘detail’ string when specified in @detailed_signal, other than a
/// non-empty check.
/// </para>
/// <para>
/// Refer to the [signals documentation](signals.html) for more
/// details.
/// </para>
/// </summary>

/// <param name="instance">
/// the instance to connect to.
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;.
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect.
/// </param>
/// <param name="data">
/// data to pass to @c_handler calls.
/// </param>
/// <param name="destroy_data">
/// a #GClosureNotify for @data.
/// </param>
/// <param name="connect_flags">
/// a combination of #GConnectFlags.
/// </param>
/// <return>
/// the handler ID (always greater than 0)
/// </return>

	public static ulong SignalConnectData(MentorLake.GObject.GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, MentorLake.GObject.GClosureNotify destroy_data, MentorLake.GObject.GConnectFlags connect_flags)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_data(instance, detailed_signal, c_handler, data, destroy_data, connect_flags);
	}

/// <summary>
/// <para>
/// This is similar to g_signal_connect_data(), but uses a closure which
/// ensures that the @gobject stays alive during the call to @c_handler
/// by temporarily adding a reference count to @gobject.
/// </para>
/// <para>
/// When the @gobject is destroyed the signal handler will be automatically
/// disconnected.  Note that this is not currently threadsafe (ie:
/// emitting a signal while @gobject is being destroyed in another thread
/// is not safe).
/// </para>
/// <para>
/// This function cannot fail. If the given signal name doesn’t exist,
/// a critical warning is emitted. No validation is performed on the
/// &quot;detail&quot; string when specified in @detailed_signal, other than a
/// non-empty check.
/// </para>
/// <para>
/// Refer to the [signals documentation](signals.html) for more
/// details.
/// </para>
/// </summary>

/// <param name="instance">
/// the instance to connect to.
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;.
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect.
/// </param>
/// <param name="gobject">
/// the object to pass as data
///    to @c_handler.
/// </param>
/// <param name="connect_flags">
/// a combination of #GConnectFlags.
/// </param>
/// <return>
/// the handler id.
/// </return>

	public static ulong SignalConnectObject(MentorLake.GObject.GTypeInstanceHandle instance, string detailed_signal, MentorLake.GObject.GCallback c_handler, MentorLake.GObject.GObjectHandle gobject, MentorLake.GObject.GConnectFlags connect_flags)
	{
		return GObjectGlobalFunctionsExterns.g_signal_connect_object(instance, detailed_signal, c_handler, gobject, connect_flags);
	}

/// <summary>
/// <para>
/// Emits a signal. Signal emission is done synchronously.
/// The method will only return control after all handlers are called or signal emission was stopped.
/// </para>
/// <para>
/// Note that g_signal_emit() resets the return value to the default
/// if no handlers are connected, in contrast to g_signal_emitv().
/// </para>
/// </summary>

/// <param name="instance">
/// the instance the signal is being emitted on.
/// </param>
/// <param name="signal_id">
/// the signal id
/// </param>
/// <param name="detail">
/// the detail
/// </param>
/// <param name="@__arglist">
/// parameters to be passed to the signal, followed by a
///  location for the return value. If the return type of the signal
///  is %G_TYPE_NONE, the return value location can be omitted.
/// </param>

	public static void SignalEmit(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, IntPtr @__arglist)
	{
		GObjectGlobalFunctionsExterns.g_signal_emit(instance, signal_id, detail, @__arglist);
	}

/// <summary>
/// <para>
/// Emits a signal. Signal emission is done synchronously.
/// The method will only return control after all handlers are called or signal emission was stopped.
/// </para>
/// <para>
/// Note that g_signal_emit_by_name() resets the return value to the default
/// if no handlers are connected, in contrast to g_signal_emitv().
/// </para>
/// </summary>

/// <param name="instance">
/// the instance the signal is being emitted on.
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;.
/// </param>
/// <param name="@__arglist">
/// parameters to be passed to the signal, followed by a
///  location for the return value. If the return type of the signal
///  is %G_TYPE_NONE, the return value location can be omitted. The
///  number of parameters to pass to this function is defined when creating the signal.
/// </param>

	public static void SignalEmitByName(MentorLake.GObject.GObjectHandle instance, string detailed_signal, IntPtr @__arglist)
	{
		GObjectGlobalFunctionsExterns.g_signal_emit_by_name(instance, detailed_signal, @__arglist);
	}

/// <summary>
/// <para>
/// Emits a signal. Signal emission is done synchronously.
/// The method will only return control after all handlers are called or signal emission was stopped.
/// </para>
/// <para>
/// Note that g_signal_emit_valist() resets the return value to the default
/// if no handlers are connected, in contrast to g_signal_emitv().
/// </para>
/// </summary>

/// <param name="instance">
/// the instance the signal is being
///    emitted on.
/// </param>
/// <param name="signal_id">
/// the signal id
/// </param>
/// <param name="detail">
/// the detail
/// </param>
/// <param name="var_args">
/// a list of parameters to be passed to the signal, followed by a
///  location for the return value. If the return type of the signal
///  is %G_TYPE_NONE, the return value location can be omitted.
/// </param>

	public static void SignalEmitValist(MentorLake.GObject.GTypeInstanceHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, IntPtr var_args)
	{
		GObjectGlobalFunctionsExterns.g_signal_emit_valist(instance, signal_id, detail, var_args);
	}

/// <summary>
/// <para>
/// Emits a signal. Signal emission is done synchronously.
/// The method will only return control after all handlers are called or signal emission was stopped.
/// </para>
/// <para>
/// Note that g_signal_emitv() doesn&apos;t change @return_value if no handlers are
/// connected, in contrast to g_signal_emit() and g_signal_emit_valist().
/// </para>
/// </summary>

/// <param name="instance_and_params">
/// argument list for the signal emission.
///  The first element in the array is a #GValue for the instance the signal
///  is being emitted on. The rest are any arguments to be passed to the signal.
/// </param>
/// <param name="signal_id">
/// the signal id
/// </param>
/// <param name="detail">
/// the detail
/// </param>
/// <param name="return_value">
/// Location to
/// store the return value of the signal emission. This must be provided if the
/// specified signal returns a value, but may be ignored otherwise.
/// </param>

	public static void SignalEmitv(MentorLake.GObject.GValue[] instance_and_params, uint signal_id, MentorLake.GLib.GQuark detail, ref MentorLake.GObject.GValue return_value)
	{
		GObjectGlobalFunctionsExterns.g_signal_emitv(instance_and_params, signal_id, detail, ref return_value);
	}

/// <summary>
/// <para>
/// Returns the invocation hint of the innermost signal emission of instance.
/// </para>
/// </summary>

/// <param name="instance">
/// the instance to query
/// </param>
/// <return>
/// the invocation hint of the innermost
///     signal emission, or %NULL if not found.
/// </return>

	public static MentorLake.GObject.GSignalInvocationHintHandle SignalGetInvocationHint(MentorLake.GObject.GObjectHandle instance)
	{
		return GObjectGlobalFunctionsExterns.g_signal_get_invocation_hint(instance);
	}

/// <summary>
/// <para>
/// Blocks a handler of an instance so it will not be called during any
/// signal emissions unless it is unblocked again. Thus &quot;blocking&quot; a
/// signal handler means to temporarily deactivate it, a signal handler
/// has to be unblocked exactly the same amount of times it has been
/// blocked before to become active again.
/// </para>
/// <para>
/// The @handler_id has to be a valid signal handler id, connected to a
/// signal of @instance.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to block the signal handler of.
/// </param>
/// <param name="handler_id">
/// Handler id of the handler to be blocked.
/// </param>

	public static void SignalHandlerBlock(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_handler_block(instance, handler_id);
	}

/// <summary>
/// <para>
/// Disconnects a handler from an instance so it will not be called during
/// any future or currently ongoing emissions of the signal it has been
/// connected to. The @handler_id becomes invalid and may be reused.
/// </para>
/// <para>
/// The @handler_id has to be a valid signal handler id, connected to a
/// signal of @instance.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to remove the signal handler from.
/// </param>
/// <param name="handler_id">
/// Handler id of the handler to be disconnected.
/// </param>

	public static void SignalHandlerDisconnect(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_handler_disconnect(instance, handler_id);
	}

/// <summary>
/// <para>
/// Finds the first signal handler that matches certain selection criteria.
/// The criteria mask is passed as an OR-ed combination of #GSignalMatchType
/// flags, and the criteria values are passed as arguments.
/// The match @mask has to be non-0 for successful matches.
/// If no handler was found, 0 is returned.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance owning the signal handler to be found.
/// </param>
/// <param name="mask">
/// Mask indicating which of @signal_id, @detail, @closure, @func
///  and/or @data the handler has to match.
/// </param>
/// <param name="signal_id">
/// Signal the handler has to be connected to.
/// </param>
/// <param name="detail">
/// Signal detail the handler has to be connected to.
/// </param>
/// <param name="closure">
/// The closure the handler will invoke.
/// </param>
/// <param name="func">
/// The C closure callback of the handler (useless for non-C closures).
/// </param>
/// <param name="data">
/// The closure data of the handler&apos;s closure.
/// </param>
/// <return>
/// A valid non-0 signal handler id for a successful match.
/// </return>

	public static ulong SignalHandlerFind(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handler_find(instance, mask, signal_id, detail, closure, func, data);
	}

/// <summary>
/// <para>
/// Returns whether @handler_id is the ID of a handler connected to @instance.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance where a signal handler is sought.
/// </param>
/// <param name="handler_id">
/// the handler ID.
/// </param>
/// <return>
/// whether @handler_id identifies a handler connected to @instance.
/// </return>

	public static bool SignalHandlerIsConnected(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handler_is_connected(instance, handler_id);
	}

/// <summary>
/// <para>
/// Undoes the effect of a previous g_signal_handler_block() call.  A
/// blocked handler is skipped during signal emissions and will not be
/// invoked, unblocking it (for exactly the amount of times it has been
/// blocked before) reverts its &quot;blocked&quot; state, so the handler will be
/// recognized by the signal system and is called upon future or
/// currently ongoing signal emissions (since the order in which
/// handlers are called during signal emissions is deterministic,
/// whether the unblocked handler in question is called as part of a
/// currently ongoing emission depends on how far that emission has
/// proceeded yet).
/// </para>
/// <para>
/// The @handler_id has to be a valid id of a signal handler that is
/// connected to a signal of @instance and is currently blocked.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to unblock the signal handler of.
/// </param>
/// <param name="handler_id">
/// Handler id of the handler to be unblocked.
/// </param>

	public static void SignalHandlerUnblock(MentorLake.GObject.GObjectHandle instance, ulong handler_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_handler_unblock(instance, handler_id);
	}

/// <summary>
/// <para>
/// Blocks all handlers on an instance that match a certain selection criteria.
/// </para>
/// <para>
/// The criteria mask is passed as a combination of #GSignalMatchType flags, and
/// the criteria values are passed as arguments. A handler must match on all
/// flags set in @mask to be blocked (i.e. the match is conjunctive).
/// </para>
/// <para>
/// Passing at least one of the %G_SIGNAL_MATCH_ID, %G_SIGNAL_MATCH_CLOSURE,
/// %G_SIGNAL_MATCH_FUNC
/// or %G_SIGNAL_MATCH_DATA match flags is required for successful matches.
/// If no handlers were found, 0 is returned, the number of blocked handlers
/// otherwise.
/// </para>
/// <para>
/// Support for %G_SIGNAL_MATCH_ID was added in GLib 2.78.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to block handlers from.
/// </param>
/// <param name="mask">
/// Mask indicating which of @signal_id, @detail, @closure, @func
///  and/or @data the handlers have to match.
/// </param>
/// <param name="signal_id">
/// Signal the handlers have to be connected to.
/// </param>
/// <param name="detail">
/// Signal detail the handlers have to be connected to.
/// </param>
/// <param name="closure">
/// The closure the handlers will invoke.
/// </param>
/// <param name="func">
/// The C closure callback of the handlers (useless for non-C closures).
/// </param>
/// <param name="data">
/// The closure data of the handlers&apos; closures.
/// </param>
/// <return>
/// The number of handlers that matched.
/// </return>

	public static uint SignalHandlersBlockMatched(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handlers_block_matched(instance, mask, signal_id, detail, closure, func, data);
	}

/// <summary>
/// <para>
/// Destroy all signal handlers of a type instance. This function is
/// an implementation detail of the #GObject dispose implementation,
/// and should not be used outside of the type system.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance whose signal handlers are destroyed
/// </param>

	public static void SignalHandlersDestroy(MentorLake.GObject.GObjectHandle instance)
	{
		GObjectGlobalFunctionsExterns.g_signal_handlers_destroy(instance);
	}

/// <summary>
/// <para>
/// Disconnects all handlers on an instance that match a certain
/// selection criteria.
/// </para>
/// <para>
/// The criteria mask is passed as a combination of #GSignalMatchType flags, and
/// the criteria values are passed as arguments. A handler must match on all
/// flags set in @mask to be disconnected (i.e. the match is conjunctive).
/// </para>
/// <para>
/// Passing at least one of the %G_SIGNAL_MATCH_ID, %G_SIGNAL_MATCH_CLOSURE,
/// %G_SIGNAL_MATCH_FUNC or
/// %G_SIGNAL_MATCH_DATA match flags is required for successful
/// matches.  If no handlers were found, 0 is returned, the number of
/// disconnected handlers otherwise.
/// </para>
/// <para>
/// Support for %G_SIGNAL_MATCH_ID was added in GLib 2.78.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to remove handlers from.
/// </param>
/// <param name="mask">
/// Mask indicating which of @signal_id, @detail, @closure, @func
///  and/or @data the handlers have to match.
/// </param>
/// <param name="signal_id">
/// Signal the handlers have to be connected to.
/// </param>
/// <param name="detail">
/// Signal detail the handlers have to be connected to.
/// </param>
/// <param name="closure">
/// The closure the handlers will invoke.
/// </param>
/// <param name="func">
/// The C closure callback of the handlers (useless for non-C closures).
/// </param>
/// <param name="data">
/// The closure data of the handlers&apos; closures.
/// </param>
/// <return>
/// The number of handlers that matched.
/// </return>

	public static uint SignalHandlersDisconnectMatched(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handlers_disconnect_matched(instance, mask, signal_id, detail, closure, func, data);
	}

/// <summary>
/// <para>
/// Unblocks all handlers on an instance that match a certain selection
/// criteria.
/// </para>
/// <para>
/// The criteria mask is passed as a combination of #GSignalMatchType flags, and
/// the criteria values are passed as arguments. A handler must match on all
/// flags set in @mask to be unblocked (i.e. the match is conjunctive).
/// </para>
/// <para>
/// Passing at least one of the %G_SIGNAL_MATCH_ID, %G_SIGNAL_MATCH_CLOSURE,
/// %G_SIGNAL_MATCH_FUNC
/// or %G_SIGNAL_MATCH_DATA match flags is required for successful matches.
/// If no handlers were found, 0 is returned, the number of unblocked handlers
/// otherwise. The match criteria should not apply to any handlers that are
/// not currently blocked.
/// </para>
/// <para>
/// Support for %G_SIGNAL_MATCH_ID was added in GLib 2.78.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to unblock handlers from.
/// </param>
/// <param name="mask">
/// Mask indicating which of @signal_id, @detail, @closure, @func
///  and/or @data the handlers have to match.
/// </param>
/// <param name="signal_id">
/// Signal the handlers have to be connected to.
/// </param>
/// <param name="detail">
/// Signal detail the handlers have to be connected to.
/// </param>
/// <param name="closure">
/// The closure the handlers will invoke.
/// </param>
/// <param name="func">
/// The C closure callback of the handlers (useless for non-C closures).
/// </param>
/// <param name="data">
/// The closure data of the handlers&apos; closures.
/// </param>
/// <return>
/// The number of handlers that matched.
/// </return>

	public static uint SignalHandlersUnblockMatched(MentorLake.GObject.GObjectHandle instance, MentorLake.GObject.GSignalMatchType mask, uint signal_id, MentorLake.GLib.GQuark detail, MentorLake.GObject.GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectGlobalFunctionsExterns.g_signal_handlers_unblock_matched(instance, mask, signal_id, detail, closure, func, data);
	}

/// <summary>
/// <para>
/// Returns whether there are any handlers connected to @instance for the
/// given signal id and detail.
/// </para>
/// <para>
/// If @detail is 0 then it will only match handlers that were connected
/// without detail.  If @detail is non-zero then it will match handlers
/// connected both without detail and with the given detail.  This is
/// consistent with how a signal emitted with @detail would be delivered
/// to those handlers.
/// </para>
/// <para>
/// Since 2.46 this also checks for a non-default class closure being
/// installed, as this is basically always what you want.
/// </para>
/// <para>
/// One example of when you might use this is when the arguments to the
/// signal are difficult to compute. A class implementor may opt to not
/// emit the signal if no one is attached anyway, thus saving the cost
/// of building the arguments.
/// </para>
/// </summary>

/// <param name="instance">
/// the object whose signal handlers are sought.
/// </param>
/// <param name="signal_id">
/// the signal id.
/// </param>
/// <param name="detail">
/// the detail.
/// </param>
/// <param name="may_be_blocked">
/// whether blocked handlers should count as match.
/// </param>
/// <return>
/// %TRUE if a handler is connected to the signal, %FALSE
///          otherwise.
/// </return>

	public static bool SignalHasHandlerPending(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail, bool may_be_blocked)
	{
		return GObjectGlobalFunctionsExterns.g_signal_has_handler_pending(instance, signal_id, detail, may_be_blocked);
	}

/// <summary>
/// <para>
/// Validate a signal name. This can be useful for dynamically-generated signals
/// which need to be validated at run-time before actually trying to create them.
/// </para>
/// <para>
/// See [func@GObject.signal_new] for details of the rules for valid names.
/// The rules for signal names are the same as those for property names.
/// </para>
/// </summary>

/// <param name="name">
/// the canonical name of the signal
/// </param>
/// <return>
/// %TRUE if @name is a valid signal name, %FALSE otherwise.
/// </return>

	public static bool SignalIsValidName(string name)
	{
		return GObjectGlobalFunctionsExterns.g_signal_is_valid_name(name);
	}

/// <summary>
/// <para>
/// Lists the signals by id that a certain instance or interface type
/// created. Further information about the signals can be acquired through
/// g_signal_query().
/// </para>
/// </summary>

/// <param name="itype">
/// Instance or interface type.
/// </param>
/// <param name="n_ids">
/// Location to store the number of signal ids for @itype.
/// </param>
/// <return>
/// Newly allocated array of signal IDs.
/// </return>

	public static uint[] SignalListIds(MentorLake.GObject.GType itype, out uint n_ids)
	{
		return GObjectGlobalFunctionsExterns.g_signal_list_ids(itype, out n_ids);
	}

/// <summary>
/// <para>
/// Given the name of the signal and the type of object it connects to, gets
/// the signal&apos;s identifying integer. Emitting the signal by number is
/// somewhat faster than using the name each time.
/// </para>
/// <para>
/// Also tries the ancestors of the given type.
/// </para>
/// <para>
/// The type class passed as @itype must already have been instantiated (for
/// example, using g_type_class_ref()) for this function to work, as signals are
/// always installed during class initialization.
/// </para>
/// <para>
/// See g_signal_new() for details on allowed signal names.
/// </para>
/// </summary>

/// <param name="name">
/// the signal&apos;s name.
/// </param>
/// <param name="itype">
/// the type that the signal operates on.
/// </param>
/// <return>
/// the signal&apos;s identifying number, or 0 if no signal was found.
/// </return>

	public static uint SignalLookup(string name, MentorLake.GObject.GType itype)
	{
		return GObjectGlobalFunctionsExterns.g_signal_lookup(name, itype);
	}

/// <summary>
/// <para>
/// Given the signal&apos;s identifier, finds its name.
/// </para>
/// <para>
/// Two different signals may have the same name, if they have differing types.
/// </para>
/// </summary>

/// <param name="signal_id">
/// the signal&apos;s identifying number.
/// </param>
/// <return>
/// the signal name, or %NULL if the signal number was invalid.
/// </return>

	public static string SignalName(uint signal_id)
	{
		return GObjectGlobalFunctionsExterns.g_signal_name(signal_id);
	}

/// <summary>
/// <para>
/// Creates a new signal. (This is usually done in the class initializer.)
/// </para>
/// <para>
/// A signal name consists of segments consisting of ASCII letters and
/// digits, separated by either the `-` or `_` character. The first
/// character of a signal name must be a letter. Names which violate these
/// rules lead to undefined behaviour. These are the same rules as for property
/// naming (see g_param_spec_internal()).
/// </para>
/// <para>
/// When registering a signal and looking up a signal, either separator can
/// be used, but they cannot be mixed. Using `-` is considerably more efficient.
/// Using `_` is discouraged.
/// </para>
/// <para>
/// If 0 is used for @class_offset subclasses cannot override the class handler
/// in their class_init method by doing super_class-&amp;gt;signal_handler = my_signal_handler.
/// Instead they will have to use g_signal_override_class_handler().
/// </para>
/// <para>
/// If @c_marshaller is %NULL, g_cclosure_marshal_generic() will be used as
/// the marshaller for this signal. In some simple cases, g_signal_new()
/// will use a more optimized c_marshaller and va_marshaller for the signal
/// instead of g_cclosure_marshal_generic().
/// </para>
/// <para>
/// If @c_marshaller is non-%NULL, you need to also specify a va_marshaller
/// using g_signal_set_va_marshaller() or the generic va_marshaller will
/// be used.
/// </para>
/// </summary>

/// <param name="signal_name">
/// the name for the signal
/// </param>
/// <param name="itype">
/// the type this signal pertains to. It will also pertain to
///  types which are derived from this type.
/// </param>
/// <param name="signal_flags">
/// a combination of #GSignalFlags specifying detail of when
///  the default handler is to be invoked. You should at least specify
///  %G_SIGNAL_RUN_FIRST or %G_SIGNAL_RUN_LAST.
/// </param>
/// <param name="class_offset">
/// The offset of the function pointer in the class structure
///  for this type. Used to invoke a class method generically. Pass 0 to
///  not associate a class method slot with this signal.
/// </param>
/// <param name="accumulator">
/// the accumulator for this signal; may be %NULL.
/// </param>
/// <param name="accu_data">
/// user data for the @accumulator.
/// </param>
/// <param name="c_marshaller">
/// the function to translate arrays of parameter
///  values to signal emissions into C language callback invocations or %NULL.
/// </param>
/// <param name="return_type">
/// the type of return value, or %G_TYPE_NONE for a signal
///  without a return value.
/// </param>
/// <param name="n_params">
/// the number of parameter types to follow.
/// </param>
/// <param name="@__arglist">
/// a list of types, one for each parameter.
/// </param>
/// <return>
/// the signal id
/// </return>

	public static uint SignalNew(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, uint class_offset, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist)
	{
		return GObjectGlobalFunctionsExterns.g_signal_new(signal_name, itype, signal_flags, class_offset, accumulator, accu_data, c_marshaller, return_type, n_params, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new signal. (This is usually done in the class initializer.)
/// </para>
/// <para>
/// This is a variant of g_signal_new() that takes a C callback instead
/// of a class offset for the signal&apos;s class handler. This function
/// doesn&apos;t need a function pointer exposed in the class structure of
/// an object definition, instead the function pointer is passed
/// directly and can be overridden by derived classes with
/// g_signal_override_class_closure() or
/// g_signal_override_class_handler() and chained to with
/// g_signal_chain_from_overridden() or
/// g_signal_chain_from_overridden_handler().
/// </para>
/// <para>
/// See g_signal_new() for information about signal names.
/// </para>
/// <para>
/// If c_marshaller is %NULL, g_cclosure_marshal_generic() will be used as
/// the marshaller for this signal.
/// </para>
/// </summary>

/// <param name="signal_name">
/// the name for the signal
/// </param>
/// <param name="itype">
/// the type this signal pertains to. It will also pertain to
///  types which are derived from this type.
/// </param>
/// <param name="signal_flags">
/// a combination of #GSignalFlags specifying detail of when
///  the default handler is to be invoked. You should at least specify
///  %G_SIGNAL_RUN_FIRST or %G_SIGNAL_RUN_LAST.
/// </param>
/// <param name="class_handler">
/// a #GCallback which acts as class implementation of
///  this signal. Used to invoke a class method generically. Pass %NULL to
///  not associate a class method with this signal.
/// </param>
/// <param name="accumulator">
/// the accumulator for this signal; may be %NULL.
/// </param>
/// <param name="accu_data">
/// user data for the @accumulator.
/// </param>
/// <param name="c_marshaller">
/// the function to translate arrays of parameter
///  values to signal emissions into C language callback invocations or %NULL.
/// </param>
/// <param name="return_type">
/// the type of return value, or %G_TYPE_NONE for a signal
///  without a return value.
/// </param>
/// <param name="n_params">
/// the number of parameter types to follow.
/// </param>
/// <param name="@__arglist">
/// a list of types, one for each parameter.
/// </param>
/// <return>
/// the signal id
/// </return>

	public static uint SignalNewClassHandler(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GCallback class_handler, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist)
	{
		return GObjectGlobalFunctionsExterns.g_signal_new_class_handler(signal_name, itype, signal_flags, class_handler, accumulator, accu_data, c_marshaller, return_type, n_params, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new signal. (This is usually done in the class initializer.)
/// </para>
/// <para>
/// See g_signal_new() for details on allowed signal names.
/// </para>
/// <para>
/// If c_marshaller is %NULL, g_cclosure_marshal_generic() will be used as
/// the marshaller for this signal.
/// </para>
/// </summary>

/// <param name="signal_name">
/// the name for the signal
/// </param>
/// <param name="itype">
/// the type this signal pertains to. It will also pertain to
///  types which are derived from this type.
/// </param>
/// <param name="signal_flags">
/// a combination of #GSignalFlags specifying detail of when
///  the default handler is to be invoked. You should at least specify
///  %G_SIGNAL_RUN_FIRST or %G_SIGNAL_RUN_LAST.
/// </param>
/// <param name="class_closure">
/// The closure to invoke on signal emission; may be %NULL.
/// </param>
/// <param name="accumulator">
/// the accumulator for this signal; may be %NULL.
/// </param>
/// <param name="accu_data">
/// user data for the @accumulator.
/// </param>
/// <param name="c_marshaller">
/// the function to translate arrays of parameter
///  values to signal emissions into C language callback invocations or %NULL.
/// </param>
/// <param name="return_type">
/// the type of return value, or %G_TYPE_NONE for a signal
///  without a return value.
/// </param>
/// <param name="n_params">
/// the number of parameter types in @args.
/// </param>
/// <param name="args">
/// va_list of #GType, one for each parameter.
/// </param>
/// <return>
/// the signal id
/// </return>

	public static uint SignalNewValist(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GClosureHandle class_closure, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, IntPtr args)
	{
		return GObjectGlobalFunctionsExterns.g_signal_new_valist(signal_name, itype, signal_flags, class_closure, accumulator, accu_data, c_marshaller, return_type, n_params, args);
	}

/// <summary>
/// <para>
/// Creates a new signal. (This is usually done in the class initializer.)
/// </para>
/// <para>
/// See g_signal_new() for details on allowed signal names.
/// </para>
/// <para>
/// If c_marshaller is %NULL, g_cclosure_marshal_generic() will be used as
/// the marshaller for this signal.
/// </para>
/// </summary>

/// <param name="signal_name">
/// the name for the signal
/// </param>
/// <param name="itype">
/// the type this signal pertains to. It will also pertain to
///     types which are derived from this type
/// </param>
/// <param name="signal_flags">
/// a combination of #GSignalFlags specifying detail of when
///     the default handler is to be invoked. You should at least specify
///     %G_SIGNAL_RUN_FIRST or %G_SIGNAL_RUN_LAST
/// </param>
/// <param name="class_closure">
/// The closure to invoke on signal emission;
///     may be %NULL
/// </param>
/// <param name="accumulator">
/// the accumulator for this signal; may be %NULL
/// </param>
/// <param name="accu_data">
/// user data for the @accumulator
/// </param>
/// <param name="c_marshaller">
/// the function to translate arrays of
///     parameter values to signal emissions into C language callback
///     invocations or %NULL
/// </param>
/// <param name="return_type">
/// the type of return value, or %G_TYPE_NONE for a signal
///     without a return value
/// </param>
/// <param name="n_params">
/// the length of @param_types
/// </param>
/// <param name="param_types">
/// an array of types, one for
///     each parameter (may be %NULL if @n_params is zero)
/// </param>
/// <return>
/// the signal id
/// </return>

	public static uint SignalNewv(string signal_name, MentorLake.GObject.GType itype, MentorLake.GObject.GSignalFlags signal_flags, MentorLake.GObject.GClosureHandle class_closure, MentorLake.GObject.GSignalAccumulator accumulator, IntPtr accu_data, MentorLake.GObject.GSignalCMarshaller c_marshaller, MentorLake.GObject.GType return_type, uint n_params, MentorLake.GObject.GType[] param_types)
	{
		return GObjectGlobalFunctionsExterns.g_signal_newv(signal_name, itype, signal_flags, class_closure, accumulator, accu_data, c_marshaller, return_type, n_params, param_types);
	}

/// <summary>
/// <para>
/// Overrides the class closure (i.e. the default handler) for the given signal
/// for emissions on instances of @instance_type. @instance_type must be derived
/// from the type to which the signal belongs.
/// </para>
/// <para>
/// See g_signal_chain_from_overridden() and
/// g_signal_chain_from_overridden_handler() for how to chain up to the
/// parent class closure from inside the overridden one.
/// </para>
/// </summary>

/// <param name="signal_id">
/// the signal id
/// </param>
/// <param name="instance_type">
/// the instance type on which to override the class closure
///  for the signal.
/// </param>
/// <param name="class_closure">
/// the closure.
/// </param>

	public static void SignalOverrideClassClosure(uint signal_id, MentorLake.GObject.GType instance_type, MentorLake.GObject.GClosureHandle class_closure)
	{
		GObjectGlobalFunctionsExterns.g_signal_override_class_closure(signal_id, instance_type, class_closure);
	}

/// <summary>
/// <para>
/// Overrides the class closure (i.e. the default handler) for the
/// given signal for emissions on instances of @instance_type with
/// callback @class_handler. @instance_type must be derived from the
/// type to which the signal belongs.
/// </para>
/// <para>
/// See g_signal_chain_from_overridden() and
/// g_signal_chain_from_overridden_handler() for how to chain up to the
/// parent class closure from inside the overridden one.
/// </para>
/// </summary>

/// <param name="signal_name">
/// the name for the signal
/// </param>
/// <param name="instance_type">
/// the instance type on which to override the class handler
///  for the signal.
/// </param>
/// <param name="class_handler">
/// the handler.
/// </param>

	public static void SignalOverrideClassHandler(string signal_name, MentorLake.GObject.GType instance_type, MentorLake.GObject.GCallback class_handler)
	{
		GObjectGlobalFunctionsExterns.g_signal_override_class_handler(signal_name, instance_type, class_handler);
	}

/// <summary>
/// <para>
/// Internal function to parse a signal name into its @signal_id
/// and @detail quark.
/// </para>
/// </summary>

/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;.
/// </param>
/// <param name="itype">
/// The interface/instance type that introduced &quot;signal-name&quot;.
/// </param>
/// <param name="signal_id_p">
/// Location to store the signal id.
/// </param>
/// <param name="detail_p">
/// Location to store the detail quark.
/// </param>
/// <param name="force_detail_quark">
/// %TRUE forces creation of a #GQuark for the detail.
/// </param>
/// <return>
/// Whether the signal name could successfully be parsed and @signal_id_p and @detail_p contain valid return values.
/// </return>

	public static bool SignalParseName(string detailed_signal, MentorLake.GObject.GType itype, out uint signal_id_p, out MentorLake.GLib.GQuark detail_p, bool force_detail_quark)
	{
		return GObjectGlobalFunctionsExterns.g_signal_parse_name(detailed_signal, itype, out signal_id_p, out detail_p, force_detail_quark);
	}

/// <summary>
/// <para>
/// Queries the signal system for in-depth information about a
/// specific signal. This function will fill in a user-provided
/// structure to hold signal-specific information. If an invalid
/// signal id is passed in, the @signal_id member of the #GSignalQuery
/// is 0. All members filled into the #GSignalQuery structure should
/// be considered constant and have to be left untouched.
/// </para>
/// </summary>

/// <param name="signal_id">
/// The signal id of the signal to query information for.
/// </param>
/// <param name="query">
/// A user provided structure that is
///  filled in with constant values upon success.
/// </param>

	public static void SignalQuery(uint signal_id, out MentorLake.GObject.GSignalQuery query)
	{
		GObjectGlobalFunctionsExterns.g_signal_query(signal_id, out query);
	}

/// <summary>
/// <para>
/// Deletes an emission hook.
/// </para>
/// </summary>

/// <param name="signal_id">
/// the id of the signal
/// </param>
/// <param name="hook_id">
/// the id of the emission hook, as returned by
///  g_signal_add_emission_hook()
/// </param>

	public static void SignalRemoveEmissionHook(uint signal_id, ulong hook_id)
	{
		GObjectGlobalFunctionsExterns.g_signal_remove_emission_hook(signal_id, hook_id);
	}

/// <summary>
/// <para>
/// Change the #GSignalCVaMarshaller used for a given signal.  This is a
/// specialised form of the marshaller that can often be used for the
/// common case of a single connected signal handler and avoids the
/// overhead of #GValue.  Its use is optional.
/// </para>
/// </summary>

/// <param name="signal_id">
/// the signal id
/// </param>
/// <param name="instance_type">
/// the instance type on which to set the marshaller.
/// </param>
/// <param name="va_marshaller">
/// the marshaller to set.
/// </param>

	public static void SignalSetVaMarshaller(uint signal_id, MentorLake.GObject.GType instance_type, MentorLake.GObject.GSignalCVaMarshaller va_marshaller)
	{
		GObjectGlobalFunctionsExterns.g_signal_set_va_marshaller(signal_id, instance_type, va_marshaller);
	}

/// <summary>
/// <para>
/// Stops a signal&apos;s current emission.
/// </para>
/// <para>
/// This will prevent the default method from running, if the signal was
/// %G_SIGNAL_RUN_LAST and you connected normally (i.e. without the &quot;after&quot;
/// flag).
/// </para>
/// <para>
/// Prints a warning if used on a signal which isn&apos;t being emitted.
/// </para>
/// </summary>

/// <param name="instance">
/// the object whose signal handlers you wish to stop.
/// </param>
/// <param name="signal_id">
/// the signal identifier, as returned by g_signal_lookup().
/// </param>
/// <param name="detail">
/// the detail which the signal was emitted with.
/// </param>

	public static void SignalStopEmission(MentorLake.GObject.GObjectHandle instance, uint signal_id, MentorLake.GLib.GQuark detail)
	{
		GObjectGlobalFunctionsExterns.g_signal_stop_emission(instance, signal_id, detail);
	}

/// <summary>
/// <para>
/// Stops a signal&apos;s current emission.
/// </para>
/// <para>
/// This is just like g_signal_stop_emission() except it will look up the
/// signal id for you.
/// </para>
/// </summary>

/// <param name="instance">
/// the object whose signal handlers you wish to stop.
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;.
/// </param>

	public static void SignalStopEmissionByName(MentorLake.GObject.GObjectHandle instance, string detailed_signal)
	{
		GObjectGlobalFunctionsExterns.g_signal_stop_emission_by_name(instance, detailed_signal);
	}

/// <summary>
/// <para>
/// Creates a new closure which invokes the function found at the offset
/// @struct_offset in the class structure of the interface or classed type
/// identified by @itype.
/// </para>
/// </summary>

/// <param name="itype">
/// the #GType identifier of an interface or classed type
/// </param>
/// <param name="struct_offset">
/// the offset of the member function of @itype&apos;s class
///  structure which is to be invoked by the new closure
/// </param>
/// <return>
/// a floating reference to a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle SignalTypeCclosureNew(MentorLake.GObject.GType itype, uint struct_offset)
	{
		return GObjectGlobalFunctionsExterns.g_signal_type_cclosure_new(itype, struct_offset);
	}

/// <summary>
/// <para>
/// Set the callback for a source as a #GClosure.
/// </para>
/// <para>
/// If the source is not one of the standard GLib types, the @closure_callback
/// and @closure_marshal fields of the #GSourceFuncs structure must have been
/// filled in with pointers to appropriate functions.
/// </para>
/// </summary>

/// <param name="source">
/// the source
/// </param>
/// <param name="closure">
/// a #GClosure
/// </param>

	public static void SourceSetClosure(MentorLake.GLib.GSourceHandle source, MentorLake.GObject.GClosureHandle closure)
	{
		GObjectGlobalFunctionsExterns.g_source_set_closure(source, closure);
	}

/// <summary>
/// <para>
/// Sets a dummy callback for @source. The callback will do nothing, and
/// if the source expects a #gboolean return value, it will return %TRUE.
/// (If the source expects any other type of return value, it will return
/// a 0/%NULL value; whatever g_value_init() initializes a #GValue to for
/// that type.)
/// </para>
/// <para>
/// If the source is not one of the standard GLib types, the
/// @closure_callback and @closure_marshal fields of the #GSourceFuncs
/// structure must have been filled in with pointers to appropriate
/// functions.
/// </para>
/// </summary>

/// <param name="source">
/// the source
/// </param>

	public static void SourceSetDummyCallback(MentorLake.GLib.GSourceHandle source)
	{
		GObjectGlobalFunctionsExterns.g_source_set_dummy_callback(source);
	}

/// <summary>
/// <para>
/// Return a newly allocated string, which describes the contents of a
/// #GValue.  The main purpose of this function is to describe #GValue
/// contents for debugging output, the way in which the contents are
/// described may change between different GLib versions.
/// </para>
/// </summary>

/// <param name="value">
/// #GValue which contents are to be described.
/// </param>
/// <return>
/// Newly allocated string.
/// </return>

	public static string StrdupValueContents(MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_strdup_value_contents(value);
	}

/// <summary>
/// <para>
/// Adds a #GTypeClassCacheFunc to be called before the reference count of a
/// class goes from one to zero. This can be used to prevent premature class
/// destruction. All installed #GTypeClassCacheFunc functions will be chained
/// until one of them returns %TRUE. The functions have to check the class id
/// passed in to figure whether they actually want to cache the class of this
/// type, since all classes are routed through the same #GTypeClassCacheFunc
/// chain.
/// </para>
/// </summary>

/// <param name="cache_data">
/// data to be passed to @cache_func
/// </param>
/// <param name="cache_func">
/// a #GTypeClassCacheFunc
/// </param>

	public static void TypeAddClassCacheFunc(IntPtr cache_data, MentorLake.GObject.GTypeClassCacheFunc cache_func)
	{
		GObjectGlobalFunctionsExterns.g_type_add_class_cache_func(cache_data, cache_func);
	}

/// <summary>
/// <para>
/// Registers a private class structure for a classed type;
/// when the class is allocated, the private structures for
/// the class and all of its parent types are allocated
/// sequentially in the same memory block as the public
/// structures, and are zero-filled.
/// </para>
/// <para>
/// This function should be called in the
/// type&apos;s get_type() function after the type is registered.
/// The private structure can be retrieved using the
/// G_TYPE_CLASS_GET_PRIVATE() macro.
/// </para>
/// </summary>

/// <param name="class_type">
/// GType of a classed type
/// </param>
/// <param name="private_size">
/// size of private structure
/// </param>

	public static void TypeAddClassPrivate(MentorLake.GObject.GType class_type, UIntPtr private_size)
	{
		GObjectGlobalFunctionsExterns.g_type_add_class_private(class_type, private_size);
	}


/// <param name="class_type">
/// </param>
/// <param name="private_size">
/// </param>

	public static int TypeAddInstancePrivate(MentorLake.GObject.GType class_type, UIntPtr private_size)
	{
		return GObjectGlobalFunctionsExterns.g_type_add_instance_private(class_type, private_size);
	}

/// <summary>
/// <para>
/// Adds a function to be called after an interface vtable is
/// initialized for any class (i.e. after the @interface_init
/// member of #GInterfaceInfo has been called).
/// </para>
/// <para>
/// This function is useful when you want to check an invariant
/// that depends on the interfaces of a class. For instance, the
/// implementation of #GObject uses this facility to check that an
/// object implements all of the properties that are defined on its
/// interfaces.
/// </para>
/// </summary>

/// <param name="check_data">
/// data to pass to @check_func
/// </param>
/// <param name="check_func">
/// function to be called after each interface
///     is initialized
/// </param>

	public static void TypeAddInterfaceCheck(IntPtr check_data, MentorLake.GObject.GTypeInterfaceCheckFunc check_func)
	{
		GObjectGlobalFunctionsExterns.g_type_add_interface_check(check_data, check_func);
	}

/// <summary>
/// <para>
/// Adds @interface_type to the dynamic @instance_type. The information
/// contained in the #GTypePlugin structure pointed to by @plugin
/// is used to manage the relationship.
/// </para>
/// </summary>

/// <param name="instance_type">
/// #GType value of an instantiatable type
/// </param>
/// <param name="interface_type">
/// #GType value of an interface type
/// </param>
/// <param name="plugin">
/// #GTypePlugin structure to retrieve the #GInterfaceInfo from
/// </param>

	public static void TypeAddInterfaceDynamic(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GTypePluginHandle plugin)
	{
		GObjectGlobalFunctionsExterns.g_type_add_interface_dynamic(instance_type, interface_type, plugin);
	}

/// <summary>
/// <para>
/// Adds @interface_type to the static @instance_type.
/// The information contained in the #GInterfaceInfo structure
/// pointed to by @info is used to manage the relationship.
/// </para>
/// </summary>

/// <param name="instance_type">
/// #GType value of an instantiatable type
/// </param>
/// <param name="interface_type">
/// #GType value of an interface type
/// </param>
/// <param name="info">
/// #GInterfaceInfo structure for this
///        (@instance_type, @interface_type) combination
/// </param>

	public static void TypeAddInterfaceStatic(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GInterfaceInfoHandle info)
	{
		GObjectGlobalFunctionsExterns.g_type_add_interface_static(instance_type, interface_type, info);
	}


/// <param name="g_class">
/// </param>
/// <param name="is_a_type">
/// </param>

	public static MentorLake.GObject.GTypeClassHandle TypeCheckClassCast(MentorLake.GObject.GTypeClassHandle g_class, MentorLake.GObject.GType is_a_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_class_cast(g_class, is_a_type);
	}


/// <param name="g_class">
/// </param>
/// <param name="is_a_type">
/// </param>

	public static bool TypeCheckClassIsA(MentorLake.GObject.GTypeClassHandle g_class, MentorLake.GObject.GType is_a_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_class_is_a(g_class, is_a_type);
	}

/// <summary>
/// <para>
/// Private helper function to aid implementation of the
/// G_TYPE_CHECK_INSTANCE() macro.
/// </para>
/// </summary>

/// <param name="instance">
/// a valid #GTypeInstance structure
/// </param>
/// <return>
/// %TRUE if @instance is valid, %FALSE otherwise
/// </return>

	public static bool TypeCheckInstance(MentorLake.GObject.GTypeInstanceHandle instance)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance(instance);
	}


/// <param name="instance">
/// </param>
/// <param name="iface_type">
/// </param>

	public static MentorLake.GObject.GTypeInstanceHandle TypeCheckInstanceCast(MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType iface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance_cast(instance, iface_type);
	}


/// <param name="instance">
/// </param>
/// <param name="iface_type">
/// </param>

	public static bool TypeCheckInstanceIsA(MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType iface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance_is_a(instance, iface_type);
	}


/// <param name="instance">
/// </param>
/// <param name="fundamental_type">
/// </param>

	public static bool TypeCheckInstanceIsFundamentallyA(MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType fundamental_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_instance_is_fundamentally_a(instance, fundamental_type);
	}


/// <param name="type">
/// </param>

	public static bool TypeCheckIsValueType(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_is_value_type(type);
	}


/// <param name="value">
/// </param>

	public static bool TypeCheckValue(MentorLake.GObject.GValueHandle value)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_value(value);
	}


/// <param name="value">
/// </param>
/// <param name="type">
/// </param>

	public static bool TypeCheckValueHolds(MentorLake.GObject.GValueHandle value, MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_check_value_holds(value, type);
	}

/// <summary>
/// <para>
/// Return a newly allocated and 0-terminated array of type IDs, listing
/// the child types of @type.
/// </para>
/// </summary>

/// <param name="type">
/// the parent type
/// </param>
/// <param name="n_children">
/// location to store the length of
///     the returned array, or %NULL
/// </param>
/// <return>
/// Newly allocated
///     and 0-terminated array of child types, free with g_free()
/// </return>

	public static MentorLake.GObject.GType[] TypeChildren(MentorLake.GObject.GType type, out uint n_children)
	{
		return GObjectGlobalFunctionsExterns.g_type_children(type, out n_children);
	}


/// <param name="g_class">
/// </param>
/// <param name="private_size_or_offset">
/// </param>

	public static void TypeClassAdjustPrivateOffset(IntPtr g_class, int private_size_or_offset)
	{
		GObjectGlobalFunctionsExterns.g_type_class_adjust_private_offset(g_class, private_size_or_offset);
	}

/// <summary>
/// <para>
/// This function is essentially the same as g_type_class_ref(),
/// except that the classes reference count isn&apos;t incremented.
/// As a consequence, this function may return %NULL if the class
/// of the type passed in does not currently exist (hasn&apos;t been
/// referenced before).
/// </para>
/// </summary>

/// <param name="type">
/// type ID of a classed type
/// </param>
/// <return>
/// the #GTypeClass
///     structure for the given type ID or %NULL if the class does not
///     currently exist
/// </return>

	public static MentorLake.GObject.GTypeClassHandle TypeClassPeek(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_class_peek(type);
	}

/// <summary>
/// <para>
/// A more efficient version of g_type_class_peek() which works only for
/// static types.
/// </para>
/// </summary>

/// <param name="type">
/// type ID of a classed type
/// </param>
/// <return>
/// the #GTypeClass
///     structure for the given type ID or %NULL if the class does not
///     currently exist or is dynamically loaded
/// </return>

	public static MentorLake.GObject.GTypeClassHandle TypeClassPeekStatic(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_class_peek_static(type);
	}

/// <summary>
/// <para>
/// Increments the reference count of the class structure belonging to
/// @type. This function will demand-create the class if it doesn&apos;t
/// exist already.
/// </para>
/// </summary>

/// <param name="type">
/// type ID of a classed type
/// </param>
/// <return>
/// the #GTypeClass
///     structure for the given type ID
/// </return>

	public static MentorLake.GObject.GTypeClassHandle TypeClassRef(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_class_ref(type);
	}

/// <summary>
/// <para>
/// Creates and initializes an instance of @type if @type is valid and
/// can be instantiated. The type system only performs basic allocation
/// and structure setups for instances: actual instance creation should
/// happen through functions supplied by the type&apos;s fundamental type
/// implementation.  So use of g_type_create_instance() is reserved for
/// implementers of fundamental types only. E.g. instances of the
/// #GObject hierarchy should be created via g_object_new() and never
/// directly through g_type_create_instance() which doesn&apos;t handle things
/// like singleton objects or object construction.
/// </para>
/// <para>
/// The extended members of the returned instance are guaranteed to be filled
/// with zeros.
/// </para>
/// <para>
/// Note: Do not use this function, unless you&apos;re implementing a
/// fundamental type. Also language bindings should not use this
/// function, but g_object_new() instead.
/// </para>
/// </summary>

/// <param name="type">
/// an instantiatable type to create an instance for
/// </param>
/// <return>
/// an allocated and initialized instance, subject to further
///     treatment by the fundamental type implementation
/// </return>

	public static MentorLake.GObject.GTypeInstanceHandle TypeCreateInstance(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_create_instance(type);
	}

/// <summary>
/// <para>
/// If the interface type @g_type is currently in use, returns its
/// default interface vtable.
/// </para>
/// </summary>

/// <param name="g_type">
/// an interface type
/// </param>
/// <return>
/// the default
///     vtable for the interface, or %NULL if the type is not currently
///     in use
/// </return>

	public static MentorLake.GObject.GTypeInterfaceHandle TypeDefaultInterfacePeek(MentorLake.GObject.GType g_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_default_interface_peek(g_type);
	}

/// <summary>
/// <para>
/// Increments the reference count for the interface type @g_type,
/// and returns the default interface vtable for the type.
/// </para>
/// <para>
/// If the type is not currently in use, then the default vtable
/// for the type will be created and initialized by calling
/// the base interface init and default vtable init functions for
/// the type (the @base_init and @class_init members of #GTypeInfo).
/// Calling g_type_default_interface_ref() is useful when you
/// want to make sure that signals and properties for an interface
/// have been installed.
/// </para>
/// </summary>

/// <param name="g_type">
/// an interface type
/// </param>
/// <return>
/// the default
///     vtable for the interface; call g_type_default_interface_unref()
///     when you are done using the interface.
/// </return>

	public static MentorLake.GObject.GTypeInterfaceHandle TypeDefaultInterfaceRef(MentorLake.GObject.GType g_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_default_interface_ref(g_type);
	}

/// <summary>
/// <para>
/// Decrements the reference count for the type corresponding to the
/// interface default vtable @g_iface. If the type is dynamic, then
/// when no one is using the interface and all references have
/// been released, the finalize function for the interface&apos;s default
/// vtable (the @class_finalize member of #GTypeInfo) will be called.
/// </para>
/// </summary>

/// <param name="g_iface">
/// the default vtable
///     structure for an interface, as returned by g_type_default_interface_ref()
/// </param>

	public static void TypeDefaultInterfaceUnref(MentorLake.GObject.GTypeInterfaceHandle g_iface)
	{
		GObjectGlobalFunctionsExterns.g_type_default_interface_unref(g_iface);
	}

/// <summary>
/// <para>
/// Returns the length of the ancestry of the passed in type. This
/// includes the type itself, so that e.g. a fundamental type has depth 1.
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>
/// <return>
/// the depth of @type
/// </return>

	public static uint TypeDepth(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_depth(type);
	}

/// <summary>
/// <para>
/// Ensures that the indicated @type has been registered with the
/// type system, and its _class_init() method has been run.
/// </para>
/// <para>
/// In theory, simply calling the type&apos;s _get_type() method (or using
/// the corresponding macro) is supposed take care of this. However,
/// _get_type() methods are often marked %G_GNUC_CONST for performance
/// reasons, even though this is technically incorrect (since
/// %G_GNUC_CONST requires that the function not have side effects,
/// which _get_type() methods do on the first call). As a result, if
/// you write a bare call to a _get_type() macro, it may get optimized
/// out by the compiler. Using g_type_ensure() guarantees that the
/// type&apos;s _get_type() method is called.
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>

	public static void TypeEnsure(MentorLake.GObject.GType type)
	{
		GObjectGlobalFunctionsExterns.g_type_ensure(type);
	}

/// <summary>
/// <para>
/// Frees an instance of a type, returning it to the instance pool for
/// the type, if there is one.
/// </para>
/// <para>
/// Like g_type_create_instance(), this function is reserved for
/// implementors of fundamental types.
/// </para>
/// </summary>

/// <param name="instance">
/// an instance of a type
/// </param>

	public static void TypeFreeInstance(MentorLake.GObject.GTypeInstanceHandle instance)
	{
		GObjectGlobalFunctionsExterns.g_type_free_instance(instance);
	}

/// <summary>
/// <para>
/// Look up the type ID from a given type name, returning 0 if no type
/// has been registered under this name (this is the preferred method
/// to find out by name whether a specific type has been registered
/// yet).
/// </para>
/// </summary>

/// <param name="name">
/// type name to look up
/// </param>
/// <return>
/// corresponding type ID or 0
/// </return>

	public static MentorLake.GObject.GType TypeFromName(string name)
	{
		return GObjectGlobalFunctionsExterns.g_type_from_name(name);
	}

/// <summary>
/// <para>
/// Internal function, used to extract the fundamental type ID portion.
/// Use G_TYPE_FUNDAMENTAL() instead.
/// </para>
/// </summary>

/// <param name="type_id">
/// valid type ID
/// </param>
/// <return>
/// fundamental type ID
/// </return>

	public static MentorLake.GObject.GType TypeFundamental(MentorLake.GObject.GType type_id)
	{
		return GObjectGlobalFunctionsExterns.g_type_fundamental(type_id);
	}

/// <summary>
/// <para>
/// Returns the next free fundamental type id which can be used to
/// register a new fundamental type with g_type_register_fundamental().
/// The returned type ID represents the highest currently registered
/// fundamental type identifier.
/// </para>
/// </summary>

/// <return>
/// the next available fundamental type ID to be registered,
///     or 0 if the type system ran out of fundamental type IDs
/// </return>

	public static MentorLake.GObject.GType TypeFundamentalNext()
	{
		return GObjectGlobalFunctionsExterns.g_type_fundamental_next();
	}

/// <summary>
/// <para>
/// Returns the number of instances allocated of the particular type;
/// this is only available if GLib is built with debugging support and
/// the `instance-count` debug flag is set (by setting the `GOBJECT_DEBUG`
/// variable to include `instance-count`).
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>
/// <return>
/// the number of instances allocated of the given type;
///   if instance counts are not available, returns 0.
/// </return>

	public static int TypeGetInstanceCount(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_get_instance_count(type);
	}

/// <summary>
/// <para>
/// Returns the #GTypePlugin structure for @type.
/// </para>
/// </summary>

/// <param name="type">
/// #GType to retrieve the plugin for
/// </param>
/// <return>
/// the corresponding plugin
///     if @type is a dynamic type, %NULL otherwise
/// </return>

	public static MentorLake.GObject.GTypePluginHandle TypeGetPlugin(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_get_plugin(type);
	}

/// <summary>
/// <para>
/// Obtains data which has previously been attached to @type
/// with g_type_set_qdata().
/// </para>
/// <para>
/// Note that this does not take subtyping into account; data
/// attached to one type with g_type_set_qdata() cannot
/// be retrieved from a subtype using g_type_get_qdata().
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>
/// <param name="quark">
/// a #GQuark id to identify the data
/// </param>
/// <return>
/// the data, or %NULL if no data was found
/// </return>

	public static IntPtr TypeGetQdata(MentorLake.GObject.GType type, MentorLake.GLib.GQuark quark)
	{
		return GObjectGlobalFunctionsExterns.g_type_get_qdata(type, quark);
	}

/// <summary>
/// <para>
/// Returns an opaque serial number that represents the state of the set
/// of registered types. Any time a type is registered this serial changes,
/// which means you can cache information based on type lookups (such as
/// g_type_from_name()) and know if the cache is still valid at a later
/// time by comparing the current serial with the one at the type lookup.
/// </para>
/// </summary>

/// <return>
/// An unsigned int, representing the state of type registrations
/// </return>

	public static uint TypeGetTypeRegistrationSerial()
	{
		return GObjectGlobalFunctionsExterns.g_type_get_type_registration_serial();
	}

/// <summary>
/// <para>
/// This function used to initialise the type system.  Since GLib 2.36,
/// the type system is initialised automatically and this function does
/// nothing.
/// </para>
/// </summary>


	public static void TypeInit()
	{
		GObjectGlobalFunctionsExterns.g_type_init();
	}

/// <summary>
/// <para>
/// This function used to initialise the type system with debugging
/// flags.  Since GLib 2.36, the type system is initialised automatically
/// and this function does nothing.
/// </para>
/// <para>
/// If you need to enable debugging features, use the `GOBJECT_DEBUG`
/// environment variable.
/// </para>
/// </summary>

/// <param name="debug_flags">
/// bitwise combination of #GTypeDebugFlags values for
///     debugging purposes
/// </param>

	public static void TypeInitWithDebugFlags(MentorLake.GObject.GTypeDebugFlags debug_flags)
	{
		GObjectGlobalFunctionsExterns.g_type_init_with_debug_flags(debug_flags);
	}

/// <summary>
/// <para>
/// Adds @prerequisite_type to the list of prerequisites of @interface_type.
/// This means that any type implementing @interface_type must also implement
/// @prerequisite_type. Prerequisites can be thought of as an alternative to
/// interface derivation (which GType doesn&apos;t support). An interface can have
/// at most one instantiatable prerequisite type.
/// </para>
/// </summary>

/// <param name="interface_type">
/// #GType value of an interface type
/// </param>
/// <param name="prerequisite_type">
/// #GType value of an interface or instantiatable type
/// </param>

	public static void TypeInterfaceAddPrerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type)
	{
		GObjectGlobalFunctionsExterns.g_type_interface_add_prerequisite(interface_type, prerequisite_type);
	}

/// <summary>
/// <para>
/// Returns the #GTypePlugin structure for the dynamic interface
/// @interface_type which has been added to @instance_type, or %NULL
/// if @interface_type has not been added to @instance_type or does
/// not have a #GTypePlugin structure. See g_type_add_interface_dynamic().
/// </para>
/// </summary>

/// <param name="instance_type">
/// #GType of an instantiatable type
/// </param>
/// <param name="interface_type">
/// #GType of an interface type
/// </param>
/// <return>
/// the #GTypePlugin for the dynamic
///     interface @interface_type of @instance_type
/// </return>

	public static MentorLake.GObject.GTypePluginHandle TypeInterfaceGetPlugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_get_plugin(instance_type, interface_type);
	}

/// <summary>
/// <para>
/// Returns the most specific instantiatable prerequisite of an
/// interface type. If the interface type has no instantiatable
/// prerequisite, %G_TYPE_INVALID is returned.
/// </para>
/// <para>
/// See g_type_interface_add_prerequisite() for more information
/// about prerequisites.
/// </para>
/// </summary>

/// <param name="interface_type">
/// an interface type
/// </param>
/// <return>
/// the instantiatable prerequisite type or %G_TYPE_INVALID if none
/// </return>

	public static MentorLake.GObject.GType TypeInterfaceInstantiatablePrerequisite(MentorLake.GObject.GType interface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_instantiatable_prerequisite(interface_type);
	}

/// <summary>
/// <para>
/// Returns the #GTypeInterface structure of an interface to which the
/// passed in class conforms.
/// </para>
/// </summary>

/// <param name="instance_class">
/// a #GTypeClass structure
/// </param>
/// <param name="iface_type">
/// an interface ID which this class conforms to
/// </param>
/// <return>
/// the #GTypeInterface
///     structure of @iface_type if implemented by @instance_class, %NULL
///     otherwise
/// </return>

	public static MentorLake.GObject.GTypeInterfaceHandle TypeInterfacePeek(MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_peek(instance_class, iface_type);
	}

/// <summary>
/// <para>
/// Returns the prerequisites of an interfaces type.
/// </para>
/// </summary>

/// <param name="interface_type">
/// an interface type
/// </param>
/// <param name="n_prerequisites">
/// location to return the number
///     of prerequisites, or %NULL
/// </param>
/// <return>
/// a
///     newly-allocated zero-terminated array of #GType containing
///     the prerequisites of @interface_type
/// </return>

	public static MentorLake.GObject.GType[] TypeInterfacePrerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites)
	{
		return GObjectGlobalFunctionsExterns.g_type_interface_prerequisites(interface_type, out n_prerequisites);
	}

/// <summary>
/// <para>
/// Return a newly allocated and 0-terminated array of type IDs, listing
/// the interface types that @type conforms to.
/// </para>
/// </summary>

/// <param name="type">
/// the type to list interface types for
/// </param>
/// <param name="n_interfaces">
/// location to store the length of
///     the returned array, or %NULL
/// </param>
/// <return>
/// Newly allocated
///     and 0-terminated array of interface types, free with g_free()
/// </return>

	public static MentorLake.GObject.GType[] TypeInterfaces(MentorLake.GObject.GType type, out uint n_interfaces)
	{
		return GObjectGlobalFunctionsExterns.g_type_interfaces(type, out n_interfaces);
	}

/// <summary>
/// <para>
/// If @is_a_type is a derivable type, check whether @type is a
/// descendant of @is_a_type. If @is_a_type is an interface, check
/// whether @type conforms to it.
/// </para>
/// </summary>

/// <param name="type">
/// type to check ancestry for
/// </param>
/// <param name="is_a_type">
/// possible ancestor of @type or interface that @type
///     could conform to
/// </param>
/// <return>
/// %TRUE if @type is a @is_a_type
/// </return>

	public static bool TypeIsA(MentorLake.GObject.GType type, MentorLake.GObject.GType is_a_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_is_a(type, is_a_type);
	}

/// <summary>
/// <para>
/// Get the unique name that is assigned to a type ID.  Note that this
/// function (like all other GType API) cannot cope with invalid type
/// IDs. %G_TYPE_INVALID may be passed to this function, as may be any
/// other validly registered type ID, but randomized type IDs should
/// not be passed in and will most likely lead to a crash.
/// </para>
/// </summary>

/// <param name="type">
/// type to return name for
/// </param>
/// <return>
/// static type name or %NULL
/// </return>

	public static string TypeName(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_name(type);
	}


/// <param name="g_class">
/// </param>

	public static string TypeNameFromClass(MentorLake.GObject.GTypeClassHandle g_class)
	{
		return GObjectGlobalFunctionsExterns.g_type_name_from_class(g_class);
	}


/// <param name="instance">
/// </param>

	public static string TypeNameFromInstance(MentorLake.GObject.GTypeInstanceHandle instance)
	{
		return GObjectGlobalFunctionsExterns.g_type_name_from_instance(instance);
	}

/// <summary>
/// <para>
/// Given a @leaf_type and a @root_type which is contained in its
/// ancestry, return the type that @root_type is the immediate parent
/// of. In other words, this function determines the type that is
/// derived directly from @root_type which is also a base class of
/// @leaf_type.  Given a root type and a leaf type, this function can
/// be used to determine the types and order in which the leaf type is
/// descended from the root type.
/// </para>
/// </summary>

/// <param name="leaf_type">
/// descendant of @root_type and the type to be returned
/// </param>
/// <param name="root_type">
/// immediate parent of the returned type
/// </param>
/// <return>
/// immediate child of @root_type and ancestor of @leaf_type
/// </return>

	public static MentorLake.GObject.GType TypeNextBase(MentorLake.GObject.GType leaf_type, MentorLake.GObject.GType root_type)
	{
		return GObjectGlobalFunctionsExterns.g_type_next_base(leaf_type, root_type);
	}

/// <summary>
/// <para>
/// Return the direct parent type of the passed in type. If the passed
/// in type has no parent, i.e. is a fundamental type, 0 is returned.
/// </para>
/// </summary>

/// <param name="type">
/// the derived type
/// </param>
/// <return>
/// the parent type
/// </return>

	public static MentorLake.GObject.GType TypeParent(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_parent(type);
	}

/// <summary>
/// <para>
/// Get the corresponding quark of the type IDs name.
/// </para>
/// </summary>

/// <param name="type">
/// type to return quark of type name for
/// </param>
/// <return>
/// the type names quark or 0
/// </return>

	public static MentorLake.GLib.GQuark TypeQname(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_qname(type);
	}

/// <summary>
/// <para>
/// Queries the type system for information about a specific type.
/// </para>
/// <para>
/// This function will fill in a user-provided structure to hold
/// type-specific information. If an invalid #GType is passed in, the
/// @type member of the #GTypeQuery is 0. All members filled into the
/// #GTypeQuery structure should be considered constant and have to be
/// left untouched.
/// </para>
/// <para>
/// Since GLib 2.78, this function allows queries on dynamic types. Previously
/// it only supported static types.
/// </para>
/// </summary>

/// <param name="type">
/// #GType of a static, classed type
/// </param>
/// <param name="query">
/// a user provided structure that is
///     filled in with constant values upon success
/// </param>

	public static void TypeQuery(MentorLake.GObject.GType type, out MentorLake.GObject.GTypeQuery query)
	{
		GObjectGlobalFunctionsExterns.g_type_query(type, out query);
	}

/// <summary>
/// <para>
/// Registers @type_name as the name of a new dynamic type derived from
/// @parent_type.  The type system uses the information contained in the
/// #GTypePlugin structure pointed to by @plugin to manage the type and its
/// instances (if not abstract).  The value of @flags determines the nature
/// (e.g. abstract or not) of the type.
/// </para>
/// </summary>

/// <param name="parent_type">
/// type from which this type will be derived
/// </param>
/// <param name="type_name">
/// 0-terminated string used as the name of the new type
/// </param>
/// <param name="plugin">
/// #GTypePlugin structure to retrieve the #GTypeInfo from
/// </param>
/// <param name="flags">
/// bitwise combination of #GTypeFlags values
/// </param>
/// <return>
/// the new type identifier or %G_TYPE_INVALID if registration failed
/// </return>

	public static MentorLake.GObject.GType TypeRegisterDynamic(MentorLake.GObject.GType parent_type, string type_name, MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_dynamic(parent_type, type_name, plugin, flags);
	}

/// <summary>
/// <para>
/// Registers @type_id as the predefined identifier and @type_name as the
/// name of a fundamental type. If @type_id is already registered, or a
/// type named @type_name is already registered, the behaviour is undefined.
/// The type system uses the information contained in the #GTypeInfo structure
/// pointed to by @info and the #GTypeFundamentalInfo structure pointed to by
/// @finfo to manage the type and its instances. The value of @flags determines
/// additional characteristics of the fundamental type.
/// </para>
/// </summary>

/// <param name="type_id">
/// a predefined type identifier
/// </param>
/// <param name="type_name">
/// 0-terminated string used as the name of the new type
/// </param>
/// <param name="info">
/// #GTypeInfo structure for this type
/// </param>
/// <param name="finfo">
/// #GTypeFundamentalInfo structure for this type
/// </param>
/// <param name="flags">
/// bitwise combination of #GTypeFlags values
/// </param>
/// <return>
/// the predefined type identifier
/// </return>

	public static MentorLake.GObject.GType TypeRegisterFundamental(MentorLake.GObject.GType type_id, string type_name, MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeFundamentalInfoHandle finfo, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_fundamental(type_id, type_name, info, finfo, flags);
	}

/// <summary>
/// <para>
/// Registers @type_name as the name of a new static type derived from
/// @parent_type. The type system uses the information contained in the
/// #GTypeInfo structure pointed to by @info to manage the type and its
/// instances (if not abstract). The value of @flags determines the nature
/// (e.g. abstract or not) of the type.
/// </para>
/// </summary>

/// <param name="parent_type">
/// type from which this type will be derived
/// </param>
/// <param name="type_name">
/// 0-terminated string used as the name of the new type
/// </param>
/// <param name="info">
/// #GTypeInfo structure for this type
/// </param>
/// <param name="flags">
/// bitwise combination of #GTypeFlags values
/// </param>
/// <return>
/// the new type identifier
/// </return>

	public static MentorLake.GObject.GType TypeRegisterStatic(MentorLake.GObject.GType parent_type, string type_name, MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_static(parent_type, type_name, info, flags);
	}

/// <summary>
/// <para>
/// Registers @type_name as the name of a new static type derived from
/// @parent_type.  The value of @flags determines the nature (e.g.
/// abstract or not) of the type. It works by filling a #GTypeInfo
/// struct and calling g_type_register_static().
/// </para>
/// </summary>

/// <param name="parent_type">
/// type from which this type will be derived
/// </param>
/// <param name="type_name">
/// 0-terminated string used as the name of the new type
/// </param>
/// <param name="class_size">
/// size of the class structure (see #GTypeInfo)
/// </param>
/// <param name="class_init">
/// location of the class initialization function (see #GTypeInfo)
/// </param>
/// <param name="instance_size">
/// size of the instance structure (see #GTypeInfo)
/// </param>
/// <param name="instance_init">
/// location of the instance initialization function (see #GTypeInfo)
/// </param>
/// <param name="flags">
/// bitwise combination of #GTypeFlags values
/// </param>
/// <return>
/// the new type identifier
/// </return>

	public static MentorLake.GObject.GType TypeRegisterStaticSimple(MentorLake.GObject.GType parent_type, string type_name, uint class_size, MentorLake.GObject.GClassInitFunc class_init, uint instance_size, MentorLake.GObject.GInstanceInitFunc instance_init, MentorLake.GObject.GTypeFlags flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_register_static_simple(parent_type, type_name, class_size, class_init, instance_size, instance_init, flags);
	}

/// <summary>
/// <para>
/// Removes a previously installed #GTypeClassCacheFunc. The cache
/// maintained by @cache_func has to be empty when calling
/// g_type_remove_class_cache_func() to avoid leaks.
/// </para>
/// </summary>

/// <param name="cache_data">
/// data that was given when adding @cache_func
/// </param>
/// <param name="cache_func">
/// a #GTypeClassCacheFunc
/// </param>

	public static void TypeRemoveClassCacheFunc(IntPtr cache_data, MentorLake.GObject.GTypeClassCacheFunc cache_func)
	{
		GObjectGlobalFunctionsExterns.g_type_remove_class_cache_func(cache_data, cache_func);
	}

/// <summary>
/// <para>
/// Removes an interface check function added with
/// g_type_add_interface_check().
/// </para>
/// </summary>

/// <param name="check_data">
/// callback data passed to g_type_add_interface_check()
/// </param>
/// <param name="check_func">
/// callback function passed to g_type_add_interface_check()
/// </param>

	public static void TypeRemoveInterfaceCheck(IntPtr check_data, MentorLake.GObject.GTypeInterfaceCheckFunc check_func)
	{
		GObjectGlobalFunctionsExterns.g_type_remove_interface_check(check_data, check_func);
	}

/// <summary>
/// <para>
/// Attaches arbitrary data to a type.
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>
/// <param name="quark">
/// a #GQuark id to identify the data
/// </param>
/// <param name="data">
/// the data
/// </param>

	public static void TypeSetQdata(MentorLake.GObject.GType type, MentorLake.GLib.GQuark quark, IntPtr data)
	{
		GObjectGlobalFunctionsExterns.g_type_set_qdata(type, quark, data);
	}


/// <param name="type">
/// </param>
/// <param name="flags">
/// </param>

	public static bool TypeTestFlags(MentorLake.GObject.GType type, uint flags)
	{
		return GObjectGlobalFunctionsExterns.g_type_test_flags(type, flags);
	}

/// <summary>
/// <para>
/// Returns the location of the #GTypeValueTable associated with @type.
/// </para>
/// <para>
/// Note that this function should only be used from source code
/// that implements or has internal knowledge of the implementation of
/// @type.
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>
/// <return>
/// location of the #GTypeValueTable associated with @type or
///     %NULL if there is no #GTypeValueTable associated with @type
/// </return>

	public static MentorLake.GObject.GTypeValueTableHandle TypeValueTablePeek(MentorLake.GObject.GType type)
	{
		return GObjectGlobalFunctionsExterns.g_type_value_table_peek(type);
	}

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

	public static void ValueRegisterTransformFunc(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type, MentorLake.GObject.GValueTransform transform_func)
	{
		GObjectGlobalFunctionsExterns.g_value_register_transform_func(src_type, dest_type, transform_func);
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

	public static bool ValueTypeCompatible(MentorLake.GObject.GType src_type, MentorLake.GObject.GType dest_type)
	{
		return GObjectGlobalFunctionsExterns.g_value_type_compatible(src_type, dest_type);
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
