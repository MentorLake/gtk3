namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSchedulingControlsFlagBitsARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSchedulingControlsFlagBitsARMExtensions
{

	public static VkPhysicalDeviceSchedulingControlsFlagBitsARM Dereference(this VkPhysicalDeviceSchedulingControlsFlagBitsARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSchedulingControlsFlagBitsARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSchedulingControlsFlagBitsARMExterns
{
}


public struct VkPhysicalDeviceSchedulingControlsFlagBitsARM
{
}
