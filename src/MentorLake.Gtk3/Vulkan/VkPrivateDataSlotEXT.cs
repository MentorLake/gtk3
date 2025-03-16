namespace MentorLake.Vulkan;

public class VkPrivateDataSlotEXTHandle : BaseSafeHandle
{
}


public static class VkPrivateDataSlotEXTExtensions
{

	public static VkPrivateDataSlotEXT Dereference(this VkPrivateDataSlotEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrivateDataSlotEXT>(x.DangerousGetHandle());
}
internal class VkPrivateDataSlotEXTExterns
{
}

public struct VkPrivateDataSlotEXT
{
}
