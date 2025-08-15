namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The class structure for the GInitiallyUnowned type.
/// </para>
/// </summary>

public class GInitiallyUnownedClassHandle : BaseSafeHandle
{
}


public static class GInitiallyUnownedClassExtensions
{

	public static GInitiallyUnownedClass Dereference(this GInitiallyUnownedClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInitiallyUnownedClass>(x.DangerousGetHandle());
}
internal class GInitiallyUnownedClassExterns
{
}

/// <summary>
/// <para>
/// The class structure for the GInitiallyUnowned type.
/// </para>
/// </summary>

public struct GInitiallyUnownedClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GTypeClass g_type_class;
	/// <summary>
/// <para>
/// the @constructor function is called by g_object_new () to
///  complete the object initialization after all the construction properties are
///  set. The first thing a @constructor implementation must do is chain up to the
///  @constructor of the parent class. Overriding @constructor should be rarely
///  needed, e.g. to handle construct properties, or to implement singletons.
/// </para>
/// </summary>

public IntPtr constructor;
	/// <summary>
/// <para>
/// the generic setter for all properties of this type. Should be
///  overridden for every type with properties. If implementations of
///  @set_property don&apos;t emit property change notification explicitly, this will
///  be done implicitly by the type system. However, if the notify signal is
///  emitted explicitly, the type system will not emit it a second time.
/// </para>
/// </summary>

public IntPtr set_property;
	/// <summary>
/// <para>
/// the generic getter for all properties of this type. Should be
///  overridden for every type with properties.
/// </para>
/// </summary>

public IntPtr get_property;
	/// <summary>
/// <para>
/// the @dispose function is supposed to drop all references to other
///  objects, but keep the instance otherwise intact, so that client method
///  invocations still work. It may be run multiple times (due to reference
///  loops). Before returning, @dispose should chain up to the @dispose method
///  of the parent class.
/// </para>
/// </summary>

public IntPtr dispose;
	/// <summary>
/// <para>
/// instance finalization function, should finish the finalization of
///  the instance begun in @dispose and chain up to the @finalize method of the
///  parent class.
/// </para>
/// </summary>

public IntPtr finalize;
	/// <summary>
/// <para>
/// emits property change notification for a bunch
///  of properties. Overriding @dispatch_properties_changed should be rarely
///  needed.
/// </para>
/// </summary>

public IntPtr dispatch_properties_changed;
	/// <summary>
/// <para>
/// the class closure for the notify signal
/// </para>
/// </summary>

public IntPtr notify;
	/// <summary>
/// <para>
/// the @constructed function is called by g_object_new() as the
///  final step of the object creation process.  At the point of the call, all
///  construction properties have been set on the object.  The purpose of this
///  call is to allow for object initialisation steps that can only be performed
///  after construction properties have been set.  @constructed implementors
///  should chain up to the @constructed call of their parent class to allow it
///  to complete its initialisation.
/// </para>
/// </summary>

public IntPtr constructed;
}
