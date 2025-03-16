namespace MentorLake.Vulkan;

public class VkPrivateDataSlotCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPrivateDataSlotCreateInfoEXTExtensions
{

	public static VkPrivateDataSlotCreateInfoEXT Dereference(this VkPrivateDataSlotCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrivateDataSlotCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPrivateDataSlotCreateInfoEXTExterns
{
}

public struct VkPrivateDataSlotCreateInfoEXT
{
}
