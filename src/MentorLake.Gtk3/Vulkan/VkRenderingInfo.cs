namespace MentorLake.Vulkan;

public class VkRenderingInfoHandle : BaseSafeHandle
{
}


public static class VkRenderingInfoExtensions
{

	public static VkRenderingInfo Dereference(this VkRenderingInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingInfo>(x.DangerousGetHandle());
}
internal class VkRenderingInfoExterns
{
}

public struct VkRenderingInfo
{
}
