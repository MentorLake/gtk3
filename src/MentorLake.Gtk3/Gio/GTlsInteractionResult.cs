namespace MentorLake.Gio;

[Flags]
public enum GTlsInteractionResult
{
	G_TLS_INTERACTION_UNHANDLED = 0,
	G_TLS_INTERACTION_HANDLED = 1,
	G_TLS_INTERACTION_FAILED = 2
}
