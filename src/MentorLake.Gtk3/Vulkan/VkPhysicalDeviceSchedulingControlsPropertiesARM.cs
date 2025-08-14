namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSchedulingControlsPropertiesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSchedulingControlsPropertiesARMExtensions
{

	public static VkPhysicalDeviceSchedulingControlsPropertiesARM Dereference(this VkPhysicalDeviceSchedulingControlsPropertiesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSchedulingControlsPropertiesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSchedulingControlsPropertiesARMExterns
{
}


public struct VkPhysicalDeviceSchedulingControlsPropertiesARM
{
}
