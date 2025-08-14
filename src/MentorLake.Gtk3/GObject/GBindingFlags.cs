namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Flags to be passed to g_object_bind_property() or
/// g_object_bind_property_full().
/// </para>
/// <para>
/// This enumeration can be extended at later date.
/// </para>
/// </summary>

[Flags]
public enum GBindingFlags : uint
{
/// <summary>
/// <para>
/// The default binding; if the source property
///   changes, the target property is updated with its value.
/// </para>
/// </summary>

	G_BINDING_DEFAULT = 0,
/// <summary>
/// <para>
/// Bidirectional binding; if either the
///   property of the source or the property of the target changes,
///   the other is updated.
/// </para>
/// </summary>

	G_BINDING_BIDIRECTIONAL = 1,
/// <summary>
/// <para>
/// Synchronize the values of the source and
///   target properties when creating the binding; the direction of
///   the synchronization is always from the source to the target.
/// </para>
/// </summary>

	G_BINDING_SYNC_CREATE = 2,
/// <summary>
/// <para>
/// If the two properties being bound are
///   booleans, setting one to %TRUE will result in the other being
///   set to %FALSE and vice versa. This flag will only work for
///   boolean properties, and cannot be used when passing custom
///   transformation functions to g_object_bind_property_full().
/// </para>
/// </summary>

	G_BINDING_INVERT_BOOLEAN = 4
}
