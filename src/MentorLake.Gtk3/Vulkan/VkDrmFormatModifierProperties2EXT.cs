namespace MentorLake.Vulkan;

public class VkDrmFormatModifierProperties2EXTHandle : BaseSafeHandle
{
}


public static class VkDrmFormatModifierProperties2EXTExtensions
{

	public static VkDrmFormatModifierProperties2EXT Dereference(this VkDrmFormatModifierProperties2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrmFormatModifierProperties2EXT>(x.DangerousGetHandle());
}
internal class VkDrmFormatModifierProperties2EXTExterns
{
}

public struct VkDrmFormatModifierProperties2EXT
{
}
