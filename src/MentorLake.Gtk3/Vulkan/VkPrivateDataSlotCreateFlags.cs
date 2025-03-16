namespace MentorLake.Vulkan;

public class VkPrivateDataSlotCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPrivateDataSlotCreateFlagsExtensions
{

	public static VkPrivateDataSlotCreateFlags Dereference(this VkPrivateDataSlotCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrivateDataSlotCreateFlags>(x.DangerousGetHandle());
}
internal class VkPrivateDataSlotCreateFlagsExterns
{
}

public struct VkPrivateDataSlotCreateFlags
{
}
