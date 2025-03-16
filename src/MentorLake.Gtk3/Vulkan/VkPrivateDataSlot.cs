namespace MentorLake.Vulkan;

public class VkPrivateDataSlotHandle : BaseSafeHandle
{
}


public static class VkPrivateDataSlotExtensions
{

	public static VkPrivateDataSlot Dereference(this VkPrivateDataSlotHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrivateDataSlot>(x.DangerousGetHandle());
}
internal class VkPrivateDataSlotExterns
{
}

public struct VkPrivateDataSlot
{
}
