namespace MentorLake.Vulkan;


public class VkDeviceGroupRenderPassBeginInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupRenderPassBeginInfoExtensions
{

	public static VkDeviceGroupRenderPassBeginInfo Dereference(this VkDeviceGroupRenderPassBeginInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupRenderPassBeginInfo>(x.DangerousGetHandle());
}
internal class VkDeviceGroupRenderPassBeginInfoExterns
{
}


public struct VkDeviceGroupRenderPassBeginInfo
{
}
