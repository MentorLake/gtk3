namespace MentorLake.Vulkan;

public class VkRenderPassMultiviewCreateInfoHandle : BaseSafeHandle
{
}


public static class VkRenderPassMultiviewCreateInfoExtensions
{

	public static VkRenderPassMultiviewCreateInfo Dereference(this VkRenderPassMultiviewCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassMultiviewCreateInfo>(x.DangerousGetHandle());
}
internal class VkRenderPassMultiviewCreateInfoExterns
{
}

public struct VkRenderPassMultiviewCreateInfo
{
}
