namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSchedulingControlsFeaturesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSchedulingControlsFeaturesARMExtensions
{

	public static VkPhysicalDeviceSchedulingControlsFeaturesARM Dereference(this VkPhysicalDeviceSchedulingControlsFeaturesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSchedulingControlsFeaturesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSchedulingControlsFeaturesARMExterns
{
}


public struct VkPhysicalDeviceSchedulingControlsFeaturesARM
{
}
