namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Virtual table for handling properties and method calls for a D-Bus
/// interface.
/// </para>
/// <para>
/// Since 2.38, if you want to handle getting/setting D-Bus properties
/// asynchronously, give %NULL as your get_property() or set_property()
/// function. The D-Bus call will be directed to your @method_call function,
/// with the provided @interface_name set to &quot;org.freedesktop.DBus.Properties&quot;.
/// </para>
/// <para>
/// Ownership of the #GDBusMethodInvocation object passed to the
/// method_call() function is transferred to your handler; you must
/// call one of the methods of #GDBusMethodInvocation to return a reply
/// (possibly empty), or an error. These functions also take ownership
/// of the passed-in invocation object, so unless the invocation
/// object has otherwise been referenced, it will be then be freed.
/// Calling one of these functions may be done within your
/// method_call() implementation but it also can be done at a later
/// point to handle the method asynchronously.
/// </para>
/// <para>
/// The usual checks on the validity of the calls is performed. For
/// `Get` calls, an error is automatically returned if the property does
/// not exist or the permissions do not allow access. The same checks are
/// performed for `Set` calls, and the provided value is also checked for
/// being the correct type.
/// </para>
/// <para>
/// For both `Get` and `Set` calls, the #GDBusMethodInvocation
/// passed to the @method_call handler can be queried with
/// g_dbus_method_invocation_get_property_info() to get a pointer
/// to the #GDBusPropertyInfo of the property.
/// </para>
/// <para>
/// If you have readable properties specified in your interface info,
/// you must ensure that you either provide a non-%NULL @get_property()
/// function or provide implementations of both the `Get` and `GetAll`
/// methods on org.freedesktop.DBus.Properties interface in your @method_call
/// function. Note that the required return type of the `Get` call is
/// `(v)`, not the type of the property. `GetAll` expects a return value
/// of type `a{sv}`.
/// </para>
/// <para>
/// If you have writable properties specified in your interface info,
/// you must ensure that you either provide a non-%NULL @set_property()
/// function or provide an implementation of the `Set` call. If implementing
/// the call, you must return the value of type %G_VARIANT_TYPE_UNIT.
/// </para>
/// </summary>

public class GDBusInterfaceVTableHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceVTableExtensions
{

	public static GDBusInterfaceVTable Dereference(this GDBusInterfaceVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceVTable>(x.DangerousGetHandle());
}
internal class GDBusInterfaceVTableExterns
{
}

/// <summary>
/// <para>
/// Virtual table for handling properties and method calls for a D-Bus
/// interface.
/// </para>
/// <para>
/// Since 2.38, if you want to handle getting/setting D-Bus properties
/// asynchronously, give %NULL as your get_property() or set_property()
/// function. The D-Bus call will be directed to your @method_call function,
/// with the provided @interface_name set to &quot;org.freedesktop.DBus.Properties&quot;.
/// </para>
/// <para>
/// Ownership of the #GDBusMethodInvocation object passed to the
/// method_call() function is transferred to your handler; you must
/// call one of the methods of #GDBusMethodInvocation to return a reply
/// (possibly empty), or an error. These functions also take ownership
/// of the passed-in invocation object, so unless the invocation
/// object has otherwise been referenced, it will be then be freed.
/// Calling one of these functions may be done within your
/// method_call() implementation but it also can be done at a later
/// point to handle the method asynchronously.
/// </para>
/// <para>
/// The usual checks on the validity of the calls is performed. For
/// `Get` calls, an error is automatically returned if the property does
/// not exist or the permissions do not allow access. The same checks are
/// performed for `Set` calls, and the provided value is also checked for
/// being the correct type.
/// </para>
/// <para>
/// For both `Get` and `Set` calls, the #GDBusMethodInvocation
/// passed to the @method_call handler can be queried with
/// g_dbus_method_invocation_get_property_info() to get a pointer
/// to the #GDBusPropertyInfo of the property.
/// </para>
/// <para>
/// If you have readable properties specified in your interface info,
/// you must ensure that you either provide a non-%NULL @get_property()
/// function or provide implementations of both the `Get` and `GetAll`
/// methods on org.freedesktop.DBus.Properties interface in your @method_call
/// function. Note that the required return type of the `Get` call is
/// `(v)`, not the type of the property. `GetAll` expects a return value
/// of type `a{sv}`.
/// </para>
/// <para>
/// If you have writable properties specified in your interface info,
/// you must ensure that you either provide a non-%NULL @set_property()
/// function or provide an implementation of the `Set` call. If implementing
/// the call, you must return the value of type %G_VARIANT_TYPE_UNIT.
/// </para>
/// </summary>

public struct GDBusInterfaceVTable
{
	/// <summary>
/// <para>
/// Function for handling incoming method calls.
/// </para>
/// </summary>

public GDBusInterfaceMethodCallFunc method_call;
	/// <summary>
/// <para>
/// Function for getting a property.
/// </para>
/// </summary>

public GDBusInterfaceGetPropertyFunc get_property;
	/// <summary>
/// <para>
/// Function for setting a property.
/// </para>
/// </summary>

public GDBusInterfaceSetPropertyFunc set_property;
}
