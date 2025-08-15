namespace MentorLake.GObject;

/// <summary>
/// <para>
/// `GObject` instance (or source) and another property on another `GObject`
/// instance (or target).
/// </para>
/// <para>
/// Whenever the source property changes, the same value is applied to the
/// target property; for instance, the following binding:
/// </para>
/// <para>
/// ```c
///   g_object_bind_property (object1, &quot;property-a&quot;,
///                           object2, &quot;property-b&quot;,
///                           G_BINDING_DEFAULT);
/// ```
/// </para>
/// <para>
/// will cause the property named &quot;property-b&quot; of @object2 to be updated
/// every time [method@GObject.set] or the specific accessor changes the value of
/// the property &quot;property-a&quot; of @object1.
/// </para>
/// <para>
/// It is possible to create a bidirectional binding between two properties
/// of two `GObject` instances, so that if either property changes, the
/// other is updated as well, for instance:
/// </para>
/// <para>
/// ```c
///   g_object_bind_property (object1, &quot;property-a&quot;,
///                           object2, &quot;property-b&quot;,
///                           G_BINDING_BIDIRECTIONAL);
/// ```
/// </para>
/// <para>
/// will keep the two properties in sync.
/// </para>
/// <para>
/// It is also possible to set a custom transformation function (in both
/// directions, in case of a bidirectional binding) to apply a custom
/// transformation from the source value to the target value before
/// applying it; for instance, the following binding:
/// </para>
/// <para>
/// ```c
///   g_object_bind_property_full (adjustment1, &quot;value&quot;,
///                                adjustment2, &quot;value&quot;,
///                                G_BINDING_BIDIRECTIONAL,
///                                celsius_to_fahrenheit,
///                                fahrenheit_to_celsius,
///                                NULL, NULL);
/// ```
/// </para>
/// <para>
/// will keep the &quot;value&quot; property of the two adjustments in sync; the
/// @celsius_to_fahrenheit function will be called whenever the &quot;value&quot;
/// property of @adjustment1 changes and will transform the current value
/// of the property before applying it to the &quot;value&quot; property of @adjustment2.
/// </para>
/// <para>
/// Vice versa, the @fahrenheit_to_celsius function will be called whenever
/// the &quot;value&quot; property of @adjustment2 changes, and will transform the
/// current value of the property before applying it to the &quot;value&quot; property
/// of @adjustment1.
/// </para>
/// <para>
/// Note that #GBinding does not resolve cycles by itself; a cycle like
/// </para>
/// <para>
/// ```
///   object1:propertyA -&amp;gt; object2:propertyB
///   object2:propertyB -&amp;gt; object3:propertyC
///   object3:propertyC -&amp;gt; object1:propertyA
/// ```
/// </para>
/// <para>
/// might lead to an infinite loop. The loop, in this particular case,
/// can be avoided if the objects emit the `GObject::notify` signal only
/// if the value has effectively been changed. A binding is implemented
/// using the `GObject::notify` signal, so it is susceptible to all the
/// various ways of blocking a signal emission, like [func@GObject.signal_stop_emission]
/// or [func@GObject.signal_handler_block].
/// </para>
/// <para>
/// A binding will be severed, and the resources it allocates freed, whenever
/// either one of the `GObject` instances it refers to are finalized, or when
/// the #GBinding instance loses its last reference.
/// </para>
/// <para>
/// Bindings for languages with garbage collection can use
/// [method@GObject.Binding.unbind] to explicitly release a binding between the source
/// and target properties, instead of relying on the last reference on the
/// binding, source, and target instances to drop.
/// </para>
/// </summary>

public class GBindingHandle : GObjectHandle
{
}

public static class GBindingHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the #GObject instance used as the source of the binding.
/// </para>
/// <para>
/// A #GBinding can outlive the source #GObject as the binding does not hold a
/// strong reference to the source. If the source is destroyed before the
/// binding then this function will return %NULL.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the source #GObject, or %NULL if the
///     source does not exist any more.
/// </return>

	public static MentorLake.GObject.GObjectHandle DupSource(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_dup_source(binding);
	}

/// <summary>
/// <para>
/// Retrieves the #GObject instance used as the target of the binding.
/// </para>
/// <para>
/// A #GBinding can outlive the target #GObject as the binding does not hold a
/// strong reference to the target. If the target is destroyed before the
/// binding then this function will return %NULL.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the target #GObject, or %NULL if the
///     target does not exist any more.
/// </return>

	public static MentorLake.GObject.GObjectHandle DupTarget(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_dup_target(binding);
	}

/// <summary>
/// <para>
/// Retrieves the flags passed when constructing the #GBinding.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the #GBindingFlags used by the #GBinding
/// </return>

	public static MentorLake.GObject.GBindingFlags GetFlags(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_flags(binding);
	}

/// <summary>
/// <para>
/// Retrieves the #GObject instance used as the source of the binding.
/// </para>
/// <para>
/// A #GBinding can outlive the source #GObject as the binding does not hold a
/// strong reference to the source. If the source is destroyed before the
/// binding then this function will return %NULL.
/// </para>
/// <para>
/// Use g_binding_dup_source() if the source or binding are used from different
/// threads as otherwise the pointer returned from this function might become
/// invalid if the source is finalized from another thread in the meantime.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the source #GObject, or %NULL if the
///     source does not exist any more.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetSource(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_source(binding);
	}

/// <summary>
/// <para>
/// Retrieves the name of the property of #GBinding:source used as the source
/// of the binding.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the name of the source property
/// </return>

	public static string GetSourceProperty(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_source_property(binding);
	}

/// <summary>
/// <para>
/// Retrieves the #GObject instance used as the target of the binding.
/// </para>
/// <para>
/// A #GBinding can outlive the target #GObject as the binding does not hold a
/// strong reference to the target. If the target is destroyed before the
/// binding then this function will return %NULL.
/// </para>
/// <para>
/// Use g_binding_dup_target() if the target or binding are used from different
/// threads as otherwise the pointer returned from this function might become
/// invalid if the target is finalized from another thread in the meantime.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the target #GObject, or %NULL if the
///     target does not exist any more.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetTarget(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_target(binding);
	}

/// <summary>
/// <para>
/// Retrieves the name of the property of #GBinding:target used as the target
/// of the binding.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <return>
/// the name of the target property
/// </return>

	public static string GetTargetProperty(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_target_property(binding);
	}

/// <summary>
/// <para>
/// Explicitly releases the binding between the source and the target
/// property expressed by @binding.
/// </para>
/// <para>
/// This function will release the reference that is being held on
/// the @binding instance if the binding is still bound; if you want to hold on
/// to the #GBinding instance after calling g_binding_unbind(), you will need
/// to hold a reference to it.
/// </para>
/// <para>
/// Note however that this function does not take ownership of @binding, it
/// only unrefs the reference that was initially created by
/// g_object_bind_property() and is owned by the binding.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>

	public static T Unbind<T>(this T binding) where T : GBindingHandle
	{
		if (binding.IsInvalid) throw new Exception("Invalid handle (GBindingHandle)");
		GBindingHandleExterns.g_binding_unbind(binding);
		return binding;
	}

}

internal class GBindingHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_dup_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_dup_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GBindingFlags g_binding_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_get_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_binding_get_source_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_get_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_binding_get_target_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_binding_unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

}
