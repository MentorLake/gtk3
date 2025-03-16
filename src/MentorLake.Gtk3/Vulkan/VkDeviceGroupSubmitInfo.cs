namespace MentorLake.Vulkan;

public class VkDeviceGroupSubmitInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupSubmitInfoExtensions
{

	public static VkDeviceGroupSubmitInfo Dereference(this VkDeviceGroupSubmitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupSubmitInfo>(x.DangerousGetHandle());
}
internal class VkDeviceGroupSubmitInfoExterns
{
}

public struct VkDeviceGroupSubmitInfo
{
}
