namespace MentorLake.Vulkan;


public class VkBindImageMemoryDeviceGroupInfoHandle : BaseSafeHandle
{
}


public static class VkBindImageMemoryDeviceGroupInfoExtensions
{

	public static VkBindImageMemoryDeviceGroupInfo Dereference(this VkBindImageMemoryDeviceGroupInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImageMemoryDeviceGroupInfo>(x.DangerousGetHandle());
}
internal class VkBindImageMemoryDeviceGroupInfoExterns
{
}


public struct VkBindImageMemoryDeviceGroupInfo
{
}
