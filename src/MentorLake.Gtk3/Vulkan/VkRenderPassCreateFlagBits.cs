namespace MentorLake.Vulkan;

public class VkRenderPassCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreateFlagBitsExtensions
{

	public static VkRenderPassCreateFlagBits Dereference(this VkRenderPassCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkRenderPassCreateFlagBitsExterns
{
}

public struct VkRenderPassCreateFlagBits
{
}
