namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Describes the layer of a component
/// </para>
/// <para>
/// These enumerated &quot;layer values&quot; are used when determining which UI
/// rendering layer a component is drawn into, which can help in making
/// determinations of when components occlude one another.
/// </para>
/// </summary>

[Flags]
public enum AtkLayer
{
/// <summary>
/// <para>
/// The object does not have a layer
/// </para>
/// </summary>

	ATK_LAYER_INVALID = 0,
/// <summary>
/// <para>
/// This layer is reserved for the desktop background
/// </para>
/// </summary>

	ATK_LAYER_BACKGROUND = 1,
/// <summary>
/// <para>
/// This layer is used for Canvas components
/// </para>
/// </summary>

	ATK_LAYER_CANVAS = 2,
/// <summary>
/// <para>
/// This layer is normally used for components
/// </para>
/// </summary>

	ATK_LAYER_WIDGET = 3,
/// <summary>
/// <para>
/// This layer is used for layered components
/// </para>
/// </summary>

	ATK_LAYER_MDI = 4,
/// <summary>
/// <para>
/// This layer is used for popup components, such as menus
/// </para>
/// </summary>

	ATK_LAYER_POPUP = 5,
/// <summary>
/// <para>
/// This layer is reserved for future use.
/// </para>
/// </summary>

	ATK_LAYER_OVERLAY = 6,
/// <summary>
/// <para>
/// This layer is used for toplevel windows.
/// </para>
/// </summary>

	ATK_LAYER_WINDOW = 7
}
