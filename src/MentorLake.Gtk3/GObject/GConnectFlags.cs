namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The connection flags are used to specify the behaviour of a signal's
/// connection.
/// </para>
/// </summary>

[Flags]
public enum GConnectFlags : uint
{
/// <summary>
/// <para>
/// Default behaviour (no special flags). Since: 2.74
/// </para>
/// </summary>

	G_CONNECT_DEFAULT = 0,
/// <summary>
/// <para>
/// If set, the handler should be called after the
///  default handler of the signal. Normally, the handler is called before
///  the default handler.
/// </para>
/// </summary>

	G_CONNECT_AFTER = 1,
/// <summary>
/// <para>
/// If set, the instance and data should be swapped when
///  calling the handler; see g_signal_connect_swapped() for an example.
/// </para>
/// </summary>

	G_CONNECT_SWAPPED = 2
}
