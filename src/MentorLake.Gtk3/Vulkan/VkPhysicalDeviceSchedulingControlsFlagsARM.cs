namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSchedulingControlsFlagsARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSchedulingControlsFlagsARMExtensions
{

	public static VkPhysicalDeviceSchedulingControlsFlagsARM Dereference(this VkPhysicalDeviceSchedulingControlsFlagsARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSchedulingControlsFlagsARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSchedulingControlsFlagsARMExterns
{
}

public struct VkPhysicalDeviceSchedulingControlsFlagsARM
{
}
