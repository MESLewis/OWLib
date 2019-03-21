// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xBFC1FB55)]
    public class STU_BFC1FB55 : STUInstance {
        [STUFieldAttribute(0x4D2DB658, "m_identifier")]
        public teStructuredDataAssetRef<ulong> m_identifier;

        [STUFieldAttribute(0x5DB91CE2, "m_displayName")]
        public teStructuredDataAssetRef<ulong> m_displayName;

        [STUFieldAttribute(0xCF17DD30, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_9F7A0E66[] m_CF17DD30;

        [STUFieldAttribute(0x904BDD85)]
        public Enum_542A081B m_904BDD85;

        [STUFieldAttribute(0x10038BBD)]
        public Enum_43D38C2E m_10038BBD;
    }
}
