namespace MentorLake.Vulkan;

public class VkResolveModeFlagBitsHandle : BaseSafeHandle
{
}


public static class VkResolveModeFlagBitsExtensions
{

	public static VkResolveModeFlagBits Dereference(this VkResolveModeFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResolveModeFlagBits>(x.DangerousGetHandle());
}
internal class VkResolveModeFlagBitsExterns
{
}

public struct VkResolveModeFlagBits
{
}
