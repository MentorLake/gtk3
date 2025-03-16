namespace MentorLake.Vulkan;

public class VkRenderingFlagBitsHandle : BaseSafeHandle
{
}


public static class VkRenderingFlagBitsExtensions
{

	public static VkRenderingFlagBits Dereference(this VkRenderingFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingFlagBits>(x.DangerousGetHandle());
}
internal class VkRenderingFlagBitsExterns
{
}

public struct VkRenderingFlagBits
{
}
