namespace MentorLake.Vulkan;

public class VkViewportHandle : BaseSafeHandle
{
}


public static class VkViewportExtensions
{

	public static VkViewport Dereference(this VkViewportHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkViewport>(x.DangerousGetHandle());
}
internal class VkViewportExterns
{
}

public struct VkViewport
{
}
