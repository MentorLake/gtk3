namespace MentorLake.Vulkan;

public class VkBindBufferMemoryDeviceGroupInfoHandle : BaseSafeHandle
{
}


public static class VkBindBufferMemoryDeviceGroupInfoExtensions
{

	public static VkBindBufferMemoryDeviceGroupInfo Dereference(this VkBindBufferMemoryDeviceGroupInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindBufferMemoryDeviceGroupInfo>(x.DangerousGetHandle());
}
internal class VkBindBufferMemoryDeviceGroupInfoExterns
{
}

public struct VkBindBufferMemoryDeviceGroupInfo
{
}
