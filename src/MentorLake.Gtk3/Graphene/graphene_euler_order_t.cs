namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// Specify the order of the rotations on each axis.
/// </para>
/// <para>
/// The %GRAPHENE_EULER_ORDER_DEFAULT value is special, and is used
/// as an alias for one of the other orders.
/// </para>
/// </summary>

[Flags]
public enum graphene_euler_order_t
{
/// <summary>
/// <para>
/// Rotate in the default order; the
///   default order is one of the following enumeration values
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_DEFAULT = -1,
/// <summary>
/// <para>
/// Rotate in the X, Y, and Z order. Deprecated in
///   Graphene 1.10, it&apos;s an alias for %GRAPHENE_EULER_ORDER_SXYZ
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_XYZ = 0,
/// <summary>
/// <para>
/// Rotate in the Y, Z, and X order. Deprecated in
///   Graphene 1.10, it&apos;s an alias for %GRAPHENE_EULER_ORDER_SYZX
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_YZX = 1,
/// <summary>
/// <para>
/// Rotate in the Z, X, and Y order. Deprecated in
///   Graphene 1.10, it&apos;s an alias for %GRAPHENE_EULER_ORDER_SZXY
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_ZXY = 2,
/// <summary>
/// <para>
/// Rotate in the X, Z, and Y order. Deprecated in
///   Graphene 1.10, it&apos;s an alias for %GRAPHENE_EULER_ORDER_SXZY
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_XZY = 3,
/// <summary>
/// <para>
/// Rotate in the Y, X, and Z order. Deprecated in
///   Graphene 1.10, it&apos;s an alias for %GRAPHENE_EULER_ORDER_SYXZ
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_YXZ = 4,
/// <summary>
/// <para>
/// Rotate in the Z, Y, and X order. Deprecated in
///   Graphene 1.10, it&apos;s an alias for %GRAPHENE_EULER_ORDER_SZYX
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_ZYX = 5,
/// <summary>
/// <para>
/// Defines a static rotation along the X, Y, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SXYZ = 6,
/// <summary>
/// <para>
/// Defines a static rotation along the X, Y, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SXYX = 7,
/// <summary>
/// <para>
/// Defines a static rotation along the X, Z, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SXZY = 8,
/// <summary>
/// <para>
/// Defines a static rotation along the X, Z, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SXZX = 9,
/// <summary>
/// <para>
/// Defines a static rotation along the Y, Z, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SYZX = 10,
/// <summary>
/// <para>
/// Defines a static rotation along the Y, Z, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SYZY = 11,
/// <summary>
/// <para>
/// Defines a static rotation along the Y, X, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SYXZ = 12,
/// <summary>
/// <para>
/// Defines a static rotation along the Y, X, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SYXY = 13,
/// <summary>
/// <para>
/// Defines a static rotation along the Z, X, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SZXY = 14,
/// <summary>
/// <para>
/// Defines a static rotation along the Z, X, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SZXZ = 15,
/// <summary>
/// <para>
/// Defines a static rotation along the Z, Y, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SZYX = 16,
/// <summary>
/// <para>
/// Defines a static rotation along the Z, Y, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_SZYZ = 17,
/// <summary>
/// <para>
/// Defines a relative rotation along the Z, Y, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RZYX = 18,
/// <summary>
/// <para>
/// Defines a relative rotation along the X, Y, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RXYX = 19,
/// <summary>
/// <para>
/// Defines a relative rotation along the Y, Z, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RYZX = 20,
/// <summary>
/// <para>
/// Defines a relative rotation along the X, Z, and X axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RXZX = 21,
/// <summary>
/// <para>
/// Defines a relative rotation along the X, Z, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RXZY = 22,
/// <summary>
/// <para>
/// Defines a relative rotation along the Y, Z, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RYZY = 23,
/// <summary>
/// <para>
/// Defines a relative rotation along the Z, X, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RZXY = 24,
/// <summary>
/// <para>
/// Defines a relative rotation along the Y, X, and Y axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RYXY = 25,
/// <summary>
/// <para>
/// Defines a relative rotation along the Y, X, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RYXZ = 26,
/// <summary>
/// <para>
/// Defines a relative rotation along the Z, X, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RZXZ = 27,
/// <summary>
/// <para>
/// Defines a relative rotation along the X, Y, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RXYZ = 28,
/// <summary>
/// <para>
/// Defines a relative rotation along the Z, Y, and Z axes (Since: 1.10)
/// </para>
/// </summary>

	GRAPHENE_EULER_ORDER_RZYZ = 29
}
