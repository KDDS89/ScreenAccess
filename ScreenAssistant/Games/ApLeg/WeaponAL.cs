// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

using System;
using TiqSoft.ScreenAssistant.ScreenInfoRecognition;

namespace TiqSoft.ScreenAssistant.Games.ApLeg
{
    // ReSharper disable once InconsistentNaming
    [Flags]
    public enum WeaponAL
    {
        [WeaponData("", 0, " ")]
        Unknown = 1 << 0,
        [WeaponData("HAVOC", 4, "HAVUC")]
        Havoc = 1 << 1,
        [WeaponData("TRIPLE TAKE", 3)]
        TripleTake = 1 << 2,
        [WeaponData("DEVOTION", 5, "DEVUTIUN")]
        Devotion = 1 << 3,
        [WeaponData("FLATLINE", 3)]
        Flatline = 1 << 4,
        [WeaponData("HEMLOK", 4, "HEMLUH")]
        Hemlok = 1 << 5,
        [WeaponData("PROWLER", 4, "DRUWLEP")]
        Prowler = 1 << 6,
        [WeaponData("LONGBOW", 5, "LUNGBUW")]
        Longbow = 1 << 7,
        [WeaponData("SPITFIRE", 4, "SDITFIRE")]
        Spitfire = 1 << 8,
        [WeaponData("WINGMAN", 3)]
        Wingman = 1 << 9,
        [WeaponData("RE-45", 3, "p E-z15")]
        RE45 = 1 << 10,
        [WeaponData("P2020", 3, "P2o2o")]
        P2020 = 1 << 11,
        [WeaponData("R-301", 4, "R-3 Ol", "9-501")]
        R301 = 1 << 12,
        [WeaponData("R-99", 0, "9-99", "R - SEI", "R-SEI")]
        R99 = 1 << 13,
        [WeaponData("ALTERNATOR", 4)]
        Alternator = 1 << 14,
        [WeaponData("G7 Scout", 5, "G7SCOUT")]
        G7Scout = 1 << 15,
        [WeaponData("EVA-8 AUTO", 3)]
        EVA8Auto = 1 << 16,
        [WeaponData("PEACEKEEPER", 0, "PEACEHEEDER")]
        Peacekeeper = 1 << 17,
        [WeaponData("MOZAMBIQUE", 3)]
        Mozambique = 1 << 18,
        [WeaponData("MASTIFF", 2)]
        MASTIFF = 1 << 19,
        [WeaponData("KRABER", 0, "HRABER")]
        KRABER = 1 << 20,
        [WeaponData("L-STAR", 2, "LSTAR")]
        LStar = 1 << 21,
        [WeaponData("CHARGE RIFLE", 2, "CHARGEDRIFLE", "CHARGERIFLE")]
        ChargedRifle = 1 << 22,
        [WeaponData("SENTINEL", 3, "SFNTINFL")]
        Sentinel = 1 << 23,
        [WeaponData("VOLT", 4)]
        Volt = 1 << 24
    }
}
