namespace MentorLake.Vulkan;

public class VkRenderPassBeginInfoHandle : BaseSafeHandle
{
}


public static class VkRenderPassBeginInfoExtensions
{

	public static VkRenderPassBeginInfo Dereference(this VkRenderPassBeginInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassBeginInfo>(x.DangerousGetHandle());
}
internal class VkRenderPassBeginInfoExterns
{
}

public struct VkRenderPassBeginInfo
{
}
