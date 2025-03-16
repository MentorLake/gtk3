namespace MentorLake.Vulkan;

public class VkDeviceFaultCountsEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultCountsEXTExtensions
{

	public static VkDeviceFaultCountsEXT Dereference(this VkDeviceFaultCountsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultCountsEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultCountsEXTExterns
{
}

public struct VkDeviceFaultCountsEXT
{
}
