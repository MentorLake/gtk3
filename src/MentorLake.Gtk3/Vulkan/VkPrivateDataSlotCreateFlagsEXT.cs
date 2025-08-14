namespace MentorLake.Vulkan;


public class VkPrivateDataSlotCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPrivateDataSlotCreateFlagsEXTExtensions
{

	public static VkPrivateDataSlotCreateFlagsEXT Dereference(this VkPrivateDataSlotCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrivateDataSlotCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPrivateDataSlotCreateFlagsEXTExterns
{
}


public struct VkPrivateDataSlotCreateFlagsEXT
{
}
