namespace MentorLake.Vulkan;

public class VkPrivateDataSlotCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPrivateDataSlotCreateInfoExtensions
{

	public static VkPrivateDataSlotCreateInfo Dereference(this VkPrivateDataSlotCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrivateDataSlotCreateInfo>(x.DangerousGetHandle());
}
internal class VkPrivateDataSlotCreateInfoExterns
{
}

public struct VkPrivateDataSlotCreateInfo
{
}
