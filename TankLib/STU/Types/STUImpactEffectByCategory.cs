// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x8DEFF143, "STUImpactEffectByCategory")]
    public class STUImpactEffectByCategory : STUInstance {
        [STUFieldAttribute(0x2C54AEAF, "m_category")]
        public teStructuredDataAssetRef<ulong> m_category;

        [STUFieldAttribute(0x58D56DD4, "m_effect")]
        public teStructuredDataAssetRef<ulong> m_effect;

        [STUFieldAttribute(0x041CE51F, "m_modelLook")]
        public teStructuredDataAssetRef<ulong> m_modelLook;

        [STUFieldAttribute(0x93CDFD2F)]
        public Enum_6842E392 m_93CDFD2F;
    }
}
