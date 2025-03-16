namespace MentorLake.Gio;

[Flags]
public enum GTlsRehandshakeMode
{
	G_TLS_REHANDSHAKE_NEVER = 0,
	G_TLS_REHANDSHAKE_SAFELY = 1,
	G_TLS_REHANDSHAKE_UNSAFELY = 2
}
